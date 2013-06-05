//=======================================================================
//  ClassName : frmClalisWebExtractJpSentenceListJson
//  概要      : Clalis 日本語文章抽出メソッドの使用サンプル(Json)
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
    public partial class frmClalisWebExtractJpSentenceListJson : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisWebExtractJpSentenceListJson
        public frmClalisWebExtractJpSentenceListJson()
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
            ps.Add("url", System.Web.HttpUtility.UrlEncode(txtInput.Text, Encoding.GetEncoding("UTF-8")));

            //結果の取得
            string jsonText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Json/clalisWebExtractJpSentenceList.aspx", ps);

            //APIの結果受け取り用クラス
            resWebSummaryList result = JsonConvert.DeserializeObject<resWebSummaryList>(jsonText);

            //追加前にクリアしておく
            dgv.Rows.Clear();

            //resMecabResultクラスの「resWordList」プロパティに結果が格納されています。
            foreach (string msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] { msg });
            }

            //テキスト表示
            txtResult.Text = jsonText;
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
        /// 役割 　
        /// 日本語抽出結果
        /// 
        /// ---------------------------------------------------------
        
    }
}
