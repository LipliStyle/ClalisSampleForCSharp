namespace Clalis.Activity
{
    partial class frmClalis31
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClalisMecab = new System.Windows.Forms.Button();
            this.btnClalisMecabP = new System.Windows.Forms.Button();
            this.btnClalisEmotion = new System.Windows.Forms.Button();
            this.btnClalisTone = new System.Windows.Forms.Button();
            this.btnClalisToneEmotion = new System.Windows.Forms.Button();
            this.btnClalisWebJp = new System.Windows.Forms.Button();
            this.btnClalisWebJpSentence = new System.Windows.Forms.Button();
            this.btnClalisWebJpImportantSentence = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClalisMecabXml = new System.Windows.Forms.Button();
            this.btnClalisWebJpImportantSentenceXml = new System.Windows.Forms.Button();
            this.btnClalisWebJpSentenceXml = new System.Windows.Forms.Button();
            this.btnClalisMecabPXml = new System.Windows.Forms.Button();
            this.btnClalisWebJpXml = new System.Windows.Forms.Button();
            this.btnClalisEmotionXml = new System.Windows.Forms.Button();
            this.btnClalisToneEmotionXml = new System.Windows.Forms.Button();
            this.btnClalisToneXml = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClalisMecabJson = new System.Windows.Forms.Button();
            this.btnClalisWebJpImportantSentenceJson = new System.Windows.Forms.Button();
            this.btnClalisWebJpSentenceJson = new System.Windows.Forms.Button();
            this.btnClalisMecabPJson = new System.Windows.Forms.Button();
            this.btnClalisWebJpJson = new System.Windows.Forms.Button();
            this.btnClalisEmotionJson = new System.Windows.Forms.Button();
            this.btnClalisToneEmotionJson = new System.Windows.Forms.Button();
            this.btnClalisToneJson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClalisMecab
            // 
            this.btnClalisMecab.Location = new System.Drawing.Point(12, 18);
            this.btnClalisMecab.Name = "btnClalisMecab";
            this.btnClalisMecab.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecab.TabIndex = 0;
            this.btnClalisMecab.Text = "Clalis 形態素解析";
            this.btnClalisMecab.UseVisualStyleBackColor = true;
            this.btnClalisMecab.Click += new System.EventHandler(this.btnClalisMecab_Click);
            // 
            // btnClalisMecabP
            // 
            this.btnClalisMecabP.Location = new System.Drawing.Point(12, 64);
            this.btnClalisMecabP.Name = "btnClalisMecabP";
            this.btnClalisMecabP.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecabP.TabIndex = 2;
            this.btnClalisMecabP.Text = "Clalis 形態素解析＋";
            this.btnClalisMecabP.UseVisualStyleBackColor = true;
            this.btnClalisMecabP.Click += new System.EventHandler(this.btnClalisMecabP_Click);
            // 
            // btnClalisEmotion
            // 
            this.btnClalisEmotion.Location = new System.Drawing.Point(12, 110);
            this.btnClalisEmotion.Name = "btnClalisEmotion";
            this.btnClalisEmotion.Size = new System.Drawing.Size(260, 40);
            this.btnClalisEmotion.TabIndex = 3;
            this.btnClalisEmotion.Text = "Clalis 感情付与";
            this.btnClalisEmotion.UseVisualStyleBackColor = true;
            this.btnClalisEmotion.Click += new System.EventHandler(this.btnClalisEmotion_Click);
            // 
            // btnClalisTone
            // 
            this.btnClalisTone.Location = new System.Drawing.Point(12, 156);
            this.btnClalisTone.Name = "btnClalisTone";
            this.btnClalisTone.Size = new System.Drawing.Size(260, 40);
            this.btnClalisTone.TabIndex = 4;
            this.btnClalisTone.Text = "Clalis 口調変換";
            this.btnClalisTone.UseVisualStyleBackColor = true;
            this.btnClalisTone.Click += new System.EventHandler(this.btnClalisTone_Click);
            // 
            // btnClalisToneEmotion
            // 
            this.btnClalisToneEmotion.Location = new System.Drawing.Point(12, 202);
            this.btnClalisToneEmotion.Name = "btnClalisToneEmotion";
            this.btnClalisToneEmotion.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneEmotion.TabIndex = 5;
            this.btnClalisToneEmotion.Text = "Clalis 口調変換＋感情付与";
            this.btnClalisToneEmotion.UseVisualStyleBackColor = true;
            this.btnClalisToneEmotion.Click += new System.EventHandler(this.btnClalisToneEmotion_Click);
            // 
            // btnClalisWebJp
            // 
            this.btnClalisWebJp.Location = new System.Drawing.Point(12, 248);
            this.btnClalisWebJp.Name = "btnClalisWebJp";
            this.btnClalisWebJp.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJp.TabIndex = 6;
            this.btnClalisWebJp.Text = "Clalis Web日本語抽出";
            this.btnClalisWebJp.UseVisualStyleBackColor = true;
            this.btnClalisWebJp.Click += new System.EventHandler(this.btnClalisWebJp_Click);
            // 
            // btnClalisWebJpSentence
            // 
            this.btnClalisWebJpSentence.Location = new System.Drawing.Point(12, 294);
            this.btnClalisWebJpSentence.Name = "btnClalisWebJpSentence";
            this.btnClalisWebJpSentence.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpSentence.TabIndex = 7;
            this.btnClalisWebJpSentence.Text = "Clalis Web文章抽出";
            this.btnClalisWebJpSentence.UseVisualStyleBackColor = true;
            this.btnClalisWebJpSentence.Click += new System.EventHandler(this.btnClalisWebJpSentence_Click);
            // 
            // btnClalisWebJpImportantSentence
            // 
            this.btnClalisWebJpImportantSentence.Location = new System.Drawing.Point(12, 340);
            this.btnClalisWebJpImportantSentence.Name = "btnClalisWebJpImportantSentence";
            this.btnClalisWebJpImportantSentence.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpImportantSentence.TabIndex = 8;
            this.btnClalisWebJpImportantSentence.Text = "Clalis Web重要文章抽出";
            this.btnClalisWebJpImportantSentence.UseVisualStyleBackColor = true;
            this.btnClalisWebJpImportantSentence.Click += new System.EventHandler(this.btnClalisWebJpImportantSentence_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClalisMecab);
            this.groupBox1.Controls.Add(this.btnClalisWebJpImportantSentence);
            this.groupBox1.Controls.Add(this.btnClalisWebJpSentence);
            this.groupBox1.Controls.Add(this.btnClalisMecabP);
            this.groupBox1.Controls.Add(this.btnClalisWebJp);
            this.groupBox1.Controls.Add(this.btnClalisEmotion);
            this.groupBox1.Controls.Add(this.btnClalisToneEmotion);
            this.groupBox1.Controls.Add(this.btnClalisTone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 430);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soap";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClalisMecabXml);
            this.groupBox2.Controls.Add(this.btnClalisWebJpImportantSentenceXml);
            this.groupBox2.Controls.Add(this.btnClalisWebJpSentenceXml);
            this.groupBox2.Controls.Add(this.btnClalisMecabPXml);
            this.groupBox2.Controls.Add(this.btnClalisWebJpXml);
            this.groupBox2.Controls.Add(this.btnClalisEmotionXml);
            this.groupBox2.Controls.Add(this.btnClalisToneEmotionXml);
            this.groupBox2.Controls.Add(this.btnClalisToneXml);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(284, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 430);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xml";
            // 
            // btnClalisMecabXml
            // 
            this.btnClalisMecabXml.Location = new System.Drawing.Point(12, 18);
            this.btnClalisMecabXml.Name = "btnClalisMecabXml";
            this.btnClalisMecabXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecabXml.TabIndex = 0;
            this.btnClalisMecabXml.Text = "Clalis 形態素解析";
            this.btnClalisMecabXml.UseVisualStyleBackColor = true;
            this.btnClalisMecabXml.Click += new System.EventHandler(this.btnClalisMecabXml_Click);
            // 
            // btnClalisWebJpImportantSentenceXml
            // 
            this.btnClalisWebJpImportantSentenceXml.Location = new System.Drawing.Point(12, 340);
            this.btnClalisWebJpImportantSentenceXml.Name = "btnClalisWebJpImportantSentenceXml";
            this.btnClalisWebJpImportantSentenceXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpImportantSentenceXml.TabIndex = 8;
            this.btnClalisWebJpImportantSentenceXml.Text = "Clalis Web重要文章抽出";
            this.btnClalisWebJpImportantSentenceXml.UseVisualStyleBackColor = true;
            this.btnClalisWebJpImportantSentenceXml.Click += new System.EventHandler(this.btnClalisWebJpImportantSentenceXml_Click);
            // 
            // btnClalisWebJpSentenceXml
            // 
            this.btnClalisWebJpSentenceXml.Location = new System.Drawing.Point(12, 294);
            this.btnClalisWebJpSentenceXml.Name = "btnClalisWebJpSentenceXml";
            this.btnClalisWebJpSentenceXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpSentenceXml.TabIndex = 7;
            this.btnClalisWebJpSentenceXml.Text = "Clalis Web文章抽出";
            this.btnClalisWebJpSentenceXml.UseVisualStyleBackColor = true;
            this.btnClalisWebJpSentenceXml.Click += new System.EventHandler(this.btnClalisWebJpSentenceXml_Click);
            // 
            // btnClalisMecabPXml
            // 
            this.btnClalisMecabPXml.Location = new System.Drawing.Point(12, 64);
            this.btnClalisMecabPXml.Name = "btnClalisMecabPXml";
            this.btnClalisMecabPXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecabPXml.TabIndex = 2;
            this.btnClalisMecabPXml.Text = "Clalis 形態素解析＋";
            this.btnClalisMecabPXml.UseVisualStyleBackColor = true;
            this.btnClalisMecabPXml.Click += new System.EventHandler(this.btnClalisMecabPXml_Click);
            // 
            // btnClalisWebJpXml
            // 
            this.btnClalisWebJpXml.Location = new System.Drawing.Point(12, 248);
            this.btnClalisWebJpXml.Name = "btnClalisWebJpXml";
            this.btnClalisWebJpXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpXml.TabIndex = 6;
            this.btnClalisWebJpXml.Text = "Clalis Web日本語抽出";
            this.btnClalisWebJpXml.UseVisualStyleBackColor = true;
            this.btnClalisWebJpXml.Click += new System.EventHandler(this.btnClalisWebJpXml_Click);
            // 
            // btnClalisEmotionXml
            // 
            this.btnClalisEmotionXml.Location = new System.Drawing.Point(12, 110);
            this.btnClalisEmotionXml.Name = "btnClalisEmotionXml";
            this.btnClalisEmotionXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisEmotionXml.TabIndex = 3;
            this.btnClalisEmotionXml.Text = "Clalis 感情付与";
            this.btnClalisEmotionXml.UseVisualStyleBackColor = true;
            this.btnClalisEmotionXml.Click += new System.EventHandler(this.btnClalisEmotionXml_Click);
            // 
            // btnClalisToneEmotionXml
            // 
            this.btnClalisToneEmotionXml.Location = new System.Drawing.Point(12, 202);
            this.btnClalisToneEmotionXml.Name = "btnClalisToneEmotionXml";
            this.btnClalisToneEmotionXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneEmotionXml.TabIndex = 5;
            this.btnClalisToneEmotionXml.Text = "Clalis 口調変換＋感情付与";
            this.btnClalisToneEmotionXml.UseVisualStyleBackColor = true;
            this.btnClalisToneEmotionXml.Click += new System.EventHandler(this.btnClalisToneEmotionXml_Click);
            // 
            // btnClalisToneXml
            // 
            this.btnClalisToneXml.Location = new System.Drawing.Point(12, 156);
            this.btnClalisToneXml.Name = "btnClalisToneXml";
            this.btnClalisToneXml.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneXml.TabIndex = 4;
            this.btnClalisToneXml.Text = "Clalis 口調変換";
            this.btnClalisToneXml.UseVisualStyleBackColor = true;
            this.btnClalisToneXml.Click += new System.EventHandler(this.btnClalisToneXml_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEnd);
            this.groupBox3.Controls.Add(this.btnClalisMecabJson);
            this.groupBox3.Controls.Add(this.btnClalisWebJpImportantSentenceJson);
            this.groupBox3.Controls.Add(this.btnClalisWebJpSentenceJson);
            this.groupBox3.Controls.Add(this.btnClalisMecabPJson);
            this.groupBox3.Controls.Add(this.btnClalisWebJpJson);
            this.groupBox3.Controls.Add(this.btnClalisEmotionJson);
            this.groupBox3.Controls.Add(this.btnClalisToneEmotionJson);
            this.groupBox3.Controls.Add(this.btnClalisToneJson);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(568, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 430);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Json";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(13, 384);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(260, 40);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnClalisMecabJson
            // 
            this.btnClalisMecabJson.Location = new System.Drawing.Point(12, 18);
            this.btnClalisMecabJson.Name = "btnClalisMecabJson";
            this.btnClalisMecabJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecabJson.TabIndex = 0;
            this.btnClalisMecabJson.Text = "Clalis 形態素解析";
            this.btnClalisMecabJson.UseVisualStyleBackColor = true;
            this.btnClalisMecabJson.Click += new System.EventHandler(this.btnClalisMecabJson_Click);
            // 
            // btnClalisWebJpImportantSentenceJson
            // 
            this.btnClalisWebJpImportantSentenceJson.Location = new System.Drawing.Point(12, 340);
            this.btnClalisWebJpImportantSentenceJson.Name = "btnClalisWebJpImportantSentenceJson";
            this.btnClalisWebJpImportantSentenceJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpImportantSentenceJson.TabIndex = 8;
            this.btnClalisWebJpImportantSentenceJson.Text = "Clalis Web重要文章抽出";
            this.btnClalisWebJpImportantSentenceJson.UseVisualStyleBackColor = true;
            this.btnClalisWebJpImportantSentenceJson.Click += new System.EventHandler(this.btnClalisWebJpImportantSentenceJson_Click);
            // 
            // btnClalisWebJpSentenceJson
            // 
            this.btnClalisWebJpSentenceJson.Location = new System.Drawing.Point(12, 294);
            this.btnClalisWebJpSentenceJson.Name = "btnClalisWebJpSentenceJson";
            this.btnClalisWebJpSentenceJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpSentenceJson.TabIndex = 7;
            this.btnClalisWebJpSentenceJson.Text = "Clalis Web文章抽出";
            this.btnClalisWebJpSentenceJson.UseVisualStyleBackColor = true;
            this.btnClalisWebJpSentenceJson.Click += new System.EventHandler(this.btnClalisWebJpSentenceJson_Click);
            // 
            // btnClalisMecabPJson
            // 
            this.btnClalisMecabPJson.Location = new System.Drawing.Point(12, 64);
            this.btnClalisMecabPJson.Name = "btnClalisMecabPJson";
            this.btnClalisMecabPJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisMecabPJson.TabIndex = 2;
            this.btnClalisMecabPJson.Text = "Clalis 形態素解析＋";
            this.btnClalisMecabPJson.UseVisualStyleBackColor = true;
            this.btnClalisMecabPJson.Click += new System.EventHandler(this.btnClalisMecabPJson_Click);
            // 
            // btnClalisWebJpJson
            // 
            this.btnClalisWebJpJson.Location = new System.Drawing.Point(12, 248);
            this.btnClalisWebJpJson.Name = "btnClalisWebJpJson";
            this.btnClalisWebJpJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisWebJpJson.TabIndex = 6;
            this.btnClalisWebJpJson.Text = "Clalis Web日本語抽出";
            this.btnClalisWebJpJson.UseVisualStyleBackColor = true;
            this.btnClalisWebJpJson.Click += new System.EventHandler(this.btnClalisWebJpJson_Click);
            // 
            // btnClalisEmotionJson
            // 
            this.btnClalisEmotionJson.Location = new System.Drawing.Point(12, 110);
            this.btnClalisEmotionJson.Name = "btnClalisEmotionJson";
            this.btnClalisEmotionJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisEmotionJson.TabIndex = 3;
            this.btnClalisEmotionJson.Text = "Clalis 感情付与";
            this.btnClalisEmotionJson.UseVisualStyleBackColor = true;
            this.btnClalisEmotionJson.Click += new System.EventHandler(this.btnClalisEmotionJson_Click);
            // 
            // btnClalisToneEmotionJson
            // 
            this.btnClalisToneEmotionJson.Location = new System.Drawing.Point(12, 202);
            this.btnClalisToneEmotionJson.Name = "btnClalisToneEmotionJson";
            this.btnClalisToneEmotionJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneEmotionJson.TabIndex = 5;
            this.btnClalisToneEmotionJson.Text = "Clalis 口調変換＋感情付与";
            this.btnClalisToneEmotionJson.UseVisualStyleBackColor = true;
            this.btnClalisToneEmotionJson.Click += new System.EventHandler(this.btnClalisToneEmotionJson_Click);
            // 
            // btnClalisToneJson
            // 
            this.btnClalisToneJson.Location = new System.Drawing.Point(12, 156);
            this.btnClalisToneJson.Name = "btnClalisToneJson";
            this.btnClalisToneJson.Size = new System.Drawing.Size(260, 40);
            this.btnClalisToneJson.TabIndex = 4;
            this.btnClalisToneJson.Text = "Clalis 口調変換";
            this.btnClalisToneJson.UseVisualStyleBackColor = true;
            this.btnClalisToneJson.Click += new System.EventHandler(this.btnClalisToneJson_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "ClalisAPI C# サンプル";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClalisMecab;
        private System.Windows.Forms.Button btnClalisMecabP;
        private System.Windows.Forms.Button btnClalisEmotion;
        private System.Windows.Forms.Button btnClalisTone;
        private System.Windows.Forms.Button btnClalisToneEmotion;
        private System.Windows.Forms.Button btnClalisWebJp;
        private System.Windows.Forms.Button btnClalisWebJpSentence;
        private System.Windows.Forms.Button btnClalisWebJpImportantSentence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClalisMecabXml;
        private System.Windows.Forms.Button btnClalisWebJpImportantSentenceXml;
        private System.Windows.Forms.Button btnClalisWebJpSentenceXml;
        private System.Windows.Forms.Button btnClalisMecabPXml;
        private System.Windows.Forms.Button btnClalisWebJpXml;
        private System.Windows.Forms.Button btnClalisEmotionXml;
        private System.Windows.Forms.Button btnClalisToneEmotionXml;
        private System.Windows.Forms.Button btnClalisToneXml;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClalisMecabJson;
        private System.Windows.Forms.Button btnClalisWebJpImportantSentenceJson;
        private System.Windows.Forms.Button btnClalisWebJpSentenceJson;
        private System.Windows.Forms.Button btnClalisMecabPJson;
        private System.Windows.Forms.Button btnClalisWebJpJson;
        private System.Windows.Forms.Button btnClalisEmotionJson;
        private System.Windows.Forms.Button btnClalisToneEmotionJson;
        private System.Windows.Forms.Button btnClalisToneJson;
        private System.Windows.Forms.Button btnEnd;
    }
}

