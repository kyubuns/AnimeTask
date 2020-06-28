# AnimeTask

Task Animation Library for Unity

![gif_animation_001](https://user-images.githubusercontent.com/961165/85936316-77f1e180-b934-11ea-9614-9d1aa152bd41.gif)

## Sample

### Basic

`(-5f, 0f, 0f)` から `(5f, 0f, 0f)` へ2秒かけて移動する。

```csharp
await Anime.Play(
    Easing.Create<Linear>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f),
    TranslateTo.LocalPosition(cube)
);
```

<img src="https://user-images.githubusercontent.com/961165/85938659-32d8aa00-b94a-11ea-84e4-162626e31861.gif" width="480">

### PlayTo

PlayToを利用すると、現在地から指定した位置まで移動する。

```csharp
await Anime.PlayTo(
    Easing.Create<Linear>(new Vector3(-5f, 3f, 0f), 2f),
    TranslateTo.LocalPosition(cube)
);
```

<img src="https://user-images.githubusercontent.com/961165/85938725-b5fa0000-b94a-11ea-8c4c-2b20b2090561.gif" width="480">

### Easing

[Easing](https://easings.net/)の[InCubic](https://easings.net/#easeInCubic)を利用して、指定した位置まで移動する。

```csharp
await Anime.PlayTo(
    Easing.Create<InCubic>(new Vector3(-5f, 3f, 0f), 2f),
    TranslateTo.LocalPosition(cube)
);
```

<img src="https://user-images.githubusercontent.com/961165/85938690-6d424700-b94a-11ea-9f8a-9bccddabf6b3.gif" width="480">

### Linear

指定した速度（秒速1）で、2秒間移動する。

```csharp
await Anime.PlayTo(
    Moving.Linear(1f, 2f),
    TranslateTo.LocalPositionX(cube)
);
```

### Gravity

```csharp
const float xRange = 5f;
const float yRangeMin = 5f;
const float yRangeMax = 10f;
await Anime.PlayTo(
    Moving.Gravity(
        new Vector3(Random.Range(-xRange, xRange), Random.Range(yRangeMin, yRangeMax)),
        Vector3.down * 9.8f,
        5f),
    TranslateTo.LocalPosition(shape)
);
```

<img src="https://user-images.githubusercontent.com/961165/85936316-77f1e180-b934-11ea-9614-9d1aa152bd41.gif" width="480">

### TranslateTo.Action

TranslateTo.Actionを利用すると、アニメーションした値を自由に使用出来る。

```csharp
await Anime.Play(
    Easing.Create<Linear>(0, 100, 2f),
    TranslateTo.Action<float>(x => Debug.Log(x))
);
```

### UnscaledTime

スケジューラーは自作出来るので、特定のオブジェクトだけ時間を止めたり出来ます。  
デフォルトはTime.timeを利用していて、Time.unscaledTimeを利用するUnscaledTimeSchedulerも利用できます。

```csharp
await Anime.Play(
    Easing.Create<Linear>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f),
    TranslateTo.LocalPosition(shape),
    new UnscaledTimeScheduler()
);
```

### Cancel

```csharp
var cancellationTokenSource = new CancellationTokenSource();
cancellationTokenSource.Token.Register(() => Debug.Log("Cancel"));
cancellationTokenSource.CancelAfter(500);

await Anime.PlayTo(
    Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 2f),
    TranslateTo.LocalPosition(cubes[0]),
    cancellationTokenSource.Token
);
```

### Delay

2秒間右に等速で移動しつつ、最後の0.2秒でScaleを0にする

```csharp
await UniTask.WhenAll(
    Anime.PlayTo(
        Moving.Linear(3f, 2f),
        TranslateTo.LocalPositionX(cube)
    ),
    Anime.PlayTo(
        Animator.Delay(1.8f, Easing.Create<Linear>(Vector3.zero, 0.2f)),
        TranslateTo.LocalScale(cube)
    )
);
```

<img src="https://user-images.githubusercontent.com/961165/85938704-8ea33300-b94a-11ea-986a-8537038f92f3.gif" width="480">

## Instructions

- Import [UniTask](https://github.com/Cysharp/UniTask)
- Import AnimeTask
    - Package Manager `git@github.com/kyubuns/AnimeTask.git?path=Assets/AnimeTask`
        - UniTask must also be installed by PackageManager
    - [UnityPackage](https://github.com/kyubuns/AnimeTask/releases)
        - AnimeTask.asmdef must have a reference to UniTask.
        - <img width="300" alt="Screen Shot 2020-06-27 at 22 48 21" src="https://user-images.githubusercontent.com/961165/85923709-51965c80-b8c8-11ea-8c3a-f0b321d0d4ab.png">

## 考え方

PlayやPlayToには2つの引数を渡します。  
1個目がAnimator、2個目がTranslatorで、これらは明確に役割が異なります。

### Animator

経過時間を受け取り、現在の値を返す。

### Translator

値を反映する。

## Requirements

- Requires Unity2018.4 or later

## License

MIT License (see [LICENSE](LICENSE))

