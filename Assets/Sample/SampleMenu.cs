﻿using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask.Sample
{
    public class SampleMenu : MonoBehaviour
    {
        public Sample Sample;
        public Dropdown Dropdown;

        private readonly List<Dropdown.OptionData> list = new List<Dropdown.OptionData>
        {
            new Dropdown.OptionData("Sample01"),
            new Dropdown.OptionData("Sample02"),
            new Dropdown.OptionData("Sample03"),
            new Dropdown.OptionData("Sample04"),
            new Dropdown.OptionData("Sample05"),
            new Dropdown.OptionData("Sample06"),
            new Dropdown.OptionData("Sample07"),
            new Dropdown.OptionData("Sample08"),
            new Dropdown.OptionData("Sample09"),
            new Dropdown.OptionData("Sample10"),
            new Dropdown.OptionData("Sample11"),
            new Dropdown.OptionData("Sample12"),
            new Dropdown.OptionData("Sample13"),
        };

        public void Start()
        {
            Dropdown.options = list;
            Dropdown.onValueChanged.AddListener(Play);
            Play(0);
        }

        private void Play(int index)
        {
            Debug.Log($"Play {list[index].text}");
            Sample.Invoke(list[index].text, 0.0f);
        }
    }

    public static class SampleEditorMenu
    {
        [MenuItem("Test/Sample01")]
        public static void Sample01()
        {
            GameObject.Find("Sample").GetComponent<Sample>().Sample01().Forget();
        }
    }
}
