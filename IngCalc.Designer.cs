namespace SimpleCalculator
{
    partial class IngCalc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.keyDegree = new System.Windows.Forms.Button();
            this.keySQRT = new System.Windows.Forms.Button();
            this.keyReverse = new System.Windows.Forms.Button();
            this.keyDegree2 = new System.Windows.Forms.Button();
            this.outputDisplay2 = new System.Windows.Forms.TextBox();
            this.keyFactorial = new System.Windows.Forms.Button();
            this.keyCBRT = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.keyQE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyExit
            // 
            this.KeyExit.Location = new System.Drawing.Point(320, 262);
            // 
            // KeyDate
            // 
            this.KeyDate.Location = new System.Drawing.Point(320, 214);
            // 
            // KeyClear
            // 
            this.KeyClear.Location = new System.Drawing.Point(320, 166);
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click_1);
            // 
            // KeyMinus
            // 
            this.KeyMinus.Location = new System.Drawing.Point(158, 262);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Location = new System.Drawing.Point(158, 310);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Location = new System.Drawing.Point(266, 310);
            this.KeyEqual.Size = new System.Drawing.Size(121, 46);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Location = new System.Drawing.Point(158, 214);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Location = new System.Drawing.Point(158, 166);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Location = new System.Drawing.Point(62, 310);
            // 
            // KeySign
            // 
            this.KeySign.Location = new System.Drawing.Point(110, 310);
            // 
            // KeyZero
            // 
            this.KeyZero.Location = new System.Drawing.Point(14, 310);
            // 
            // KeyNine
            // 
            this.KeyNine.Location = new System.Drawing.Point(110, 166);
            // 
            // KeyEight
            // 
            this.KeyEight.Location = new System.Drawing.Point(62, 166);
            // 
            // KeySeven
            // 
            this.KeySeven.Location = new System.Drawing.Point(14, 166);
            // 
            // KeySix
            // 
            this.KeySix.Location = new System.Drawing.Point(110, 214);
            // 
            // KeyFive
            // 
            this.KeyFive.Location = new System.Drawing.Point(62, 214);
            // 
            // KeyFour
            // 
            this.KeyFour.Location = new System.Drawing.Point(14, 214);
            // 
            // KeyThree
            // 
            this.KeyThree.Location = new System.Drawing.Point(110, 262);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Location = new System.Drawing.Point(62, 262);
            // 
            // KeyOne
            // 
            this.KeyOne.Location = new System.Drawing.Point(14, 262);
            // 
            // keyDegree
            // 
            this.keyDegree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.keyDegree.ForeColor = System.Drawing.Color.Red;
            this.keyDegree.Location = new System.Drawing.Point(212, 166);
            this.keyDegree.Name = "keyDegree";
            this.keyDegree.Size = new System.Drawing.Size(48, 46);
            this.keyDegree.TabIndex = 24;
            this.keyDegree.TabStop = false;
            this.keyDegree.Text = "X^Y";
            this.toolTip1.SetToolTip(this.keyDegree, "Возведение в степень");
            this.keyDegree.Click += new System.EventHandler(this.keyDegree_Click);
            // 
            // keySQRT
            // 
            this.keySQRT.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.keySQRT.ForeColor = System.Drawing.Color.Red;
            this.keySQRT.Location = new System.Drawing.Point(212, 214);
            this.keySQRT.Name = "keySQRT";
            this.keySQRT.Size = new System.Drawing.Size(48, 46);
            this.keySQRT.TabIndex = 25;
            this.keySQRT.TabStop = false;
            this.keySQRT.Text = "SQRT";
            this.toolTip1.SetToolTip(this.keySQRT, "Квадратный корень");
            this.keySQRT.Click += new System.EventHandler(this.keySQRT_Click);
            // 
            // keyReverse
            // 
            this.keyReverse.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.keyReverse.ForeColor = System.Drawing.Color.Red;
            this.keyReverse.Location = new System.Drawing.Point(212, 262);
            this.keyReverse.Name = "keyReverse";
            this.keyReverse.Size = new System.Drawing.Size(48, 46);
            this.keyReverse.TabIndex = 26;
            this.keyReverse.TabStop = false;
            this.keyReverse.Text = "1/X";
            this.toolTip1.SetToolTip(this.keyReverse, "Обратное значение");
            this.keyReverse.Click += new System.EventHandler(this.keyReverse_Click);
            // 
            // keyDegree2
            // 
            this.keyDegree2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.keyDegree2.ForeColor = System.Drawing.Color.Red;
            this.keyDegree2.Location = new System.Drawing.Point(212, 310);
            this.keyDegree2.Name = "keyDegree2";
            this.keyDegree2.Size = new System.Drawing.Size(48, 46);
            this.keyDegree2.TabIndex = 27;
            this.keyDegree2.TabStop = false;
            this.keyDegree2.Text = "X^2";
            this.toolTip1.SetToolTip(this.keyDegree2, "Квадрат");
            this.keyDegree2.Click += new System.EventHandler(this.keyDegree2_Click);
            // 
            // outputDisplay2
            // 
            this.outputDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.outputDisplay2.Enabled = false;
            this.outputDisplay2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.outputDisplay2.Location = new System.Drawing.Point(14, 123);
            this.outputDisplay2.Name = "outputDisplay2";
            this.outputDisplay2.ReadOnly = true;
            this.outputDisplay2.Size = new System.Drawing.Size(298, 26);
            this.outputDisplay2.TabIndex = 28;
            this.outputDisplay2.TabStop = false;
            this.outputDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // keyFactorial
            // 
            this.keyFactorial.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.keyFactorial.ForeColor = System.Drawing.Color.Red;
            this.keyFactorial.Location = new System.Drawing.Point(266, 166);
            this.keyFactorial.Name = "keyFactorial";
            this.keyFactorial.Size = new System.Drawing.Size(48, 46);
            this.keyFactorial.TabIndex = 29;
            this.keyFactorial.TabStop = false;
            this.keyFactorial.Text = "X!";
            this.toolTip1.SetToolTip(this.keyFactorial, "Факториал");
            this.keyFactorial.Click += new System.EventHandler(this.keyFactorial_Click);
            // 
            // keyCBRT
            // 
            this.keyCBRT.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.keyCBRT.ForeColor = System.Drawing.Color.Red;
            this.keyCBRT.Location = new System.Drawing.Point(266, 214);
            this.keyCBRT.Name = "keyCBRT";
            this.keyCBRT.Size = new System.Drawing.Size(48, 46);
            this.keyCBRT.TabIndex = 30;
            this.keyCBRT.TabStop = false;
            this.keyCBRT.Text = "CBRT";
            this.toolTip1.SetToolTip(this.keyCBRT, "Кубический корень");
            this.keyCBRT.Click += new System.EventHandler(this.keyCBRT_Click);
            // 
            // keyQE
            // 
            this.keyQE.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.keyQE.ForeColor = System.Drawing.Color.Red;
            this.keyQE.Location = new System.Drawing.Point(266, 262);
            this.keyQE.Name = "keyQE";
            this.keyQE.Size = new System.Drawing.Size(48, 46);
            this.keyQE.TabIndex = 31;
            this.keyQE.TabStop = false;
            this.keyQE.Text = "QE";
            this.toolTip1.SetToolTip(this.keyQE, "Квадратное уравнение");
            this.keyQE.Click += new System.EventHandler(this.keyQE_Click);
            // 
            // IngCalc
            // 
            this.ClientSize = new System.Drawing.Size(429, 378);
            this.Controls.Add(this.keyQE);
            this.Controls.Add(this.keyCBRT);
            this.Controls.Add(this.keyFactorial);
            this.Controls.Add(this.outputDisplay2);
            this.Controls.Add(this.keyDegree2);
            this.Controls.Add(this.keyReverse);
            this.Controls.Add(this.keySQRT);
            this.Controls.Add(this.keyDegree);
            this.Name = "IngCalc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngCalc_FormClosed);
            this.Controls.SetChildIndex(this.OutputDisplay, 0);
            this.Controls.SetChildIndex(this.keyDegree, 0);
            this.Controls.SetChildIndex(this.keySQRT, 0);
            this.Controls.SetChildIndex(this.keyReverse, 0);
            this.Controls.SetChildIndex(this.keyDegree2, 0);
            this.Controls.SetChildIndex(this.KeyExit, 0);
            this.Controls.SetChildIndex(this.KeyClear, 0);
            this.Controls.SetChildIndex(this.KeyDate, 0);
            this.Controls.SetChildIndex(this.KeyEqual, 0);
            this.Controls.SetChildIndex(this.KeyPoint, 0);
            this.Controls.SetChildIndex(this.KeySign, 0);
            this.Controls.SetChildIndex(this.KeyDivide, 0);
            this.Controls.SetChildIndex(this.KeyMultiply, 0);
            this.Controls.SetChildIndex(this.KeyMinus, 0);
            this.Controls.SetChildIndex(this.KeyPlus, 0);
            this.Controls.SetChildIndex(this.KeyZero, 0);
            this.Controls.SetChildIndex(this.KeyNine, 0);
            this.Controls.SetChildIndex(this.KeyEight, 0);
            this.Controls.SetChildIndex(this.KeySeven, 0);
            this.Controls.SetChildIndex(this.KeySix, 0);
            this.Controls.SetChildIndex(this.KeyFive, 0);
            this.Controls.SetChildIndex(this.KeyFour, 0);
            this.Controls.SetChildIndex(this.KeyThree, 0);
            this.Controls.SetChildIndex(this.KeyTwo, 0);
            this.Controls.SetChildIndex(this.KeyOne, 0);
            this.Controls.SetChildIndex(this.outputDisplay2, 0);
            this.Controls.SetChildIndex(this.keyFactorial, 0);
            this.Controls.SetChildIndex(this.keyCBRT, 0);
            this.Controls.SetChildIndex(this.keyQE, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button keyDegree;
        protected System.Windows.Forms.Button keySQRT;
        protected System.Windows.Forms.Button keyReverse;
        protected System.Windows.Forms.Button keyDegree2;
        private System.Windows.Forms.TextBox outputDisplay2;
        protected System.Windows.Forms.Button keyFactorial;
        protected System.Windows.Forms.Button keyCBRT;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.Button keyQE;
    }
}
