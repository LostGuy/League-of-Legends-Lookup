namespace League_of_Legends_Lookup
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.summonerLookupTab = new System.Windows.Forms.TabPage();
            this.tab1ComboBox = new System.Windows.Forms.ComboBox();
            this.tab1Image = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.summonerNameBox = new System.Windows.Forms.TextBox();
            this.summonerLookupButton = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.summonerLookupTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.summonerLookupTab);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(4, 1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(746, 524);
            this.tabs.TabIndex = 0;
            // 
            // summonerLookupTab
            // 
            this.summonerLookupTab.Controls.Add(this.summonerLookupButton);
            this.summonerLookupTab.Controls.Add(this.summonerNameBox);
            this.summonerLookupTab.Controls.Add(this.tab1ComboBox);
            this.summonerLookupTab.Controls.Add(this.tab1Image);
            this.summonerLookupTab.Location = new System.Drawing.Point(4, 22);
            this.summonerLookupTab.Name = "summonerLookupTab";
            this.summonerLookupTab.Padding = new System.Windows.Forms.Padding(3);
            this.summonerLookupTab.Size = new System.Drawing.Size(738, 498);
            this.summonerLookupTab.TabIndex = 0;
            this.summonerLookupTab.Text = "Summoner Lookup";
            this.summonerLookupTab.UseVisualStyleBackColor = true;
            // 
            // tab1ComboBox
            // 
            this.tab1ComboBox.FormattingEnabled = true;
            this.tab1ComboBox.Location = new System.Drawing.Point(323, 110);
            this.tab1ComboBox.Name = "tab1ComboBox";
            this.tab1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.tab1ComboBox.TabIndex = 1;
            // 
            // tab1Image
            // 
            this.tab1Image.ErrorImage = null;
            this.tab1Image.InitialImage = null;
            this.tab1Image.Location = new System.Drawing.Point(0, 0);
            this.tab1Image.Name = "tab1Image";
            this.tab1Image.Size = new System.Drawing.Size(738, 498);
            this.tab1Image.TabIndex = 0;
            this.tab1Image.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // summonerNameBox
            // 
            this.summonerNameBox.Location = new System.Drawing.Point(294, 165);
            this.summonerNameBox.Name = "summonerNameBox";
            this.summonerNameBox.Size = new System.Drawing.Size(186, 20);
            this.summonerNameBox.TabIndex = 2;
            // 
            // summonerLookupButton
            // 
            this.summonerLookupButton.Location = new System.Drawing.Point(294, 391);
            this.summonerLookupButton.Name = "summonerLookupButton";
            this.summonerLookupButton.Size = new System.Drawing.Size(157, 41);
            this.summonerLookupButton.TabIndex = 3;
            this.summonerLookupButton.Text = "Lookup Summoner";
            this.summonerLookupButton.UseVisualStyleBackColor = true;
            this.summonerLookupButton.Click += new System.EventHandler(this.summonerLookupButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 528);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.summonerLookupTab.ResumeLayout(false);
            this.summonerLookupTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage summonerLookupTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox tab1Image;
        private System.Windows.Forms.ComboBox tab1ComboBox;
        private System.Windows.Forms.TextBox summonerNameBox;
        private System.Windows.Forms.Button summonerLookupButton;
    }
}

