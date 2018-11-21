namespace _2210_002_CowellDakota_DataStructuresProject3
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutInfixToPostFixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infixTitleLabel = new System.Windows.Forms.Label();
            this.infixLabel = new System.Windows.Forms.Label();
            this.postFixLabel = new System.Windows.Forms.Label();
            this.infixExpressionListBox = new System.Windows.Forms.ListBox();
            this.infixTextBox = new System.Windows.Forms.TextBox();
            this.postFixTextBox = new System.Windows.Forms.TextBox();
            this.generatePostFixButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(64, 38);
            this.fileButton.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.openToolStripMenuItem.Text = "Input Infix Data File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInfixToPostFixToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutInfixToPostFixToolStripMenuItem
            // 
            this.aboutInfixToPostFixToolStripMenuItem.Name = "aboutInfixToPostFixToolStripMenuItem";
            this.aboutInfixToPostFixToolStripMenuItem.Size = new System.Drawing.Size(340, 38);
            this.aboutInfixToPostFixToolStripMenuItem.Text = "About Infix to PostFix";
            this.aboutInfixToPostFixToolStripMenuItem.Click += new System.EventHandler(this.aboutInfixToPostFixToolStripMenuItem_Click);
            // 
            // infixTitleLabel
            // 
            this.infixTitleLabel.AutoSize = true;
            this.infixTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infixTitleLabel.Location = new System.Drawing.Point(63, 82);
            this.infixTitleLabel.Name = "infixTitleLabel";
            this.infixTitleLabel.Size = new System.Drawing.Size(219, 31);
            this.infixTitleLabel.TabIndex = 1;
            this.infixTitleLabel.Text = "Infix Expressions";
            // 
            // infixLabel
            // 
            this.infixLabel.AutoSize = true;
            this.infixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infixLabel.Location = new System.Drawing.Point(63, 487);
            this.infixLabel.Name = "infixLabel";
            this.infixLabel.Size = new System.Drawing.Size(181, 29);
            this.infixLabel.TabIndex = 2;
            this.infixLabel.Text = "Infix Expression";
            // 
            // postFixLabel
            // 
            this.postFixLabel.AutoSize = true;
            this.postFixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postFixLabel.Location = new System.Drawing.Point(63, 539);
            this.postFixLabel.Name = "postFixLabel";
            this.postFixLabel.Size = new System.Drawing.Size(219, 29);
            this.postFixLabel.TabIndex = 3;
            this.postFixLabel.Text = "PostFix Expression";
            // 
            // infixExpressionListBox
            // 
            this.infixExpressionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infixExpressionListBox.FormattingEnabled = true;
            this.infixExpressionListBox.ItemHeight = 25;
            this.infixExpressionListBox.Location = new System.Drawing.Point(69, 128);
            this.infixExpressionListBox.Name = "infixExpressionListBox";
            this.infixExpressionListBox.Size = new System.Drawing.Size(1100, 329);
            this.infixExpressionListBox.TabIndex = 4;
            this.infixExpressionListBox.SelectedIndexChanged += new System.EventHandler(this.infixExpressionListBox_SelectedIndexChanged);
            // 
            // infixTextBox
            // 
            this.infixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infixTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infixTextBox.Location = new System.Drawing.Point(305, 481);
            this.infixTextBox.Name = "infixTextBox";
            this.infixTextBox.Size = new System.Drawing.Size(864, 40);
            this.infixTextBox.TabIndex = 5;
            // 
            // postFixTextBox
            // 
            this.postFixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postFixTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.postFixTextBox.Enabled = false;
            this.postFixTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postFixTextBox.Location = new System.Drawing.Point(305, 539);
            this.postFixTextBox.Name = "postFixTextBox";
            this.postFixTextBox.Size = new System.Drawing.Size(864, 40);
            this.postFixTextBox.TabIndex = 6;
            // 
            // generatePostFixButton
            // 
            this.generatePostFixButton.Location = new System.Drawing.Point(189, 607);
            this.generatePostFixButton.Name = "generatePostFixButton";
            this.generatePostFixButton.Size = new System.Drawing.Size(213, 54);
            this.generatePostFixButton.TabIndex = 7;
            this.generatePostFixButton.Text = "Generate PostFix";
            this.generatePostFixButton.UseVisualStyleBackColor = true;
            this.generatePostFixButton.Click += new System.EventHandler(this.generatePostFixButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(513, 607);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(213, 54);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(839, 607);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(213, 54);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 688);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.generatePostFixButton);
            this.Controls.Add(this.postFixTextBox);
            this.Controls.Add(this.infixTextBox);
            this.Controls.Add(this.infixExpressionListBox);
            this.Controls.Add(this.postFixLabel);
            this.Controls.Add(this.infixLabel);
            this.Controls.Add(this.infixTitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSCI-2210-002 - Dakota Cowell\'s Infix to PostFix converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutInfixToPostFixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label infixTitleLabel;
        private System.Windows.Forms.Label infixLabel;
        private System.Windows.Forms.Label postFixLabel;
        private System.Windows.Forms.ListBox infixExpressionListBox;
        private System.Windows.Forms.TextBox infixTextBox;
        private System.Windows.Forms.TextBox postFixTextBox;
        private System.Windows.Forms.Button generatePostFixButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

