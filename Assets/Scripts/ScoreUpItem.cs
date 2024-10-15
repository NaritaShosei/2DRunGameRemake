using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpItem : ItemManager
{
    [SerializeField] int _scoreChangeValue = 1;
    public override void Activate()
    {
        FindObjectOfType<GameManager>().ScoreUp(_scoreChangeValue);
    }

}
