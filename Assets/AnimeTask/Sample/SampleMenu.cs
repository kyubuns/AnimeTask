using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask.Sample
{
    public class SampleMenu : MonoBehaviour
    {
        [SerializeField] private Sample sample;
        [SerializeField] private Dropdown dropdown;
        private readonly List<Dropdown.OptionData> list = new List<Dropdown.OptionData>
        {
            new Dropdown.OptionData("Sample01"),
        };

        public void Start()
        {
            dropdown.options = list;
            dropdown.onValueChanged.AddListener(x => { sample.Invoke(list[x].text, 0.0f); });
            sample.Invoke(list[0].text, 0.0f);
        }
    }
}
