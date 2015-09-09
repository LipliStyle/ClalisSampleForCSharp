//=======================================================================
//  ClassName : frmClalisEmotionJson
//  概要      : Clalis 感情付与メソッドの使用サンプル(Json)
//
//ClalisSample
// Copyright  : 2011-2013 LipliStyle
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
using Clalis.Web;
using Clalis.Api;
using Newtonsoft.Json;

namespace Clalis.Activity.SubActivityJson
{
    public partial class frmClalisEmotionJson : Form
    {
        ///------------------------------------
        ///プロパティ
        protected string url = "";

        ///------------------------------------
        ///URL定義
        private const string API_URL = "http://liplis.mine.nu/Clalis/v30/Post/Json/clalisEmotional.aspx";

        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisEmotion
        public frmClalisEmotionJson()
        {
            InitializeComponent();
            this.url = API_URL;
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
            run(this.url);
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
        protected virtual void run(string url)
        {
            //ポストデータの作成
            NameValueCollection ps = new NameValueCollection();
            ps.Add("sentence", System.Web.HttpUtility.UrlEncode(txtInput.Text, Encoding.GetEncoding("UTF-8")));        

            //結果の取得
            string jsonText = HttpPost.sendPost(url, ps);

            //APIの結果受け取り用クラス
            resEmotional result = JsonConvert.DeserializeObject<resEmotional>(jsonText);

            //追加前にクリアしておく
            dgv.Rows.Clear();

            //resEmotionalクラスの「resWordList」プロパティに結果が格納されているので、回して取り出す。
            foreach (msgLeafAndEmotion msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] {msg.name, msg.emotion, msg.point });
            }

            //テキスト表示
            txtResult.Text = jsonText;
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
        /// 役割 　
        /// 感情付与の結果
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
