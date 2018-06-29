using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCG.Core.CoreArgs;
using NCG.Core.Domain;

namespace NHibernateClassGenerator
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var domain = new DomainLayer(new MainArg(txtConnectionString.Text, txtScheme.Text, txtTableName.Text));
            txtDomainCode.Text = domain.GetClass();
            txtMapCode.Text = domain.GetMap();
        }
    }
}
