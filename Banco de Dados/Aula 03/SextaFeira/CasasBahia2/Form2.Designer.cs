namespace CasasBahia2
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            tabPage3 = new TabPage();
            button3 = new Button();
            textBox8 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 453);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.AliceBlue;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.ForeColor = SystemColors.MenuText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar Item";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(330, 247);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 6;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(361, 142);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 5;
            label3.Text = "Valor(R$)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 142);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 69);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 3;
            label1.Text = "Descrição";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar Item";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 23);
            textBox4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 169);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 1;
            label4.Text = "Código";
            // 
            // button2
            // 
            button2.BackColor = Color.GhostWhite;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(481, 164);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 0;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.OldLace;
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(795, 425);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Editar Item";
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.Location = new Point(569, 67);
            button3.Name = "button3";
            button3.Size = new Size(106, 30);
            button3.TabIndex = 14;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(228, 72);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(241, 23);
            textBox8.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(110, 70);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 12;
            label8.Text = "Código";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 267);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 11;
            label5.Text = "Valor(R$)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(110, 207);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 10;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(110, 138);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 9;
            label7.Text = "Descrição";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(225, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(198, 23);
            textBox5.TabIndex = 8;
            textBox5.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(225, 209);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 7;
            textBox6.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(225, 136);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(344, 23);
            textBox7.TabIndex = 6;
            textBox7.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Button button3;
    }
}