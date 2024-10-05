using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject[] _damageItem;
    [SerializeField] GameObject[] _spawnPosition;
    [SerializeField] float[] _waitTime;
    int _itemIndex;
    int _waitTimeIndex;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartGenerate());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator StartGenerate()
    {
        yield return new WaitForSeconds(_waitTime[_waitTimeIndex]);
        _itemIndex = Random.Range(0, _damageItem.Length);
        _waitTimeIndex = Random.Range(0, _waitTime.Length);
        float dis = Vector2.Distance(_spawnPosition[0].transform.position, _spawnPosition[1].transform.position);
        float randomDistance = Random.Range(0, dis);
        Instantiate(_damageItem[_itemIndex], _spawnPosition[0].transform.position + new Vector3(randomDistance, 0, 0), Quaternion.identity);
        Debug.Log(_itemIndex);
        StartCoroutine(StartGenerate());
    }
}
