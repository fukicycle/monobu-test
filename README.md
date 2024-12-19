# 超簡易テストプラットフォーム、チェッくん
このWebアプリは簡易的なテストを作成できます。

Github Pagesで動作させる関係上、問題は直接コミットする必要があります。

以下は課題に利用できるCSVの説明です。

### CSVフォーマット

| 記号 | 意味 | 備考 |
| - | - | - |
| , | csvなので当たり前ですが、区切り文字です。 | |
| : | {プロパティ}:{値}の形式で使うと表形式にできます。| ２番目に配置した場合のみ有効 |
| # | 上記を区切るための記号です。| |

## 例
- csvのサンプル
```csv
リンゴのスペルは？,1:applle#2:apple#3:aple#4:applu
```
- 表示される問題
---

## Q1
## リンゴのスペルは？

| プロパティ | 値 |
| - | - |
| 1 | applle |
| 2 | apple |
| 3 | aple |
| 4 | applu |

---

### 注意点
- 基本的にはこのリポジトリをForkし、自身のプロジェクト上でcsvを編集し公開してください。
- csvは`問題,テーブル形式の記述`で記述する必要があります。テーブルが不要な場合は第２項目を省略することができますが、カンマは忘れないでください。（sample csv参照）

### Sample csv
```csv
以下の内容でフィールドとして正しいものを選択してください。回答は番号で答えてください。,1:private int length = 0#2:public int length = 0;#3:private int length = 0;#4:private int LENGTH = 0;
以下の内容でフィールドとして正しいものを選択してください。回答は番号で答えてください。,1:private string status = "ok";#2:private String status = "ok";#3:private string Status = "ok";#4:private String Status = "ok";
以下の内容でフィールドとして正しいものを選択してください。回答は番号で答えてください。,1:private string[] errors = "ok";#2:private string[] errors = "error1"."error2";#3:private string[] errors = new string[];#4:private string[] errors = new string[5];
ファイルを新規作成するメソッドで正しいものを選択してください。回答は番号で答えてください。,1:FileCreate("filename");#2:File Create("filename");#3:File.Create('filename');#4:File.Create("filename");
ファイルの文字列を読み取るメソッドで正しいものを選択してください。回答は番号で答えてください。,1:File.ReadText("filename");#2:File.ReadAllText("filename");#3:File.LeadAllText("filename");#4:File.ReadingText("filename");
ファイルのバイナリデータを読み取るメソッドで正しいものを選択してください。回答は番号で答えてください。,1:File.ReadByte("filename");#2:File.ReadAll("filename");#3:File.ReadByteArray("filename");#4:File.ReadAllBytes("filename");
以下のフィールドを以下の回答欄に入力してください。回答には半角スペース、大文字小文字が区別されます。,型名:int#フィールド名:count#初期値:0
以下のフィールドを以下の回答欄に入力してください。回答には半角スペース、大文字小文字が区別されます。,型名:string[]#フィールド名:messages#初期値:5個の値を追加できるようにする
以下のフィールドを以下の回答欄に入力してください。回答には半角スペース、大文字小文字が区別されます。,型名:List<bool>#フィールド名:results#初期値:new List<bool>();
以下のメソッドを以下の回答欄に入力してください。回答には半角スペース、大文字小文字が区別されます。,戻り値:なし#メソッド名:SetMessage#引数:string message#メソッド内の処理:なし
以下のメソッドを以下の回答欄に入力してください。回答には半角スペース、大文字小文字が区別されます。,戻り値:string#メソッド名:GetMessage#引数:なし#メソッド内の処理:return "message";
以下のメソッドを以下の回答欄に入力してください。回答には半角スペース、大文字小文字が区別されます。,戻り値:string#メソッド名:GetMessage#引数:int length#メソッド内の処理:return "message" + length;
これが最後の問題です。プログラミングの感想を回答に入力してください。,
```
