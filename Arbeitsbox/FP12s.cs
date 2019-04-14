using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using System.IO.Compression;
using System.Reflection;

namespace Arbeitsbox
{
    class FP12s
    {



        //                              /* 12s */                               //
        //                                                                      //
        //                        $$\    $$$$$$\                                //
        //                      $$$$ |  $$  __$$\                               //
        //                      \_$$ |  \__/  $$ | $$$$$$$\                     //
        //                        $$ |   $$$$$$  |$$  _____|                    //
        //                        $$ |  $$  ____/ \$$$$$$\                      //
        //                        $$ |  $$ |       \____$$\                     //
        //                      $$$$$$\ $$$$$$$$\ $$$$$$$  |                    //
        //                      \______|\________|\_______/                     //
        //                                                                      //
        //                                                                      //



        public static string intVar { get; set; }


        public static string aX000Y000 { get; set; }
        public static string aX000Y001 { get; set; }
        public static string aX000Y002 { get; set; }
        public static string aX000Y003 { get; set; }
        public static string aX000Y004 { get; set; }
        public static string aX000Y005 { get; set; }
        public static string aX000Y006 { get; set; }
        public static string aX000Y007 { get; set; }
        public static string aX000Y008 { get; set; }
        public static string aX000Y009 { get; set; }
        public static string aX000Y010 { get; set; }
        public static string aX000Y011 { get; set; }

        public static string aX001Y000 { get; set; }
        public static string aX001Y001 { get; set; }
        public static string aX001Y002 { get; set; }
        public static string aX001Y003 { get; set; }
        public static string aX001Y004 { get; set; }
        public static string aX001Y005 { get; set; }
        public static string aX001Y006 { get; set; }
        public static string aX001Y007 { get; set; }
        public static string aX001Y008 { get; set; }
        public static string aX001Y009 { get; set; }
        public static string aX001Y010 { get; set; }
        public static string aX001Y011 { get; set; }

        public static string aX002Y000 { get; set; }
        public static string aX002Y001 { get; set; }
        public static string aX002Y002 { get; set; }
        public static string aX002Y003 { get; set; }
        public static string aX002Y004 { get; set; }
        public static string aX002Y005 { get; set; }
        public static string aX002Y006 { get; set; }
        public static string aX002Y007 { get; set; }
        public static string aX002Y008 { get; set; }
        public static string aX002Y009 { get; set; }
        public static string aX002Y010 { get; set; }
        public static string aX002Y011 { get; set; }

        public static string aX003Y000 { get; set; }
        public static string aX003Y001 { get; set; }
        public static string aX003Y002 { get; set; }
        public static string aX003Y003 { get; set; }
        public static string aX003Y004 { get; set; }
        public static string aX003Y005 { get; set; }
        public static string aX003Y006 { get; set; }
        public static string aX003Y007 { get; set; }
        public static string aX003Y008 { get; set; }
        public static string aX003Y009 { get; set; }
        public static string aX003Y010 { get; set; }
        public static string aX003Y011 { get; set; }

        public static string aX004Y000 { get; set; }
        public static string aX004Y001 { get; set; }
        public static string aX004Y002 { get; set; }
        public static string aX004Y003 { get; set; }
        public static string aX004Y004 { get; set; }
        public static string aX004Y005 { get; set; }
        public static string aX004Y006 { get; set; }
        public static string aX004Y007 { get; set; }
        public static string aX004Y008 { get; set; }
        public static string aX004Y009 { get; set; }
        public static string aX004Y010 { get; set; }
        public static string aX004Y011 { get; set; }

        public static string aX005Y000 { get; set; }
        public static string aX005Y001 { get; set; }
        public static string aX005Y002 { get; set; }
        public static string aX005Y003 { get; set; }
        public static string aX005Y004 { get; set; }
        public static string aX005Y005 { get; set; }
        public static string aX005Y006 { get; set; }
        public static string aX005Y007 { get; set; }
        public static string aX005Y008 { get; set; }
        public static string aX005Y009 { get; set; }
        public static string aX005Y010 { get; set; }
        public static string aX005Y011 { get; set; }

