using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemManager : MonoBehaviour
{
    [SerializeField] ItemType _type;
    enum ItemType
    {
        vertical,
        horizontal,
    }
    public abstract void Activate();

    // Start is called before the first frame update
    void Start()
    {
        if (_type == ItemType.vertical)
        {
            var Goal = FindObjectOfType<ItemMove>();
            transform.parent = Goal.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (_type)
        {
            case ItemType.vertical:
                if (transform.position.y <= -6)
                {
                    Destroy(gameObject);
                }
                break;
            case ItemType.horizontal:
                if (Mathf.Abs(transform.position.x) > 6)
                {
                    Destroy(gameObject);
                }
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Activate();
            Destroy(gameObject);
        }
    }
}
