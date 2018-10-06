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
        };

        public void Start()
        {
            Dropdown.options = list;
            Dropdown.onValueChanged.AddListener(x => { Sample.Invoke(list[x].text, 0.0f); });
            Sample.Invoke(list[0].text, 0.0f);
        }
    }
}
