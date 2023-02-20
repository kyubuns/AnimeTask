# AnimeTask

UnityのTaskアニメーションライブラリ  
Rx Version! -> [kyubuns/AnimeRx](https://github.com/kyubuns/AnimeRx)

***Read this document in other languages: [English](https://github.com/kyubuns/AnimeTask/blob/main/README.md)***

<a href="https://www.buymeacoffee.com/kyubuns" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

![gif_animation_001](https://user-images.githubusercontent.com/961165/85940937-8c48d500-b95a-11ea-81b5-fddd17166a96.gif)

## Sample

-> [使用例](https://github.com/kyubuns/AnimeTask/wiki/Gallery)

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

秒速1で、2秒間移動する。

```csharp
await Moving.Linear(1f, 2f).ToLocalPositionX(cube);
```

### Gravity

```csharp
const float xRange = 5f;
const float yRangeMin = 5f;
const float yRangeMax = 10f;
await Moving.Gravity(
          new Vector2(Random.Range(-xRange, xRange), Random.Range(yRangeMin, yRangeMax)),
          Vector2.down * 9.8f,
          5f
      ).ToLocalPosition(shape)
```

<img src="https://user-images.githubusercontent.com/961165/85940937-8c48d500-b95a-11ea-81b5-fddd17166a96.gif" width="480">

### CalcDuration

距離から移動時間を計算して移動する。

```csharp
await Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), x => x / 2f)
    .Concat(Easing.Create<OutCubic>(new Vector3(5f, 2f, 0f), x => x / 2f))
    .Concat(Easing.Create<OutCubic>(new Vector3(-5f, 0f, 0f), x => x / 2f))
    .ToLocalPosition(cubes);
```

### TranslateTo.Action

`TranslateTo.Action`を利用すると、アニメーションした値を自由に使用出来る。

```csharp
Easing.Create<Linear>(0, 100, 2f).ToAction<float>(x => Debug.Log(x))
```

### UnscaledTime

スケジューラーは自作出来るので、特定のオブジェクトだけ時間を止めたりすることが可能。  
デフォルトは`Time.time`を利用していて、`Time.unscaledTime`を利用する`UnscaledTimeScheduler`も利用できる。

```csharp
Easing.Create<Linear>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f)
    .ToLocalPosition(shape, default, new UnscaledTimeScheduler());
```

### Update Timing

スケジューラーで更新タイミングを指定すれば、Update 以外のタイミングで値を更新することも可能です。

```csharp
public class CustomScheduler : IScheduler
{
    public float DeltaTime => Time.deltaTime;
    public PlayerLoopTiming UpdateTiming => PlayerLoopTiming.PreUpdate;
}
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
    .ToLocalPositionX(cubes[0]);
```

### IProgress

[IProgress](https://docs.microsoft.com/ja-jp/dotnet/api/system.iprogress-1) をサポートしています。

```csharp
await Easing.Create<Linear>(2f).ToProgress(Progress.Create<float>(x => Debug.Log(x)));
```

### AnimationCanceller

```csharp
var canceller = go.GetAnimationCanceller().Cancel();
Easing.Create<Linear>(1.0f, 0.5f).ToLocalPositionX(go, canceller.Token);

// 他のクラス/スコープ内で、他のアニメを中断する
var canceller = go.GetAnimationCanceller().Cancel();
Easing.Create<Linear>(0.0f, 0.5f).ToLocalPositionX(go, canceller.Token);
```

### Skip

- (CancellationTokenを用いた) Cancelは `Cancel` した瞬間に、その位置に停止します。
- (SkipTokenを用いた) Skipは `Skip` した瞬間に、終了位置まで移動します。

```csharp
var skipTokenSource = new SkipTokenSource();
Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 5f).ToLocalPosition(cubes[0], default, skipTokenSource.Token).Forget();
await UniTask.Delay(TimeSpan.FromSeconds(1));
skipTokenSource.Skip();
```

### UniRx.Extensions

```csharp
var score = new ReactiveProperty<int>(0);
score
    .SubscribeTask(async (x, cancellationToken) =>
    {
        scoreCounter.text = $"{x}";
        await Easing.Create<OutBounce>(2f, 1f, 0.5f).ToLocalScale(scoreCounter, cancellationToken);
    });
```

## Instructions

- [UniTask](https://github.com/Cysharp/UniTask)をインポート
- AnimeTaskをインポート
  - Package Manager `https://github.com/kyubuns/AnimeTask.git?path=Assets/AnimeTask`
  - [UnityPackage](https://github.com/kyubuns/AnimeTask/releases)

## 考え方

`Play`や`PlayTo`には2つの引数を渡します。  
1個目が`Animator`、2個目が`Translator`で、これらは明確に役割が異なります。

### Animator

経過時間を受け取り、現在の値を返す。

### Translator

値を反映する。

## Requirements

- Unity2019.4 以降。

## License

MIT License (see [LICENSE](LICENSE))

## Buy me a coffee

もしこのプロジェクトが気に入ったなら、ぜひコーヒーを奢ってください！  
https://www.buymeacoffee.com/kyubuns

## 「ゲームに使ったよ！」

「このゲームにこのライブラリ使ったよ！」という報告を貰えるとめっちゃ喜びます！  
メールやtwitterでお気軽にご連絡ください。  
(MITライセンスのため、報告は義務ではありません。)  
[メッセージフォーム](https://kyubuns.dev/message.html)

https://kyubuns.dev/
