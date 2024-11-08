using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] SpriteRenderer _sprite;
    float _spriteHeight;
    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _spriteHeight = _sprite.bounds.size.y;
        Debug.Log(_spriteHeight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