        public static string aX006Y000 { get; set; }
        public static string aX006Y001 { get; set; }
        public static string aX006Y002 { get; set; }
        public static string aX006Y003 { get; set; }
        public static string aX006Y004 { get; set; }
        public static string aX006Y005 { get; set; }
        public static string aX006Y006 { get; set; }
        public static string aX006Y007 { get; set; }
        public static string aX006Y008 { get; set; }
        public static string aX006Y009 { get; set; }
        public static string aX006Y010 { get; set; }
        public static string aX006Y011 { get; set; }

        public static string aX007Y000 { get; set; }
        public static string aX007Y001 { get; set; }
        public static string aX007Y002 { get; set; }
        public static string aX007Y003 { get; set; }
        public static string aX007Y004 { get; set; }
        public static string aX007Y005 { get; set; }
        public static string aX007Y006 { get; set; }
        public static string aX007Y007 { get; set; }
        public static string aX007Y008 { get; set; }
        public static string aX007Y009 { get; set; }
        public static string aX007Y010 { get; set; }
        public static string aX007Y011 { get; set; }

        public static string aX008Y000 { get; set; }
        public static string aX008Y001 { get; set; }
        public static string aX008Y002 { get; set; }
        public static string aX008Y003 { get; set; }
        public static string aX008Y004 { get; set; }
        public static string aX008Y005 { get; set; }
        public static string aX008Y006 { get; set; }
        public static string aX008Y007 { get; set; }
        public static string aX008Y008 { get; set; }
        public static string aX008Y009 { get; set; }
        public static string aX008Y010 { get; set; }
        public static string aX008Y011 { get; set; }

        public static string aX009Y000 { get; set; }
        public static string aX009Y001 { get; set; }
        public static string aX009Y002 { get; set; }
        public static string aX009Y003 { get; set; }
        public static string aX009Y004 { get; set; }
        public static string aX009Y005 { get; set; }
        public static string aX009Y006 { get; set; }
        public static string aX009Y007 { get; set; }
        public static string aX009Y008 { get; set; }
        public static string aX009Y009 { get; set; }
        public static string aX009Y010 { get; set; }
        public static string aX009Y011 { get; set; }

        public static string aX010Y000 { get; set; }
        public static string aX010Y001 { get; set; }
        public static string aX010Y002 { get; set; }
        public static string aX010Y003 { get; set; }
        public static string aX010Y004 { get; set; }
        public static string aX010Y005 { get; set; }
        public static string aX010Y006 { get; set; }
        public static string aX010Y007 { get; set; }
        public static string aX010Y008 { get; set; }
        public static string aX010Y009 { get; set; }
        public static string aX010Y010 { get; set; }
        public static string aX010Y011 { get; set; }

        public static string aX011Y000 { get; set; }
        public static string aX011Y001 { get; set; }
        public static string aX011Y002 { get; set; }
        public static string aX011Y003 { get; set; }
        public static string aX011Y004 { get; set; }
        public static string aX011Y005 { get; set; }
        public static string aX011Y006 { get; set; }
        public static string aX011Y007 { get; set; }
        public static string aX011Y008 { get; set; }
        public static string aX011Y009 { get; set; }
        public static string aX011Y010 { get; set; }
        public static string aX011Y011 { get; set; }



        SoundPlayer completesong = new SoundPlayer("Resources/start.wav");

        /******************************************* TOOLS/ACTION BUTTONS ************************************/

        /* Action buttons in TOols frame */

        // ___________                            __________                                                       
        // \_   _____/____   __ __  ____ _____    \______   \_______  ____   ____  ____   ______ _________________ 
        //  |    __) \__  \ |  |  \/    \\__  \    |     ___/\_  __ \/  _ \_/ ___\/ __ \ /  ___//  ___/  _ \_  __ \
        //  |     \   / __ \|  |  /   |  \/ __ \_  |    |     |  | \(  <_> )  \__\  ___/ \___ \ \___ (  <_> )  | \/
        //  \___  /  (____  /____/|___|  (____  /  |____|     |__|   \____/ \___  >___  >____  >____  >____/|__|   
        //      \/        \/           \/     \/                                \/    \/     \/     \/             




