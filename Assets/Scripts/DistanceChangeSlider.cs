using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceChangeSlider : MonoBehaviour
{
<<<<<<< HEAD
    public static float _distance = 500;
    public static float _max;
=======
    public static float _distance;
>>>>>>> 25c19ca3a0032357a14ab0cd91b65e8a6282369e
    Slider _slider;
    void Start()
    {
        _slider = GetComponent<Slider>();
<<<<<<< HEAD
        _max = _slider.maxValue;
=======
>>>>>>> 25c19ca3a0032357a14ab0cd91b65e8a6282369e
    }

    // Update is called once per frame
    void Update()
    {
        _distance = _slider.value;
    }
}
