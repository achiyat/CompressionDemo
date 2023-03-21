namespace CompressionDemo
{
    partial class Form1
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
            this.btnCompress = new System.Windows.Forms.Button();
            this.checkZip = new System.Windows.Forms.CheckBox();
            this.checkRar = new System.Windows.Forms.CheckBox();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(76, 62);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(119, 50);
            this.btnCompress.TabIndex = 0;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click_1);
            // 
            // checkZip
            // 
            this.checkZip.AutoSize = true;
            this.checkZip.Location = new System.Drawing.Point(314, 78);
            this.checkZip.Name = "checkZip";
            this.checkZip.Size = new System.Drawing.Size(48, 20);
            this.checkZip.TabIndex = 1;
            this.checkZip.Text = "Zip";
            this.checkZip.UseVisualStyleBackColor = true;
            this.checkZip.CheckedChanged += new System.EventHandler(this.checkZip_CheckedChanged);
            // 
            // checkRar
            // 
            this.checkRar.AutoSize = true;
            this.checkRar.Location = new System.Drawing.Point(314, 118);
            this.checkRar.Name = "checkRar";
            this.checkRar.Size = new System.Drawing.Size(51, 20);
            this.checkRar.TabIndex = 2;
            this.checkRar.Text = "Rar";
            this.checkRar.UseVisualStyleBackColor = true;
            this.checkRar.CheckedChanged += new System.EventHandler(this.checkRar_CheckedChanged);
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(45, 195);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(717, 30);
            this.txtSourceDirectory.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.checkRar);
            this.Controls.Add(this.checkZip);
            this.Controls.Add(this.btnCompress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.CheckBox checkZip;
        private System.Windows.Forms.CheckBox checkRar;
        private System.Windows.Forms.TextBox txtSourceDirectory;
    }
}

