namespace prilog
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonYes_Click = new System.Windows.Forms.Button();
            this.buttonNo_Click = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonYes_Click
            // 
            this.buttonYes_Click.Location = new System.Drawing.Point(12, 99);
            this.buttonYes_Click.Name = "buttonYes_Click";
            this.buttonYes_Click.Size = new System.Drawing.Size(97, 23);
            this.buttonYes_Click.TabIndex = 0;
            this.buttonYes_Click.Text = "Подтвердить";
            this.buttonYes_Click.UseVisualStyleBackColor = true;
            this.buttonYes_Click.Click += new System.EventHandler(this.buttonYes_Click_Click);
            // 
            // buttonNo_Click
            // 
            this.buttonNo_Click.Location = new System.Drawing.Point(115, 99);
            this.buttonNo_Click.Name = "buttonNo_Click";
            this.buttonNo_Click.Size = new System.Drawing.Size(93, 23);
            this.buttonNo_Click.TabIndex = 1;
            this.buttonNo_Click.Text = "Отмена";
            this.buttonNo_Click.UseVisualStyleBackColor = true;
            this.buttonNo_Click.Click += new System.EventHandler(this.buttonNo_Click_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ед\\измерения";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNo_Click);
            this.Controls.Add(this.buttonYes_Click);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonYes_Click;
        private Button buttonNo_Click;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}