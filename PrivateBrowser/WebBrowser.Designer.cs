namespace PrivateBrowser
{
    partial class WebBrowser
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.Favourite = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.browserWindow = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backButton.Location = new System.Drawing.Point(5, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 25);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.Location = new System.Drawing.Point(434, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 25);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.historyButton.Location = new System.Drawing.Point(507, 12);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(75, 25);
            this.historyButton.TabIndex = 4;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // Favourite
            // 
            this.Favourite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Favourite.Location = new System.Drawing.Point(588, 12);
            this.Favourite.Name = "Favourite";
            this.Favourite.Size = new System.Drawing.Size(43, 25);
            this.Favourite.TabIndex = 5;
            this.Favourite.Text = "Fav\'s";
            this.Favourite.UseVisualStyleBackColor = true;
            this.Favourite.Click += new System.EventHandler(this.Favourite_Click);
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goButton.Location = new System.Drawing.Point(303, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(49, 25);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forwardButton.Location = new System.Drawing.Point(31, 12);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(33, 25);
            this.forwardButton.TabIndex = 7;
            this.forwardButton.Text = ">>";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(358, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(637, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // browserWindow
            // 
            this.browserWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserWindow.Location = new System.Drawing.Point(0, 41);
            this.browserWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserWindow.Name = "browserWindow";
            this.browserWindow.Size = new System.Drawing.Size(674, 451);
            this.browserWindow.TabIndex = 10;
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 492);
            this.Controls.Add(this.browserWindow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.Favourite);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "WebBrowser";
            this.Text = "Private Browser v 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Favourite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser browserWindow;
    }
}