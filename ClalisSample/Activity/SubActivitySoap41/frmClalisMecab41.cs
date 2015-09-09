//=======================================================================
//  ClassName : frmClalisMecab41
//  概要      : Clalis 形態素解析メソッドの使用サンプル
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
    public partial class frmClalisMecab41 : frmClalisMecab
    {
        #region コンストラクター
        public frmClalisMecab41()
        {
            InitializeComponent();
        }
        #endregion
        
        /// <summary>
        /// 実行サンプル
        /// </summary>
        private override void run()
        {
            //APIの結果受け取り用クラス。
            resMecabResult result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resMecabResult」クラスで結果が帰ってきます。
                result = client.ClalisMecab(txtInput.Text);
            }

            //追加前にクリアしておく
            dgv.Rows.Clear();

            //resMecabResultクラスの「resWordList」プロパティに結果が格納されています。
            foreach (msgMecabResult msg in result.resWordList)
            {
                //1個づつ取り出してデータグリッドに入れています。
                dgv.Rows.Add(new object[] { msg.idx, msg.name, msg.pos, msg.pos1 });
            }
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
