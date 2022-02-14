namespace PiesDB
{
    partial class DB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bartek = new System.Windows.Forms.Button();
            this.Janek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.janekListBox = new System.Windows.Forms.ListBox();
            this.refresh = new System.Windows.Forms.Button();
            this.bartekListBox = new System.Windows.Forms.ListBox();
            this.liczba = new System.Windows.Forms.Label();
            this.kto = new System.Windows.Forms.Label();
            this.textBoxBartek = new System.Windows.Forms.TextBox();
            this.textBoxJanek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bartek
            // 
            this.Bartek.Location = new System.Drawing.Point(122, 356);
            this.Bartek.Name = "Bartek";
            this.Bartek.Size = new System.Drawing.Size(130, 68);
            this.Bartek.TabIndex = 0;
            this.Bartek.Text = "Bartek";
            this.Bartek.UseVisualStyleBackColor = true;
            this.Bartek.Click += new System.EventHandler(this.Bartek_Click);
            // 
            // Janek
            // 
            this.Janek.Location = new System.Drawing.Point(657, 356);
            this.Janek.Name = "Janek";
            this.Janek.Size = new System.Drawing.Size(130, 68);
            this.Janek.TabIndex = 1;
            this.Janek.Text = "Janek";
            this.Janek.UseVisualStyleBackColor = true;
            this.Janek.Click += new System.EventHandler(this.Janek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // janekListBox
            // 
            this.janekListBox.FormattingEnabled = true;
            this.janekListBox.ItemHeight = 15;
            this.janekListBox.Location = new System.Drawing.Point(527, 31);
            this.janekListBox.Name = "janekListBox";
            this.janekListBox.Size = new System.Drawing.Size(260, 319);
            this.janekListBox.TabIndex = 3;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(388, 379);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(125, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // bartekListBox
            // 
            this.bartekListBox.FormattingEnabled = true;
            this.bartekListBox.ItemHeight = 15;
            this.bartekListBox.Location = new System.Drawing.Point(122, 31);
            this.bartekListBox.Name = "bartekListBox";
            this.bartekListBox.Size = new System.Drawing.Size(260, 319);
            this.bartekListBox.TabIndex = 3;
            // 
            // liczba
            // 
            this.liczba.AutoSize = true;
            this.liczba.Location = new System.Drawing.Point(437, 163);
            this.liczba.Name = "liczba";
            this.liczba.Size = new System.Drawing.Size(37, 15);
            this.liczba.TabIndex = 5;
            this.liczba.Text = "liczba";
            // 
            // kto
            // 
            this.kto.AutoSize = true;
            this.kto.Location = new System.Drawing.Point(436, 67);
            this.kto.Name = "kto";
            this.kto.Size = new System.Drawing.Size(0, 15);
            this.kto.TabIndex = 6;
            // 
            // textBoxBartek
            // 
            this.textBoxBartek.Location = new System.Drawing.Point(250, 379);
            this.textBoxBartek.Name = "textBoxBartek";
            this.textBoxBartek.Size = new System.Drawing.Size(132, 23);
            this.textBoxBartek.TabIndex = 7;
            this.textBoxBartek.Leave += new System.EventHandler(this.textBoxBartek_Leave);
            // 
            // textBoxJanek
            // 
            this.textBoxJanek.Location = new System.Drawing.Point(527, 379);
            this.textBoxJanek.Name = "textBoxJanek";
            this.textBoxJanek.Size = new System.Drawing.Size(132, 23);
            this.textBoxJanek.TabIndex = 7;
            this.textBoxJanek.Leave += new System.EventHandler(this.textBoxJanek_Leave);
            // 
            // DB
            // 
            this.ClientSize = new System.Drawing.Size(912, 465);
            this.Controls.Add(this.textBoxJanek);
            this.Controls.Add(this.textBoxBartek);
            this.Controls.Add(this.kto);
            this.Controls.Add(this.liczba);
            this.Controls.Add(this.bartekListBox);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.janekListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Janek);
            this.Controls.Add(this.Bartek);
            this.Name = "DB";
            this.Load += new System.EventHandler(this.DB_Load);
            this.Leave += new System.EventHandler(this.DB_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button Janek;
        private System.Windows.Forms.Button Bartek;
        private System.Windows.Forms.Button Janek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox janekListBox;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ListBox bartekListBox;
        private System.Windows.Forms.Label liczba;
        private System.Windows.Forms.Label kto;
        private System.Windows.Forms.TextBox textBoxBartek;
        private System.Windows.Forms.TextBox textBoxJanek;
    }
}

