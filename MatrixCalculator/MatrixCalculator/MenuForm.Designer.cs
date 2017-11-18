namespace MatrixCalculator
{
    partial class MenuForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.unaryOpsButton = new System.Windows.Forms.Button();
            this.binaryOpsButton = new System.Windows.Forms.Button();
            this.linearSystemOpsButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.menuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(201, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Matrix calculator";
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.aboutButton);
            this.menuGroupBox.Controls.Add(this.linearSystemOpsButton);
            this.menuGroupBox.Controls.Add(this.binaryOpsButton);
            this.menuGroupBox.Controls.Add(this.unaryOpsButton);
            this.menuGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuGroupBox.Location = new System.Drawing.Point(12, 66);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(268, 227);
            this.menuGroupBox.TabIndex = 1;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(179, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // unaryOpsButton
            // 
            this.unaryOpsButton.AutoSize = true;
            this.unaryOpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unaryOpsButton.Location = new System.Drawing.Point(25, 33);
            this.unaryOpsButton.Name = "unaryOpsButton";
            this.unaryOpsButton.Size = new System.Drawing.Size(214, 32);
            this.unaryOpsButton.TabIndex = 3;
            this.unaryOpsButton.Text = "Unary operations";
            this.unaryOpsButton.UseVisualStyleBackColor = true;
            this.unaryOpsButton.Click += new System.EventHandler(this.unaryOpsButton_Click);
            // 
            // binaryOpsButton
            // 
            this.binaryOpsButton.AutoSize = true;
            this.binaryOpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binaryOpsButton.Location = new System.Drawing.Point(25, 80);
            this.binaryOpsButton.Name = "binaryOpsButton";
            this.binaryOpsButton.Size = new System.Drawing.Size(214, 32);
            this.binaryOpsButton.TabIndex = 4;
            this.binaryOpsButton.Text = "Binary operations";
            this.binaryOpsButton.UseVisualStyleBackColor = true;
            this.binaryOpsButton.Click += new System.EventHandler(this.binaryOpsButton_Click);
            // 
            // linearSystemOpsButton
            // 
            this.linearSystemOpsButton.AutoSize = true;
            this.linearSystemOpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linearSystemOpsButton.Location = new System.Drawing.Point(25, 128);
            this.linearSystemOpsButton.Name = "linearSystemOpsButton";
            this.linearSystemOpsButton.Size = new System.Drawing.Size(214, 32);
            this.linearSystemOpsButton.TabIndex = 5;
            this.linearSystemOpsButton.Text = "Linear system operations";
            this.linearSystemOpsButton.UseVisualStyleBackColor = true;
            this.linearSystemOpsButton.Click += new System.EventHandler(this.linearSystemOpsButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSize = true;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(25, 175);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(214, 32);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 321);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(57, 20);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "v1.0.0.0";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(292, 353);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix calculator";
            this.menuGroupBox.ResumeLayout(false);
            this.menuGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button linearSystemOpsButton;
        private System.Windows.Forms.Button binaryOpsButton;
        private System.Windows.Forms.Button unaryOpsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label versionLabel;
    }
}

