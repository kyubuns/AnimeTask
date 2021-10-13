# AnimeTask

Task Animation Library for Unity  
Rx Version! -> [kyubuns/AnimeRx](https://github.com/kyubuns/AnimeRx)

***Read this document in other languages: [日本語](https://github.com/kyubuns/AnimeTask/blob/main/README_ja.md)***

<a href="https://www.buymeacoffee.com/kyubuns" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

![gif_animation_001](https://user-images.githubusercontent.com/961165/85940937-8c48d500-b95a-11ea-81b5-fddd17166a96.gif)

## Sample

-> [Example of use](https://github.com/kyubuns/AnimeTask/wiki/Gallery)

### Basic

Move from `(-5f, 0f, 0f)` to `(5f, 0f, 0f)` over 2 seconds.

```csharp
await Easing.Create<Linear>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f).ToLocalPosition(cube);
```

<img src="https://user-images.githubusercontent.com/961165/85938659-32d8aa00-b94a-11ea-84e4-162626e31861.gif" width="480">

### PlayTo

Move from the current location to a specified location.

```csharp
await Easing.Create<Linear>(new Vector3(-5f, 3f, 0f), 2f).ToLocalPosition(cube);
```

<img src="https://user-images.githubusercontent.com/961165/85938725-b5fa0000-b94a-11ea-8c4c-2b20b2090561.gif" width="480">

### Easing

Use [InCubic](https://easings.net/#easeInCubic) of [Easing](https://easings.net/) to move to a specified position.

```csharp
await Easing.Create<InCubic>(new Vector3(-5f, 3f, 0f), 2f).ToLocalPosition(cube);
```

<img src="https://user-images.githubusercontent.com/961165/85938690-6d424700-b94a-11ea-9f8a-9bccddabf6b3.gif" width="480">

### Linear

Move at 1 per second for 2 seconds.

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

### AnimationCurve

```csharp
[SerializeField] private AnimationCurve sample12 = default;

public async UniTask Sample12()
{
    await Moving.AnimationCurve(sample12).ToLocalPositionX(cube);
}
```

### CalcDuration

Move by calculating moving time from distance.

```csharp
await Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), x => x / 2f)
    .Concat(Easing.Create<OutCubic>(new Vector3(5f, 2f, 0f), x => x / 2f))
    .Concat(Easing.Create<OutCubic>(new Vector3(-5f, 0f, 0f), x => x / 2f))
    .ToLocalPosition(cubes);
```

### TranslateTo.Action

`TranslateTo.Action` enables you to use the animated values freely.

```csharp
Easing.Create<Linear>(0, 100, 2f).ToAction<float>(x => Debug.Log(x))
```

### UnscaledTime

You can create your own scheduler, so you can stop time for specific objects.  
The default is to use `Time.time`, and you can also use `UnscaledTimeScheduler`, which uses `Time.unscaledTime`.

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

### Convert

Convert a `float` transition to a circular motion.

```csharp
await Easing.Create<OutCubic>(0.0f, Mathf.PI * 2.0f, 2f)
    .Convert(x => new Vector3(Mathf.Sin(x), Mathf.Cos(x), 0.0f) * 3.0f)
    .ToLocalPosition(go);
```

<img src="https://user-images.githubusercontent.com/961165/85940836-ef863780-b959-11ea-94a3-11e9ed5057f4.gif" width="480">

### Concat

It moves from 5f to 0f in 2 seconds, stops for 1 second, and moves to -5f in 2 seconds.

```csharp
await Easing.Create<OutCubic>(5f, 0f, 2f)
    .Delay(1f)
    .Concat(Easing.Create<OutCubic>(0f, -5f, 2f))
    .ToLocalPositionX(cubes[0]);
```

### IProgress

Supporting [IProgress](https://docs.microsoft.com/ja-jp/dotnet/api/system.iprogress-1)

```csharp
await Easing.Create<Linear>(2f).ToProgress(Progress.Create<float>(x => Debug.Log(x)));
```

### AnimationCanceller

```csharp
var canceller = go.GetAnimationCanceller().Cancel();
Easing.Create<Linear>(1.0f, 0.5f).ToLocalPositionX(go, canceller.Token);

// in other class/scope
var canceller = go.GetAnimationCanceller().Cancel();
Easing.Create<Linear>(0.0f, 0.5f).ToLocalPositionX(go, canceller.Token);
```

### Skip

- Cancel (using CancellationToken) will stop at the position at the moment of `Cancel`.
- Skip (using SkipToken) will move to the last position at the moment of `Skip`.

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

- Import AnimeTask via Package Manager
  - `https://github.com/kyubuns/AnimeTask.git?path=Assets/AnimeTask`
- Import AnimeTask via UnityPackage
  - Import [UniTask](https://github.com/Cysharp/UniTask)
  - Import [UnityPackage](https://github.com/kyubuns/AnimeTask/releases)

## Way of thinking

You can pass two arguments to `Play` and `PlayTo`.  
The first is the `Animator` and the second is the `Translator`, which have distinct roles.

### Animator

Takes the elapsed time and returns the current value.

### Translator

Reflect the value.

## Requirements

- Requires Unity2020.3 or later

## License

MIT License (see [LICENSE](LICENSE))

## Buy me a coffee

Are you enjoying save time?  
Buy me a coffee if you love my code!  
https://www.buymeacoffee.com/kyubuns

## "I used it for this game!"

I'd be happy to receive reports like "I used it for this game!"  
Please contact me by email, twitter or any other means.  
(This library is MIT licensed, so reporting is NOT mandatory.)  
[MessageForm](https://kyubuns.dev/message.html)

https://kyubuns.dev/
