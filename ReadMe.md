# ReadMe

---

## �t�@���N�V�����̃L�[�o�C���h

�t�@���N�V�����̃L�[�o�C���h�ݒ�\�B  
�_�C�A���O���F5�������ł��邱�Ƃ��m�F�����B  

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

[ASP.NET Core Blazor �̃C�x���g����](https://learn.microsoft.com/ja-jp/aspnet/core/blazor/components/event-handling?view=aspnetcore-6.0)  

---

## �_�C�A���O

[Blazor �Ŋm�F�_�C�A���O���폜����](https://www.youtube.com/watch?v=Caw5hmq4dEY)  
[Blazor Tutorial C# - Part 5 - Blazor Component Reference](https://www.youtube.com/watch?v=3Gr83lIaENg)  

[bootstrap](https://getbootstrap.jp/docs/5.0/components/modal/)  

---

## 

`@charset "utf-8";`��razor�t�@�C���̒��ɋL�q�ł��Ȃ��B
�ł��A�S�̂̃v���W�F�N�g�ł�utf8���K������Ă�����ۂ��̂ŁA�ʂɏ����Ȃ��Ă����Ȃ��͗l�B

---

[ .NET 6 �� Entity Framework Core InMemory ���g�p���� Blazor Server CRUD](https://www.youtube.com/watch?v=ii6QzWudZ6E)  
