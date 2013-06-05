﻿//=======================================================================
//  ClassName : frmClalisWebExtractJpSentenceList
//  概要      : Clalis 日本語文章抽出メソッドの使用サンプル
//
//  Clalis
//  Copyright(c) 2011-2013 LipliStyle. All Rights Reserved. 
//=======================================================================
using System;
using System.Windows.Forms;
using Clalis.Api;

namespace Clalis.Activity.SubActivitySoap
{
    public partial class frmClalisWebExtractJpSentenceList : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisWebExtractJpSentenceList
        public frmClalisWebExtractJpSentenceList()
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
            //APIの結果受け取り用クラス
            resWebSummaryList result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resWebSummaryList」クラスで結果が帰ってきます。
                result = client.clalisWebExtractJpSentenceList(txtInput.Text);
            }

            //追加前にクリアしておきます。
            dgv.Rows.Clear();

            //resWebSummaryListクラスの「resWordList」プロパティに結果が格納されています。
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
