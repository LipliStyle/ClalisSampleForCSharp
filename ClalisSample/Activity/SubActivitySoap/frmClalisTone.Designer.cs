namespace Clalis.Activity.SubActivitySoap
{
    partial class frmClalisTone
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.spl = new System.Windows.Forms.SplitContainer();
            this.txtToneUrl = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpCtl = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl)).BeginInit();
            this.spl.Panel1.SuspendLayout();
            this.spl.Panel2.SuspendLayout();
            this.spl.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.grpCtl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(703, 25);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "今日はお天気がいい。お洗濯にはもってこいだ。";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.spl);
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Location = new System.Drawing.Point(0, 0);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(784, 66);
            this.grpInput.TabIndex = 3;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "文章入力";
            // 
            // spl
            // 
            this.spl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl.Location = new System.Drawing.Point(3, 15);
            this.spl.Name = "spl";
            this.spl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spl.Panel1
            // 
            this.spl.Panel1.Controls.Add(this.txtInput);
            // 
            // spl.Panel2
            // 
            this.spl.Panel2.Controls.Add(this.txtToneUrl);
            this.spl.Size = new System.Drawing.Size(703, 48);
            this.spl.SplitterDistance = 25;
            this.spl.TabIndex = 2;
            // 
            // txtToneUrl
            // 
            this.txtToneUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToneUrl.Location = new System.Drawing.Point(0, 0);
            this.txtToneUrl.Name = "txtToneUrl";
            this.txtToneUrl.Size = new System.Drawing.Size(703, 19);
            this.txtToneUrl.TabIndex = 1;
            this.txtToneUrl.Text = "http://liplis.mine.nu/xml/Tone/LiplisLili.xml";
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRun.Location = new System.Drawing.Point(706, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 48);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "実行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResult.Location = new System.Drawing.Point(0, 66);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(784, 496);
            this.grpResult.TabIndex = 4;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "結果";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 15);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(778, 478);
            this.txtResult.TabIndex = 0;
            // 
            // grpCtl
            // 
            this.grpCtl.Controls.Add(this.btnCrear);
            this.grpCtl.Controls.Add(this.btnEnd);
            this.grpCtl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpCtl.Location = new System.Drawing.Point(0, 520);
            this.grpCtl.Name = "grpCtl";
            this.grpCtl.Size = new System.Drawing.Size(784, 42);
            this.grpCtl.TabIndex = 5;
            this.grpCtl.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCrear.Location = new System.Drawing.Point(3, 15);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 24);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "クリア";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnd.Location = new System.Drawing.Point(706, 15);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 24);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmClalisTone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpCtl);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpInput);
            this.Name = "frmClalisTone";
            this.Text = "ClalisAPI C# サンプル SOAP 口調変換";
            this.grpInput.ResumeLayout(false);
            this.spl.Panel1.ResumeLayout(false);
            this.spl.Panel1.PerformLayout();
            this.spl.Panel2.ResumeLayout(false);
            this.spl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl)).EndInit();
            this.spl.ResumeLayout(false);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpCtl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.GroupBox grpCtl;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.SplitContainer spl;
        private System.Windows.Forms.TextBox txtToneUrl;
        private System.Windows.Forms.TextBox txtResult;
    }
}