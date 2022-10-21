using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnter : MonoBehaviour
{
    public Transform otherdoor;
    public GameObject Player;
    public bool PlayerIn;

    private float deadDelay = 0.3f; // 設定延遲計時秒數
    private float deadDelayTimer = 0; // 用來累加時間的變數

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerIn == true)
        {
            deadDelayTimer += Time.deltaTime;
            if (deadDelayTimer >= deadDelay)
            {
                Player.GetComponent<Transform>().transform.position = new Vector3(otherdoor.position.x, otherdoor.position.y, otherdoor.position.z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerIn = true;
            Player = other.gameObject;
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
