//=======================================================================
//  ClassName : frmClalisTone
//  概要      : Clalis4.1 口調変換メソッドの使用サンプル
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
    public partial class frmClalisTone41 : frmClalisTone
    {
        #region コンストラクター
        public frmClalisTone41()
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
            string result;

            //Clalisに送信し、結果を得ます。
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                //「resTone」クラスで結果が帰ってきます。
                result = client.ClalisTone(txtInput.Text, txtToneUrl.Text);
            }

            //結果を入れます。
            txtResult.Text = result;
        }
    }
}
