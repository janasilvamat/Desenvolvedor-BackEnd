namespace Master
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(196, 52);
            label1.Name = "label1";
            label1.Size = new Size(376, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de conta bancária";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(103, 157);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 1;
            label2.Text = "Titular da conta";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(103, 204);
            label3.Name = "label3";
            label3.Size = new Size(182, 30);
            label3.TabIndex = 2;
            label3.Text = "Número da conta";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(103, 247);
            label4.Name = "label4";
            label4.Size = new Size(156, 30);
            label4.TabIndex = 3;
            label4.Text = "Saldo da conta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(318, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(381, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(306, 366);
            button1.Name = "button1";
            button1.Size = new Size(202, 45);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(713, 263);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Saldo inicial?";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipTitle = "Saldo inicial?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(734, 263);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 9;
            label5.Text = "Saldo inicial?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(850, 450);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private CheckBox checkBox1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label label5;
    }
}
