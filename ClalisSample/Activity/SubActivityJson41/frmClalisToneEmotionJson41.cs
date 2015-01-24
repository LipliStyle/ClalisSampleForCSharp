//=======================================================================
//  ClassName : frmClalisToneEmotionJson41
//  概要      : Clalis 口調変換＋感情付与メソッドの使用サンプル(Json)
//
//ClalisSample
// Copyright  : 2011-2015 LipliStyle
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
using System.Collections.Specialized;
using System.Text;
using Clalis.Activity.SubActivityJson;
using Clalis.Api;
using Clalis.Web;
using Newtonsoft.Json;

namespace Clalis.Activity.SubActivityJson41
{
    public partial class frmClalisToneEmotionJson41 : frmClalisToneEmotionJson
    {
        ///------------------------------------
        ///URL定義
        private const string API_URL = "http://liplis.mine.nu/Clalis/v41/Json/ClalisToneEmotional.aspx";

        public frmClalisToneEmotionJson41()
        {
            InitializeComponent();
            this.url = API_URL;
            this.Text = "ClalisAPI4.1 C# サンプル JSON 口調変換＋感情付与";
        }

        /// <summary>
        /// 実行サンプル
        /// </summary>
        protected override void run(string url)
        {
            //ポストデータの作成
            NameValueCollection ps = new NameValueCollection();
            ps.Add("sentence", System.Web.HttpUtility.UrlEncode(txtInput.Text, Encoding.GetEncoding("UTF-8")));
            ps.Add("tone", System.Web.HttpUtility.UrlEncode(txtToneUrl.Text, Encoding.GetEncoding("UTF-8")));

            //結果の取得
            string jsonText = HttpPost.sendPost(url, ps);

            //APIの結果受け取り用クラス
            string result = JsonConvert.DeserializeObject<string>(jsonText);

            //追加前にクリアしておく
            dgv.Rows.Clear();

            //1語の区切りがコロン
            string[] bufList = result.Split(';');

            //resEmotionalクラスの「resWordList」プロパティに結果が格納されています。
            foreach (string msg in bufList)
            {
                //1語の対象語、感情値、レベルはカンマ区切りで表現されている。
                string[] buf = msg.Split(',');

                if (buf.Length == 3)
                {
                    //1個づつ取り出してデータグリッドに入れています。
                    dgv.Rows.Add(new object[] { buf[0], buf[1], buf[2] });
                }
            }

            //テキスト表示
            txtResult.Text = jsonText;
        }
    }
}
