//=======================================================================
//  ClassName : frmMain
//  概要      : Clalis Sample For C# 4.1
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clalis.Activity.SubActivityJson;
using Clalis.Activity.SubActivityJson41;

namespace Clalis.Activity
{
    public partial class frmClalis41 : Form
    {
        #region コンストラクター
        public frmClalis41()
        {
            InitializeComponent();
        }
        #endregion

        private void btnClalisMecabJson_Click(object sender, EventArgs e)
        {
            using (frmClalisMecabJson41 f = new frmClalisMecabJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisEmotionJson_Click(object sender, EventArgs e)
        {
            using (frmClalisEmotionJson41 f = new frmClalisEmotionJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneJson_Click(object sender, EventArgs e)
        {
            using (frmClalisToneJson41 f = new frmClalisToneJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneEmotionJson_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotionJson41 f = new frmClalisToneEmotionJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisMecabSoap_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotionJson41 f = new frmClalisToneEmotionJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisEmotionSoap_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotionJson41 f = new frmClalisToneEmotionJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneSoap_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotionJson41 f = new frmClalisToneEmotionJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneEmotionSoap_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotionJson41 f = new frmClalisToneEmotionJson41())
            {
                f.ShowDialog();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
