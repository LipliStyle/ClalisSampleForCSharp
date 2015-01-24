//=======================================================================
//  ClassName : frmClalisEmotion41
//  概要      : Clalis4.1 感情付与メソッドの使用サンプル
//
//ClalisSample
// Copyright  : 2011-2015 LipliStyle
// 
// ライセンス : MIT License
// ・本ソフトウェアは無保証です。作者は責任を追いません。
// ・上記の著作権表示を記載して下さい。
// ・上記の２項に同意頂ければ自由に使用して頂けます。
//=======================================================================
using Clalis.Activity.SubActivitySoap;
using Clalis.Api41;

namespace Clalis.Activity.SubActivitySoap41
{
    public partial class frmClalisEmotion41 : frmClalisEmotion
    {
        #region コンストラクター
        public frmClalisEmotion41()
        {
            InitializeComponent();
        }
        #endregion
        
        /// <summary>
        /// 実行サンプル
        /// </summary>
        protected virtual void run()
        {
            //APIの結果受け取り用クラス。
            string result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resEmotional」クラスで結果が帰ってきます。
                result = client.ClalisEmotional(txtInput.Text);
            }

            //追加前にクリアしておきます。
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
        }
    }
}
