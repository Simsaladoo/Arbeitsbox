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
    public partial class PanelsChooser : Form
    {
        public PanelsChooser()
        {
            InitializeComponent();
            setupShit();

        }


        public void setupShit()
        {
            var principcalForm = Application.OpenForms.OfType<QuestChart>().Single();
            int choosingPanel = 0;
            choosingPanel = principcalForm.choosingPaneforPanel;

            // tell this form what number pane we're choosing for

            this.ParentForm.Text = ("Choose UI Pane for slot " + choosingPanel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var principcalForm = Application.OpenForms.OfType<QuestChart>().Single();
            principcalForm.addingPaneEnum1 = 0;

            CloseThisForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var principcalForm = Application.OpenForms.OfType<QuestChart>().Single();
            principcalForm.addingPaneEnum1 = 0;

            CloseThisForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var principcalForm = Application.OpenForms.OfType<QuestChart>().Single();
            principcalForm.addingPaneEnum1 = 0;

            CloseThisForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var principcalForm = Application.OpenForms.OfType<QuestChart>().Single();
            principcalForm.addingPaneEnum1 = 0;

            CloseThisForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var principcalForm = Application.OpenForms.OfType<QuestChart>().Single();
            principcalForm.addingPaneEnum1 = 0;

            CloseThisForm();
        }





        public void CloseThisForm()
        {
            //close the window

            this.Close();
        }
    }
}

