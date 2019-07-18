namespace COMP123_S2019_Lesson10B
{
    partial class MainForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.UnitSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.MetriUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.UnitSelectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 494);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(173, 55);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(599, 494);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(173, 55);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // UnitSelectionGroupBox
            // 
            this.UnitSelectionGroupBox.Controls.Add(this.MetriUnitRadioButton);
            this.UnitSelectionGroupBox.Controls.Add(this.ImperialUnitRadioButton);
            this.UnitSelectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.UnitSelectionGroupBox.Name = "UnitSelectionGroupBox";
            this.UnitSelectionGroupBox.Size = new System.Drawing.Size(760, 163);
            this.UnitSelectionGroupBox.TabIndex = 3;
            this.UnitSelectionGroupBox.TabStop = false;
            this.UnitSelectionGroupBox.Text = "Unit Selection";
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Checked = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(7, 38);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialUnitRadioButton.TabIndex = 0;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetriUnitRadioButton
            // 
            this.MetriUnitRadioButton.AutoSize = true;
            this.MetriUnitRadioButton.Location = new System.Drawing.Point(8, 79);
            this.MetriUnitRadioButton.Name = "MetriUnitRadioButton";
            this.MetriUnitRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetriUnitRadioButton.TabIndex = 0;
            this.MetriUnitRadioButton.Text = "Metric";
            this.MetriUnitRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.UnitSelectionGroupBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.UnitSelectionGroupBox.ResumeLayout(false);
            this.UnitSelectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox UnitSelectionGroupBox;
        private System.Windows.Forms.RadioButton MetriUnitRadioButton;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
    }
}

