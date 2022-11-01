using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject Dropcoin;

    private int index;

    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("OnTriggerEnter");
            index = Random.Range(3, 10);
            for (int i = 0; i < index; i++)
            {
                Debug.Log("i++");
                Instantiate(Dropcoin, transform.position, Quaternion.identity);
            }
        }
    }
}
