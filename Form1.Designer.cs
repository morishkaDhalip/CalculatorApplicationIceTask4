namespace CalculatorApplication
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
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(61, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(226, 195);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(94, 29);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "SUBTRACT";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(409, 195);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(94, 29);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "MULTIPLY";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(600, 195);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(94, 29);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(161, 109);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(125, 27);
            txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(460, 106);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(125, 27);
            txtNumber2.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(323, 325);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 21);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 7;
            label1.Text = "CALCULATOR APPLICATION ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 109);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter number1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 109);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 9;
            label3.Text = "Enter number 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
