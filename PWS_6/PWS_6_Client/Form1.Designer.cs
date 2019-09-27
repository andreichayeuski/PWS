namespace PWS_6_Client
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
            this.getNotes = new System.Windows.Forms.Button();
            this.getStudents = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getNotes
            // 
            this.getNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getNotes.Location = new System.Drawing.Point(402, 339);
            this.getNotes.Name = "getNotes";
            this.getNotes.Size = new System.Drawing.Size(345, 71);
            this.getNotes.TabIndex = 5;
            this.getNotes.Text = "notes";
            this.getNotes.UseVisualStyleBackColor = true;
            this.getNotes.Click += new System.EventHandler(this.getNotes_Click);
            // 
            // getStudents
            // 
            this.getStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getStudents.Location = new System.Drawing.Point(54, 339);
            this.getStudents.Name = "getStudents";
            this.getStudents.Size = new System.Drawing.Size(342, 71);
            this.getStudents.TabIndex = 4;
            this.getStudents.Text = "students";
            this.getStudents.UseVisualStyleBackColor = true;
            this.getStudents.Click += new System.EventHandler(this.getStudents_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(54, 40);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(693, 293);
            this.result.TabIndex = 3;
            this.result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getNotes);
            this.Controls.Add(this.getStudents);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getNotes;
        private System.Windows.Forms.Button getStudents;
        private System.Windows.Forms.RichTextBox result;
    }
}

