# ReadMe

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

## 

`@charset "utf-8";`はrazorファイルの中に記述できない。
でも、全体のプロジェクトではutf8が適応されているっぽいので、別に書かなくても問題ない模様。

---

[ .NET 6 と Entity Framework Core InMemory を使用した Blazor Server CRUD](https://www.youtube.com/watch?v=ii6QzWudZ6E)  
