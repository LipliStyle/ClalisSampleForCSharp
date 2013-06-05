﻿//=======================================================================
//  ClassName : frmClalisMecabXml
//  概要      : Clalis 形態素解析＋メソッドの使用サンプル(Xml)
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
    public partial class frmClalisMecabPlusXml : Form
    {
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisMecabPlus
        public frmClalisMecabPlusXml()
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
            string xmlText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Xml/clalisMecabFull.aspx", ps);

            //追加前にクリアしておきます。
            dgv.Rows.Clear();

            //XMLを読み込みます。
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlText);

            //読み込んだノードリストからデータグリッドに登録します。
            foreach (XmlNode node in xmlDoc.SelectNodes("/resMecabResultFull/resWordList/msgMecabResultFull"))
            {
                dgv.Rows.Add(new object[] { node.ChildNodes[0].InnerText, node.ChildNodes[1].InnerText, node.ChildNodes[2].InnerText, node.ChildNodes[3].InnerText, node.ChildNodes[4].InnerText, node.ChildNodes[5].InnerText, node.ChildNodes[6].InnerText, node.ChildNodes[7].InnerText, node.ChildNodes[8].InnerText, node.ChildNodes[9].InnerText, node.ChildNodes[10].InnerText });
            }

            //テキスト表示
            txtResult.Text = xmlText;
        }
    }
}
