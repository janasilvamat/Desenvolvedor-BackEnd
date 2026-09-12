namespace Vendas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 449);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(radioButton4);
            tabPage1.Controls.Add(radioButton3);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(797, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(429, 115);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(58, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Marca";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(340, 115);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tipo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(192, 115);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(111, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Data de Compra";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(130, 115);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(35, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Id";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(791, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Location = new Point(364, 150);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 3;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 115);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "Filtros de Pesquisa";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalhes";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 56);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(241, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(240, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(192, 198);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(240, 23);
            textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(190, 249);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(241, 23);
            textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(190, 309);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(241, 23);
            textBox7.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 56);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 6;
            label3.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 105);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 7;
            label4.Text = "Data de Compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 155);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 206);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 9;
            label6.Text = "Marca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 257);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 10;
            label7.Text = "Faturamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 312);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 11;
            label8.Text = "Lucro";
            // 
            // button2
            // 
            button2.Location = new Point(557, 62);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Editar ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 451);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos de Vendas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
    }
}
