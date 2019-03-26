using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeitsbox
{
    public partial class QuestChart : Form
    {
        public QuestChart()
        {
            InitializeComponent();

            int startupNationINT = Properties.Settings.Default.Nation;

        }





















        private void button6_Click(object sender, EventArgs e)
        {
            // close everything
            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.Close();

            this.Close();


        }
    }
}
