using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePopTwo : MonoBehaviour
{
    public GameObject Message;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Message.SetActive(true);
        }
    }
}
