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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.OpsPanel1 = new System.Windows.Forms.Panel();
            this.OpsPanel2 = new System.Windows.Forms.Panel();
            this.OpsPanel3 = new System.Windows.Forms.Panel();
            this.OpsPanel4 = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(65, 461);
            this.MenuPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OpsPanel1
            // 
            this.OpsPanel1.Location = new System.Drawing.Point(65, 0);
            this.OpsPanel1.Name = "OpsPanel1";
            this.OpsPanel1.Size = new System.Drawing.Size(719, 461);
            this.OpsPanel1.TabIndex = 1;
            // 
            // OpsPanel2
            // 
            this.OpsPanel2.Location = new System.Drawing.Point(65, 0);
            this.OpsPanel2.Name = "OpsPanel2";
            this.OpsPanel2.Size = new System.Drawing.Size(719, 461);
            this.OpsPanel2.TabIndex = 2;
            // 
            // OpsPanel3
            // 
            this.OpsPanel3.Location = new System.Drawing.Point(65, 0);
            this.OpsPanel3.Name = "OpsPanel3";
            this.OpsPanel3.Size = new System.Drawing.Size(719, 461);
            this.OpsPanel3.TabIndex = 3;
            // 
            // OpsPanel4
            // 
            this.OpsPanel4.Location = new System.Drawing.Point(65, 0);
            this.OpsPanel4.Name = "OpsPanel4";
            this.OpsPanel4.Size = new System.Drawing.Size(719, 461);
            this.OpsPanel4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.OpsPanel4);
            this.Controls.Add(this.OpsPanel3);
            this.Controls.Add(this.OpsPanel2);
            this.Controls.Add(this.OpsPanel1);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Arbeitsbox";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel OpsPanel1;
        private System.Windows.Forms.Panel OpsPanel2;
        private System.Windows.Forms.Panel OpsPanel3;
        private System.Windows.Forms.Panel OpsPanel4;
    }
}

