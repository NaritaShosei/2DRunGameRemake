using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] List<GameObject> _backgroundList = new();
    [SerializeField] float _moveSpeed;
    List<Rigidbody2D> _rbList = new();
    float _spriteHeight;
    int _indexCount;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sprite = _backgroundList[0].GetComponent<SpriteRenderer>();
        _spriteHeight = sprite.bounds.size.y;
        for (int i = 0; i < _backgroundList.Count; i++)
        {
            _backgroundList[i].transform.position = new Vector2(0, _spriteHeight * i);
            _rbList.Add(_backgroundList[i].GetComponent<Rigidbody2D>());
        }
        Debug.Log(_spriteHeight);
        foreach (var rb in _rbList)
        {
            rb.velocity = new Vector2(0, -_spriteHeight);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_backgroundList[_indexCount].transform.position.y <= -_spriteHeight)
        {
            var pos = _backgroundList[_indexCount].transform.position;
            pos.y = _spriteHeight * 2;
            _backgroundList[_indexCount].transform.position = pos;
            _indexCount = (_indexCount + 1) % _backgroundList.Count;
        }
    }
}
