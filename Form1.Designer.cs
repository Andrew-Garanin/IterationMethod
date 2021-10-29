namespace IterationMethod
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonN = new System.Windows.Forms.Button();
            this.pointChart = new ZedGraph.ZedGraphControl();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.TextBox();
            this.labelBeta = new System.Windows.Forms.Label();
            this.beta = new System.Windows.Forms.TextBox();
            this.labelGamma = new System.Windows.Forms.Label();
            this.gamma = new System.Windows.Forms.TextBox();
            this.checkAlpha = new System.Windows.Forms.RadioButton();
            this.checkBeta = new System.Windows.Forms.RadioButton();
            this.checkGamma = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelM = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.TextBox();
            this.labelP = new System.Windows.Forms.Label();
            this.x0 = new System.Windows.Forms.TextBox();
            this.labelX0 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(655, 427);
            this.buttonN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(171, 70);
            this.buttonN.TabIndex = 0;
            this.buttonN.Text = "Нарисовать";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.ButtonN_Click);
            // 
            // pointChart
            // 
            this.pointChart.BackColor = System.Drawing.SystemColors.Window;
            this.pointChart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pointChart.IsShowPointValues = false;
            this.pointChart.Location = new System.Drawing.Point(13, 82);
            this.pointChart.Margin = new System.Windows.Forms.Padding(4);
            this.pointChart.Name = "pointChart";
            this.pointChart.PointValueFormat = "G";
            this.pointChart.Size = new System.Drawing.Size(563, 532);
            this.pointChart.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(745, 137);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 17);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(882, 137);
            this.labelB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 17);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(907, 137);
            this.B.Margin = new System.Windows.Forms.Padding(4);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(56, 22);
            this.B.TabIndex = 6;
            this.B.Text = "20";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(770, 212);
            this.C.Margin = new System.Windows.Forms.Padding(4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(56, 22);
            this.C.TabIndex = 8;
            this.C.Text = "-20";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(745, 212);
            this.labelC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(17, 17);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "C";
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(907, 212);
            this.D.Margin = new System.Windows.Forms.Padding(4);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(56, 22);
            this.D.TabIndex = 10;
            this.D.Text = "20";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(882, 212);
            this.labelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(18, 17);
            this.labelD.TabIndex = 9;
            this.labelD.Text = "D";
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(833, 279);
            this.labelAlpha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(16, 17);
            this.labelAlpha.TabIndex = 11;
            this.labelAlpha.Text = "α";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(857, 279);
            this.alpha.Margin = new System.Windows.Forms.Padding(4);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(57, 22);
            this.alpha.TabIndex = 12;
            this.alpha.Text = "5";
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Location = new System.Drawing.Point(833, 311);
            this.labelBeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(16, 17);
            this.labelBeta.TabIndex = 14;
            this.labelBeta.Text = "β";
            // 
            // beta
            // 
            this.beta.Location = new System.Drawing.Point(857, 311);
            this.beta.Margin = new System.Windows.Forms.Padding(4);
            this.beta.Name = "beta";
            this.beta.Size = new System.Drawing.Size(57, 22);
            this.beta.TabIndex = 15;
            this.beta.Text = "6";
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Location = new System.Drawing.Point(834, 343);
            this.labelGamma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(15, 17);
            this.labelGamma.TabIndex = 17;
            this.labelGamma.Text = "γ";
            // 
            // gamma
            // 
            this.gamma.Location = new System.Drawing.Point(857, 343);
            this.gamma.Margin = new System.Windows.Forms.Padding(4);
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(57, 22);
            this.gamma.TabIndex = 18;
            this.gamma.Text = "7";
            // 
            // checkAlpha
            // 
            this.checkAlpha.AutoSize = true;
            this.checkAlpha.Checked = true;
            this.checkAlpha.Location = new System.Drawing.Point(8, 23);
            this.checkAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.checkAlpha.Name = "checkAlpha";
            this.checkAlpha.Size = new System.Drawing.Size(17, 16);
            this.checkAlpha.TabIndex = 25;
            this.checkAlpha.TabStop = true;
            this.checkAlpha.UseVisualStyleBackColor = true;
            // 
            // checkBeta
            // 
            this.checkBeta.AutoSize = true;
            this.checkBeta.Location = new System.Drawing.Point(8, 55);
            this.checkBeta.Margin = new System.Windows.Forms.Padding(4);
            this.checkBeta.Name = "checkBeta";
            this.checkBeta.Size = new System.Drawing.Size(17, 16);
            this.checkBeta.TabIndex = 26;
            this.checkBeta.UseVisualStyleBackColor = true;
            // 
            // checkGamma
            // 
            this.checkGamma.AutoSize = true;
            this.checkGamma.Location = new System.Drawing.Point(8, 87);
            this.checkGamma.Margin = new System.Windows.Forms.Padding(4);
            this.checkGamma.Name = "checkGamma";
            this.checkGamma.Size = new System.Drawing.Size(17, 16);
            this.checkGamma.TabIndex = 27;
            this.checkGamma.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAlpha);
            this.groupBox1.Controls.Add(this.checkBeta);
            this.groupBox1.Controls.Add(this.checkGamma);
            this.groupBox1.Location = new System.Drawing.Point(922, 261);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(32, 113);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(743, 282);
            this.labelM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(19, 17);
            this.labelM.TabIndex = 27;
            this.labelM.Text = "m";
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(770, 279);
            this.m.Margin = new System.Windows.Forms.Padding(4);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(59, 22);
            this.m.TabIndex = 28;
            this.m.Text = "10";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(770, 311);
            this.n.Margin = new System.Windows.Forms.Padding(4);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(59, 22);
            this.n.TabIndex = 30;
            this.n.Text = "10";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(743, 314);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(16, 17);
            this.labelN.TabIndex = 29;
            this.labelN.Text = "n";
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(770, 343);
            this.p.Margin = new System.Windows.Forms.Padding(4);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(59, 22);
            this.p.TabIndex = 32;
            this.p.Text = "5";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(744, 346);
            this.labelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(16, 17);
            this.labelP.TabIndex = 31;
            this.labelP.Text = "p";
            // 
            // x0
            // 
            this.x0.Location = new System.Drawing.Point(770, 376);
            this.x0.Margin = new System.Windows.Forms.Padding(4);
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(59, 22);
            this.x0.TabIndex = 34;
            this.x0.Text = "5";
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(743, 376);
            this.labelX0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(22, 17);
            this.labelX0.TabIndex = 33;
            this.labelX0.Text = "x0";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(770, 137);
            this.A.Margin = new System.Windows.Forms.Padding(4);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(56, 22);
            this.A.TabIndex = 35;
            this.A.Text = "-20";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(834, 427);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(171, 70);
            this.buttonClear.TabIndex = 36;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "По горизонтали:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "По вертикали:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Лабораторная_3_метод_итераций.Properties.Resources.FUNC;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(612, 279);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 31);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 51);
            this.label5.TabIndex = 44;
            this.label5.Text = "Для того, чтобы изобразить в окне все n \r\nрезультатов итераций нужно сделать \r\nпа" +
    "раметр p равным 1.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1162, 662);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.A);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.p);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.n);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.m);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.D);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.C);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.B);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.gamma);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.beta);
            this.Controls.Add(this.labelBeta);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.pointChart);
            this.Controls.Add(this.labelAlpha);
            this.Controls.Add(this.buttonN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Метод итераций. Гаранин Андрей ИВТ-41";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonN;
        private ZedGraph.ZedGraphControl pointChart;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.TextBox alpha;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.TextBox beta;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.TextBox gamma;
        private System.Windows.Forms.RadioButton checkAlpha;
        private System.Windows.Forms.RadioButton checkBeta;
        private System.Windows.Forms.RadioButton checkGamma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox x0;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

