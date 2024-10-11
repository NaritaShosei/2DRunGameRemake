using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float _score;
    float _defaultScoreValue = 1000;
    float _defaultScoreDistanceMagnification = 5;
    float _scoreDistanceMagnification;
    float _defaultScoreTimeLimitMagnification = 5;
    float _scoreTimeLimitMagnification;
    float _timeLimit;
    float _lastTimeLimit;
    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        var player = FindObjectOfType<PlayerMove>();
        var goal = FindObjectOfType<ItemMove>();
        float dis = Vector2.Distance(player.transform.position, goal.transform.position);
        goal.transform.position = new Vector2(goal.transform.position.x, DistanceChangeSlider._distance);
        _timeLimit = dis / 6f;
        _lastTimeLimit = _timeLimit;
        _scoreDistanceMagnification = dis / DistanceChangeSlider._max * _defaultScoreDistanceMagnification;
        Debug.Log(_timeLimit.ToString("000.000"));
        Debug.Log(_timeLimit * 6);
    }

    // Update is called once per frame
    void Update()
    {
        _timeLimit -= Time.deltaTime;
        _text.text = _timeLimit.ToString("000.000");
    }
    public void Score()
    {
        _scoreTimeLimitMagnification = _lastTimeLimit / _timeLimit * _defaultScoreTimeLimitMagnification;
        _score = _defaultScoreValue * _scoreTimeLimitMagnification * _scoreDistanceMagnification;
        Debug.LogWarning(_score.ToString());
    }
}
