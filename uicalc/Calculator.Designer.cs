namespace uicalc
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
            outputBox = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            percentButton = new Button();
            clearEntryButton = new Button();
            clearButton = new Button();
            eraseButton = new Button();
            reciprocalButton = new Button();
            squareButton = new Button();
            sqrtButton = new Button();
            divideButton = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            multiplyButton = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            subtractButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            addButton = new Button();
            negateButton = new Button();
            button0 = new Button();
            decimalButton = new Button();
            evaluateButton = new Button();
            topOutput = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // outputBox
            // 
            outputBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputBox.BackColor = SystemColors.ControlLight;
            outputBox.BorderStyle = BorderStyle.Fixed3D;
            outputBox.Cursor = Cursors.IBeam;
            outputBox.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputBox.Location = new Point(12, 36);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(320, 72);
            outputBox.TabIndex = 0;
            outputBox.Text = "0";
            outputBox.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(percentButton);
            flowLayoutPanel1.Controls.Add(clearEntryButton);
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.Controls.Add(eraseButton);
            flowLayoutPanel1.Controls.Add(reciprocalButton);
            flowLayoutPanel1.Controls.Add(squareButton);
            flowLayoutPanel1.Controls.Add(sqrtButton);
            flowLayoutPanel1.Controls.Add(divideButton);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(multiplyButton);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(subtractButton);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(addButton);
            flowLayoutPanel1.Controls.Add(negateButton);
            flowLayoutPanel1.Controls.Add(button0);
            flowLayoutPanel1.Controls.Add(decimalButton);
            flowLayoutPanel1.Controls.Add(evaluateButton);
            flowLayoutPanel1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(4, 128);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(336, 364);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // percentButton
            // 
            percentButton.Anchor = AnchorStyles.None;
            percentButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            percentButton.Location = new Point(0, 0);
            percentButton.Margin = new Padding(0);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(84, 60);
            percentButton.TabIndex = 0;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = true;
            // 
            // clearEntryButton
            // 
            clearEntryButton.Anchor = AnchorStyles.None;
            clearEntryButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            clearEntryButton.Location = new Point(84, 0);
            clearEntryButton.Margin = new Padding(0);
            clearEntryButton.Name = "clearEntryButton";
            clearEntryButton.Size = new Size(84, 60);
            clearEntryButton.TabIndex = 1;
            clearEntryButton.Text = "CE";
            clearEntryButton.UseVisualStyleBackColor = true;
            clearEntryButton.Click += clearEntry;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.None;
            clearButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            clearButton.Location = new Point(168, 0);
            clearButton.Margin = new Padding(0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(84, 60);
            clearButton.TabIndex = 2;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearOutput;
            // 
            // eraseButton
            // 
            eraseButton.Anchor = AnchorStyles.None;
            eraseButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            eraseButton.Location = new Point(252, 0);
            eraseButton.Margin = new Padding(0);
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new Size(84, 60);
            eraseButton.TabIndex = 3;
            eraseButton.Text = "E";
            eraseButton.UseVisualStyleBackColor = true;
            eraseButton.Click += eraseOutput;
            // 
            // reciprocalButton
            // 
            reciprocalButton.Anchor = AnchorStyles.None;
            reciprocalButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            reciprocalButton.Location = new Point(0, 60);
            reciprocalButton.Margin = new Padding(0);
            reciprocalButton.Name = "reciprocalButton";
            reciprocalButton.Size = new Size(84, 60);
            reciprocalButton.TabIndex = 4;
            reciprocalButton.Text = "1/x";
            reciprocalButton.UseVisualStyleBackColor = true;
            reciprocalButton.Click += useSpecialOperator;
            // 
            // squareButton
            // 
            squareButton.Anchor = AnchorStyles.None;
            squareButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            squareButton.Location = new Point(84, 60);
            squareButton.Margin = new Padding(0);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(84, 60);
            squareButton.TabIndex = 5;
            squareButton.Text = "x^2";
            squareButton.UseVisualStyleBackColor = true;
            squareButton.Click += useSpecialOperator;
            // 
            // sqrtButton
            // 
            sqrtButton.Anchor = AnchorStyles.None;
            sqrtButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            sqrtButton.Location = new Point(168, 60);
            sqrtButton.Margin = new Padding(0);
            sqrtButton.Name = "sqrtButton";
            sqrtButton.Size = new Size(84, 60);
            sqrtButton.TabIndex = 6;
            sqrtButton.Text = "sqrt";
            sqrtButton.UseVisualStyleBackColor = true;
            sqrtButton.Click += useSpecialOperator;
            // 
            // divideButton
            // 
            divideButton.Anchor = AnchorStyles.None;
            divideButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            divideButton.Location = new Point(252, 60);
            divideButton.Margin = new Padding(0);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(84, 60);
            divideButton.TabIndex = 7;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += useOperator;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button7.Location = new Point(0, 120);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(84, 60);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += insertNumber;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button8.Location = new Point(84, 120);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(84, 60);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += insertNumber;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button9.Location = new Point(168, 120);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(84, 60);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += insertNumber;
            // 
            // multiplyButton
            // 
            multiplyButton.Anchor = AnchorStyles.None;
            multiplyButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            multiplyButton.Location = new Point(252, 120);
            multiplyButton.Margin = new Padding(0);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(84, 60);
            multiplyButton.TabIndex = 11;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += useOperator;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button4.Location = new Point(0, 180);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(84, 60);
            button4.TabIndex = 12;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += insertNumber;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button5.Location = new Point(84, 180);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(84, 60);
            button5.TabIndex = 13;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += insertNumber;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button6.Location = new Point(168, 180);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(84, 60);
            button6.TabIndex = 14;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += insertNumber;
            // 
            // subtractButton
            // 
            subtractButton.Anchor = AnchorStyles.None;
            subtractButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            subtractButton.Location = new Point(252, 180);
            subtractButton.Margin = new Padding(0);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(84, 60);
            subtractButton.TabIndex = 15;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += useOperator;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button1.Location = new Point(0, 240);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(84, 60);
            button1.TabIndex = 16;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += insertNumber;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button2.Location = new Point(84, 240);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(84, 60);
            button2.TabIndex = 17;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += insertNumber;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button3.Location = new Point(168, 240);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(84, 60);
            button3.TabIndex = 18;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += insertNumber;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            addButton.Location = new Point(252, 240);
            addButton.Margin = new Padding(0);
            addButton.Name = "addButton";
            addButton.Size = new Size(84, 60);
            addButton.TabIndex = 19;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += useOperator;
            // 
            // negateButton
            // 
            negateButton.Anchor = AnchorStyles.None;
            negateButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            negateButton.Location = new Point(0, 300);
            negateButton.Margin = new Padding(0);
            negateButton.Name = "negateButton";
            negateButton.Size = new Size(84, 60);
            negateButton.TabIndex = 20;
            negateButton.Text = "+/-";
            negateButton.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.None;
            button0.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button0.Location = new Point(84, 300);
            button0.Margin = new Padding(0);
            button0.Name = "button0";
            button0.Size = new Size(84, 60);
            button0.TabIndex = 21;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += insertNumber;
            // 
            // decimalButton
            // 
            decimalButton.Anchor = AnchorStyles.None;
            decimalButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            decimalButton.Location = new Point(168, 300);
            decimalButton.Margin = new Padding(0);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(84, 60);
            decimalButton.TabIndex = 22;
            decimalButton.Text = ".";
            decimalButton.UseVisualStyleBackColor = true;
            decimalButton.Click += insertNumber;
            // 
            // evaluateButton
            // 
            evaluateButton.Anchor = AnchorStyles.None;
            evaluateButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            evaluateButton.Location = new Point(252, 300);
            evaluateButton.Margin = new Padding(0);
            evaluateButton.Name = "evaluateButton";
            evaluateButton.Size = new Size(84, 60);
            evaluateButton.TabIndex = 23;
            evaluateButton.Text = "=";
            evaluateButton.UseVisualStyleBackColor = true;
            evaluateButton.Click += evaluateAnswer;
            // 
            // topOutput
            // 
            topOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            topOutput.BackColor = Color.Transparent;
            topOutput.BorderStyle = BorderStyle.Fixed3D;
            topOutput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topOutput.Location = new Point(256, 36);
            topOutput.Name = "topOutput";
            topOutput.Size = new Size(76, 23);
            topOutput.TabIndex = 2;
            topOutput.TextAlign = ContentAlignment.TopRight;
            topOutput.Visible = false;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 501);
            Controls.Add(topOutput);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(outputBox);
            MinimumSize = new Size(340, 500);
            Name = "Calculator";
            Text = "Calculator";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label outputBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button percentButton;
        private Button clearEntryButton;
        private Button clearButton;
        private Button eraseButton;
        private Button reciprocalButton;
        private Button squareButton;
        private Button sqrtButton;
        private Button divideButton;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button multiplyButton;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button subtractButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button addButton;
        private Button negateButton;
        private Button button0;
        private Button decimalButton;
        private Button evaluateButton;
        private Label topOutput;
    }
}
