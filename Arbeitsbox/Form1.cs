using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;


namespace Arbeitsbox
{
    public partial class Form1 : Form
    {
        // global variables 
        public string dummyFileName;
        public string savePath;
        public bool haschosen;
        public int startingnumber;
        public int endingnumber;
        public string sequence;
        public string wholepath;


        public Form1()
        {
            InitializeComponent();
            /* Beginning of record */
            haschosen = false;
            dummyFileName = "Choose a folder";
            textBox1.Text = "Choose a folder";
            savePath = @"C:\Users\dmiller\Desktop";
            panel1.Visible = false;
            startingnumber = 0000;
            endingnumber = 0010;
            sequence = "ASD";
            minlabel.Text = startingnumber.ToString();
            maxlabel.Text = endingnumber.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //choose directory
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = dummyFileName;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string savePath = Path.GetDirectoryName(sf.FileName);
                Console.WriteLine(savePath + " " + haschosen);
                haschosen = true;
                textBox1.Text = savePath;

            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (haschosen == true)
            {
                // show panel for choosing folder numbers
                panel1.Visible = true;
                wholepath = (savePath + @"\" + sequence + startingnumber);
                //now update the path to show what we're working with
                textBox1.Text = (wholepath);

            }

            else
            {
                textBox1.Text = "You must first choose a path!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nothing
        }






        private void button3_Click(object sender, EventArgs e)
        {
            //make folders
            //append the sequence name first, then use a loop while to create folders with incrementing #s until !< endingnumber

            var folder = Path.Combine(savePath, "folder");
            Directory.CreateDirectory(wholepath);

        }






        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //use this as prefix for folder name

            sequence = textBox2.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // lower start number
            if (startingnumber < 0000)
            {
                //do nothing because is zero
                minlabel.Text = startingnumber.ToString();
                wholepath = (savePath + @"\" + sequence + startingnumber);
                //now update the path to show what we're working with
                textBox1.Text += (wholepath);
            }
            else
            {
                // Jesus tap-dancing Christ!
                if (Control.ModifierKeys == Keys.Shift)
                {
                    startingnumber = (startingnumber) - 0100;
                    minlabel.Text = startingnumber.ToString();
                    wholepath = (savePath + @"\" + sequence + startingnumber);
                    //now update the path to show what we're working with
                    textBox1.Text += (wholepath);
                }
                else
                {
                    startingnumber = (startingnumber) - 0010;
                    minlabel.Text = startingnumber.ToString();
                    wholepath = (savePath + @"\" + sequence + startingnumber);
                    //now update the path to show what we're working with
                    textBox1.Text += (wholepath);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // raise starting number
            if (startingnumber < 0000)
            {
                //do nothing because is zero
                minlabel.Text = startingnumber.ToString();
                wholepath = (savePath + @"\" + sequence + startingnumber);
                //now update the path to show what we're working with
                textBox1.Text += (wholepath);

            }
            else
            {  
                //Jesus tap-dancing Christ! Shift for hundreds!

                if (Control.ModifierKeys == Keys.Shift)
                {
                    startingnumber = (startingnumber) + 0100;
                    minlabel.Text = startingnumber.ToString();
                    // also make sure ending number is always larger than starting
                    if (endingnumber < startingnumber)
                    {
                        endingnumber = (endingnumber) + 0100;
                        maxlabel.Text = endingnumber.ToString();
                        wholepath = (savePath + @"\" + sequence + startingnumber);
                        //now update the path to show what we're working with
                        textBox1.Text += (wholepath);
                    }
                }
                else
                {
                    startingnumber = (startingnumber) + 0010;
                    minlabel.Text = startingnumber.ToString();
                    // also make sure ending number is always larger than starting
                    if (endingnumber < startingnumber)
                    {
                        endingnumber = (endingnumber) + 0010;
                        maxlabel.Text = endingnumber.ToString();
                        wholepath = (savePath + @"\" + sequence + startingnumber);
                        //now update the path to show what we're working with
                        textBox1.Text += (wholepath);
                    }
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // lower ending number
            if (endingnumber < 0000)
            {
                //do nothing because is zero
                maxlabel.Text = endingnumber.ToString();
            }
            else
            {
                endingnumber = (endingnumber) - 0010;
                maxlabel.Text = endingnumber.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // raise ending number
            if (endingnumber < 0000)
            {
                //do nothing because is zero
                maxlabel.Text = endingnumber.ToString();
            }
            else
            {
                endingnumber = (endingnumber) + 0010;
                maxlabel.Text = endingnumber.ToString();
            }
        }
    }
}
