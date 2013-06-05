﻿//=======================================================================
//  ClassName : frmClalisWebExtractJpXml
//  概要      : Clalis Web日本語抽出メソッドの使用サンプル(Xml)
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
    public partial class frmClalisWebExtractJpXml : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisWebExtractJp
        public frmClalisWebExtractJpXml()
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
            txtResult_.Text = "";
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
            string xmlText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Xml/clalisWebExtractJp.aspx", ps);

            //XMLを読み込みます。
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlText);

            //結果を入れる
            foreach (XmlNode node in xmlDoc.SelectNodes("/resWebSummary/result"))
            {
                txtResult.Text = node.InnerText;
                break;
            }

            //テキスト表示
            txtResult_.Text = xmlText;
        }
    }
}
