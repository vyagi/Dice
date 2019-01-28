namespace Dice.WinForm
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
            this.rollButton = new System.Windows.Forms.Button();
            this.rolledDiceTextBox = new System.Windows.Forms.TextBox();
            this.rolledLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(131, 281);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(139, 33);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "ROLL THE DICE";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // rolledDiceTextBox
            // 
            this.rolledDiceTextBox.Location = new System.Drawing.Point(83, 177);
            this.rolledDiceTextBox.Name = "rolledDiceTextBox";
            this.rolledDiceTextBox.Size = new System.Drawing.Size(187, 20);
            this.rolledDiceTextBox.TabIndex = 1;
            // 
            // rolledLabel
            // 
            this.rolledLabel.AutoSize = true;
            this.rolledLabel.Location = new System.Drawing.Point(12, 184);
            this.rolledLabel.Name = "rolledLabel";
            this.rolledLabel.Size = new System.Drawing.Size(65, 13);
            this.rolledLabel.TabIndex = 2;
            this.rolledLabel.Text = "Rolled Dice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "It\'s time to roll some dice!";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(12, 116);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(186, 13);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "How many dice do you wish to throw?";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rolledLabel);
            this.Controls.Add(this.rolledDiceTextBox);
            this.Controls.Add(this.rollButton);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "DICE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox rolledDiceTextBox;
        private System.Windows.Forms.Label rolledLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

