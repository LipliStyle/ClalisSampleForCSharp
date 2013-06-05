//=======================================================================
//  ClassName : frmClalisToneJson
//  概要      : Clalis 口調変換メソッドの使用サンプル(Json)
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
    public partial class frmClalisToneJson : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisToneJson
        public frmClalisToneJson()
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
            ps.Add("sentence", System.Web.HttpUtility.UrlEncode(txtInput.Text, Encoding.GetEncoding("UTF-8")));
            ps.Add("toneFileUrl", System.Web.HttpUtility.UrlEncode(txtToneUrl.Text, Encoding.GetEncoding("UTF-8")));

            //結果の取得
            string jsonText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Json/ClalisTone.aspx", ps);

            //APIの結果受け取り用クラス
            resTone result = JsonConvert.DeserializeObject<resTone>(jsonText);

            //結果を入れる
            txtResult.Text = result.result;

            //テキスト表示
            txtResult_.Text = jsonText;
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
        /// resTone
        ///  口調変換結果
        /// 役割 　
        ///  口調変換結果
        /// 
        /// ---------------------------------------------------------
    }
}
