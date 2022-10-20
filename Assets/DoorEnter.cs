using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnter : MonoBehaviour
{
    public Transform otherdoor;
    bool playerIn;
    public GameObject Player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Press Q to teleport");
            playerIn = true;
            Player = other.gameObject;
            Player.transform.position = new Vector3(otherdoor.position.x, otherdoor.position.y, otherdoor.position.z);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = false;
        }
    }
}
