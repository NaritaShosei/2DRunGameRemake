using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject[] _item;
    [SerializeField] GameObject _horizontalItem;
    [SerializeField] GameObject[] _spawnPosition;
    [SerializeField] float[] _waitTime;
    int _waitTimeIndex;
    int _itemIndex;
    PlayerMove _player;
    [SerializeField] GenerateType _generatorType;
    enum GenerateType
    {
        vertical,
        horizontal
    }
    // Start is called before the first frame update
    void Start()
    {
        switch (_generatorType)
        {
            case GenerateType.vertical:
                StartCoroutine(StartGenerateVertical());
                break;
            case GenerateType.horizontal:
                _player = FindObjectOfType<PlayerMove>();
                StartCoroutine(StartGenerateHorizontal());
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartGenerateVertical()
    {
        yield return new WaitForSeconds(_waitTime[_waitTimeIndex]);
        _itemIndex = Random.Range(0, _item.Length);
        _waitTimeIndex = Random.Range(0, _waitTime.Length);
        float dis = Vector2.Distance(_spawnPosition[0].transform.position,
            _spawnPosition[1].transform.position);
        float randomDistance = Random.Range(0, dis);
        Instantiate(_item[_itemIndex], _spawnPosition[0].transform.position + new Vector3(randomDistance, 0, 0), Quaternion.identity);
        Debug.Log(_itemIndex);
        StartCoroutine(StartGenerateVertical());
    }

    IEnumerator StartGenerateHorizontal()
    {
        yield return new WaitForSeconds(_waitTime[_waitTimeIndex]);
        _waitTimeIndex = Random.Range(0, _waitTime.Length);
        Instantiate(_horizontalItem, new Vector2(_player.transform.position.x >= 0 ? -3 : 3,
            _player.transform.position.y), Quaternion.identity);
        StartCoroutine(StartGenerateHorizontal());
    }
}
