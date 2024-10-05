using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{
    [SerializeField] float _maxLife;
    float _life;
    // Start is called before the first frame update
    void Start()
    {
        _life = _maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (_life <= 0)
        {
            Debug.Log("GAMEOVER");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            _life--;
        }
    }
}
