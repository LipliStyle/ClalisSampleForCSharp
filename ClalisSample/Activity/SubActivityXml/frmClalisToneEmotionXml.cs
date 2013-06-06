//=======================================================================
//  ClassName : frmClalisToneEmotionXml
//  概要      : Clalis 口調変換＋感情付与メソッドの使用サンプル(Xml)
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
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;
using Clalis.Web;
using System.Xml;

namespace Clalis.Activity.SubActivityXml
{
    public partial class frmClalisToneEmotionXml : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisToneEmotion
        public frmClalisToneEmotionXml()
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
            ps.Add("toneFileUrl", System.Web.HttpUtility.UrlEncode(txtToneUrl.Text, Encoding.GetEncoding("UTF-8")));

            //結果の取得
            string xmlText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Xml/clalisToneEmotional.aspx", ps);

            //追加前にクリアしておきます。
            dgv.Rows.Clear();

            //XMLを読み込みます。
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlText);

            //読み込んだノードリストからデータグリッドに登録します。
            foreach (XmlNode node in xmlDoc.SelectNodes("/resEmotional/resWordList/msgLeafAndEmotion"))
            {
                dgv.Rows.Add(new object[] { node.ChildNodes[0].InnerText, node.ChildNodes[1].InnerText, node.ChildNodes[2].InnerText });
            }

            //テキスト表示
            txtResult.Text = xmlText;
        }
    }
}
