using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class SpeedChange : MonoBehaviour
{
    public Slider slider;
    public Text sliderText;

    public void Update()
    {
        sliderText.text = slider.value.ToString();
    }
}
