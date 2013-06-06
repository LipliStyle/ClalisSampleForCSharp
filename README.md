ClalisSampleForCSharp
=====================

ClalisをC#から使用するための簡単なサンプルです。  
ソースを読んで頂けると、APIの叩き方が分かるかと思います。  
APIはSOAP、JSON、XMLのインターフェースを用意しています。  
お好みのものをご使用ください。C#の場合はSOAPがおすすめです。  
下の方で、各画面とその使い方を簡単に説明しています。

動作環境
------
ソースやサンプルのプロジェクトを開くにはVisualStudio2010が必要です。  
また、サンプルプログラムの実行には.netFramwwork4.0が必要です。  
　
　
ライセンス
------
 Copyright  : 2013 LipliStyle. All Rights Reserved.
 
 ライセンス : MIT License  
 ・本ソフトウェアは無保証です。作者は責任を追いません。  
 ・上記の著作権表示を記載して下さい。  
 ・上記の２項に同意頂ければ自由に使用して頂けます。  

使用ライブラリ
-------
本サンプルではJsonのパースに「Json.net」を使用しています。
http://james.newtonking.com/projects/json-net.aspx

ご注意
------
ソースコードの使用はライセンスに基づく通りですが、
Clalisサーバーに不用意に負荷をかける用途には使用しないで下さい。    

サンプルの紹介と解説  
------ 
プログラムを起動すると、以下のコントール画面が表示されます。
 APIのインターフェースとして、SAOP、JSON、XMLを用意しています。  
各ボタンを押すと、サンプルの画面を起動できます。  
* ![picUi](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/1.gif "UI")

サービス参照の追加
------
C#からClalisのSOAPメソッドを使用するには、設定が必要です。  
 VisualStudioにて、プロジェクトを作成、または開きます。  
 「ServiceReference」を右クリックし、「サービス参照の追加」を押します。  
* ![picService1](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/serveice1.gif "UI")  

サービス参照の追加のウインドウが開くので、以下のとおり入力します。  
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/serveice2.gif "UI")  
アドレス  
`http://liplis.mine.nu/Clalis/v30/Soap/Clalis.asmx`  
名前空間(任意の名前で問題ありません。)  
`Api`  

以上の登録を行うと、指定した名前空間配下で、ClalisのAPIが使用出来ます。  
サンプルでは、最初から設定済みです。  
 　

形態素解析 ClalisMecab
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/2.gif "UI") 

■概要  
対象の日本語の文章を形態素解析して、単語に分解します。  
サンプルでは、テキストボックスに入力した文字列を形態素解析し、  
データグリッドに表示する処理になっています。  

このメソッドは、日本語の分解結果と品詞のみを返します。  
単純に文章を形態素に分解するだけであれば、本メソッドが有効です。  
情報が足りない場合は、ClalisMecabPlusメソッドの使用を検討してください。  

サーバーサイドで形態素解析器「Mecab」を使用しています。  
Mecabについては下記アドレスを参照下さい。  
https://code.google.com/p/mecab/

■サンプル  

        private void run()
        {
            resMecabResult result;
     
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisMecab(txtInput.Text);
            }
     
            dgv.Rows.Clear();
     
            foreach (msgMecabResult msg in result.resWordList)
            {
                dgv.Rows.Add(new object[] { msg.idx, msg.name, msg.pos, msg.pos1 });
            }
        }
　
形態素解析 ClalisMecabPlus
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/3.gif "UI") 

■概要  
このメソッドはMecabが返してくる全ての情報を取得します。  
サンプルでは、テキストボックスに入力した文字列を形態素解析し、  
データグリッドに表示する処理になっています。  

■サンプル  

        private void run()
        {
            resMecabResultFull result;
     
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisMecabFull(txtInput.Text);
            }
      
            dgv.Rows.Clear();
     
            foreach (msgMecabResultFull msg in result.resWordList)
            {
                dgv.Rows.Add(new object[] { msg.idx, msg.name, msg.pos, msg.pos1 ,msg.pos2,msg.pos3, msg.infetted1, msg.infetted2, msg.prototype, msg.read, msg.pronunciation});
            }
        }
　
