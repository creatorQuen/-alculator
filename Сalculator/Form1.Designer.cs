
namespace Сalculator
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
            this.Result_Box = new System.Windows.Forms.TextBox();
            this.Backspace_Button = new System.Windows.Forms.Button();
            this.CE_Button = new System.Windows.Forms.Button();
            this.C_Button = new System.Windows.Forms.Button();
            this.One_Button = new System.Windows.Forms.Button();
            this.Two_Button = new System.Windows.Forms.Button();
            this.Three_Button = new System.Windows.Forms.Button();
            this.Four_Button = new System.Windows.Forms.Button();
            this.Five_Button = new System.Windows.Forms.Button();
            this.Six_Button = new System.Windows.Forms.Button();
            this.Seven_Button = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Negative_Button = new System.Windows.Forms.Button();
            this.Point_Button = new System.Windows.Forms.Button();
            this.Divide_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.Sqrt_Button = new System.Windows.Forms.Button();
            this.Percent_Button = new System.Windows.Forms.Button();
            this.RowMinusOne_Button = new System.Windows.Forms.Button();
            this.Solve_Button = new System.Windows.Forms.Button();
            this.Operaion_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result_Box
            // 
            this.Result_Box.Enabled = false;
            this.Result_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_Box.Location = new System.Drawing.Point(10, 10);
            this.Result_Box.Margin = new System.Windows.Forms.Padding(1);
            this.Result_Box.Name = "Result_Box";
            this.Result_Box.Size = new System.Drawing.Size(234, 34);
            this.Result_Box.TabIndex = 0;
            this.Result_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Backspace_Button
            // 
            this.Backspace_Button.Location = new System.Drawing.Point(10, 83);
            this.Backspace_Button.Name = "Backspace_Button";
            this.Backspace_Button.Size = new System.Drawing.Size(74, 32);
            this.Backspace_Button.TabIndex = 1;
            this.Backspace_Button.Text = "<=";
            this.Backspace_Button.UseVisualStyleBackColor = true;
            this.Backspace_Button.Click += new System.EventHandler(this.Backspace_Button_Click);
            // 
            // CE_Button
            // 
            this.CE_Button.Location = new System.Drawing.Point(90, 83);
            this.CE_Button.Name = "CE_Button";
            this.CE_Button.Size = new System.Drawing.Size(74, 32);
            this.CE_Button.TabIndex = 2;
            this.CE_Button.Text = "CE";
            this.CE_Button.UseVisualStyleBackColor = true;
            // 
            // C_Button
            // 
            this.C_Button.Location = new System.Drawing.Point(170, 83);
            this.C_Button.Name = "C_Button";
            this.C_Button.Size = new System.Drawing.Size(74, 32);
            this.C_Button.TabIndex = 3;
            this.C_Button.Text = "C";
            this.C_Button.UseVisualStyleBackColor = true;
            this.C_Button.Click += new System.EventHandler(this.C_Button_Click);
            // 
            // One_Button
            // 
            this.One_Button.Location = new System.Drawing.Point(10, 201);
            this.One_Button.Name = "One_Button";
            this.One_Button.Size = new System.Drawing.Size(42, 32);
            this.One_Button.TabIndex = 4;
            this.One_Button.Text = "1";
            this.One_Button.UseVisualStyleBackColor = true;
            this.One_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Two_Button
            // 
            this.Two_Button.Location = new System.Drawing.Point(58, 201);
            this.Two_Button.Name = "Two_Button";
            this.Two_Button.Size = new System.Drawing.Size(42, 32);
            this.Two_Button.TabIndex = 5;
            this.Two_Button.Text = "2";
            this.Two_Button.UseVisualStyleBackColor = true;
            this.Two_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Three_Button
            // 
            this.Three_Button.Location = new System.Drawing.Point(106, 201);
            this.Three_Button.Name = "Three_Button";
            this.Three_Button.Size = new System.Drawing.Size(42, 32);
            this.Three_Button.TabIndex = 6;
            this.Three_Button.Text = "3";
            this.Three_Button.UseVisualStyleBackColor = true;
            this.Three_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Four_Button
            // 
            this.Four_Button.Location = new System.Drawing.Point(10, 163);
            this.Four_Button.Name = "Four_Button";
            this.Four_Button.Size = new System.Drawing.Size(42, 32);
            this.Four_Button.TabIndex = 7;
            this.Four_Button.Text = "4";
            this.Four_Button.UseVisualStyleBackColor = true;
            this.Four_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Five_Button
            // 
            this.Five_Button.Location = new System.Drawing.Point(58, 163);
            this.Five_Button.Name = "Five_Button";
            this.Five_Button.Size = new System.Drawing.Size(42, 32);
            this.Five_Button.TabIndex = 8;
            this.Five_Button.Text = "5";
            this.Five_Button.UseVisualStyleBackColor = true;
            this.Five_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Six_Button
            // 
            this.Six_Button.Location = new System.Drawing.Point(106, 163);
            this.Six_Button.Name = "Six_Button";
            this.Six_Button.Size = new System.Drawing.Size(42, 32);
            this.Six_Button.TabIndex = 9;
            this.Six_Button.Text = "6";
            this.Six_Button.UseVisualStyleBackColor = true;
            this.Six_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Seven_Button
            // 
            this.Seven_Button.Location = new System.Drawing.Point(10, 125);
            this.Seven_Button.Name = "Seven_Button";
            this.Seven_Button.Size = new System.Drawing.Size(42, 32);
            this.Seven_Button.TabIndex = 10;
            this.Seven_Button.Text = "7";
            this.Seven_Button.UseVisualStyleBackColor = true;
            this.Seven_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Eight_Button
            // 
            this.Eight_Button.Location = new System.Drawing.Point(58, 125);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(42, 32);
            this.Eight_Button.TabIndex = 11;
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = true;
            this.Eight_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Nine_Button
            // 
            this.Nine_Button.Location = new System.Drawing.Point(106, 125);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(42, 32);
            this.Nine_Button.TabIndex = 12;
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = true;
            this.Nine_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Zero_Button
            // 
            this.Zero_Button.Location = new System.Drawing.Point(10, 239);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(42, 32);
            this.Zero_Button.TabIndex = 13;
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = true;
            this.Zero_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Negative_Button
            // 
            this.Negative_Button.Location = new System.Drawing.Point(58, 239);
            this.Negative_Button.Name = "Negative_Button";
            this.Negative_Button.Size = new System.Drawing.Size(42, 32);
            this.Negative_Button.TabIndex = 14;
            this.Negative_Button.Text = "+/-";
            this.Negative_Button.UseVisualStyleBackColor = true;
            // 
            // Point_Button
            // 
            this.Point_Button.Location = new System.Drawing.Point(106, 239);
            this.Point_Button.Name = "Point_Button";
            this.Point_Button.Size = new System.Drawing.Size(42, 32);
            this.Point_Button.TabIndex = 15;
            this.Point_Button.Text = ",";
            this.Point_Button.UseVisualStyleBackColor = true;
            this.Point_Button.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Divide_Button
            // 
            this.Divide_Button.Location = new System.Drawing.Point(154, 125);
            this.Divide_Button.Name = "Divide_Button";
            this.Divide_Button.Size = new System.Drawing.Size(42, 32);
            this.Divide_Button.TabIndex = 16;
            this.Divide_Button.Text = "/";
            this.Divide_Button.UseVisualStyleBackColor = true;
            this.Divide_Button.Click += new System.EventHandler(this.Divide_Button_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.Location = new System.Drawing.Point(154, 163);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(42, 32);
            this.Multiply_Button.TabIndex = 17;
            this.Multiply_Button.Text = "*";
            this.Multiply_Button.UseVisualStyleBackColor = true;
            this.Multiply_Button.Click += new System.EventHandler(this.Multiply_Button_Click);
            // 
            // Minus_Button
            // 
            this.Minus_Button.Location = new System.Drawing.Point(154, 201);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(42, 32);
            this.Minus_Button.TabIndex = 18;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = true;
            this.Minus_Button.Click += new System.EventHandler(this.Minus_Button_Click);
            // 
            // Plus_Button
            // 
            this.Plus_Button.Location = new System.Drawing.Point(154, 239);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(42, 32);
            this.Plus_Button.TabIndex = 19;
            this.Plus_Button.Text = "+";
            this.Plus_Button.UseVisualStyleBackColor = true;
            this.Plus_Button.Click += new System.EventHandler(this.Plus_Button_Click);
            // 
            // Sqrt_Button
            // 
            this.Sqrt_Button.Location = new System.Drawing.Point(202, 125);
            this.Sqrt_Button.Name = "Sqrt_Button";
            this.Sqrt_Button.Size = new System.Drawing.Size(42, 32);
            this.Sqrt_Button.TabIndex = 20;
            this.Sqrt_Button.Text = "sqrt";
            this.Sqrt_Button.UseVisualStyleBackColor = true;
            // 
            // Percent_Button
            // 
            this.Percent_Button.Location = new System.Drawing.Point(202, 163);
            this.Percent_Button.Name = "Percent_Button";
            this.Percent_Button.Size = new System.Drawing.Size(42, 32);
            this.Percent_Button.TabIndex = 21;
            this.Percent_Button.Text = "%";
            this.Percent_Button.UseVisualStyleBackColor = true;
            // 
            // RowMinusOne_Button
            // 
            this.RowMinusOne_Button.Location = new System.Drawing.Point(202, 201);
            this.RowMinusOne_Button.Name = "RowMinusOne_Button";
            this.RowMinusOne_Button.Size = new System.Drawing.Size(42, 32);
            this.RowMinusOne_Button.TabIndex = 22;
            this.RowMinusOne_Button.Text = "1/x";
            this.RowMinusOne_Button.UseVisualStyleBackColor = true;
            // 
            // Solve_Button
            // 
            this.Solve_Button.Location = new System.Drawing.Point(202, 239);
            this.Solve_Button.Name = "Solve_Button";
            this.Solve_Button.Size = new System.Drawing.Size(42, 32);
            this.Solve_Button.TabIndex = 23;
            this.Solve_Button.Text = "=";
            this.Solve_Button.UseVisualStyleBackColor = true;
            this.Solve_Button.Click += new System.EventHandler(this.Solve_Button_Click);
            // 
            // Operaion_Label
            // 
            this.Operaion_Label.AutoSize = true;
            this.Operaion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Operaion_Label.Location = new System.Drawing.Point(218, 55);
            this.Operaion_Label.Name = "Operaion_Label";
            this.Operaion_Label.Size = new System.Drawing.Size(0, 25);
            this.Operaion_Label.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(254, 293);
            this.Controls.Add(this.Operaion_Label);
            this.Controls.Add(this.Solve_Button);
            this.Controls.Add(this.RowMinusOne_Button);
            this.Controls.Add(this.Percent_Button);
            this.Controls.Add(this.Sqrt_Button);
            this.Controls.Add(this.Plus_Button);
            this.Controls.Add(this.Minus_Button);
            this.Controls.Add(this.Multiply_Button);
            this.Controls.Add(this.Divide_Button);
            this.Controls.Add(this.Point_Button);
            this.Controls.Add(this.Negative_Button);
            this.Controls.Add(this.Zero_Button);
            this.Controls.Add(this.Nine_Button);
            this.Controls.Add(this.Eight_Button);
            this.Controls.Add(this.Seven_Button);
            this.Controls.Add(this.Six_Button);
            this.Controls.Add(this.Five_Button);
            this.Controls.Add(this.Four_Button);
            this.Controls.Add(this.Three_Button);
            this.Controls.Add(this.Two_Button);
            this.Controls.Add(this.One_Button);
            this.Controls.Add(this.C_Button);
            this.Controls.Add(this.CE_Button);
            this.Controls.Add(this.Backspace_Button);
            this.Controls.Add(this.Result_Box);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result_Box;
        private System.Windows.Forms.Button Backspace_Button;
        private System.Windows.Forms.Button CE_Button;
        private System.Windows.Forms.Button C_Button;
        private System.Windows.Forms.Button One_Button;
        private System.Windows.Forms.Button Two_Button;
        private System.Windows.Forms.Button Three_Button;
        private System.Windows.Forms.Button Four_Button;
        private System.Windows.Forms.Button Five_Button;
        private System.Windows.Forms.Button Six_Button;
        private System.Windows.Forms.Button Seven_Button;
        private System.Windows.Forms.Button Eight_Button;
        private System.Windows.Forms.Button Nine_Button;
        private System.Windows.Forms.Button Zero_Button;
        private System.Windows.Forms.Button Negative_Button;
        private System.Windows.Forms.Button Point_Button;
        private System.Windows.Forms.Button Divide_Button;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Button Sqrt_Button;
        private System.Windows.Forms.Button Percent_Button;
        private System.Windows.Forms.Button RowMinusOne_Button;
        private System.Windows.Forms.Button Solve_Button;
        private System.Windows.Forms.Label Operaion_Label;
    }
}

