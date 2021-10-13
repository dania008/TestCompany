using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCompany
{
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DbSqlServerCompanyEntities1 dbSqlServer = new DbSqlServerCompanyEntities1())
            {
                User user = new User();
                user.Имя = textBox1.Text;
                user.Фамилия = textBox2.Text;
                user.Отчество = textBox3.Text;
                user.Дата_рождения = dateTimePicker1.Value;
                user.Место_работы = (int)comboBox1.SelectedValue;
                user.Номер_телефона = textBox6.Text;
                if (openFileDialog1 != null) user.Фото = openFileDialog1.FileName.Trim().ToString();
                dbSqlServer.Users.Add(user);
                try
                {
                    dbSqlServer.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        textBox4.Text += item.Entry.Entity.ToString() + Environment.NewLine;
                        foreach (var item2 in item.ValidationErrors)
                        {
                            textBox4.Text += item2.ErrorMessage + Environment.NewLine;
                        }
                    }
                }
            }
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbSqlServerCompanyDataSet1.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter1.Fill(this.dbSqlServerCompanyDataSet1.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbSqlServerCompanyDataSet.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.dbSqlServerCompanyDataSet.Company);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ComboBox).SelectedValue.ToString());
        }
    }
}