感情付与 ClalisEmotional
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/4.gif "UI")

■概要  
対象の文章にメタ感情を付与して結果を返します。  
サンプルでは、テキストボックスに入力した文字列を感情付与し、  
データグリッドに表示する処理になっています。  

■サンプル  

        private void run()
        {
            resEmotional result;
     
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisEmotional(txtInput.Text);
            }
     
            dgv.Rows.Clear();
      
            foreach (msgLeafAndEmotion msg in result.resWordList)
            {
                dgv.Rows.Add(new object[] {msg.name, msg.emotion, msg.point });
            }
        }
　
**口調変換 ClalisTone
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/5.gif "UI")

■概要
対象の文章を口調変換ルールファイルに従って変換します。
サンプルでは、テキストボックスに入力した文字列を口調変換し、
テキストボックスに表示する処理になっています。

■サンプル  

        private void run()
        {
            resTone result;
     
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisTone(txtInput.Text, txtToneUrl.Text);
            }
     
            txtResult.Text = result.result;
        }
　
　
口調変換+感情付与 ClalisToneEmotion
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/6.gif "UI")

■概要  
対象の文章を口調変換ルールファイルに従って変換します。  
さらに、感情付与を行います。  
サンプルでは、テキストボックスに入力した文字列を口調変換し、  
データグリッドに表示する処理になっています。  

■サンプル  

        private void run()
        {
            resEmotional result;
     
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisToneEmotional(txtInput.Text, txtToneUrl.Text);
            }
     
            dgv.Rows.Clear();
     
            foreach (msgLeafAndEmotion msg in result.resWordList)
            {
                dgv.Rows.Add(new object[] {msg.name, msg.emotion, msg.point });
            }
        }
　
Web日本語抽出 ClalisWebExtractJp
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/7.gif "UI")

■概要  
対象のURLのサイトから日本語を抽出して返します。
サンプルでは、テキストボックスに入力したURLから日本語抽出し、
テキストボックスに表示する処理になっています。

■サンプル  

        private void run()
        {
            resWebSummary result;
      
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisWebExtractJp(txtInput.Text);
            }
     
            txtResult.Text = result.result;
        }

　
　
Web日本語文章抽出 ClalisWebExtractJpSentenceList
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/8.gif "UI")

■概要  
対象のURLのサイトから日本語を文章ごとに抽出して返します。  
サンプルでは、テキストボックスに入力したURLから日本語文章を抽出し、  
データグリッドに表示する処理になっています。  

■サンプル  

        private void run()
        {
            resWebSummaryList result;
     
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisWebExtractJpSentenceList(txtInput.Text);
            }
     
            dgv.Rows.Clear();
     
            foreach (string msg in result.resWordList)
            {
                dgv.Rows.Add(new object[] { msg });
            }
        }
　
Web日本語重要文章抽出 ClalisWebExtractJpSentenceRelevanceList
------
* ![picService2](http://liplis.mine.nu/lipliswiki/webroot/image/common/ClalisSample/CS/9.gif "UI")

■概要  
対象のURLのサイトから日本語を文章ごとに抽出し、  
重要な文章の順番にソートして返します。  
サンプルでは、テキストボックスに入力したURLから日本語文章を抽出し、  
データグリッドに表示する処理になっています。  

■サンプル  

        private void run()
        {
            resWebSummaryList result;
     
            using (ClalisSoapClient client = new ClalisSoapClient())
            {
                result = client.clalisWebExtractJpSentenceRelevanceList(txtInput.Text);
            }
     
            dgv.Rows.Clear();
     
            foreach (string msg in result.resWordList)
            {
                dgv.Rows.Add(new object[] { msg });
            }
        }


