//=======================================================================
//  ClassName : frmMain
//  概要      : Clalis Sample For C#
//
//
// 本サンプルを用いた結果生じた損害について、作者は責任を追いません。 
// APIの仕様、およびサンプルの内容は予告なく変更する場合があります。
// 不用意に負荷をかける用途には使用しないで下さい。
//
// 以上の点についてご了承頂ければ、
// 本サンプルは自由にご使用頂いて構いません。
//
// APIはSOAP、JSON、XMLのインターフェースを用意しています。
// お好みのものをご使用ください。
// C#の場合はSOAPがおすすめです。
//
//  Clalis
//  Copyright(c) 2011-2015 LipliStyle さちん
//=======================================================================
using System.Windows.Forms;
using System;
namespace Clalis.Activity
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region イベントハンドラ
        private void btnClalis31_Click(object sender, EventArgs e)
        {
            using (frmClalis31 f = new frmClalis31())
            {
                f.ShowDialog();
            }
        }

        private void btnClalis41_Click(object sender, EventArgs e)
        {
            using (frmClalis41 f = new frmClalis41())
            {
                f.ShowDialog();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
