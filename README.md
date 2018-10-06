# AnimeTask - Task Animation Library for Unity

Created by kyubuns

![image](https://user-images.githubusercontent.com/961165/46568998-56470e80-c989-11e8-8798-c168a1c6b494.gif)

## Features

- Taskベースのアニメーション
- Easing Animation
  - Linear
  - InQuad, OutQuad, InOutQuad
  - InCubic, OutCubic, InOutCubic
  - InQuart, OutQuart, InOutQuart
  - InQuint, OutQuint, InOutQuint
  - InSine, OutSine, InOutSine
  - InExpo, OutExpo, InOutExpo
  - InCirc, OutCirc, InOutCirc
  - InElastic, OutElastic, InOutElastic
  - InBack, OutBack, InOutBack
  - InBounce, OutBounce, InOutBounce

## Sample

### Basic

`(-5f, 0f, 0f)` から `(5f, 0f, 0f)` へ2秒かけて移動する。

```csharp
await Anime.Play(
    Easing.Create<Linear>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f),
    TranslateTo.LocalPosition(cube)
);
```

### PlayTo

PlayToを利用すると、現在地から移動する。

```csharp
await Anime.PlayTo(
    Easing.Create<Linear>(new Vector3(-5f, 3f, 0f), 2f),
    TranslateTo.LocalPosition(cube)
);
```

### Easing

EasingのInCubicを利用して移動する。

```csharp
await Anime.PlayTo(
    Easing.Create<InCubic>(new Vector3(-5f, 3f, 0f), 2f),
    TranslateTo.LocalPosition(cube)
);
```

### TranslateTo.Action

TranslateTo.Actionを利用すると、アニメーションした値を自由に使用出来る。

```csharp
await Anime.Play(
    Easing.Create<Linear>(0, 100, 2f),
    TranslateTo.Action<float>(x => Debug.Log(x))
);
```

## License

[MIT License](LICENSE)
