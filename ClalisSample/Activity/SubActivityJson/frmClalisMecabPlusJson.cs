﻿//=======================================================================
//  ClassName : frmClalisMecabJson
//  概要      : Clalis 形態素解析＋メソッドの使用サンプル(Json)
//
//  Clalis
//  Copyright(c) 2011-2013 LipliStyle. All Rights Reserved. 
//=======================================================================
using System;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;
using Clalis.Api;
using Clalis.Web;
using Newtonsoft.Json;

namespace Clalis.Activity.SubActivityJson
{
    public partial class frmClalisMecabPlusJson : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisMecabPlusJson
        public frmClalisMecabPlusJson()
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
            txtResult.Text = "";
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
            //ポストデータの作成
            NameValueCollection ps = new NameValueCollection();
            ps.Add("sentence", System.Web.HttpUtility.UrlEncode(txtInput.Text, Encoding.GetEncoding("UTF-8")));

            //結果の取得
            string jsonText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Json/clalisMecabFull.aspx", ps);

            //APIの結果受け取り用クラス
            resMecabResultFull result = JsonConvert.DeserializeObject<resMecabResultFull>(jsonText);

            //追加前にクリアしておく
            dgv.Rows.Clear();

            //resMecabResultFullクラスの「resWordList」プロパティに結果が格納されています。
            //resWordListは
            foreach (msgMecabResultFull msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] { msg.idx, msg.name, msg.pos, msg.pos1 ,msg.pos2,msg.pos3, msg.infetted1, msg.infetted2, msg.prototype, msg.read, msg.pronunciation});
            }

            //テキスト表示
            txtResult.Text = jsonText;
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
        ///  「resMecabResultFull」の配列です。
        ///  　1個の要素が分解された形態素を表しています。
        /// 役割 　
        /// 形態素解析の結果
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
