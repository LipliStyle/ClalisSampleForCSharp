//=======================================================================
//  ClassName : frmClalisWebExtractJpJson
//  概要      : Clalis Web日本語抽出メソッドの使用サンプル(Json)
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
    public partial class frmClalisWebExtractJpJson : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisWebExtractJpJson
        public frmClalisWebExtractJpJson()
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
            txtResult_.Text = "";
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
            //ポストデータの作成
            NameValueCollection ps = new NameValueCollection();
            ps.Add("url", System.Web.HttpUtility.UrlEncode(txtInput.Text, Encoding.GetEncoding("UTF-8")));

            //結果の取得
            string jsonText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Json/clalisWebExtractJp.aspx", ps);

            //APIの結果受け取り用クラス
            resWebSummary result = JsonConvert.DeserializeObject<resWebSummary>(jsonText);

            //結果をテキストボックスに貼り付け
            txtResult.Text = result.result;

            //テキスト表示
            txtResult_.Text = jsonText;
        }

        ///補足
        /// サンプル内で使用されているクラスについての補足説明です。
        ///
        /// ---------------------------------------------------------
        ///■resWebSummary
        /// 
        ///クラス名
        /// resWebSummary
        ///プロパティ
        /// result
        /// 　日本語の抽出結果。
        /// 役割 　
        /// 　日本語の抽出結果を格納
        /// 
        /// ---------------------------------------------------------
    }
}
