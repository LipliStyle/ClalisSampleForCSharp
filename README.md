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
Copyright © 2013 LipliStyle sachin http://liplis.mine.nu/
MIT License

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
http://liplis.mine.nu/Clalis/v30/Soap/Clalis.asmx  
名前空間(任意の名前で問題ありません。)  
Api  

以上の登録を行うと、指定した名前空間配下で、ClalisのAPIが使用出来ます。  
サンプルでは、最初から設定済みです。  
 　

