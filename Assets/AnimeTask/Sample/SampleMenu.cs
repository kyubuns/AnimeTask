using System.Collections.Generic;
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
}
