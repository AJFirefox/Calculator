namespace Calculator
{
    partial class Calculator
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
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Zero = new Button();
            Decimal = new Button();
            Exponent = new Button();
            Divide = new Button();
            Multiply = new Button();
            Subtract = new Button();
            Add = new Button();
            Equal = new Button();
            Clear = new Button();
            Round = new Button();
            Negation = new Button();
            MemoryRecall = new Button();
            MemoryRemove = new Button();
            MemoryAdd = new Button();
            Answer = new Button();
            Back = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // Seven
            // 
            Seven.Location = new Point(296, 90);
            Seven.Name = "Seven";
            Seven.Size = new Size(50, 30);
            Seven.TabIndex = 0;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Eight
            // 
            Eight.Location = new Point(352, 90);
            Eight.Name = "Eight";
            Eight.Size = new Size(50, 30);
            Eight.TabIndex = 1;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.Location = new Point(408, 90);
            Nine.Name = "Nine";
            Nine.Size = new Size(50, 30);
            Nine.TabIndex = 2;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Four
            // 
            Four.Location = new Point(296, 126);
            Four.Name = "Four";
            Four.Size = new Size(50, 30);
            Four.TabIndex = 3;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.Location = new Point(352, 126);
            Five.Name = "Five";
            Five.Size = new Size(50, 30);
            Five.TabIndex = 4;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.Location = new Point(408, 126);
            Six.Name = "Six";
            Six.Size = new Size(50, 30);
            Six.TabIndex = 5;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // One
            // 
            One.Location = new Point(296, 162);
            One.Name = "One";
            One.Size = new Size(50, 30);
            One.TabIndex = 8;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Two
            // 
            Two.Location = new Point(352, 162);
            Two.Name = "Two";
            Two.Size = new Size(50, 30);
            Two.TabIndex = 9;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.Location = new Point(408, 162);
            Three.Name = "Three";
            Three.Size = new Size(50, 30);
            Three.TabIndex = 10;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Zero
            // 
            Zero.Location = new Point(296, 198);
            Zero.Name = "Zero";
            Zero.Size = new Size(50, 30);
            Zero.TabIndex = 11;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Decimal
            // 
            Decimal.Location = new Point(352, 198);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(50, 30);
            Decimal.TabIndex = 12;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = true;
            // 
            // Exponent
            // 
            Exponent.Location = new Point(408, 198);
            Exponent.Name = "Exponent";
            Exponent.Size = new Size(50, 30);
            Exponent.TabIndex = 13;
            Exponent.Text = "EXP";
            Exponent.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            Divide.Location = new Point(464, 198);
            Divide.Name = "Divide";
            Divide.Size = new Size(50, 30);
            Divide.TabIndex = 17;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(464, 162);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(50, 30);
            Multiply.TabIndex = 16;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Subtract
            // 
            Subtract.Location = new Point(464, 126);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(50, 30);
            Subtract.TabIndex = 15;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += Subtract_Click;
            // 
            // Add
            // 
            Add.Location = new Point(464, 90);
            Add.Name = "Add";
            Add.Size = new Size(50, 30);
            Add.TabIndex = 14;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Equal
            // 
            Equal.Location = new Point(464, 234);
            Equal.Name = "Equal";
            Equal.Size = new Size(50, 30);
            Equal.TabIndex = 21;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            Clear.Location = new Point(408, 234);
            Clear.Name = "Clear";
            Clear.Size = new Size(50, 30);
            Clear.TabIndex = 20;
            Clear.Text = "AC";
            Clear.UseVisualStyleBackColor = true;
            // 
            // Round
            // 
            Round.Location = new Point(352, 234);
            Round.Name = "Round";
            Round.Size = new Size(50, 30);
            Round.TabIndex = 19;
            Round.Text = "RND";
            Round.UseVisualStyleBackColor = true;
            // 
            // Negation
            // 
            Negation.Location = new Point(296, 234);
            Negation.Name = "Negation";
            Negation.Size = new Size(50, 30);
            Negation.TabIndex = 18;
            Negation.Text = "+/-";
            Negation.UseVisualStyleBackColor = true;
            // 
            // MemoryRecall
            // 
            MemoryRecall.Location = new Point(520, 234);
            MemoryRecall.Name = "MemoryRecall";
            MemoryRecall.Size = new Size(50, 30);
            MemoryRecall.TabIndex = 26;
            MemoryRecall.Text = "MR";
            MemoryRecall.UseVisualStyleBackColor = true;
            // 
            // MemoryRemove
            // 
            MemoryRemove.Location = new Point(520, 198);
            MemoryRemove.Name = "MemoryRemove";
            MemoryRemove.Size = new Size(50, 30);
            MemoryRemove.TabIndex = 25;
            MemoryRemove.Text = "M-";
            MemoryRemove.UseVisualStyleBackColor = true;
            // 
            // MemoryAdd
            // 
            MemoryAdd.Location = new Point(520, 162);
            MemoryAdd.Name = "MemoryAdd";
            MemoryAdd.Size = new Size(50, 30);
            MemoryAdd.TabIndex = 24;
            MemoryAdd.Text = "M+";
            MemoryAdd.UseVisualStyleBackColor = true;
            // 
            // Answer
            // 
            Answer.Location = new Point(520, 126);
            Answer.Name = "Answer";
            Answer.Size = new Size(50, 30);
            Answer.TabIndex = 23;
            Answer.Text = "Ans";
            Answer.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            Back.Location = new Point(520, 90);
            Back.Name = "Back";
            Back.Size = new Size(50, 30);
            Back.TabIndex = 22;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(296, 56);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 27;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 477);
            Controls.Add(result);
            Controls.Add(MemoryRecall);
            Controls.Add(MemoryRemove);
            Controls.Add(MemoryAdd);
            Controls.Add(Answer);
            Controls.Add(Back);
            Controls.Add(Equal);
            Controls.Add(Clear);
            Controls.Add(Round);
            Controls.Add(Negation);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Subtract);
            Controls.Add(Add);
            Controls.Add(Exponent);
            Controls.Add(Decimal);
            Controls.Add(Zero);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Name = "Calculator";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Zero;
        private Button Decimal;
        private Button Exponent;
        private Button Divide;
        private Button Multiply;
        private Button Subtract;
        private Button Add;
        private Button Equal;
        private Button Clear;
        private Button Round;
        private Button Negation;
        private Button MemoryRecall;
        private Button MemoryRemove;
        private Button MemoryAdd;
        private Button Answer;
        private Button Back;
        private Label result;
    }
}
