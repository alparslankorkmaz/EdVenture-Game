using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenedChest : MonoBehaviour
{
    public Sprite Opened;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Opened;
        }
    }
}
