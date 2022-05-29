# QuestBasics

OculusQuest向けの基本的なサンプル、Gaze/Laser/コントローラ入力など
基本的な使い方がまとまっているサイトがみつからず、SDK付属のサンプルもわかりやすいとはいえないため、入門者向けにまとめてみました。

こんな基本機能の実装が見たい、という要望があればissueに挙げておいてください、
気が向いたら追加します（複雑なことはやりません、あくまでSDKの基本的な使い方）

リクエストが多いようなら、より詳細な実装のしかたはそのうちQiitaなどに書くかもしれません。

## 使用機器
* Oculus Quest/Quest2  
（動作検証に使ったQuestのバージョン　39.0.0.88.xxxxxxxxxxxxx）

## Unityバージョン
* 2020.3.13.f1  
2020..3系以降であれば問題なく動くと思います  

## 使用ライブラリ
* Oculus Integration version 39.0  
<https://developer.oculus.com/downloads/package/unity-integration/>

    アセットストアのリンク  
<https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022>

  プロジェクト内に同梱しています

## 各シーンの概要
各シーンそれぞれ一つの機能しかないため理解しやすいと思います 
* _00_0 		ランチャー、このシーンからすべてのサンプルシーンに飛べます  
* _01_xx		いろいろなコントローラを表示  
* _02_xx		オブジェクトを操作する例  
* _03_xx		uGUIを操作する例  
* _04_xx		オブジェクト＋uGUIどちらも操作  
* _05_xx		コントローラーのいろいろな入力を取得  
* _06_xx		スティックの入力を利用する例  
* _07_xx		HMD側のセンサーの取得  


## 上記サンプルがうまく動かないとき
Oculus Integrationの中は現在作り変えられており、今後はOpenXRベースのAPIで開発していく、いままでのAPIはLegacyと呼ばれ今後サポート対象外になる、と発表されてます。ただいくつかの機能が、まだOpenXRベースだと不安定だったり、動かなかったりするみたいです。
上部メニューの Oculus - Tools - OpenXR から、LegacyかOpenXRベースかを切り替えられます、動かない場合はここをLegacyにしてみて下さい。


## 各シーンからランチャーシーンへのもどりかた
左ステックを押し込んだ状態で、右ステックを押し込むと、ランチャーのシーンに戻ります。


## 注意事項
* Githubからクローンする場合  
git clone https://github.com/hassydhw/OculusGoBasics.git

## ビルド時にエラーが出る場合
Oculusフォルダを削除し（Oculus Integrationがはいっているフォルダ）、アセットストアから、Oculus Ingegrationをダウンロードして取り込みなおしてみてください。
