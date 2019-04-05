using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using System.IO.Compression;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;




namespace Arbeitsbox
{
    public partial class QuestChart : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private const string V = "/,";
        private PrivateFontCollection fonts = new PrivateFontCollection();
        System.Drawing.Font myFont10;
        System.Drawing.Font myFont12;
        System.Drawing.Font myFont22;
        private System.Data.DataSet dataSet;
        public string Stage = "Stage 40";
        public int StageINT = 40;
        public bool isSaveNeeded = false;
        public string filepath = "null";
        public string tline = "null";

        //Quest struct import

        List<string> list_A = new List<string>();
        List<string> list_ID = new List<string>();
        List<string> list_Stage = new List<string>();
        List<string> list_QuestNameREF = new List<string>();
        List<string> list_ForceFirstPane = new List<string>();
        List<string> list_UIPanes = new List<string>();
        List<string> list_UIFreetingLines = new List<string>();
        List<string> list_UIResponseButtonLines = new List<string>();
        List<string> list_UIResponseButtonActions = new List<string>();
        List<string> list_AnimationArray = new List<string>();
        List<string> list_Vos = new List<string>();
        List<string> list_UIReminderPane = new List<string>();
        List<string> list_UIReminderLines = new List<string>();
        List<string> list_UIReminderButton = new List<string>();
        List<string> list_UIReminderAction = new List<string>();
        List<string> list_ReminderAnim = new List<string>();
        List<string> list_ReminderVO = new List<string>();
        List<string> list_Notes = new List<string>();
        List<string> list_HasSpottedAction = new List<string>();
        List<string> list_SpottedAction = new List<string>();


        public QuestChart()
        {
            
            InitializeComponent();

            int startupNationINT = Properties.Settings.Default.Nation; // import that basic integer for chosen nation if we need it
            var principcalForm = Application.OpenForms.OfType<Form1>().Single();
            filepath = principcalForm.CurrentQuestCSV;
            label1.Text = principcalForm.CurrentQuestCSV; // filepath of current csv


            ReadAllChapters();

            // embedded font shit
            byte[] fontData = Properties.Resources.MorrisRomanAlternate_Black;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            
            uint dummy = 0;

            fonts.AddMemoryFont(fontPtr, Properties.Resources.MorrisRomanAlternate_Black.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.MorrisRomanAlternate_Black.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            // sizing of the new custom font
            myFont10 = new System.Drawing.Font(fonts.Families[0], 10.0F);
            myFont12 = new System.Drawing.Font(fonts.Families[0], 12.0F);
            myFont22 = new System.Drawing.Font(fonts.Families[0], 22.0F);

            label1.Font = myFont12;
            label2.Font = myFont12;
            label3.Font = myFont22;
            button3.BackColor = System.Drawing.Color.FromArgb(0, 55, 55, 155);
            button4.BackColor = System.Drawing.Color.FromArgb(0, 55, 55, 155);
            button6.BackColor = System.Drawing.Color.FromArgb(0, 55, 55, 155);

            DataTable oData = null;
            oData = new DataTable();
            oData.Columns.Add("A", typeof(string));
            oData.Columns.Add("ID", typeof(string));
            oData.Columns.Add("Stage", typeof(string));
            oData.Columns.Add("QuestNameREF", typeof(string));
            oData.Columns.Add("ForceFirstPane", typeof(string));
            oData.Columns.Add("UIPanes", typeof(string));
            oData.Columns.Add("UIFreetingLines", typeof(string));
            oData.Columns.Add("UIResponseButtonLines", typeof(string));
            oData.Columns.Add("UIResponseButtonActions", typeof(string));
            oData.Columns.Add("AnimationArray", typeof(string));
            oData.Columns.Add("Vos", typeof(string));
            oData.Columns.Add("UIReminderPane", typeof(string));
            oData.Columns.Add("UIReminderLines", typeof(string));
            oData.Columns.Add("UIReminderButton", typeof(string));
            oData.Columns.Add("UIReminderAction", typeof(string));
            oData.Columns.Add("ReminderAnim", typeof(string));
            oData.Columns.Add("ReminderVO", typeof(string));
            oData.Columns.Add("Notes", typeof(string));
            oData.Columns.Add("HasSpottedAction", typeof(string));
            oData.Columns.Add("SpottedAction", typeof(string));
        }





        public void ReadAllChapters()
        {
            // read specific column within "principcalForm.CurrentQuestCSV;"
            var principcalForm = Application.OpenForms.OfType<Form1>().Single();
            Console.WriteLine("Reading from: " + filepath);


           using (StreamReader reader = new StreamReader(filepath))
           {
               
           
               while ((tline = reader.ReadLine()) != null)
               {
                   //Define pattern
                   Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
           
                   //Separating columns to array
                   string[] CSVRows = CSVParser.Split(tline);



                    foreach (string s in CSVRows)
                   {
                        Console.WriteLine(s);
                   }
           
               
               }
           }


            label2.Text = "Current Stage: " + tline; // name of all chapters in chosen cs

        }



        private void button6_Click(object sender, EventArgs e)
        {
            // close everything
            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.Close();

            this.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // cancel
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // save

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (StageINT < 40)
            {
                StageINT = StageINT + 1;
            }
            label3.Text = StageINT.ToString();
            ReadAllChapters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // prev chapter
            if (StageINT > 0)
            {
                StageINT = StageINT - 1;
            }
            label3.Text = StageINT.ToString();
            ReadAllChapters();
        }
    }
}
