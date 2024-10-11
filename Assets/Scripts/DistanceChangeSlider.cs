using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceChangeSlider : MonoBehaviour
{
    public static float _distance;
    Slider _slider;
    void Start()
    {
        _slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        _distance = _slider.value;
    }
}
