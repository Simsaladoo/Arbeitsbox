using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Arbeitsbox
{
    public partial class NationChooser : Form
    {
        public NationChooser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Natives

            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.SetNativesNation();

            CloseTheForm();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Rowani

            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.SetRowaniNation();
            CloseTheForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Graata

            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.SetGraataNation();
            CloseTheForm();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Neagese

            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.SetNeageseNation();
            CloseTheForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mons

            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.SetMonsNation();
            CloseTheForm();


        }



        public void CloseTheForm()
        {
            //close the window

            this.Close();

        }


    }
}
