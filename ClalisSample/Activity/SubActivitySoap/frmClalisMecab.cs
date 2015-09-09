//=======================================================================
//  ClassName : frmClalisMecab
//  概要      : Clalis 形態素解析メソッドの使用サンプル
//
//ClalisSample
// Copyright  : 2011-2013 LipliStyle
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
    public partial class frmClalisMecab : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisMecab
        public frmClalisMecab()
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
        private virtual void run()
        {
            //APIの結果受け取り用クラス。
            resMecabResult result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resMecabResult」クラスで結果が帰ってきます。
                result = client.ClalisMecab(txtInput.Text);
            }

            //追加前にクリアしておく
            dgv.Rows.Clear();

            //resMecabResultクラスの「resWordList」プロパティに結果が格納されています。
            foreach (msgMecabResult msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] { msg.idx, msg.name, msg.pos, msg.pos1 });
            }
        }




        ///補足
        /// サンプル内で使用されているクラスについての補足説明です。
        ///
        /// ---------------------------------------------------------
        ///■resMecabResult
        /// 
        ///クラス名
        /// resMecabResult
        ///プロパティ
        /// resWordList
        ///  「msgMecabResult」の配列です。
        ///  　1個の要素が分解された形態素を表しています。
        /// 
        /// --------------------------------------------------------- 　
        ///■msgMecabResult
        /// 
        ///クラス名
        /// msgMecabResult
        ///プロパティ
        /// idx;
        /// 　形態素の追番です。
        /// name;
        ///   分解された文字です。
        /// pos;
        ///   分解された文字の品詞です。
        /// pos1;
        ///   分解された文字の品詞細分類1です。
        /// ---------------------------------------------------------
        
    }
}
