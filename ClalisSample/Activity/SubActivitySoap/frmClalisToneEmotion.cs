﻿//=======================================================================
//  ClassName : frmClalisToneEmotion
//  概要      : Clalis 口調変換＋感情付与メソッドの使用サンプル
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
    public partial class frmClalisToneEmotion : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisToneEmotion
        public frmClalisToneEmotion()
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
            resEmotional result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resEmotional」クラスで結果が帰ってきます。
                result = client.clalisToneEmotional(txtInput.Text, txtToneUrl.Text);
            }

            //追加前にクリアしておきます。
            dgv.Rows.Clear();

            //resMecabResultクラスの「resWordList」プロパティに結果が格納されています。
            foreach (msgLeafAndEmotion msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] {msg.name, msg.emotion, msg.point });
            }
        }

        ///補足
        /// サンプル内で使用されているクラスについての補足説明です。
        ///
        /// ---------------------------------------------------------
        ///■resEmotional
        /// 
        ///クラス名
        /// resEmotional
        ///プロパティ
        /// resWordList
        ///  「msgLeafAndEmotion」の配列です。
        ///  　1個の要素が分解された文字を表しています。
        ///  　その文字に対応した感情値および感情ポイントを保持しています。
        /// 
        /// --------------------------------------------------------- 　
        ///■msgLeafAndEmotion
        /// 
        ///クラス名
        /// msgLeafAndEmotion
        ///プロパティ
        /// name;
        ///   分解された文字です。
        /// emotion;
        ///   分解された文字の感情です。
        /// point;
        ///   分解された文字の感情値です。
        /// ---------------------------------------------------------
    }
}
