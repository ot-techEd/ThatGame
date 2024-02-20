using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    [SerializeField] private ItemType itemType;

    [SerializeField] private float itemSpawnSpeed = 2.0f;

    [SerializeField] private int scoreAmount = 1;

    private void Update()
    {
        transform.Translate(Vector3.forward * itemSpawnSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.GetGameManager().PlayerTookHit(this, scoreAmount);

        }
        else if (other.CompareTag("Exit"))
        {
            Destroy(gameObject);
        }
    }

    public ItemType GetItemType()
    {
        return itemType;
    }
}


