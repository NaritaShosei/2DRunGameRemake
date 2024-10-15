using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float _score;
    int _scoreUpValue = 0;
    float _defaultScoreDistanceMagnification = 5;
    float _scoreDistanceMagnification;
    float _defaultScoreTimeLimitMagnification = 5;
    float _scoreTimeLimitMagnification;
    float _timeLimit;
    float _lastTimeLimit;
    [SerializeField] Text _text;
    PlayerMove _player;
    ItemMove _goal;
    float _distance;
    float _startDistance;
    Image _slider;

    void Start()
    {
        _score = 0;
        _slider = GameObject.FindWithTag("Slider").GetComponent<Image>();
        _player = FindObjectOfType<PlayerMove>();
        _goal = FindObjectOfType<ItemMove>();
        _distance = Vector2.Distance(_player.transform.position, _goal.transform.position);
        _startDistance = _distance;
        _goal.transform.position = new Vector2(_goal.transform.position.x, DistanceChangeSlider._distance);
        _timeLimit = _distance / 6f;
        _lastTimeLimit = _timeLimit;
        _scoreDistanceMagnification = _distance / DistanceChangeSlider._max * _defaultScoreDistanceMagnification;
        _timeLimit = Vector2.Distance(_player.transform.position, _goal.transform.position) / 6f;
        Debug.Log(_timeLimit.ToString("000.000"));
        Debug.Log(_timeLimit * 6);
    }


    void Update()
    {
        _timeLimit -= Time.deltaTime;
        _text.text = _timeLimit.ToString("000.000");
        _distance = Vector2.Distance(transform.position, _goal.transform.position);
        _slider.fillAmount = _distance / _startDistance;
    }
    public void Score()
    {
        _scoreTimeLimitMagnification = _lastTimeLimit / _timeLimit * _defaultScoreTimeLimitMagnification;
        _score = ((_distance * 10) + 500 * _scoreUpValue) * _scoreTimeLimitMagnification * _scoreDistanceMagnification;
        Debug.LogWarning(_score.ToString());
    }

    public void ScoreUp(int value)
    {
        _scoreUpValue += value;
    }
}
