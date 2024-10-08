using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HorizontalItemMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 3f;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector3(transform.position.x <= 0 ? 1 : -1, 0, 0) * _moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) > 6)
        {
            Destroy(gameObject);
        }
    }
}
