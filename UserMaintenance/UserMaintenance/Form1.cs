using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = ResourceFile_1.LastName;
            lblFirstName.Text = ResourceFile_1.FirstName;
            btnAdd.Text = ResourceFile_1.Add;

        }
    }
}
