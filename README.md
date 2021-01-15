# AnimeTask

<a href="https://www.buymeacoffee.com/kyubuns" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

Task Animation Library for Unity

![gif_animation_001](https://user-images.githubusercontent.com/961165/85940937-8c48d500-b95a-11ea-81b5-fddd17166a96.gif)

Rx Version! -> [kyubuns/AnimeRx](https://github.com/kyubuns/AnimeRx)

## Sample

### Basic

`(-5f, 0f, 0f)` から `(5f, 0f, 0f)` へ2秒かけて移動する。

```csharp
await Easing.Create<Linear>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f).ToLocalPosition(cube);
```

<img src="https://user-images.githubusercontent.com/961165/85938659-32d8aa00-b94a-11ea-84e4-162626e31861.gif" width="480">

### PlayTo

現在地から指定した位置まで移動する。

```csharp
await Easing.Create<Linear>(new Vector3(-5f, 3f, 0f), 2f).ToLocalPosition(cube);
```

<img src="https://user-images.githubusercontent.com/961165/85938725-b5fa0000-b94a-11ea-8c4c-2b20b2090561.gif" width="480">

### Easing

[Easing](https://easings.net/)の[InCubic](https://easings.net/#easeInCubic)を利用して、指定した位置まで移動する。

```csharp
await Easing.Create<InCubic>(new Vector3(-5f, 3f, 0f), 2f).ToLocalPosition(cube);
```

<img src="https://user-images.githubusercontent.com/961165/85938690-6d424700-b94a-11ea-9f8a-9bccddabf6b3.gif" width="480">

### Linear

指定した速度（秒速1）で、2秒間移動する。

```csharp
await Moving.Linear(1f, 2f).ToLocalPositionX(cube);
```

### Gravity

```csharp
const float xRange = 5f;
const float yRangeMin = 5f;
const float yRangeMax = 10f;
await Moving.Gravity(
          new Vector3(Random.Range(-xRange, xRange), Random.Range(yRangeMin, yRangeMax)),
          Vector3.down * 9.8f,
          5f
      ).ToLocalPosition(shape)
```

<img src="https://user-images.githubusercontent.com/961165/85940937-8c48d500-b95a-11ea-81b5-fddd17166a96.gif" width="480">

### TranslateTo.Action

TranslateTo.Actionを利用すると、アニメーションした値を自由に使用出来る。

```csharp
Easing.Create<Linear>(0, 100, 2f).ToAction<float>(x => Debug.Log(x))
```

### UnscaledTime

スケジューラーは自作出来るので、特定のオブジェクトだけ時間を止めたりすることが可能。  
デフォルトはTime.timeを利用していて、Time.unscaledTimeを利用するUnscaledTimeSchedulerも利用できる。

```csharp
Easing.Create<Linear>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f)
    .ToLocalPosition(shape, default, new UnscaledTimeScheduler());
```

### Cancel

```csharp
var cancellationTokenSource = new CancellationTokenSource();
cancellationTokenSource.Token.Register(() => Debug.Log("Cancel"));
cancellationTokenSource.CancelAfter(500);

await Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 2f).ToLocalPosition(cubes[0], cancellationTokenSource.Token);
```

### Delay

2秒間右に等速で移動しつつ、最後の0.2秒でScaleを0にする

```csharp
await UniTask.WhenAll(
    Moving.Linear(3f, 2f).ToLocalPositionX(cube),
    Animator.Delay(1.8f, Easing.Create<Linear>(Vector3.zero, 0.2f)).ToLocalScale(cube),
);
```

<img src="https://user-images.githubusercontent.com/961165/85938704-8ea33300-b94a-11ea-986a-8537038f92f3.gif" width="480">

### Convert

floatの推移を円運動に変換する。

```csharp
await Easing.Create<OutCubic>(0.0f, Mathf.PI * 2.0f, 2f)
    .Convert(x => new Vector3(Mathf.Sin(x), Mathf.Cos(x), 0.0f) * 3.0f)
    .ToLocalPosition(go);
```

<img src="https://user-images.githubusercontent.com/961165/85940836-ef863780-b959-11ea-94a3-11e9ed5057f4.gif" width="480">

### Concat

2秒で5fから0fまで移動し、1秒停止したあと、2秒で-5fへ移動する。

```csharp
await Easing.Create<OutCubic>(5f, 0f, 2f)
    .Delay(1f)
    .Concat(Easing.Create<OutCubic>(0f, -5f, 2f))
    .Convert(x => new Vector3(x, 0f, 0f))
    .ToLocalPosition(cubes[0]);
```

### IProgress

Supporting [IProgress](https://docs.microsoft.com/ja-jp/dotnet/api/system.iprogress-1)

```csharp
await Easing.Create<Linear>(2f).ToProgress(Progress.Create<float>(x => Debug.Log(x)));
```

## Instructions

- Import [UniTask](https://github.com/Cysharp/UniTask)
- Import AnimeTask
    - Package Manager `https://github.com/kyubuns/AnimeTask.git?path=Assets/AnimeTask`
    - [UnityPackage](https://github.com/kyubuns/AnimeTask/releases)

## 考え方

PlayやPlayToには2つの引数を渡します。  
1個目がAnimator、2個目がTranslatorで、これらは明確に役割が異なります。

### Animator

経過時間を受け取り、現在の値を返す。

### Translator

値を反映する。

## Requirements

- Requires Unity2019.4 or later

## License

MIT License (see [LICENSE](LICENSE))

