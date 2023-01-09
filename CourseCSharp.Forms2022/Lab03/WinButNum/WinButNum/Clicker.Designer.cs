
namespace WinButNum
{
    partial class Clicker
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
            this.clickButton1 = new WinButNum.ClickButton();
            this.SuspendLayout();
            // 
            // clickButton1
            // 
            this.clickButton1.Location = new System.Drawing.Point(13, 13);
            this.clickButton1.Name = "clickButton1";
            this.clickButton1.Size = new System.Drawing.Size(134, 23);
            this.clickButton1.TabIndex = 0;
            this.clickButton1.Text = "clickButton1";
            this.clickButton1.UseVisualStyleBackColor = true;
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 54);
            this.Controls.Add(this.clickButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Clicker";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClickButton clickButton1;
    }
}

