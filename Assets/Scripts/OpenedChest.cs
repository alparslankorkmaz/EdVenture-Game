using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenedChest : MonoBehaviour
{

    public Sprite Opened;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Opened;
        }
    }
}
