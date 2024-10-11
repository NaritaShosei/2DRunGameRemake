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
        goal.transform.position = new Vector2(goal.transform.position.x, DistanceChangeSlider._distance);
        _timeLimit = Vector2.Distance(player.transform.position, goal.transform.position) / 6f;
        Debug.Log(_timeLimit.ToString("000.000"));
        Debug.Log(_timeLimit * 6);
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
