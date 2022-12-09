namespace WF_Auditory__09._12._22_
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
            this.labelCursorPoint = new System.Windows.Forms.Label();
            this.listBoxShopList = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLimit = new System.Windows.Forms.Label();
            this.buttonDeleteList = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSetLimit = new System.Windows.Forms.Button();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.labelShopList = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCursorPoint
            // 
            this.labelCursorPoint.AutoSize = true;
            this.labelCursorPoint.Location = new System.Drawing.Point(12, 9);
            this.labelCursorPoint.Name = "labelCursorPoint";
            this.labelCursorPoint.Size = new System.Drawing.Size(113, 13);
            this.labelCursorPoint.TabIndex = 0;
            this.labelCursorPoint.Text = "Координаты курсора";
            // 
            // listBoxShopList
            // 
            this.listBoxShopList.FormattingEnabled = true;
            this.listBoxShopList.Location = new System.Drawing.Point(15, 108);
            this.listBoxShopList.Name = "listBoxShopList";
            this.listBoxShopList.Size = new System.Drawing.Size(120, 95);
            this.listBoxShopList.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(199, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить позицию";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(359, 108);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить позицию";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите название позиции и ёё цену через точку\r\n(Пример: Хлеб . 200)";
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLimit.Location = new System.Drawing.Point(12, 67);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(61, 16);
            this.labelLimit.TabIndex = 6;
            this.labelLimit.Text = "Лимит: ";
            // 
            // buttonDeleteList
            // 
            this.buttonDeleteList.Location = new System.Drawing.Point(498, 108);
            this.buttonDeleteList.Name = "buttonDeleteList";
            this.buttonDeleteList.Size = new System.Drawing.Size(107, 23);
            this.buttonDeleteList.TabIndex = 7;
            this.buttonDeleteList.Text = "Удалить список";
            this.buttonDeleteList.UseVisualStyleBackColor = true;
            this.buttonDeleteList.Click += new System.EventHandler(this.buttonDeleteList_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(335, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите лимит расходов";
            // 
            // buttonSetLimit
            // 
            this.buttonSetLimit.Location = new System.Drawing.Point(199, 179);
            this.buttonSetLimit.Name = "buttonSetLimit";
            this.buttonSetLimit.Size = new System.Drawing.Size(121, 23);
            this.buttonSetLimit.TabIndex = 10;
            this.buttonSetLimit.Text = "Установить лимит";
            this.buttonSetLimit.UseVisualStyleBackColor = true;
            this.buttonSetLimit.Click += new System.EventHandler(this.buttonSetLimit_Click);
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Location = new System.Drawing.Point(15, 212);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(120, 23);
            this.buttonShowMessage.TabIndex = 11;
            this.buttonShowMessage.Text = "Отчёт о расходах";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // labelShopList
            // 
            this.labelShopList.AutoSize = true;
            this.labelShopList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShopList.Location = new System.Drawing.Point(11, 89);
            this.labelShopList.Name = "labelShopList";
            this.labelShopList.Size = new System.Drawing.Size(124, 16);
            this.labelShopList.TabIndex = 12;
            this.labelShopList.Text = "Сумма покупок:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(141, 92);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(14, 15);
            this.labelSum.TabIndex = 13;
            this.labelSum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelShopList);
            this.Controls.Add(this.buttonShowMessage);
            this.Controls.Add(this.buttonSetLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonDeleteList);
            this.Controls.Add(this.labelLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxShopList);
            this.Controls.Add(this.labelCursorPoint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCursorPoint;
        private System.Windows.Forms.ListBox listBoxShopList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.Button buttonDeleteList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSetLimit;
        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.Label labelShopList;
        private System.Windows.Forms.Label labelSum;
    }
}

