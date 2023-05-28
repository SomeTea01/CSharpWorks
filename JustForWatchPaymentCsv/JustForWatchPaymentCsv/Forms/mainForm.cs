using JustForWatchPaymentCsv.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustForWatchPaymentCsv
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] files = new string[]
            {
                "Test.csv",
                "Test1.csv"
            };
            string[] titles = new string[]
            {
                "AAA",
                "BBB",
                "CCC"
            };
            MappingCsvForm mappingCsvForm = new MappingCsvForm(files,titles);
            mappingCsvForm.ShowDialog();
        }
    }
}