        /******************************************* Fauna Type 12s ************************************/
        //                              /* 12s */                               //
        //                                                                      //
        //                        $$\    $$$$$$\                                //
        //                      $$$$ |  $$  __$$\                               //
        //                      \_$$ |  \__/  $$ | $$$$$$$\                     //
        //                        $$ |   $$$$$$  |$$  _____|                    //
        //                        $$ |  $$  ____/ \$$$$$$\                      //
        //                        $$ |  $$ |       \____$$\                     //
        //                      $$$$$$\ $$$$$$$$\ $$$$$$$  |                    //
        //                      \______|\________|\_______/                     //
        //                                                                      //
        //                                                                      //




        private void button3_Click(object sender, EventArgs e)
        {

            var principcalForm = Application.OpenForms.OfType<Form1>().Single();

            principcalForm.SetNativesNation();


            Console.WriteLine("Writing 12s clicked...");
            // richTextBox1.AppendText(Environment.NewLine + "Writing 12s clicked...");
            int x, y;
            DataTable dta = new DataTable();
            dta.Columns.Add(" ");
            dta.Columns.Add("Type1CellY000");
            dta.Columns.Add("Type1CellY001");
            dta.Columns.Add("Type1CellY002");
            dta.Columns.Add("Type1CellY003");
            dta.Columns.Add("Type1CellY004");
            dta.Columns.Add("Type1CellY005");
            dta.Columns.Add("Type1CellY006");
            dta.Columns.Add("Type1CellY007");
            dta.Columns.Add("Type1CellY008");
            dta.Columns.Add("Type1CellY009");
            dta.Columns.Add("Type1CellY010");
            dta.Columns.Add("Type1CellY011");
            string path = Properties.Settings.Default.CSVpath;
            //string altpath = @"D:\Test";
            string searchPattern = "A*";
            DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.CSVpath);
            DirectoryInfo[] directories = di.GetDirectories(searchPattern, SearchOption.TopDirectoryOnly);
            FileInfo[] files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);

            Console.WriteLine("Searching for files that begin with the letter \"A\" in {0}", path);
            // richTextBox1.AppendText(Environment.NewLine + "Searching for files that begin with the letter A in " + path);
            // richTextBox1.Focus();
            // richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // richTextBox1.ScrollToCaret();


            // loop through the directory for files and begin processing

