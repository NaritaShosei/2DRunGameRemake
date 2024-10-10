using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ItemMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    [SerializeField] float _minSpeedChangeValue;
    [SerializeField] float _maxSpeedChangeValue = 5;
    float _speedChangeValue = 1;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = Vector2.down * _moveSpeed * _speedChangeValue;
    }
     public void SpeedChange(float value)
    {
        _speedChangeValue += value;
        _speedChangeValue = Mathf.Clamp(_speedChangeValue, _minSpeedChangeValue, _maxSpeedChangeValue);
    }
}
