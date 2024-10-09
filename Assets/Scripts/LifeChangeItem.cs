using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeChangeItem : ItemManager
{
    [SerializeField] float _lifeChangeValue;
    public override void Activate()
    {
        FindObjectOfType<LifeSystemPlayer>().Life(_lifeChangeValue);
    }
}
