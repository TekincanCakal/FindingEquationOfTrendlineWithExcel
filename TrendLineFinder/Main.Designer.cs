
namespace TrendLineFinder
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataListBox1 = new System.Windows.Forms.ListBox();
            this.dataListBox2 = new System.Windows.Forms.ListBox();
            this.dataTextBox1 = new System.Windows.Forms.TextBox();
            this.dataTextBox2 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.hideButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.midPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListBox1
            // 
            this.dataListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataListBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataListBox1.FormattingEnabled = true;
            this.dataListBox1.Location = new System.Drawing.Point(10, 12);
            this.dataListBox1.Name = "dataListBox1";
            this.dataListBox1.Size = new System.Drawing.Size(120, 210);
            this.dataListBox1.TabIndex = 0;
            this.dataListBox1.DoubleClick += new System.EventHandler(this.dataListBox_DoubleClick);
            // 
            // dataListBox2
            // 
            this.dataListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataListBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataListBox2.FormattingEnabled = true;
            this.dataListBox2.Location = new System.Drawing.Point(140, 12);
            this.dataListBox2.Name = "dataListBox2";
            this.dataListBox2.Size = new System.Drawing.Size(120, 210);
            this.dataListBox2.TabIndex = 1;
            this.dataListBox2.DoubleClick += new System.EventHandler(this.dataListBox_DoubleClick);
            // 
            // dataTextBox1
            // 
            this.dataTextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataTextBox1.Location = new System.Drawing.Point(10, 232);
            this.dataTextBox1.Multiline = true;
            this.dataTextBox1.Name = "dataTextBox1";
            this.dataTextBox1.Size = new System.Drawing.Size(120, 20);
            this.dataTextBox1.TabIndex = 2;
            this.dataTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataTextBox_KeyPress);
            // 
            // dataTextBox2
            // 
            this.dataTextBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataTextBox2.Location = new System.Drawing.Point(140, 232);
            this.dataTextBox2.Name = "dataTextBox2";
            this.dataTextBox2.Size = new System.Drawing.Size(120, 20);
            this.dataTextBox2.TabIndex = 3;
            this.dataTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataTextBox_KeyPress);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculateButton.Location = new System.Drawing.Point(8, 262);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(250, 20);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.hideButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(270, 30);
            this.topPanel.TabIndex = 6;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // hideButton
            // 
            this.hideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.Location = new System.Drawing.Point(210, 0);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(30, 30);
            this.hideButton.TabIndex = 1;
            this.hideButton.Text = "─";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(240, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "✘";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // midPanel
            // 
            this.midPanel.Controls.Add(this.dataListBox1);
            this.midPanel.Controls.Add(this.dataListBox2);
            this.midPanel.Controls.Add(this.dataTextBox1);
            this.midPanel.Controls.Add(this.calculateButton);
            this.midPanel.Controls.Add(this.dataTextBox2);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 30);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(270, 290);
            this.midPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 320);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.midPanel.ResumeLayout(false);
            this.midPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox dataListBox2;
        private System.Windows.Forms.TextBox dataTextBox1;
        private System.Windows.Forms.TextBox dataTextBox2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox dataListBox1;
        private System.Windows.Forms.Panel midPanel;
    }
}

