namespace Calculadora
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.sumButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.No0 = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.No3 = new System.Windows.Forms.Button();
            this.No2 = new System.Windows.Forms.Button();
            this.No1 = new System.Windows.Forms.Button();
            this.reciprocalButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.No6 = new System.Windows.Forms.Button();
            this.No5 = new System.Windows.Forms.Button();
            this.No4 = new System.Windows.Forms.Button();
            this.moduleButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.No9 = new System.Windows.Forms.Button();
            this.No8 = new System.Windows.Forms.Button();
            this.No7 = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.calcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.author = new System.Windows.Forms.Label();
            this.operationInProgress = new System.Windows.Forms.Label();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ControlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlsPanel.Controls.Add(this.sumButton);
            this.ControlsPanel.Controls.Add(this.decimalButton);
            this.ControlsPanel.Controls.Add(this.No0);
            this.ControlsPanel.Controls.Add(this.resultButton);
            this.ControlsPanel.Controls.Add(this.minusButton);
            this.ControlsPanel.Controls.Add(this.No3);
            this.ControlsPanel.Controls.Add(this.No2);
            this.ControlsPanel.Controls.Add(this.No1);
            this.ControlsPanel.Controls.Add(this.reciprocalButton);
            this.ControlsPanel.Controls.Add(this.multiplyButton);
            this.ControlsPanel.Controls.Add(this.No6);
            this.ControlsPanel.Controls.Add(this.No5);
            this.ControlsPanel.Controls.Add(this.No4);
            this.ControlsPanel.Controls.Add(this.moduleButton);
            this.ControlsPanel.Controls.Add(this.divisionButton);
            this.ControlsPanel.Controls.Add(this.No9);
            this.ControlsPanel.Controls.Add(this.No8);
            this.ControlsPanel.Controls.Add(this.No7);
            this.ControlsPanel.Controls.Add(this.squareButton);
            this.ControlsPanel.Controls.Add(this.changeSignButton);
            this.ControlsPanel.Controls.Add(this.clearAllButton);
            this.ControlsPanel.Controls.Add(this.clearButton);
            this.ControlsPanel.Controls.Add(this.eraseButton);
            this.ControlsPanel.Location = new System.Drawing.Point(12, 73);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(260, 249);
            this.ControlsPanel.TabIndex = 0;
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sumButton.Location = new System.Drawing.Point(158, 196);
            this.sumButton.Name = "sumButton";
            this.sumButton.Padding = new System.Windows.Forms.Padding(3);
            this.sumButton.Size = new System.Drawing.Size(45, 40);
            this.sumButton.TabIndex = 25;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_clicked);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decimalButton.Location = new System.Drawing.Point(107, 196);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Padding = new System.Windows.Forms.Padding(3);
            this.decimalButton.Size = new System.Drawing.Size(45, 40);
            this.decimalButton.TabIndex = 24;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.button_clicked);
            // 
            // No0
            // 
            this.No0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No0.Location = new System.Drawing.Point(5, 196);
            this.No0.Name = "No0";
            this.No0.Padding = new System.Windows.Forms.Padding(3);
            this.No0.Size = new System.Drawing.Size(96, 40);
            this.No0.TabIndex = 22;
            this.No0.Text = "0";
            this.No0.UseVisualStyleBackColor = true;
            this.No0.Click += new System.EventHandler(this.button_clicked);
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultButton.Image = global::Calculadora.Properties.Resources.Equal;
            this.resultButton.Location = new System.Drawing.Point(209, 150);
            this.resultButton.Name = "resultButton";
            this.resultButton.Padding = new System.Windows.Forms.Padding(3);
            this.resultButton.Size = new System.Drawing.Size(45, 86);
            this.resultButton.TabIndex = 21;
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minusButton.Location = new System.Drawing.Point(158, 150);
            this.minusButton.Name = "minusButton";
            this.minusButton.Padding = new System.Windows.Forms.Padding(3);
            this.minusButton.Size = new System.Drawing.Size(45, 40);
            this.minusButton.TabIndex = 20;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_clicked);
            // 
            // No3
            // 
            this.No3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No3.Location = new System.Drawing.Point(107, 150);
            this.No3.Name = "No3";
            this.No3.Padding = new System.Windows.Forms.Padding(3);
            this.No3.Size = new System.Drawing.Size(45, 40);
            this.No3.TabIndex = 19;
            this.No3.Text = "3";
            this.No3.UseVisualStyleBackColor = true;
            this.No3.Click += new System.EventHandler(this.button_clicked);
            // 
            // No2
            // 
            this.No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No2.Location = new System.Drawing.Point(56, 150);
            this.No2.Name = "No2";
            this.No2.Padding = new System.Windows.Forms.Padding(3);
            this.No2.Size = new System.Drawing.Size(45, 40);
            this.No2.TabIndex = 18;
            this.No2.Text = "2";
            this.No2.UseVisualStyleBackColor = true;
            this.No2.Click += new System.EventHandler(this.button_clicked);
            // 
            // No1
            // 
            this.No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No1.Location = new System.Drawing.Point(5, 150);
            this.No1.Name = "No1";
            this.No1.Padding = new System.Windows.Forms.Padding(3);
            this.No1.Size = new System.Drawing.Size(45, 40);
            this.No1.TabIndex = 17;
            this.No1.Text = "1";
            this.No1.UseVisualStyleBackColor = true;
            this.No1.Click += new System.EventHandler(this.button_clicked);
            // 
            // reciprocalButton
            // 
            this.reciprocalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciprocalButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reciprocalButton.Location = new System.Drawing.Point(209, 104);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.Padding = new System.Windows.Forms.Padding(3);
            this.reciprocalButton.Size = new System.Drawing.Size(45, 40);
            this.reciprocalButton.TabIndex = 16;
            this.reciprocalButton.Text = "1/x";
            this.reciprocalButton.UseVisualStyleBackColor = true;
            this.reciprocalButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_clicked);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multiplyButton.Location = new System.Drawing.Point(158, 104);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Padding = new System.Windows.Forms.Padding(3);
            this.multiplyButton.Size = new System.Drawing.Size(45, 40);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_clicked);
            // 
            // No6
            // 
            this.No6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No6.Location = new System.Drawing.Point(107, 104);
            this.No6.Name = "No6";
            this.No6.Padding = new System.Windows.Forms.Padding(3);
            this.No6.Size = new System.Drawing.Size(45, 40);
            this.No6.TabIndex = 14;
            this.No6.Text = "6";
            this.No6.UseVisualStyleBackColor = true;
            this.No6.Click += new System.EventHandler(this.button_clicked);
            // 
            // No5
            // 
            this.No5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No5.Location = new System.Drawing.Point(56, 104);
            this.No5.Name = "No5";
            this.No5.Padding = new System.Windows.Forms.Padding(3);
            this.No5.Size = new System.Drawing.Size(45, 40);
            this.No5.TabIndex = 13;
            this.No5.Text = "5";
            this.No5.UseVisualStyleBackColor = true;
            this.No5.Click += new System.EventHandler(this.button_clicked);
            // 
            // No4
            // 
            this.No4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No4.Location = new System.Drawing.Point(5, 104);
            this.No4.Name = "No4";
            this.No4.Padding = new System.Windows.Forms.Padding(3);
            this.No4.Size = new System.Drawing.Size(45, 40);
            this.No4.TabIndex = 12;
            this.No4.Text = "4";
            this.No4.UseVisualStyleBackColor = true;
            this.No4.Click += new System.EventHandler(this.button_clicked);
            // 
            // moduleButton
            // 
            this.moduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moduleButton.Location = new System.Drawing.Point(209, 58);
            this.moduleButton.Name = "moduleButton";
            this.moduleButton.Padding = new System.Windows.Forms.Padding(3);
            this.moduleButton.Size = new System.Drawing.Size(45, 40);
            this.moduleButton.TabIndex = 11;
            this.moduleButton.Text = "%";
            this.moduleButton.UseVisualStyleBackColor = true;
            this.moduleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_clicked);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divisionButton.Location = new System.Drawing.Point(158, 58);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Padding = new System.Windows.Forms.Padding(3);
            this.divisionButton.Size = new System.Drawing.Size(45, 40);
            this.divisionButton.TabIndex = 10;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_clicked);
            // 
            // No9
            // 
            this.No9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No9.Location = new System.Drawing.Point(107, 58);
            this.No9.Name = "No9";
            this.No9.Padding = new System.Windows.Forms.Padding(3);
            this.No9.Size = new System.Drawing.Size(45, 40);
            this.No9.TabIndex = 9;
            this.No9.Text = "9";
            this.No9.UseVisualStyleBackColor = true;
            this.No9.Click += new System.EventHandler(this.button_clicked);
            // 
            // No8
            // 
            this.No8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No8.Location = new System.Drawing.Point(56, 58);
            this.No8.Name = "No8";
            this.No8.Padding = new System.Windows.Forms.Padding(3);
            this.No8.Size = new System.Drawing.Size(45, 40);
            this.No8.TabIndex = 8;
            this.No8.Text = "8";
            this.No8.UseVisualStyleBackColor = true;
            this.No8.Click += new System.EventHandler(this.button_clicked);
            // 
            // No7
            // 
            this.No7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No7.Location = new System.Drawing.Point(5, 58);
            this.No7.Name = "No7";
            this.No7.Padding = new System.Windows.Forms.Padding(3);
            this.No7.Size = new System.Drawing.Size(45, 40);
            this.No7.TabIndex = 7;
            this.No7.Text = "7";
            this.No7.UseVisualStyleBackColor = true;
            this.No7.Click += new System.EventHandler(this.button_clicked);
            // 
            // squareButton
            // 
            this.squareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.squareButton.Location = new System.Drawing.Point(209, 12);
            this.squareButton.Name = "squareButton";
            this.squareButton.Padding = new System.Windows.Forms.Padding(3);
            this.squareButton.Size = new System.Drawing.Size(45, 40);
            this.squareButton.TabIndex = 6;
            this.squareButton.Text = "√";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_clicked);
            // 
            // changeSignButton
            // 
            this.changeSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSignButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeSignButton.Location = new System.Drawing.Point(158, 12);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Padding = new System.Windows.Forms.Padding(3);
            this.changeSignButton.Size = new System.Drawing.Size(45, 40);
            this.changeSignButton.TabIndex = 5;
            this.changeSignButton.Text = "+-";
            this.changeSignButton.UseVisualStyleBackColor = true;
            this.changeSignButton.Click += new System.EventHandler(this.changeSignButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearAllButton.Location = new System.Drawing.Point(107, 12);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Padding = new System.Windows.Forms.Padding(3);
            this.clearAllButton.Size = new System.Drawing.Size(45, 40);
            this.clearAllButton.TabIndex = 4;
            this.clearAllButton.Text = "C";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearButton.Location = new System.Drawing.Point(56, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Padding = new System.Windows.Forms.Padding(3);
            this.clearButton.Size = new System.Drawing.Size(45, 40);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "CE";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eraseButton.Image = global::Calculadora.Properties.Resources.Erase;
            this.eraseButton.Location = new System.Drawing.Point(5, 12);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Padding = new System.Windows.Forms.Padding(3);
            this.eraseButton.Size = new System.Drawing.Size(45, 40);
            this.eraseButton.TabIndex = 2;
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // calcTextBox
            // 
            this.calcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.calcTextBox.Location = new System.Drawing.Point(12, 34);
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.Size = new System.Drawing.Size(260, 32);
            this.calcTextBox.TabIndex = 1;
            this.calcTextBox.Text = "0";
            this.calcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.SystemColors.MenuText;
            this.author.Location = new System.Drawing.Point(25, 330);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(232, 16);
            this.author.TabIndex = 2;
            this.author.Text = "Created by \"Diego Ivan Perez Michel\"";
            // 
            // operationInProgress
            // 
            this.operationInProgress.AutoSize = true;
            this.operationInProgress.BackColor = System.Drawing.SystemColors.Window;
            this.operationInProgress.Location = new System.Drawing.Point(12, 9);
            this.operationInProgress.Name = "operationInProgress";
            this.operationInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.operationInProgress.Size = new System.Drawing.Size(6, 19);
            this.operationInProgress.TabIndex = 3;
            this.operationInProgress.Visible = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 358);
            this.Controls.Add(this.operationInProgress);
            this.Controls.Add(this.author);
            this.Controls.Add(this.calcTextBox);
            this.Controls.Add(this.ControlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire Calc";
            this.ControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.MaskedTextBox calcTextBox;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button No3;
        private System.Windows.Forms.Button No2;
        private System.Windows.Forms.Button No1;
        private System.Windows.Forms.Button reciprocalButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button No6;
        private System.Windows.Forms.Button No5;
        private System.Windows.Forms.Button No4;
        private System.Windows.Forms.Button moduleButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button No9;
        private System.Windows.Forms.Button No8;
        private System.Windows.Forms.Button No7;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button No0;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label operationInProgress;
    }
}

