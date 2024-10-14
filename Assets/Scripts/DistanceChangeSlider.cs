using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceChangeSlider : MonoBehaviour
{
    public static float _distance = 500;
    public static float _max;
    Slider _slider;
    void Start()
    {
        _slider = GetComponent<Slider>();
        _max = _slider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        _distance = _slider.value;
    }
}
