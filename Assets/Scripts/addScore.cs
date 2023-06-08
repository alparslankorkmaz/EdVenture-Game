using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addScore : MonoBehaviour
{
    public Text chestsFound;
    private int chestNum;

    // Start is called before the first frame update
    void Start()
    {
        chestNum = 0;
        chestsFound.text = chestNum + "/4";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Chest")
        {
            chestNum += 1;
            Destroy(other.gameObject);
            chestsFound.text = chestNum + "/4";
        }
    }

}