            foreach (FileInfo file in files)
            {
                try
                {
                    Console.WriteLine("Found file " + file);
                    string readfilepath = (Properties.Settings.Default.CSVpath + "/" + file);
                    Console.WriteLine("Current file to process: " + readfilepath);
                    Bitmap testimage = new Bitmap(readfilepath);
                    Console.WriteLine(file + " ... clearing previous data from variables... ");
                    //richTextBox1.AppendText(Environment.NewLine + file + " ... clearing previous data from variables... ");
                    try
                    {
                        dta.Clear();
                    }
                    catch (DataException)
                    {

                    }
                    Console.WriteLine(file + " ... processing ...");
                    // richTextBox1.AppendText(Environment.NewLine + file + " ... processing ...");
                    // richTextBox1.Focus();
                    // richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    // richTextBox1.ScrollToCaret();



                    /******************************************* IMAGE PROCESSING LOOP ************************************/

                    // x++ increment through all pixels
                    for (x = 0; x < testimage.Width; x++)
                    {
                        for (y = 0; y < testimage.Height; y++)
                        {
                            //This is where we setup ALL that data into a Row.  
                            // row start
                            if (y == 0)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX000Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX000Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX000Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX000Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX000Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX000Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX000Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX000Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX000Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX000Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX000Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX000Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 1)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX001Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX001Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX001Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX001Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX001Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX001Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX001Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX001Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX001Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX001Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX001Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX001Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 2)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX002Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX002Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX002Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX002Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX002Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX002Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX002Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX002Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX002Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX002Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX002Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX002Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 3)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX003Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX003Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX003Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX003Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX003Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX003Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX003Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX003Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX003Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX003Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX003Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX003Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 4)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX004Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX004Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX004Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX004Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX004Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX004Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX004Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX004Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX004Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX004Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX004Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX004Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 5)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX005Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX005Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX005Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX005Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX005Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX005Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX005Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX005Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX005Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX005Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX005Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX005Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 6)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX006Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX006Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX006Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX006Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX006Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX006Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX006Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX006Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX006Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX006Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX006Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX006Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 7)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX007Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX007Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX007Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX007Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX007Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX007Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX007Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX007Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX007Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX007Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX007Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX007Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 8)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX008Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX008Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX008Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX008Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX008Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX008Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX008Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX008Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX008Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX008Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX008Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX008Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 9)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX009Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX009Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX009Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX009Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX009Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX009Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX009Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX009Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX009Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX009Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX009Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX009Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 10)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX010Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX010Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX010Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX010Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX010Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX010Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX010Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX010Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX010Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX010Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX010Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX010Y011 = pixelColorStringValue; }
                            }
                            // row start
                            if (y == 11)
                            {
                                System.Drawing.Color pixelColor = testimage.GetPixel(x, y);
                                string pixelColorStringValue = pixelColor.B.ToString("D3");
                                //Console.WriteLine(x + ", " + y + " = " + pixelColorStringValue);
                                if (x == 0)
                                { aX011Y000 = pixelColorStringValue; }
                                if (x == 1)
                                { aX011Y001 = pixelColorStringValue; }
                                if (x == 2)
                                { aX011Y002 = pixelColorStringValue; }
                                if (x == 3)
                                { aX011Y003 = pixelColorStringValue; }
                                if (x == 4)
                                { aX011Y004 = pixelColorStringValue; }
                                if (x == 5)
                                { aX011Y005 = pixelColorStringValue; }
                                if (x == 6)
                                { aX011Y006 = pixelColorStringValue; }
                                if (x == 7)
                                { aX011Y007 = pixelColorStringValue; }
                                if (x == 8)
                                { aX011Y008 = pixelColorStringValue; }
                                if (x == 9)
                                { aX011Y009 = pixelColorStringValue; }
                                if (x == 10)
                                { aX011Y010 = pixelColorStringValue; }
                                if (x == 11)
                                { aX011Y011 = pixelColorStringValue; }
                            }

                        }

                    }
                }

                /******************************************* PROCESSING LOOP EXCEPTIONS ************************************/
                catch (ArgumentException)
                {

                    string message = "No applicable files were found, close application?";
                    string caption = "Tools Fail!";
                    // MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    // DialogResult result;
                    // result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    // if (result == DialogResult.Yes)
                    // { Application.Exit(); }
                    // if (result == DialogResult.No)
                    // { Console.WriteLine("Ignoring error '" + caption + "'"); }
                    // richTextBox1.AppendText(Environment.NewLine + "not applicable");
                    // richTextBox1.Focus();
                    // richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    // richTextBox1.ScrollToCaret();

                }

                Console.WriteLine(file + " Adding values to data table...");
                //richTextBox1.AppendText(Environment.NewLine + file + " Adding values to data table...");
                dta.Rows.Add("cellX000", aX000Y000, aX000Y001, aX000Y002, aX000Y003, aX000Y004, aX000Y005, aX000Y006, aX000Y007, aX000Y008, aX000Y009, aX000Y010, aX000Y011);
                dta.Rows.Add("cellX001", aX001Y000, aX001Y001, aX001Y002, aX001Y003, aX001Y004, aX001Y005, aX001Y006, aX001Y007, aX001Y008, aX001Y009, aX001Y010, aX001Y011);
                dta.Rows.Add("cellX002", aX002Y000, aX002Y001, aX002Y002, aX002Y003, aX002Y004, aX002Y005, aX002Y006, aX002Y007, aX002Y008, aX002Y009, aX002Y010, aX002Y011);
                dta.Rows.Add("cellX003", aX003Y000, aX003Y001, aX003Y002, aX003Y003, aX003Y004, aX003Y005, aX003Y006, aX003Y007, aX003Y008, aX003Y009, aX003Y010, aX003Y011);
                dta.Rows.Add("cellX004", aX004Y000, aX004Y001, aX004Y002, aX004Y003, aX004Y004, aX004Y005, aX004Y006, aX004Y007, aX004Y008, aX004Y009, aX004Y010, aX004Y011);
                dta.Rows.Add("cellX005", aX005Y000, aX005Y001, aX005Y002, aX005Y003, aX005Y004, aX005Y005, aX005Y006, aX005Y007, aX005Y008, aX005Y009, aX005Y010, aX005Y011);
                dta.Rows.Add("cellX006", aX006Y000, aX006Y001, aX006Y002, aX006Y003, aX006Y004, aX006Y005, aX006Y006, aX006Y007, aX006Y008, aX006Y009, aX006Y010, aX006Y011);
                dta.Rows.Add("cellX007", aX007Y000, aX007Y001, aX007Y002, aX007Y003, aX007Y004, aX007Y005, aX007Y006, aX007Y007, aX007Y008, aX007Y009, aX007Y010, aX007Y011);
                dta.Rows.Add("cellX008", aX008Y000, aX008Y001, aX008Y002, aX008Y003, aX008Y004, aX008Y005, aX008Y006, aX008Y007, aX008Y008, aX008Y009, aX008Y010, aX008Y011);
                dta.Rows.Add("cellX009", aX009Y000, aX009Y001, aX009Y002, aX009Y003, aX009Y004, aX009Y005, aX009Y006, aX009Y007, aX009Y008, aX009Y009, aX009Y010, aX009Y011);
                dta.Rows.Add("cellX010", aX010Y000, aX010Y001, aX010Y002, aX010Y003, aX010Y004, aX010Y005, aX010Y006, aX010Y007, aX010Y008, aX010Y009, aX010Y010, aX010Y011);
                dta.Rows.Add("cellX011", aX011Y000, aX011Y001, aX011Y002, aX011Y003, aX011Y004, aX011Y005, aX011Y006, aX011Y007, aX011Y008, aX011Y009, aX011Y010, aX011Y011);


                StringBuilder sb = new StringBuilder();

                foreach (DataColumn col in dta.Columns)
                {
                    // In order to make a csv, we need a string data table variable to pass the info into.
                    // Here we take the column names from above and add them all--places a comma after each (hence comma separated values)
                    sb.Append(col.ColumnName + ',');

                }

                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();


                foreach (DataRow row in dta.Rows)
                {
                    // First row is all headers (done above), now we add the rows all at once using comma separators.  
                    // Uses Append line after each.  Counts by number of columns to know when to go to next line.
                    for (int i = 0; i < dta.Columns.Count; i++)
                    {

                        if (i < 12)
                        {
                            sb.Append(row[i].ToString() + ",");
                        }

                        else
                        {
                            sb.Append(row[i].ToString());
                        }

                    }

                    sb.AppendLine();
                }



                /*  Write everything to csvs */

                try
                {
                    // name csv from images, this goes off for every file converted --commented out the richtextbox updater for performance
                    System.IO.File.WriteAllText(path + file + ".csv", sb.ToString());
                    // richTextBox1.AppendText(Environment.NewLine + file + " Written...");
                    // richTextBox1.Focus();
                    // richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    // richTextBox1.ScrollToCaret();
                }
                catch
                {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "No valid directory for CSVs in " + path + ", close application?";
                    string caption = "CSV folder found!";
                    // MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    // DialogResult result;
                    // result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    // if (result == DialogResult.Yes)
                    // { Application.Exit(); }
                    // if (result == DialogResult.No)
                    { Console.WriteLine("Ignoring error '" + caption + "'"); }
                }




            }

            // richTextBox1.AppendText(Environment.NewLine + "... Finished Writing All CSVs!");


            // Play a little tune when we're done processing
            System.Media.SoundPlayer sp = (completesong);
            sp.Play();

            // richTextBox1.Focus();
            // richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // richTextBox1.ScrollToCaret();
        }








    }
}
