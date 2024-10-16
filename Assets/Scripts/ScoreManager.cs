using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    const string dataName = "SaveData";

    static List<float> _scores = null;
    [SerializeField] Text[] _text;

    void Start()
    {
        if (_scores == null)
        {
            Load();
        }
        _scores.Add(GameManager._score);
        var orderByScore = _scores.OrderByDescending(x => x).ToList();
        for (int i = 0; i < ((orderByScore.Count > 5) ? 5 : orderByScore.Count); i++)
        {
            _text[i].text = orderByScore[i].ToString("000000");
        }
        Save();
    }

    void Load()
    {
        string json = PlayerPrefs.GetString(dataName);
        SaveData saveData = JsonUtility.FromJson<SaveData>(json);
        if (saveData == null)
        {
            _scores = new List<float>();
        }
        else
        {
            _scores = saveData.dataList;
        }
    }

    void Save()
    {
        SaveData saveData = new SaveData()
        {
            dataList = _scores
        };
        string data = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString(dataName, data);
    }

    [Serializable]
    class SaveData
    {
        public List<float> dataList;
    }
}
