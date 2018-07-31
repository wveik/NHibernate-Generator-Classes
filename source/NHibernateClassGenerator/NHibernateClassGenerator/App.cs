using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using NCG.Core.CoreArgs;
using NCG.Core.Domain;
using NCG.Core.Domain.inter;
using NHibernateClassGenerator.Properties;


namespace NHibernateClassGenerator
{
    public partial class App : Form
    {
        private IDomainLayer _domain;
        public App()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            _domain = new DomainLayer(new MainArg(txtConnectionString.Text, txtScheme.Text, txtTableName.Text));
            txtDomainCode.Text = _domain.GetClass();
            txtMapCode.Text = _domain.GetMap();
            txtServices.Text = _domain.GetServices();
        }

        private void generateModernButton_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            var container = new MainContainer(txtConnectionString.Text, txtScheme.Text, txtTableName.Text);

            var writer = new XmlSerializer(container.GetType());

            var path = Properties.Settings.Default.pathToSettings;
            using (var file = System.IO.File.Create(path))
            {
                writer.Serialize(file, container);
            }
            MessageBox.Show(Resources.App_btnSaveConnection_Click_File_is_Saved);
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            MainContainer container = null;
            var path = Properties.Settings.Default.pathToSettings;

            var serializer = new XmlSerializer(typeof(MainContainer));

            using (var reader = new StreamReader(path))
                container = (MainContainer)serializer.Deserialize(reader);

            if (container == null) return;

            txtConnectionString.Text = container.ConnectionString;
            txtScheme.Text = container.Sheme;
            txtTableName.Text = container.Table;
        }
    }
}
