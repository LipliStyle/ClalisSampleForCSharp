namespace Clalis.Activity
{
    partial class frmClalis41
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClalisMecabJson = new System.Windows.Forms.Button();
            this.btnClalisEmotionJson = new System.Windows.Forms.Button();
            this.btnClalisToneEmotionJson = new System.Windows.Forms.Button();
            this.btnClalisToneJson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClalisMecabSoap = new System.Windows.Forms.Button();
            this.btnClalisEmotionSoap = new System.Windows.Forms.Button();
            this.btnClalisToneEmotionSoap = new System.Windows.Forms.Button();
            this.btnClalisToneSoap = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEnd);
            this.groupBox3.Controls.Add(this.btnClalisMecabJson);
            this.groupBox3.Controls.Add(this.btnClalisEmotionJson);
            this.groupBox3.Controls.Add(this.btnClalisToneEmotionJson);
            this.groupBox3.Controls.Add(this.btnClalisToneJson);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(284, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 256);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Json";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(12, 202);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(260, 40);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnClalisMecabJson
            // 
            this.btnClalisMecabJson.Location = new System.Drawing.Point(12, 18);
            this.btnClalisMecabJson.Name = "btnClalisMecabJson";
            this.btnClalisMecabJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecabJson.TabIndex = 0;
            this.btnClalisMecabJson.Text = "ClalisApi4.1 形態素解析";
            this.btnClalisMecabJson.UseVisualStyleBackColor = true;
            this.btnClalisMecabJson.Click += new System.EventHandler(this.btnClalisMecabJson_Click);
            // 
            // btnClalisEmotionJson
            // 
            this.btnClalisEmotionJson.Location = new System.Drawing.Point(12, 64);
            this.btnClalisEmotionJson.Name = "btnClalisEmotionJson";
            this.btnClalisEmotionJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisEmotionJson.TabIndex = 3;
            this.btnClalisEmotionJson.Text = "ClalisApi4.1 感情付与";
            this.btnClalisEmotionJson.UseVisualStyleBackColor = true;
            this.btnClalisEmotionJson.Click += new System.EventHandler(this.btnClalisEmotionJson_Click);
            // 
            // btnClalisToneEmotionJson
            // 
            this.btnClalisToneEmotionJson.Location = new System.Drawing.Point(12, 156);
            this.btnClalisToneEmotionJson.Name = "btnClalisToneEmotionJson";
            this.btnClalisToneEmotionJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneEmotionJson.TabIndex = 5;
            this.btnClalisToneEmotionJson.Text = "ClalisApi4.1 口調変換＋感情付与";
            this.btnClalisToneEmotionJson.UseVisualStyleBackColor = true;
            this.btnClalisToneEmotionJson.Click += new System.EventHandler(this.btnClalisToneEmotionJson_Click);
            // 
            // btnClalisToneJson
            // 
            this.btnClalisToneJson.Location = new System.Drawing.Point(12, 110);
            this.btnClalisToneJson.Name = "btnClalisToneJson";
            this.btnClalisToneJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneJson.TabIndex = 4;
            this.btnClalisToneJson.Text = "ClalisApi4.1 口調変換";
            this.btnClalisToneJson.UseVisualStyleBackColor = true;
            this.btnClalisToneJson.Click += new System.EventHandler(this.btnClalisToneJson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClalisMecabSoap);
            this.groupBox1.Controls.Add(this.btnClalisEmotionSoap);
            this.groupBox1.Controls.Add(this.btnClalisToneEmotionSoap);
            this.groupBox1.Controls.Add(this.btnClalisToneSoap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 256);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soap";
            // 
            // btnClalisMecabSoap
            // 
            this.btnClalisMecabSoap.Location = new System.Drawing.Point(12, 18);
            this.btnClalisMecabSoap.Name = "btnClalisMecabSoap";
            this.btnClalisMecabSoap.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecabSoap.TabIndex = 0;
            this.btnClalisMecabSoap.Text = "ClalisApi4.1 形態素解析";
            this.btnClalisMecabSoap.UseVisualStyleBackColor = true;
            this.btnClalisMecabSoap.Click += new System.EventHandler(this.btnClalisMecabSoap_Click);
            // 
            // btnClalisEmotionSoap
            // 
            this.btnClalisEmotionSoap.Location = new System.Drawing.Point(12, 64);
            this.btnClalisEmotionSoap.Name = "btnClalisEmotionSoap";
            this.btnClalisEmotionSoap.Size = new System.Drawing.Size(260, 40);
            this.btnClalisEmotionSoap.TabIndex = 3;
            this.btnClalisEmotionSoap.Text = "ClalisApi4.1 感情付与";
            this.btnClalisEmotionSoap.UseVisualStyleBackColor = true;
            this.btnClalisEmotionSoap.Click += new System.EventHandler(this.btnClalisEmotionSoap_Click);
            // 
            // btnClalisToneEmotionSoap
            // 
            this.btnClalisToneEmotionSoap.Location = new System.Drawing.Point(12, 156);
            this.btnClalisToneEmotionSoap.Name = "btnClalisToneEmotionSoap";
            this.btnClalisToneEmotionSoap.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneEmotionSoap.TabIndex = 5;
            this.btnClalisToneEmotionSoap.Text = "ClalisApi4.1 口調変換＋感情付与";
            this.btnClalisToneEmotionSoap.UseVisualStyleBackColor = true;
            this.btnClalisToneEmotionSoap.Click += new System.EventHandler(this.btnClalisToneEmotionSoap_Click);
            // 
            // btnClalisToneSoap
            // 
            this.btnClalisToneSoap.Location = new System.Drawing.Point(12, 110);
            this.btnClalisToneSoap.Name = "btnClalisToneSoap";
            this.btnClalisToneSoap.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneSoap.TabIndex = 4;
            this.btnClalisToneSoap.Text = "ClalisApi4.1 口調変換";
            this.btnClalisToneSoap.UseVisualStyleBackColor = true;
            this.btnClalisToneSoap.Click += new System.EventHandler(this.btnClalisToneSoap_Click);
            // 
            // frmClalis41
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 256);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClalis41";
            this.Text = "ClalisAPI4.1 C# サンプル";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClalisMecabJson;
        private System.Windows.Forms.Button btnClalisEmotionJson;
        private System.Windows.Forms.Button btnClalisToneEmotionJson;
        private System.Windows.Forms.Button btnClalisToneJson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClalisMecabSoap;
        private System.Windows.Forms.Button btnClalisEmotionSoap;
        private System.Windows.Forms.Button btnClalisToneEmotionSoap;
        private System.Windows.Forms.Button btnClalisToneSoap;


    }
}