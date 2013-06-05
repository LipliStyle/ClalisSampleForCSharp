//=======================================================================
//  ClassName : frmClalisWebExtractJpSentenceListXml
//  概要      : Clalis 日本語文章抽出メソッドの使用サンプル(Xml)
//
//  Clalis
//  Copyright(c) 2011-2013 LipliStyle. All Rights Reserved. 
//=======================================================================
using System;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;
using Clalis.Web;
using System.Xml;

namespace Clalis.Activity.SubActivityXml
{
    public partial class frmClalisWebExtractJpSentenceListXml : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisWebExtractJpSentenceList
        public frmClalisWebExtractJpSentenceListXml()
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
            string xmlText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Xml/clalisWebExtractJpSentenceList.aspx", ps);

            //追加前にクリアしておきます。
            dgv.Rows.Clear();

            //XMLを読み込みます。
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlText);

            //読み込んだノードリストからデータグリッドに登録します。
            foreach (XmlNode node in xmlDoc.SelectNodes("/resWebSummaryList/resWordList/string"))
            {
                dgv.Rows.Add(new object[] { node.InnerText });
            }

            //テキスト表示
            txtResult.Text = xmlText;
        }
    }
}
