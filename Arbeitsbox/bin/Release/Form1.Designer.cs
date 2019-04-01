namespace Arbeitsbox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AudioButton = new System.Windows.Forms.Button();
            this.GeneralButton = new System.Windows.Forms.Button();
            this.FaunaButton = new System.Windows.Forms.Button();
            this.FoliageButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.AudioPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.ProcessAudioButton = new System.Windows.Forms.Button();
            this.AudioVisualizerButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.waveformPainter2 = new NAudio.Gui.WaveformPainter();
            this.FaunaPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FoliagePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MasterQuestNationText = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.OtherPanel = new System.Windows.Forms.Panel();
            this.FoliagePageTitle = new System.Windows.Forms.Label();
            this.Foliage_HeaderLabel = new System.Windows.Forms.Label();
            this.FoliageHLine = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AudioPanel.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.FaunaPanel.SuspendLayout();
            this.FoliagePanel.SuspendLayout();
            this.OtherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.AudioButton);
            this.MenuPanel.Controls.Add(this.GeneralButton);
            this.MenuPanel.Controls.Add(this.FaunaButton);
            this.MenuPanel.Controls.Add(this.FoliageButton);
            this.MenuPanel.Controls.Add(this.OtherButton);
            this.MenuPanel.Location = new System.Drawing.Point(0, 47);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(65, 515);
            this.MenuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Arbeitsbox.Properties.Resources.android_icon_192x1921;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // AudioButton
            // 
            this.AudioButton.BackColor = System.Drawing.Color.BlueViolet;
            this.AudioButton.FlatAppearance.BorderSize = 0;
            this.AudioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AudioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.AudioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AudioButton.ForeColor = System.Drawing.Color.White;
            this.AudioButton.Location = new System.Drawing.Point(0, 0);
            this.AudioButton.Margin = new System.Windows.Forms.Padding(0);
            this.AudioButton.Name = "AudioButton";
            this.AudioButton.Size = new System.Drawing.Size(64, 50);
            this.AudioButton.TabIndex = 0;
            this.AudioButton.Text = "Dialogue";
            this.AudioButton.UseVisualStyleBackColor = false;
            this.AudioButton.Click += new System.EventHandler(this.AudioButton_Click);
            // 
            // GeneralButton
            // 
            this.GeneralButton.BackColor = System.Drawing.Color.Orange;
            this.GeneralButton.FlatAppearance.BorderSize = 0;
            this.GeneralButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.GeneralButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GeneralButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.GeneralButton.ForeColor = System.Drawing.Color.White;
            this.GeneralButton.Location = new System.Drawing.Point(0, 51);
            this.GeneralButton.Name = "GeneralButton";
            this.GeneralButton.Size = new System.Drawing.Size(64, 50);
            this.GeneralButton.TabIndex = 1;
            this.GeneralButton.Text = "General";
            this.GeneralButton.UseVisualStyleBackColor = false;
            this.GeneralButton.Click += new System.EventHandler(this.GeneralButton_Click);
            // 
            // FaunaButton
            // 
            this.FaunaButton.BackColor = System.Drawing.Color.Cyan;
            this.FaunaButton.FlatAppearance.BorderSize = 0;
            this.FaunaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FaunaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.FaunaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaunaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FaunaButton.ForeColor = System.Drawing.Color.White;
            this.FaunaButton.Location = new System.Drawing.Point(0, 102);
            this.FaunaButton.Name = "FaunaButton";
            this.FaunaButton.Size = new System.Drawing.Size(64, 50);
            this.FaunaButton.TabIndex = 2;
            this.FaunaButton.Text = "Fauna";
            this.FaunaButton.UseVisualStyleBackColor = false;
            this.FaunaButton.Click += new System.EventHandler(this.FaunaButton_Click);
            // 
            // FoliageButton
            // 
            this.FoliageButton.BackColor = System.Drawing.Color.Firebrick;
            this.FoliageButton.FlatAppearance.BorderSize = 0;
            this.FoliageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FoliageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.FoliageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoliageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FoliageButton.ForeColor = System.Drawing.Color.White;
            this.FoliageButton.Location = new System.Drawing.Point(0, 153);
            this.FoliageButton.Margin = new System.Windows.Forms.Padding(2);
            this.FoliageButton.Name = "FoliageButton";
            this.FoliageButton.Size = new System.Drawing.Size(64, 50);
            this.FoliageButton.TabIndex = 3;
            this.FoliageButton.Text = "Quests";
            this.FoliageButton.UseVisualStyleBackColor = false;
            this.FoliageButton.Click += new System.EventHandler(this.FoliageButton_Click);
            // 
            // OtherButton
            // 
            this.OtherButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OtherButton.FlatAppearance.BorderSize = 0;
            this.OtherButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.OtherButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.OtherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OtherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OtherButton.ForeColor = System.Drawing.Color.White;
            this.OtherButton.Location = new System.Drawing.Point(0, 204);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(64, 50);
            this.OtherButton.TabIndex = 4;
            this.OtherButton.Text = "Other";
            this.OtherButton.UseVisualStyleBackColor = false;
            this.OtherButton.Click += new System.EventHandler(this.OtherButton_Click);
            // 
            // AudioPanel
            // 
            this.AudioPanel.Controls.Add(this.label6);
            this.AudioPanel.Controls.Add(this.waveformPainter1);
            this.AudioPanel.Controls.Add(this.ProcessAudioButton);
            this.AudioPanel.Controls.Add(this.AudioVisualizerButton);
            this.AudioPanel.Location = new System.Drawing.Point(65, 48);
            this.AudioPanel.Name = "AudioPanel";
            this.AudioPanel.Size = new System.Drawing.Size(882, 374);
            this.AudioPanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(351, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 36);
            this.label6.TabIndex = 53;
            this.label6.Text = "Audio Sorter";
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackColor = System.Drawing.Color.Black;
            this.waveformPainter1.ForeColor = System.Drawing.Color.Lime;
            this.waveformPainter1.Location = new System.Drawing.Point(0, 52);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(882, 202);
            this.waveformPainter1.TabIndex = 37;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // ProcessAudioButton
            // 
            this.ProcessAudioButton.BackColor = System.Drawing.Color.Lime;
            this.ProcessAudioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProcessAudioButton.FlatAppearance.BorderSize = 0;
            this.ProcessAudioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ProcessAudioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.ProcessAudioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessAudioButton.ForeColor = System.Drawing.Color.White;
            this.ProcessAudioButton.Location = new System.Drawing.Point(208, 318);
            this.ProcessAudioButton.Name = "ProcessAudioButton";
            this.ProcessAudioButton.Size = new System.Drawing.Size(206, 54);
            this.ProcessAudioButton.TabIndex = 36;
            this.ProcessAudioButton.Text = "Process Audio";
            this.ProcessAudioButton.UseVisualStyleBackColor = true;
            this.ProcessAudioButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // AudioVisualizerButton
            // 
            this.AudioVisualizerButton.BackColor = System.Drawing.Color.Lime;
            this.AudioVisualizerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AudioVisualizerButton.FlatAppearance.BorderSize = 0;
            this.AudioVisualizerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AudioVisualizerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.AudioVisualizerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudioVisualizerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioVisualizerButton.ForeColor = System.Drawing.Color.White;
            this.AudioVisualizerButton.Location = new System.Drawing.Point(1, 318);
            this.AudioVisualizerButton.Name = "AudioVisualizerButton";
            this.AudioVisualizerButton.Size = new System.Drawing.Size(206, 54);
            this.AudioVisualizerButton.TabIndex = 35;
            this.AudioVisualizerButton.Text = "Visualizer";
            this.AudioVisualizerButton.UseVisualStyleBackColor = true;
            this.AudioVisualizerButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(66, 424);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(881, 138);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "Arbeitsbox opened...";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 54);
            this.button1.TabIndex = 36;
            this.button1.Text = "Process Audio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 54);
            this.button2.TabIndex = 35;
            this.button2.Text = "Visualizer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.label5);
            this.GeneralPanel.Controls.Add(this.waveformPainter2);
            this.GeneralPanel.Controls.Add(this.button1);
            this.GeneralPanel.Controls.Add(this.button2);
            this.GeneralPanel.Location = new System.Drawing.Point(65, 48);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(882, 374);
            this.GeneralPanel.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 36);
            this.label5.TabIndex = 53;
            this.label5.Text = "General Audio";
            // 
            // waveformPainter2
            // 
            this.waveformPainter2.BackColor = System.Drawing.Color.Black;
            this.waveformPainter2.Location = new System.Drawing.Point(0, 52);
            this.waveformPainter2.Name = "waveformPainter2";
            this.waveformPainter2.Size = new System.Drawing.Size(882, 202);
            this.waveformPainter2.TabIndex = 38;
            this.waveformPainter2.Text = "waveformPainter2";
            // 
            // FaunaPanel
            // 
            this.FaunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FaunaPanel.Controls.Add(this.label4);
            this.FaunaPanel.Controls.Add(this.label1);
            this.FaunaPanel.Controls.Add(this.label2);
            this.FaunaPanel.Controls.Add(this.label3);
            this.FaunaPanel.Controls.Add(this.button21);
            this.FaunaPanel.Controls.Add(this.button22);
            this.FaunaPanel.Controls.Add(this.button23);
            this.FaunaPanel.Controls.Add(this.button24);
            this.FaunaPanel.Controls.Add(this.button25);
            this.FaunaPanel.Controls.Add(this.button26);
            this.FaunaPanel.Controls.Add(this.button3);
            this.FaunaPanel.Controls.Add(this.button4);
            this.FaunaPanel.Location = new System.Drawing.Point(65, 48);
            this.FaunaPanel.Name = "FaunaPanel";
            this.FaunaPanel.Size = new System.Drawing.Size(882, 374);
            this.FaunaPanel.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(510, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "G:\\UE4\\Tailwind_R E B U I L D\\Environment\\World Machine 93e\\PNGs\\12\\BMPs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 52;
            this.label1.Text = "Fauna Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Fauna PNG -> CSV Processor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1109, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____________________________";
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Lime;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(732, 191);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(30, 54);
            this.button21.TabIndex = 49;
            this.button21.Text = ">";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Lime;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(568, 191);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(30, 54);
            this.button22.TabIndex = 48;
            this.button22.Text = "<";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Lime;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(604, 191);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(122, 54);
            this.button23.TabIndex = 47;
            this.button23.Text = "Run (10)";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Lime;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(300, 191);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(30, 54);
            this.button24.TabIndex = 46;
            this.button24.Text = ">";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Lime;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(136, 191);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(30, 54);
            this.button25.TabIndex = 45;
            this.button25.Text = "<";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Lime;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(172, 191);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(122, 54);
            this.button26.TabIndex = 44;
            this.button26.Text = "Run (10)";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(136, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 54);
            this.button3.TabIndex = 42;
            this.button3.Text = "Write 12s CSVs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(568, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 54);
            this.button4.TabIndex = 43;
            this.button4.Text = "Write 64s CSVs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 54);
            this.button5.TabIndex = 36;
            this.button5.Text = "Set Nation";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FoliagePanel
            // 
            this.FoliagePanel.Controls.Add(this.button9);
            this.FoliagePanel.Controls.Add(this.label7);
            this.FoliagePanel.Controls.Add(this.button6);
            this.FoliagePanel.Controls.Add(this.label8);
            this.FoliagePanel.Controls.Add(this.label9);
            this.FoliagePanel.Controls.Add(this.label10);
            this.FoliagePanel.Controls.Add(this.MasterQuestNationText);
            this.FoliagePanel.Controls.Add(this.button5);
            this.FoliagePanel.Location = new System.Drawing.Point(65, 48);
            this.FoliagePanel.Name = "FoliagePanel";
            this.FoliagePanel.Size = new System.Drawing.Size(882, 374);
            this.FoliagePanel.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(223, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Current Stage";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 54);
            this.button6.TabIndex = 57;
            this.button6.Text = "Open Charts";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "G:\\UE4\\Tailwind_R E B U I L D\\Environment\\QuestData";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(344, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Master Quest Dialogues";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(71, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(889, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "_________________________________________________________________________________" +
    "_______";
            // 
            // MasterQuestNationText
            // 
            this.MasterQuestNationText.AutoSize = true;
            this.MasterQuestNationText.ForeColor = System.Drawing.SystemColors.Control;
            this.MasterQuestNationText.Location = new System.Drawing.Point(224, 329);
            this.MasterQuestNationText.Name = "MasterQuestNationText";
            this.MasterQuestNationText.Size = new System.Drawing.Size(70, 20);
            this.MasterQuestNationText.TabIndex = 37;
            this.MasterQuestNationText.Text = "Not Set";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(208, 318);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 54);
            this.button7.TabIndex = 36;
            this.button7.Text = "Nothing";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lime;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(1, 318);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(206, 54);
            this.button8.TabIndex = 35;
            this.button8.Text = "Nothing";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // OtherPanel
            // 
            this.OtherPanel.Controls.Add(this.FoliagePageTitle);
            this.OtherPanel.Controls.Add(this.Foliage_HeaderLabel);
            this.OtherPanel.Controls.Add(this.FoliageHLine);
            this.OtherPanel.Controls.Add(this.button7);
            this.OtherPanel.Controls.Add(this.button8);
            this.OtherPanel.Location = new System.Drawing.Point(65, 48);
            this.OtherPanel.Name = "OtherPanel";
            this.OtherPanel.Size = new System.Drawing.Size(882, 374);
            this.OtherPanel.TabIndex = 43;
            // 
            // FoliagePageTitle
            // 
            this.FoliagePageTitle.AutoSize = true;
            this.FoliagePageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoliagePageTitle.ForeColor = System.Drawing.Color.White;
            this.FoliagePageTitle.Location = new System.Drawing.Point(370, 10);
            this.FoliagePageTitle.Name = "FoliagePageTitle";
            this.FoliagePageTitle.Size = new System.Drawing.Size(157, 36);
            this.FoliagePageTitle.TabIndex = 47;
            this.FoliagePageTitle.Text = "Other Data";
            this.FoliagePageTitle.Click += new System.EventHandler(this.FoliagePageTitle_Click);
            // 
            // Foliage_HeaderLabel
            // 
            this.Foliage_HeaderLabel.AutoSize = true;
            this.Foliage_HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foliage_HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.Foliage_HeaderLabel.Location = new System.Drawing.Point(121, 57);
            this.Foliage_HeaderLabel.Name = "Foliage_HeaderLabel";
            this.Foliage_HeaderLabel.Size = new System.Drawing.Size(57, 24);
            this.Foliage_HeaderLabel.TabIndex = 45;
            this.Foliage_HeaderLabel.Text = "Other";
            // 
            // FoliageHLine
            // 
            this.FoliageHLine.AutoSize = true;
            this.FoliageHLine.ForeColor = System.Drawing.Color.White;
            this.FoliageHLine.Location = new System.Drawing.Point(122, 71);
            this.FoliageHLine.Name = "FoliageHLine";
            this.FoliageHLine.Size = new System.Drawing.Size(1109, 20);
            this.FoliageHLine.TabIndex = 46;
            this.FoliageHLine.Text = "_________________________________________________________________________________" +
    "_____________________________";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(717, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 42);
            this.button9.TabIndex = 59;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 561);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.FoliagePanel);
            this.Controls.Add(this.OtherPanel);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.AudioPanel);
            this.Controls.Add(this.FaunaPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(963, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbeitsbox";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AudioPanel.ResumeLayout(false);
            this.AudioPanel.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.FaunaPanel.ResumeLayout(false);
            this.FaunaPanel.PerformLayout();
            this.FoliagePanel.ResumeLayout(false);
            this.FoliagePanel.PerformLayout();
            this.OtherPanel.ResumeLayout(false);
            this.OtherPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button AudioButton;
        private System.Windows.Forms.Panel AudioPanel;
        private System.Windows.Forms.Button ProcessAudioButton;
        private System.Windows.Forms.Button AudioVisualizerButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button GeneralButton;
        private System.Windows.Forms.Button FaunaButton;
        private System.Windows.Forms.Button FoliageButton;
        private System.Windows.Forms.Button OtherButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel FaunaPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel FoliagePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel OtherPanel;
        private System.Windows.Forms.Label FoliagePageTitle;
        private System.Windows.Forms.Label Foliage_HeaderLabel;
        private System.Windows.Forms.Label FoliageHLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.WaveformPainter waveformPainter2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MasterQuestNationText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
    }
}

