using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageItem : MonoBehaviour
{
    [SerializeField] float _changeLifeValue = 1;
    [SerializeField] ItemType _itemType;
    enum ItemType
    {
        damage,
        heal,
        score
    }

    // Start is called before the first frame update
    void Start()
    {
        var Goal = FindObjectOfType<ItemMove>();
        transform.parent = Goal.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var life = collision.gameObject.GetComponent<LifeSystem>();
            switch (_itemType)
            {
                case ItemType.damage:
                    life.Life(_changeLifeValue);
                    break;
                case ItemType.heal:
                    life.Life(_changeLifeValue);
                    break;
                case ItemType.score:
                    break;
            }
            Destroy(gameObject);
        }
    }
}
