namespace simulatorTeloNaOpruzi
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
            timer1 = new System.Windows.Forms.Timer(components);
            masaBox = new NumericUpDown();
            xBox = new NumericUpDown();
            yBox = new NumericUpDown();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            cBox = new NumericUpDown();
            label6 = new Label();
            label8 = new Label();
            duzinaBox = new NumericUpDown();
            kBox = new NumericUpDown();
            groupBox3 = new GroupBox();
            radioCentim = new RadioButton();
            radioMetar = new RadioButton();
            pictureBox1 = new PictureBox();
            pivot = new Button();
            ((System.ComponentModel.ISupportInitialize)masaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duzinaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kBox).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // masaBox
            // 
            masaBox.DecimalPlaces = 3;
            masaBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            masaBox.Location = new Point(6, 17);
            masaBox.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            masaBox.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            masaBox.Name = "masaBox";
            masaBox.Size = new Size(120, 21);
            masaBox.TabIndex = 0;
            masaBox.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // xBox
            // 
            xBox.DecimalPlaces = 3;
            xBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            xBox.Location = new Point(6, 41);
            xBox.Maximum = new decimal(new int[] { 25, 0, 0, 65536 });
            xBox.Minimum = new decimal(new int[] { 25, 0, 0, -2147418112 });
            xBox.Name = "xBox";
            xBox.Size = new Size(120, 21);
            xBox.TabIndex = 1;
            // 
            // yBox
            // 
            yBox.DecimalPlaces = 3;
            yBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            yBox.Location = new Point(6, 64);
            yBox.Maximum = new decimal(new int[] { 25, 0, 0, 65536 });
            yBox.Minimum = new decimal(new int[] { 25, 0, 0, -2147418112 });
            yBox.Name = "yBox";
            yBox.Size = new Size(120, 21);
            yBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(masaBox);
            groupBox1.Controls.Add(yBox);
            groupBox1.Controls.Add(xBox);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 89);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Маса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 65);
            label3.Name = "label3";
            label3.Size = new Size(13, 12);
            label3.TabIndex = 6;
            label3.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 43);
            label2.Name = "label2";
            label2.Size = new Size(13, 12);
            label2.TabIndex = 5;
            label2.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 19);
            label1.Name = "label1";
            label1.Size = new Size(35, 12);
            label1.TabIndex = 4;
            label1.Text = "маса";
            // 
            // button1
            // 
            button1.Location = new Point(12, 381);
            button1.Name = "button1";
            button1.Size = new Size(75, 19);
            button1.TabIndex = 4;
            button1.Text = "Примени";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 405);
            button2.Name = "button2";
            button2.Size = new Size(75, 19);
            button2.TabIndex = 5;
            button2.Text = "Започни";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Dotum", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(200, 9);
            label4.Name = "label4";
            label4.Size = new Size(336, 47);
            label4.TabIndex = 6;
            label4.Text = "Нумеричка симулација тачкасте масе на опрузи";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Dotum", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(202, 54);
            label5.Name = "label5";
            label5.Size = new Size(256, 25);
            label5.TabIndex = 7;
            label5.Text = "Вељко Иђушки 2025.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(duzinaBox);
            groupBox2.Controls.Add(kBox);
            groupBox2.Location = new Point(12, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(185, 83);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Опруга";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 63);
            label7.Name = "label7";
            label7.Size = new Size(39, 12);
            label7.TabIndex = 8;
            label7.Text = "приг.";
            // 
            // cBox
            // 
            cBox.DecimalPlaces = 1;
            cBox.Enabled = false;
            cBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            cBox.Location = new Point(6, 61);
            cBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cBox.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            cBox.Name = "cBox";
            cBox.Size = new Size(120, 21);
            cBox.TabIndex = 7;
            cBox.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 41);
            label6.Name = "label6";
            label6.Size = new Size(11, 12);
            label6.TabIndex = 6;
            label6.Text = "k";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 20);
            label8.Name = "label8";
            label8.Size = new Size(50, 12);
            label8.TabIndex = 4;
            label8.Text = "дужина";
            // 
            // duzinaBox
            // 
            duzinaBox.DecimalPlaces = 3;
            duzinaBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            duzinaBox.Location = new Point(6, 17);
            duzinaBox.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            duzinaBox.Name = "duzinaBox";
            duzinaBox.Size = new Size(120, 21);
            duzinaBox.TabIndex = 0;
            duzinaBox.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // kBox
            // 
            kBox.DecimalPlaces = 1;
            kBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            kBox.Location = new Point(6, 39);
            kBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            kBox.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            kBox.Name = "kBox";
            kBox.Size = new Size(120, 21);
            kBox.TabIndex = 2;
            kBox.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            kBox.ValueChanged += kBox_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioCentim);
            groupBox3.Controls.Add(radioMetar);
            groupBox3.Location = new Point(12, 341);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(185, 35);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Размер";
            // 
            // radioCentim
            // 
            radioCentim.AutoSize = true;
            radioCentim.Checked = true;
            radioCentim.Location = new Point(89, 17);
            radioCentim.Margin = new Padding(3, 2, 3, 2);
            radioCentim.Name = "radioCentim";
            radioCentim.Size = new Size(72, 16);
            radioCentim.TabIndex = 1;
            radioCentim.TabStop = true;
            radioCentim.Text = "1px=5mm";
            radioCentim.UseVisualStyleBackColor = true;
            radioCentim.CheckedChanged += radioCentim_CheckedChanged;
            // 
            // radioMetar
            // 
            radioMetar.AutoSize = true;
            radioMetar.Location = new Point(6, 17);
            radioMetar.Margin = new Padding(3, 2, 3, 2);
            radioMetar.Name = "radioMetar";
            radioMetar.Size = new Size(70, 16);
            radioMetar.TabIndex = 0;
            radioMetar.Text = "1px=1cm";
            radioMetar.UseVisualStyleBackColor = true;
            radioMetar.CheckedChanged += radioMetar_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(204, 75);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += Form1_Paint;
            // 
            // pivot
            // 
            pivot.FlatStyle = FlatStyle.Flat;
            pivot.Location = new Point(373, 249);
            pivot.Name = "pivot";
            pivot.Size = new Size(8, 8);
            pivot.TabIndex = 10;
            pivot.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 436);
            Controls.Add(pivot);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("Dotum", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Нумеричка симулација тачкасте масе на опрузи";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)masaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)xBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)yBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)duzinaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)kBox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private NumericUpDown masaBox;
        private NumericUpDown xBox;
        private NumericUpDown yBox;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown duzinaBox;
        private NumericUpDown kBox;
        private NumericUpDown numericUpDown3;
        private GroupBox groupBox3;
        private RadioButton radioMetar;
        private RadioButton radioCentim;
        private PictureBox pictureBox1;
        private NumericUpDown cBox;
        private Button pivot;
    }
}
