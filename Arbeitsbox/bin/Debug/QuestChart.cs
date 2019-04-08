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
using LumenWorks.Framework.IO.Csv;




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
        public int sheetlength = 20;

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
            oData.Columns.Add(" ", typeof(string));
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

            // basic data setup

            DataRow _test = oData.NewRow();
            _test[" "] = "0";                                           // 0
            _test["ID"] = "0";                                          // 1
            _test["Stage"] = "0";                                       // 2
            _test["QuestNameREF"] = "The Journey Home";                 // 3
            _test["ForceFirstPane"] = "FALSE";                          // 4
            _test["UIPanes"] = "0";                                     // 5
            _test["UIFreetingLines"] = ("Empty Value");                 // 6
            _test["UIResponseButtonLines"] = ("Empty Value");           // 7
            _test["UIResponseButtonActions"] = ("Empty Value");         // 8
            _test["AnimationArray"] = ("Idle01");                       // 9
            _test["Vos"] = " ";                                         // 10
            _test["UIReminderPane"] = "2";                              // 11
            _test["UIReminderLines"] = ("Empty Value");                 // 12
            _test["UIReminderButton"] = ("Empty Value");                // 13
            _test["UIReminderAction"] = ("EndConversation");            // 14
            _test["ReminderAnim"] = ("Idle01");                         // 15
            _test["ReminderVO"] = " ";                                  // 16
            _test["Notes"] = ("Completely pointless notes field");      // 17
            _test["HasSpottedAction"] = "FALSE";                        // 18
            _test["SpottedAction"] = "SpeakWalkFree";                   // 19

            oData.Rows.Add(_test);


            ReadAllChapters();


        }



        public void ReadAllChapters()
        {
            // read specific column within "principcalForm.CurrentQuestCSV;"
            var principcalForm = Application.OpenForms.OfType<Form1>().Single();
            Console.WriteLine("Reading from: " + filepath);


            // use o.Data -- this is the setup





           using (StreamReader reader = new StreamReader(filepath))
           {
                int linecounter = 0;
                int rowcounter = 0;
                int rowmaths = 0;
           
               while ((tline = reader.ReadLine()) != null)
               {
                   //Define pattern
                   Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
           
                   //Separating columns to array
                   string[] CSVRows = CSVParser.Split(tline);
           
           
                     foreach (string s in CSVRows)
                    {
                        linecounter = (linecounter) + 1;
                        // say its own index point
                        if (linecounter > sheetlength)
                        {
                            rowmaths = (linecounter) / 20;

                            


                        }
                         Console.WriteLine(rowmaths + " " + " " + s); // each string written here is a cell, so divide by the number of columns--20-- to get each row
                    }
           
               
               }
           }





            label2.Text = "Current Stage: " + tline; // name of all chapters in chosen cs

        }

        public void NeedsToSave()
        {
            // re-enable Save button
            button3.Enabled = true;

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
            Console.WriteLine("Saved");

            // re-disable Save button
            button3.Enabled = false;

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
