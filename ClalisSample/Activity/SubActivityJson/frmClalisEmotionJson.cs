//=======================================================================
//  ClassName : frmClalisEmotionJson
//  概要      : Clalis 感情付与メソッドの使用サンプル(Json)
//
//  Clalis
//  Copyright(c) 2011-2013 LipliStyle. All Rights Reserved. 
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
        /// <summary>
        /// コンストラクター
        /// </summary>
        #region frmClalisEmotion
        public frmClalisEmotionJson()
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
            string jsonText = HttpPost.sendPost("http://liplis.mine.nu/Clalis/v30/Post/Json/clalisEmotional.aspx", ps);

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
