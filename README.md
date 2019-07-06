# プロジェクト名をここに

## 使用機器
* 
* 

## Unityバージョン
* 

## 使用ライブラリ
* 例：ライブラリ名、バージョン、URL　SteamVR Plugin v1.2.3 http://u3d.as/cjo
* 

## git の設定

### コミット時の自動コードフォーマット

コミット時にフォーマットを掛けて、ファイルに差分があるとコミットを止めてくれるスクリプトが入っています。

```
cp BuildFiles/git/hooks/pre-commit .git/hooks/pre-commit
```

### 改行コードをそろえる

スクリプトファイルの改行コードを git に取り込む時に LF にそろえる設定です。

```
git config core.autocrlf input
```

### 空白対応

余計な空白を入れない設定です。

```
git config filter.stripspace.clean git-stripspace
```
