//=======================================================================
//  ClassName : frmClalisMecabJson41
//  概要      : Clalis 形態素解析メソッドの使用サンプル(Json)
//
//ClalisSample
// Copyright  : 2011-2015 LipliStyle
// 
// ライセンス : MIT License
// ・本ソフトウェアは無保証です。作者は責任を追いません。
// ・上記の著作権表示を記載して下さい。
// ・上記の２項に同意頂ければ自由に使用して頂けます。
//
//
//本ソースはJson.NETを使用しています。
//http://james.newtonking.com/
//
//MITライセンスの元使用します。
//以下、Json.NETのライセンスの原文です。
//Copyright (c) 2007 James Newton-King
//
//Permission is hereby granted, free of charge, to any person obtaining a copy of this
//software and associated documentation files (the "Software"), to deal in the Software
//without restriction, including without limitation the rights to use, copy, modify,
//merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
//permit persons to whom the Software is furnished to do so, subject to the following
//conditions:
//
//The above copyright notice and this permission notice shall be included in all copies
//or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
//PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
//CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
//OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//=======================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clalis.Activity.SubActivityJson;

namespace Clalis.Activity.SubActivityJson41
{
    public partial class frmClalisMecabJson41 : frmClalisMecabJson
    {
        ///------------------------------------
        ///URL定義
        private const string API_URL = "http://liplis.mine.nu/Clalis/v41/Json/ClalisMecab.aspx";

        public frmClalisMecabJson41():base()
        {
            InitializeComponent();
            this.url = API_URL;
            this.Text = "ClalisAPI4.1 C# サンプル JSON 形態素解析";
        }


    }
}
