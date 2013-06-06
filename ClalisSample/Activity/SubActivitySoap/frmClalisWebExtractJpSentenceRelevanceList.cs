//=======================================================================
//  ClassName : frmClalisWebExtractJpSentenceList
//  概要      : Clalis 日本語文章抽出メソッドの使用サンプル
//
//ClalisSample
// Copyright  : 2011-2013 LipliStyle. All Rights Reserved.
// 
// ライセンス : MIT License
// ・本ソフトウェアは無保証です。作者は責任を追いません。
// ・上記の著作権表示を記載して下さい。
// ・上記の２項に同意頂ければ自由に使用して頂けます。
//=======================================================================
using System;
using System.Windows.Forms;
using Clalis.Api;

namespace Clalis.Activity.SubActivitySoap
{
    public partial class frmClalisWebExtractJpSentenceRelevanceList : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisWebExtractJpSentenceRelevanceList
        public frmClalisWebExtractJpSentenceRelevanceList()
        {
            InitializeComponent();
        }
        #endregion
        
        #region イベントハンドラ

        /// <summary>
        /// 実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            run();
        }

        /// <summary>
        /// クリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            dgv.Rows.Clear();
        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        /// <summary>
        /// 実行サンプル
        /// </summary>
        private void run()
        {
            //APIの結果受け取り用クラス。
            resWebSummaryList result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resMecabResult」クラスで結果が帰ってきます。
                result = client.clalisWebExtractJpSentenceRelevanceList(txtInput.Text);
            }

            //追加前にクリアしておきます。
            dgv.Rows.Clear();

            //resMecabResultクラスの「resWordList」プロパティに結果が格納されています。
            foreach (string msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] { msg });
            }
        }




        ///補足
        /// サンプル内で使用されているクラスについての補足説明です。
        ///
        /// ---------------------------------------------------------
        ///■resWebSummaryList
        /// 
        ///クラス名
        /// resWebSummaryList
        ///プロパティ
        /// resWordList
        ///  「string」の配列です。
        ///  　1個の要素が抽出された文章の1文になります。
        /// 
        /// ---------------------------------------------------------
        
    }
}
