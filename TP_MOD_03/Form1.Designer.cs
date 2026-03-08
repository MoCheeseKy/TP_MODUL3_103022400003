namespace TP_MOD_03
{
    partial class Form1
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
            label = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button0 = new System.Windows.Forms.Button();
            buttonPlus = new System.Windows.Forms.Button();
            buttonResult = new System.Windows.Forms.Button();
            SuspendLayout();

            label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label.Location = new System.Drawing.Point(12, 12);
            label.Name = "label";
            label.Size = new System.Drawing.Size(186, 40);
            label.TabIndex = 0;
            label.Text = "Label Output";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            button1.Location = new System.Drawing.Point(12, 65);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(55, 55);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_onClick);

            button2.Location = new System.Drawing.Point(78, 65);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(55, 55);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_onClick);

            button3.Location = new System.Drawing.Point(144, 65);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(55, 55);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_onClick);

            button4.Location = new System.Drawing.Point(12, 131);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(55, 55);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_onClick);

            button5.Location = new System.Drawing.Point(78, 131);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(55, 55);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(button5_onClick);
            
            button6.Location = new System.Drawing.Point(144, 131);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(55, 55);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(button6_onClick);
            
            button7.Location = new System.Drawing.Point(12, 197);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(55, 55);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(button7_onClick);

            button8.Location = new System.Drawing.Point(78, 197);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(55, 55);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += new System.EventHandler(button8_onClick);

            button9.Location = new System.Drawing.Point(144, 197);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(55, 55);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += new System.EventHandler(button9_onClick);

            button0.Location = new System.Drawing.Point(78, 263);
            button0.Name = "button0";
            button0.Size = new System.Drawing.Size(55, 55);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += new System.EventHandler(button0_onClick);

            buttonPlus.Location = new System.Drawing.Point(12, 263);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new System.Drawing.Size(55, 55);
            buttonPlus.TabIndex = 10;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += new System.EventHandler(buttonPlus_onClick);

            

            buttonResult.Location = new System.Drawing.Point(144, 263);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new System.Drawing.Size(55, 55);
            buttonResult.TabIndex = 12;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += new System.EventHandler(buttonResult_onClick);

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(210, 332);
            Controls.Add(label);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(buttonPlus);
            Controls.Add(button0);
            Controls.Add(buttonResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonResult;
    }
}