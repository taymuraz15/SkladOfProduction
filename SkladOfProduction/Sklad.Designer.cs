namespace SkladOfProduction
{
    partial class Sklad
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
            this.listBoxCatalog = new System.Windows.Forms.ListBox();
            this.listBoxSklad = new System.Windows.Forms.ListBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCatalog
            // 
            this.listBoxCatalog.FormattingEnabled = true;
            this.listBoxCatalog.Location = new System.Drawing.Point(43, 74);
            this.listBoxCatalog.Name = "listBoxCatalog";
            this.listBoxCatalog.Size = new System.Drawing.Size(309, 264);
            this.listBoxCatalog.TabIndex = 0;
            this.listBoxCatalog.SelectedIndexChanged += new System.EventHandler(this.listBoxCatalog_SelectedIndexChanged);
            // 
            // listBoxSklad
            // 
            this.listBoxSklad.FormattingEnabled = true;
            this.listBoxSklad.Location = new System.Drawing.Point(444, 74);
            this.listBoxSklad.Name = "listBoxSklad";
            this.listBoxSklad.Size = new System.Drawing.Size(291, 264);
            this.listBoxSklad.TabIndex = 1;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(357, 348);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "ПРОВЕРКА";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Доступные товары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Товары на складе";
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.listBoxSklad);
            this.Controls.Add(this.listBoxCatalog);
            this.Name = "Sklad";
            this.Text = "Sklad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCatalog;
        private System.Windows.Forms.ListBox listBoxSklad;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

