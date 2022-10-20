using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnter : MonoBehaviour
{
    public Transform Backdoor;

    private bool IsDoor;  //判斷玩家是否接觸的是門 
    private Transform PlayerTransform;  //判斷玩家位置 

    void Start()
    {

    }
    void Update()
    {

    }

    //玩家和門產生碰撞
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("玩家進入門的範圍");
            IsDoor = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("玩家離開門的範圍");
            IsDoor = false;
        }
    }
}



