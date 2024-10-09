using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChangeItem : ItemManager
{
    [SerializeField] float _speedChangeValue;
    public override void Activate()
    {
        FindObjectOfType<PlayerMove>().Speed(_speedChangeValue);
    }
}
