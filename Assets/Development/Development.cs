using AnimeTask;
using UnityEngine;
using UnityEngine.UI;

public class Development : MonoBehaviour
{
    [SerializeField] private Text text;

    public async void Start()
    {
        Debug.Log("Move Start");

        await Anime.PlayTo(
            Easing.Create<OutBack>(new Vector3(5f, 0f, 0f), 2f), TranslateTo.LocalPosition(transform)
        );

        await Anime.PlayTo(
            Easing.Create<OutBack>(new Vector3(5f, 0f, 0f), 2f), TranslateTo.LocalPosition(transform)
        );

        await Anime.PlayTo(
            Easing.Create<OutBack>(new Vector3(5f, 0f, 0f), 2f), TranslateTo.LocalPosition(transform)
        );

        await Anime.PlayTo(
            Easing.Create<OutBack>(new Vector3(5f, 0f, 0f), 2f), TranslateTo.LocalPosition(transform)
        );

        await Anime.Play(
            Easing.Create<Linear>(0, 100, 2f),
            TranslateTo.Action<float>(x => Debug.Log(x))
        );

        Debug.Log("Move End");
    }
}
