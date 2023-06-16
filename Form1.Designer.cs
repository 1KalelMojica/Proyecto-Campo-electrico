namespace Campo_electrico_programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox_q1_1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_q1_2 = new TextBox();
            textBox_q1_potencia = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label6 = new Label();
            label_resultado = new Label();
            textBox_q2_1 = new TextBox();
            textBox_q2_2 = new TextBox();
            textBox_q2_potencia = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label7 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox_q1_1
            // 
            textBox_q1_1.Location = new Point(206, 66);
            textBox_q1_1.Name = "textBox_q1_1";
            textBox_q1_1.Size = new Size(32, 23);
            textBox_q1_1.TabIndex = 0;
            textBox_q1_1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 1;
            label1.Text = "Campo Electrico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(188, 21);
            label2.TabIndex = 2;
            label2.Text = "Una carga de prueba de ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 70);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 3;
            label3.Text = "X";
            // 
            // textBox_q1_2
            // 
            textBox_q1_2.Location = new Point(264, 67);
            textBox_q1_2.Name = "textBox_q1_2";
            textBox_q1_2.Size = new Size(35, 23);
            textBox_q1_2.TabIndex = 4;
            // 
            // textBox_q1_potencia
            // 
            textBox_q1_potencia.Location = new Point(323, 66);
            textBox_q1_potencia.Name = "textBox_q1_potencia";
            textBox_q1_potencia.Size = new Size(35, 23);
            textBox_q1_potencia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(364, 68);
            label4.Name = "label4";
            label4.Size = new Size(216, 21);
            label4.TabIndex = 6;
            label4.Text = "recibe una fuerza horizontal ";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(472, 234);
            button1.Name = "button1";
            button1.Size = new Size(108, 59);
            button1.TabIndex = 11;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(323, 122);
            label6.Name = "label6";
            label6.Size = new Size(267, 21);
            label6.TabIndex = 12;
            label6.Text = "la magnitud del campo electrico en";
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_resultado.Location = new Point(408, 174);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(58, 17);
            label_resultado.TabIndex = 14;
            label_resultado.Text = "----------";
            // 
            // textBox_q2_1
            // 
            textBox_q2_1.Location = new Point(165, 119);
            textBox_q2_1.Name = "textBox_q2_1";
            textBox_q2_1.Size = new Size(35, 23);
            textBox_q2_1.TabIndex = 15;
            // 
            // textBox_q2_2
            // 
            textBox_q2_2.Location = new Point(226, 119);
            textBox_q2_2.Name = "textBox_q2_2";
            textBox_q2_2.Size = new Size(35, 23);
            textBox_q2_2.TabIndex = 16;
            // 
            // textBox_q2_potencia
            // 
            textBox_q2_potencia.Location = new Point(282, 118);
            textBox_q2_potencia.Name = "textBox_q2_potencia";
            textBox_q2_potencia.Size = new Size(35, 23);
            textBox_q2_potencia.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 69);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 18;
            label5.Text = "^";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(264, 122);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 19;
            label8.Text = "^";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 126);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 20;
            label9.Text = "X";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 121);
            label10.Name = "label10";
            label10.Size = new Size(153, 21);
            label10.TabIndex = 21;
            label10.Text = "hacia la derecha de ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(12, 170);
            label11.Name = "label11";
            label11.Size = new Size(390, 21);
            label11.TabIndex = 22;
            label11.Text = "el punto donde esta colodaca la carga de prueba es:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 214);
            label7.Name = "label7";
            label7.Size = new Size(201, 21);
            label7.TabIndex = 23;
            label7.Text = "Newtons sobre coulombs.";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 105);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(588, 9);
            button2.Name = "button2";
            button2.Size = new Size(50, 43);
            button2.TabIndex = 25;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(653, 380);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox_q2_potencia);
            Controls.Add(textBox_q2_2);
            Controls.Add(textBox_q2_1);
            Controls.Add(label_resultado);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox_q1_potencia);
            Controls.Add(textBox_q1_2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_q1_1);
            ForeColor = Color.IndianRed;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Electricidad y magnetismo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_q1_1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_q1_2;
        private TextBox textBox_q1_potencia;
        private Label label4;
        private Button button1;
        private Label label6;
        private Label label_resultado;
        private TextBox textBox_q2_1;
        private TextBox textBox_q2_2;
        private TextBox textBox_q2_potencia;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label7;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
    }
}