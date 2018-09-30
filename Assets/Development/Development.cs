using System;
using AnimeTask;
using AnimeTask.Easing;
using UnityEngine;
using UnityEngine.UI;

public class Development : MonoBehaviour
{
    [SerializeField] private Text text;

    public async void Start()
    {
        Debug.Log("Move Start");

        await Anime.Play(
            Linear.Animation(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), TimeSpan.FromSeconds(2f)),
            TranslateTo.LocalPosition(transform)
        );

        await Anime.Play(
            Linear.Animation(new Vector3(5f, 0f, 0f), new Vector3(5f, 3f, 0f), TimeSpan.FromSeconds(2f)),
            TranslateTo.LocalPosition(transform)
        );

        await Anime.Play(
            Linear.Animation(0, 100, TimeSpan.FromSeconds(2f)),
            TranslateTo.Text(text, "{0}pt")
        );

        Debug.Log("Move End");
    }
}
