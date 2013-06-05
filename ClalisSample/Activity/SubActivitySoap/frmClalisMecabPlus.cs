//=======================================================================
//  ClassName : frmClalisMecabPlus
//  概要      : Clalis 形態素解析＋メソッドの使用サンプル
//
//  Clalis
//  Copyright(c) 2011-2013 LipliStyle. All Rights Reserved. 
//=======================================================================
using System;
using System.Windows.Forms;
using Clalis.Api;

namespace Clalis.Activity.SubActivitySoap
{
    public partial class frmClalisMecabPlus : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisMecabPlus
        public frmClalisMecabPlus()
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
            resMecabResultFull result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resMecabResultFull」クラスで結果が帰ってきます。
                result = client.clalisMecabFull(txtInput.Text);
            }

            //追加前にクリアしておきます。
            dgv.Rows.Clear();

            //resMecabResultクラスの「resWordList」プロパティに結果が格納されています。
            foreach (msgMecabResultFull msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] { msg.idx, msg.name, msg.pos, msg.pos1 ,msg.pos2,msg.pos3, msg.infetted1, msg.infetted2, msg.prototype, msg.read, msg.pronunciation});
            }
        }




        ///補足
        /// サンプル内で使用されているクラスについての補足説明です。
        ///
        /// ---------------------------------------------------------
        ///■resMecabResultFull
        /// 
        ///クラス名
        /// resMecabResultFull
        ///プロパティ
        /// resWordList
        ///  「msgMecabResultFull」の配列です。
        ///  　1個の要素が分解された形態素を表しています。
        /// 
        /// --------------------------------------------------------- 　
        ///■msgMecabResultFull
        /// 
        ///クラス名
        /// msgMecabResultFull
        ///プロパティ
        /// idx;
        /// 　形態素の追番です。
        /// name;
        ///   分解された文字です。
        /// pos;
        ///   分解された文字の品詞です。
        /// pos1;
        ///   分解された文字の品詞細分類1です。
        /// pos2;
        ///   分解された文字の品詞細分類2です。
        /// pos3;
        ///   分解された文字の品詞細分類3です。
        /// infetted1;
        ///   分解された文字の活用形です。
        /// infetted2
        ///   分解された文字の活用形です。
        /// prototype
        ///   分解された文字の原形です。
        /// read
        ///   分解された文字の読みです。
        /// pronunciation
        ///   解された文字の発音です。
        /// ---------------------------------------------------------
        /// 


        


    }
}
