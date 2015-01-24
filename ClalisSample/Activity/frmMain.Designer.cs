namespace Clalis.Activity
{
    partial class frmMain
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClalis41 = new System.Windows.Forms.Button();
            this.btnClalis31 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEnd.Location = new System.Drawing.Point(12, 124);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(260, 50);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnClalis41
            // 
            this.btnClalis41.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClalis41.Location = new System.Drawing.Point(12, 68);
            this.btnClalis41.Name = "btnClalis41";
            this.btnClalis41.Size = new System.Drawing.Size(260, 50);
            this.btnClalis41.TabIndex = 4;
            this.btnClalis41.Text = "Clalis4.1サンプル";
            this.btnClalis41.UseVisualStyleBackColor = true;
            this.btnClalis41.Click += new System.EventHandler(this.btnClalis41_Click);
            // 
            // btnClalis31
            // 
            this.btnClalis31.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClalis31.Location = new System.Drawing.Point(12, 12);
            this.btnClalis31.Name = "btnClalis31";
            this.btnClalis31.Size = new System.Drawing.Size(260, 50);
            this.btnClalis31.TabIndex = 3;
            this.btnClalis31.Text = "Clalis3.1サンプル";
            this.btnClalis31.UseVisualStyleBackColor = true;
            this.btnClalis31.Click += new System.EventHandler(this.btnClalis31_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClalis41);
            this.Controls.Add(this.btnClalis31);
            this.Name = "frmMain";
            this.Text = "ClalisAPI C# サンプル";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClalis41;
        private System.Windows.Forms.Button btnClalis31;
    }
}