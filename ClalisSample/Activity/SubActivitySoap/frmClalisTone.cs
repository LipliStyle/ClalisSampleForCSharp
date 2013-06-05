//=======================================================================
//  ClassName : frmClalisTone
//  概要      : Clalis 口調変換メソッドの使用サンプル
//
//  Clalis
//  Copyright(c) 2011-2013 LipliStyle. All Rights Reserved. 
//=======================================================================
using System;
using System.Windows.Forms;
using Clalis.Api;

namespace Clalis.Activity.SubActivitySoap
{
    public partial class frmClalisTone : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisEmotion
        public frmClalisTone()
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
            txtToneUrl.Text = "";
            txtResult.Text = "";
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
            resTone result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resTone」クラスで結果が帰ってきます。
                result = client.clalisTone(txtInput.Text, txtToneUrl.Text);
            }

            //結果を入れます。
            txtResult.Text = result.result;
        }

        ///補足
        /// サンプル内で使用されているクラスについての補足説明です。
        ///
        /// ---------------------------------------------------------
        ///■resTone
        /// 
        ///クラス名
        /// resTone
        ///プロパティ
        /// result
        ///  口調変換結果
        /// 
        /// ---------------------------------------------------------
    }
}
