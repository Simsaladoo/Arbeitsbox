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
            dummyFileName = "Choose a Directory";
            textBox1.Text = "Choose a Directory";
            savePath = @"C:\Users\dmiller\Desktop";
            panel1.Visible = false;
            startingnumber = 0;
            endingnumber = 100;
            sequence = "AA";
            minlabel.Text = startingnumber.ToString();
            maxlabel.Text = endingnumber.ToString();
            button3.Enabled = false;
            button3.BackColor = Color.FromArgb(75, 75, 75);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //choose directory
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = dummyFileName;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                savePath = Path.GetDirectoryName(sf.FileName);
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
                button3.Enabled = true;
                button3.BackColor = Color.FromArgb(5, 192, 75);
                Console.WriteLine("Working...");
            }

            else
            {
                textBox1.Text = "You must first choose a Directory!";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nothing
        }




//                  
//            _________ __                 __  .__                
//           /   _____//  |______ ________/  |_|__| ____    ____  
//           \_____  \\   __\__  \\_  __ \   __\  |/    \  / ___\ 
//           /        \|  |  / __ \|  | \/|  | |  |   |  \/ /_/  >
//          /_______  /|__| (____  /__|   |__| |__|___|  /\___  / 
//                  \/           \/                    \//_____/  
//          


        private void button7_Click(object sender, EventArgs e)
        {
            // lower start number
            if (startingnumber == 0)
            {
                //do nothing because is zero
                minlabel.Text = startingnumber.ToString();
                wholepath = (savePath + @"\" + sequence + startingnumber);
                //now update the path to show what we're working with
                textBox1.Text = (wholepath);
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
                    textBox1.Text = (wholepath);
                }
                else
                {
                    startingnumber = (startingnumber) - 0010;
                    minlabel.Text = startingnumber.ToString();
                    wholepath = (savePath + @"\" + sequence + startingnumber);
                    //now update the path to show what we're working with
                    textBox1.Text = (wholepath);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // raise starting number
            if(0 == 0)
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
                        textBox1.Text = (wholepath);
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
                        textBox1.Text = (wholepath);
                    }
                }


            }
        }


        
//              ___________           .___.__                
//              \_   _____/ ____    __| _/|__| ____    ____  
//               |    __)_ /    \  / __ | |  |/    \  / ___\ 
//               |        \   |  \/ /_/ | |  |   |  \/ /_/  >
//              /_______  /___|  /\____ | |__|___|  /\___  / 
//                      \/     \/      \/         \//_____/  
//              




        private void button4_Click(object sender, EventArgs e)
        {
            // lower ending number
            if (endingnumber == 0)
            {

            }
            else { 

                 if (Control.ModifierKeys == Keys.Shift)
                 {
                     endingnumber = (endingnumber) - 0100;
                     maxlabel.Text = endingnumber.ToString();
                 }
                 else
                 {
                     endingnumber = (endingnumber) - 0010;
                     maxlabel.Text = endingnumber.ToString();
                 }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // raise ending number
            if (0 == 0)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    endingnumber = (endingnumber) + 0100;
                    maxlabel.Text = endingnumber.ToString();
                }
                else
                {
                    endingnumber = (endingnumber) + 0010;
                    maxlabel.Text = endingnumber.ToString();
                }

            }
        }







        //          _________                        __          
        //          \_   ___ \_______   ____ _____ _/  |_  ____  
        //          /    \  \/\_  __ \_/ __ \\__  \\   __\/ __ \ 
        //          \     \____|  | \/\  ___/ / __ \|  | \  ___/ 
        //           \______  /|__|    \___  >____  /__|  \___  >
        //                  \/             \/     \/          \/ 
        //          


        private void button3_Click(object sender, EventArgs e)
        {
            int i = startingnumber;
            int j = endingnumber;

            //make folders
            //append the sequence name first, then use a loop while to create folders with incrementing #s until !< endingnumber
            for (i = startingnumber; i <= j; i+=10)
            {


                if (i < 10)
                {
                    // check for number of digits to force 0000 instead of just 0

                    wholepath = (savePath + @"\" + sequence + "000" + i);
                }

                if (i > 9 && i < 100)
                {
                    // check for number of digits to force 0010 instead of just 10

                    wholepath = (savePath + @"\" + sequence + "00" + i);
                }

                if (i > 99 && i < 1000)
                {
                    // check for number of digits to force 0100 instead of just 100

                    wholepath = (savePath + @"\" + sequence + "0" + i);
                }

                if (i > 999)
                {
                    // check for number of digits to force 1000

                    wholepath = (savePath + @"\" + sequence + i);
                }




                var folder = Path.Combine(savePath, "folder");
                Directory.CreateDirectory(wholepath);
                Console.WriteLine(i);
                Console.WriteLine(wholepath);
            }
            Console.WriteLine("Done");

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //use this as prefix for folder name

            sequence = textBox2.Text;
            wholepath = (savePath + @"\" + sequence + startingnumber);
            //now update the path to show what we're working with
            textBox1.Text = (wholepath);

        }



    }
}
