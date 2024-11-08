using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float _score;
    int _scoreUpCount = 0;
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
        _goal.transform.position = new Vector2(_goal.transform.position.x, DistanceChangeSlider._distance);
        _startDistance = _distance = Vector2.Distance(_player.transform.position, _goal.transform.position);
        _timeLimit = _lastTimeLimit = _distance / 6f;
        _scoreDistanceMagnification = _distance / DistanceChangeSlider._max * _defaultScoreDistanceMagnification;
        Debug.Log(_timeLimit.ToString("000.000"));
        Debug.Log(_timeLimit * 6);
    }


    void Update()
    {
        _lastTimeLimit -= Time.deltaTime;
        _text.text = _lastTimeLimit.ToString("000.000");
        _distance = Vector2.Distance(transform.position, _goal.transform.position);
        _slider.fillAmount = _distance / _startDistance;
    }
    public void Score()
    {
        _scoreTimeLimitMagnification = _lastTimeLimit / _timeLimit * _defaultScoreTimeLimitMagnification;
        _score = (_lastTimeLimit * 100 + 500 * _scoreUpCount) * _scoreTimeLimitMagnification * _scoreDistanceMagnification;
        Debug.LogWarning(_score.ToString("000000"));
    }

    public void ScoreUp(int count)
    {
        _scoreUpCount += count;
    }
}
