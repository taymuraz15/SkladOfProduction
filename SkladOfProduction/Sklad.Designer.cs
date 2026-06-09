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
            this.SuspendLayout();
            // 
            // listBoxCatalog
            // 
            this.listBoxCatalog.FormattingEnabled = true;
            this.listBoxCatalog.Location = new System.Drawing.Point(43, 74);
            this.listBoxCatalog.Name = "listBoxCatalog";
            this.listBoxCatalog.Size = new System.Drawing.Size(249, 264);
            this.listBoxCatalog.TabIndex = 0;
            this.listBoxCatalog.SelectedIndexChanged += new System.EventHandler(this.listBoxCatalog_SelectedIndexChanged);
            // 
            // listBoxSklad
            // 
            this.listBoxSklad.FormattingEnabled = true;
            this.listBoxSklad.Location = new System.Drawing.Point(512, 74);
            this.listBoxSklad.Name = "listBoxSklad";
            this.listBoxSklad.Size = new System.Drawing.Size(223, 264);
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
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.listBoxSklad);
            this.Controls.Add(this.listBoxCatalog);
            this.Name = "Sklad";
            this.Text = "Sklad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCatalog;
        private System.Windows.Forms.ListBox listBoxSklad;
        private System.Windows.Forms.Button buttonCheck;
    }
}

