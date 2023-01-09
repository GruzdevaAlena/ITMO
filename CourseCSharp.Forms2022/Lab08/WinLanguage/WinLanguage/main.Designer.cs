
namespace WinLanguage
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перваяКомандаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.втораяКомандаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // главноеМенюToolStripMenuItem
            // 
            resources.ApplyResources(this.главноеМенюToolStripMenuItem, "главноеМенюToolStripMenuItem");
            this.главноеМенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перваяКомандаToolStripMenuItem,
            this.втораяКомандаToolStripMenuItem});
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            // 
            // перваяКомандаToolStripMenuItem
            // 
            resources.ApplyResources(this.перваяКомандаToolStripMenuItem, "перваяКомандаToolStripMenuItem");
            this.перваяКомандаToolStripMenuItem.Name = "перваяКомандаToolStripMenuItem";
            // 
            // втораяКомандаToolStripMenuItem
            // 
            resources.ApplyResources(this.втораяКомандаToolStripMenuItem, "втораяКомандаToolStripMenuItem");
            this.втораяКомандаToolStripMenuItem.Name = "втораяКомандаToolStripMenuItem";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перваяКомандаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem втораяКомандаToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

