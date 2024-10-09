using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystemPlayer : MonoBehaviour
{
    [SerializeField] float _maxLife;
    float _life;
    // Start is called before the first frame update
    void Start()
    {
        _life = _maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (_life <= 0)
        {
            Debug.Log("GAMEOVER");
        }
    }
    public void Life(float damage)
    {
        _life -= damage;
        Debug.Log("���C�t" + _life);
    }
}
