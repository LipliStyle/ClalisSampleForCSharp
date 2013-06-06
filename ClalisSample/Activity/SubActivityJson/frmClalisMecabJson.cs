//=======================================================================
//  ClassName : frmClalisMecabJson
//  概要      : Clalis 形態素解析メソッドの使用サンプル(Json)
//
//ClalisSample
// Copyright  : 2011-2013 LipliStyle. All Rights Reserved.
// 
// ライセンス : MIT License
// ・本ソフトウェアは無保証です。作者は責任を追いません。
// ・上記の著作権表示を記載して下さい。
// ・上記の２項に同意頂ければ自由に使用して頂けます。
//
//
//本ソースはJson.NETを使用しています。
//http://james.newtonking.com/
//
//MITライセンスの元使用します。
//以下、Json.NETのライセンスの原文です。
//Copyright (c) 2007 James Newton-King
//
//Permission is hereby granted, free of charge, to any person obtaining a copy of this
//software and associated documentation files (the "Software"), to deal in the Software
//without restriction, including without limitation the rights to use, copy, modify,
//merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
//permit persons to whom the Software is furnished to do so, subject to the following
//conditions:
//
//The above copyright notice and this permission notice shall be included in all copies
//or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
//PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
//CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
//OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
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
    public partial class frmClalisMecabJson : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisMecabJson
        public frmClalisMecabJson()
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
            string jsonText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Json/clalisMecab.aspx", ps);

            //APIの結果受け取り用クラス
            resMecabResult result = JsonConvert.DeserializeObject<resMecabResult>(jsonText);

            //追加前にクリアしておく
            dgv.Rows.Clear();

            //resMecabResultクラスの「resWordList」プロパティに結果が格納されています。
            //resWordListは
            foreach (msgMecabResult msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] { msg.idx, msg.name, msg.pos, msg.pos1 });
            }

            //テキスト表示
            txtResult.Text = jsonText;
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
        /// 役割 　
        /// 形態素解析の結果
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
