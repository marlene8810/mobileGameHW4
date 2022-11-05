using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorMenu;

    private bool IsOpen = false;

    private bool IsClose = true;

    private Player keys;

    void Start()
    {
        keys = FindObjectOfType<Player>();
    }

    void Update()
    {
        if (IsOpen == true && (Input.GetKey(KeyCode.E)) && keys.KeyAmount >= 1)
        {
            keys.KeyAmount -= 1;
            DoorMenu.SetActive(false);
            IsOpen = false;
            Destroy(this.gameObject);
            IsClose = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DoorMenu.SetActive(true);
            IsOpen = false;
            if (keys.KeyAmount >= 1)
            {
                IsOpen = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            DoorMenu.SetActive(false);
        }
    }
}
