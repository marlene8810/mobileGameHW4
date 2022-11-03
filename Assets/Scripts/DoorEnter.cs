using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnter : MonoBehaviour
{
    public Transform Otherdoor;

    public GameObject Player;

    public bool PlayerIn;

    private CharacterController controller;

    void Start()
    {
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && PlayerIn == false)
        {
            PlayerIn = true;
            Player = other.gameObject;
            Player.SetActive(false);
            if (PlayerIn)
            {
                other.transform.position = Otherdoor.transform.position;
            }
            Player.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerIn = false;
        }
    }
}
