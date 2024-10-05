using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float _score;
    float _timeLimit;
    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        var player = FindObjectOfType<PlayerMove>();
        var goal = FindObjectOfType<ItemMove>();
        Vector2 playerPos = player.transform.position;
        while (playerPos.y <= goal.transform.position.y)
        {
            _timeLimit += Time.deltaTime;
            var pos = playerPos;
            pos.y += 6f * Time.deltaTime;
            playerPos = pos;
        }
        Debug.Log(_timeLimit.ToString("000.000"));
    }

    // Update is called once per frame
    void Update()
    {
        _timeLimit -= Time.deltaTime;
        _text.text = _timeLimit.ToString("000.000");
    }
    void Score()
    {
        
    }
}
