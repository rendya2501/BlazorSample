# Blazorメモ

とりあえず分かった事を殴り書く。  

---

## ファンクションのキーバインド

ファンクションのキーバインド設定可能。  
ダイアログ上でF5を掌握できることを確認した。  

``` razor
@if (ShowConfirmation)
{
    <div class="modal fade show" @onkeydown="KeyHandler" @onkeydown:preventDefault style="display:block" tabindex="-1">
    </div>
}

@code {
    private void KeyHandler(KeyboardEventArgs e)
    {
        if (e.Key == "F5")
        {
            _ = 1;
        }
    }
}
```

[ASP.NET Core Blazor のイベント処理](https://learn.microsoft.com/ja-jp/aspnet/core/blazor/components/event-handling?view=aspnetcore-6.0)  

---

## ダイアログ

[Blazor で確認ダイアログを削除する](https://www.youtube.com/watch?v=Caw5hmq4dEY)  
[Blazor Tutorial C# - Part 5 - Blazor Component Reference](https://www.youtube.com/watch?v=3Gr83lIaENg)  

[bootstrap](https://getbootstrap.jp/docs/5.0/components/modal/)  

---

## Styleタグ中のcharset

`@charset "utf-8";`はrazorファイルのStyleタグの中に記述できない。  
でも、全体のプロジェクトではutf8が適応されているっぽいので、別に書かなくても問題ない模様。  

---

## BrazorのCSSの分離

トップレベルにCSSを配置できることは分かったが、CSSってどうやって適応されていくのか？  
トップレベルに大本となるCSSを配置して、微妙に色などを変えたい場合はそれぞれのrazorファイルにCSSを書くのがお作法なのだろうか。  
bootstrapを使いつつ、共通的に使いたいcssコンポーネントを作った時、それはどこに配置すべきなのだろうか。  
そもそもCSSって後書きが強いのか？  
CSSの勉強しないとわからんな。  

[【Blazor Server】【ASP.NET Core】CSS isolation と MapControllers](https://mslgt.hatenablog.com/entry/2020/12/16/203458)  

---

## 静的ファイルを wwwroot 以外のフォルダに配置する

ASP.Netではwwwrootなるフォルダに静的コンテンツを配置する決まりになっている模様。  
各プロジェクトに静的コンテンツを配置したくばスタートアッププログラムで追加の設定が必要。  
その手順は全て参考サイトに乗っているので、そちらを参照されたし。  

[静的ファイルを wwwroot 以外のフォルダに配置する](https://sorceryforce.net/ja/tips/asp-net-core-content-static-file-another-folder)  

---

BlazorServerCRUDの参考サイト
[.NET 6 と Entity Framework Core InMemory を使用した Blazor Server CRUD](https://www.youtube.com/watch?v=ii6QzWudZ6E)  