namespace WindowsFormsApp22
{
    partial class Form1
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
            this.wayout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wayin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.alltxt = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // wayout
            // 
            this.wayout.Location = new System.Drawing.Point(21, 38);
            this.wayout.Name = "wayout";
            this.wayout.Size = new System.Drawing.Size(500, 22);
            this.wayout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите путь к файлу для считывания: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите путь к файлу для записи: ";
            // 
            // wayin
            // 
            this.wayin.Location = new System.Drawing.Point(19, 91);
            this.wayin.Name = "wayin";
            this.wayin.Size = new System.Drawing.Size(502, 22);
            this.wayin.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Считать и записать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Исходный текст из файла:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Записанный в файл текст:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 84);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alltxt
            // 
            this.alltxt.Location = new System.Drawing.Point(16, 143);
            this.alltxt.Multiline = true;
            this.alltxt.Name = "alltxt";
            this.alltxt.ReadOnly = true;
            this.alltxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.alltxt.Size = new System.Drawing.Size(641, 116);
            this.alltxt.TabIndex = 13;
            // 
            // rez
            // 
            this.rez.FormattingEnabled = true;
            this.rez.ItemHeight = 16;
            this.rez.Location = new System.Drawing.Point(16, 282);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(505, 84);
            this.rez.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 425);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.alltxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wayin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wayin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox alltxt;
        private System.Windows.Forms.ListBox rez;
    }
}

