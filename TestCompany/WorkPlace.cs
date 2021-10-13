using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCompany
{
    public partial class WorkPlace : Form
    {
        public WorkPlace()
        {
            InitializeComponent();
        }

        private void AddPerson(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.Show();
        }
    }
}
