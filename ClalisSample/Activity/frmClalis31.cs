//=======================================================================
//  ClassName : frmMain
//  概要      : Clalis Sample For C# 3.1
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
using System.Windows.Forms;
using Clalis.Activity.SubActivityJson;
using Clalis.Activity.SubActivitySoap;
using Clalis.Activity.SubActivityXml;

namespace Clalis.Activity
{
    public partial class frmClalis31 : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region コンストラクター
        public frmClalis31()
        {
            InitializeComponent();
        }
        #endregion
        
        #region SOAP

        /// <summary>
        /// 形態素解析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisMecab_Click(object sender, EventArgs e)
        {
            using (frmClalisMecab f = new frmClalisMecab())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// 形態素解析プラス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisMecabP_Click(object sender, EventArgs e)
        {
            using (frmClalisMecabPlus f = new frmClalisMecabPlus())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// 感情付与
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisEmotion_Click(object sender, EventArgs e)
        {
            using (frmClalisEmotion f = new frmClalisEmotion())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// 口調変換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisTone_Click(object sender, EventArgs e)
        {
            using (frmClalisTone f = new frmClalisTone())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// 口調変換＋感情付与
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisToneEmotion_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotion f = new frmClalisToneEmotion())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// ウェブ要約日本語抽出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisWebJp_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJp f = new frmClalisWebExtractJp())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// ウェブ要約日本語文章抽出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisWebJpSentence_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpSentenceList f = new frmClalisWebExtractJpSentenceList())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// ウェブ要約日本語抽出重要文章ソート
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClalisWebJpImportantSentence_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpSentenceRelevanceList f = new frmClalisWebExtractJpSentenceRelevanceList())
            {
                f.ShowDialog();
            }
        }

        #endregion

        #region XML
        private void btnClalisMecabXml_Click(object sender, EventArgs e)
        {
            using (frmClalisMecabXml f = new frmClalisMecabXml())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisMecabPXml_Click(object sender, EventArgs e)
        {
            using (frmClalisMecabPlusXml f = new frmClalisMecabPlusXml())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisEmotionXml_Click(object sender, EventArgs e)
        {
            using (frmClalisEmotionXml f = new frmClalisEmotionXml())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneXml_Click(object sender, EventArgs e)
        {
            using (frmClalisToneXml f = new frmClalisToneXml())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneEmotionXml_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotionXml f = new frmClalisToneEmotionXml())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisWebJpXml_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpXml f = new frmClalisWebExtractJpXml())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisWebJpSentenceXml_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpSentenceListXml f = new frmClalisWebExtractJpSentenceListXml())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisWebJpImportantSentenceXml_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpSentenceListXml f = new frmClalisWebExtractJpSentenceListXml())
            {
                f.ShowDialog();
            }
        }
        #endregion

        #region Json
        private void btnClalisMecabJson_Click(object sender, EventArgs e)
        {
            using (frmClalisEmotionJson f = new frmClalisEmotionJson())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisMecabPJson_Click(object sender, EventArgs e)
        {
            using (frmClalisMecabPlusJson f = new frmClalisMecabPlusJson())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisEmotionJson_Click(object sender, EventArgs e)
        {
            using (frmClalisEmotionJson f = new frmClalisEmotionJson())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneJson_Click(object sender, EventArgs e)
        {
            using (frmClalisToneJson f = new frmClalisToneJson())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisToneEmotionJson_Click(object sender, EventArgs e)
        {
            using (frmClalisToneEmotionJson f = new frmClalisToneEmotionJson())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisWebJpJson_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpJson f = new frmClalisWebExtractJpJson())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisWebJpSentenceJson_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpSentenceListJson f = new frmClalisWebExtractJpSentenceListJson())
            {
                f.ShowDialog();
            }
        }

        private void btnClalisWebJpImportantSentenceJson_Click(object sender, EventArgs e)
        {
            using (frmClalisWebExtractJpSentenceListJson f = new frmClalisWebExtractJpSentenceListJson())
            {
                f.ShowDialog();
            }
        }
        #endregion

        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 終了ボタン
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
