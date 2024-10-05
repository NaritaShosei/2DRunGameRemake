using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vel = _rb.velocity;
        vel.x = Input.GetAxisRaw("Horizontal") * _moveSpeed;
        vel.y = Input.GetAxisRaw("Vertical") * _moveSpeed;
        _rb.velocity = vel;
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -2.7f, 2.7f);
        pos.y = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
        transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("GAMECLEAR");
        }
    }
}
