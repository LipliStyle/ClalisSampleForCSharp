namespace Clalis.Activity.SubActivitySoap
{
    partial class frmClalisMecab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCtl = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpCtl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 15);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(703, 48);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "今日はお天気がいいですね。お洗濯にはもってこいです！";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Location = new System.Drawing.Point(0, 0);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(784, 66);
            this.grpInput.TabIndex = 3;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "文章入力";
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
            this.grpResult.Controls.Add(this.dgv);
            this.grpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResult.Location = new System.Drawing.Point(0, 66);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(784, 496);
            this.grpResult.TabIndex = 4;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "結果";
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.word,
            this.pos,
            this.pos1});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 15);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 21;
            this.dgv.Size = new System.Drawing.Size(778, 478);
            this.dgv.TabIndex = 1;
            // 
            // idx
            // 
            this.idx.HeaderText = "";
            this.idx.Name = "idx";
            // 
            // word
            // 
            this.word.HeaderText = "単語";
            this.word.Name = "word";
            // 
            // pos
            // 
            this.pos.HeaderText = "品詞";
            this.pos.Name = "pos";
            // 
            // pos1
            // 
            this.pos1.HeaderText = "品詞細分類1";
            this.pos1.Name = "pos1";
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
            // frmClalisMecab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpCtl);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpInput);
            this.Name = "frmClalisMecab";
            this.Text = "ClalisAPI C# サンプル SOAP 形態素解析";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpCtl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox txtInput;
        protected System.Windows.Forms.GroupBox grpInput;
        protected System.Windows.Forms.Button btnRun;
        protected System.Windows.Forms.GroupBox grpResult;
        protected System.Windows.Forms.GroupBox grpCtl;
        protected System.Windows.Forms.Button btnCrear;
        protected System.Windows.Forms.Button btnEnd;
        protected System.Windows.Forms.DataGridView dgv;
        protected System.Windows.Forms.DataGridViewTextBoxColumn idx;
        protected System.Windows.Forms.DataGridViewTextBoxColumn word;
        protected System.Windows.Forms.DataGridViewTextBoxColumn pos;
        protected System.Windows.Forms.DataGridViewTextBoxColumn pos1;

    }
}