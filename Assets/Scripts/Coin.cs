using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform coin;
    private float delay = 0;
    private float pasttime = 0;
    private float when = 1.0f;
    private Vector3 off;

    void Start()
    {

    }

    private void Awake()
    {
        //x和y的隨機方向
        off = new Vector3(Random.Range(1, -0.5f), Random.Range(0.5f, 0.4f), Random.Range(-0.3f, 1));
        off = new Vector3(Random.Range(-0.5f, 2), Random.Range(0.5f, 0.4f), Random.Range(1, -0.2f));
    }
    // Update is called once per frame
    void Update()
    {
        //1秒後會移動 
        if (when >= delay)
        {
            pasttime = Time.deltaTime;

            //金幣位置 
            coin.position += off * Time.deltaTime;
            delay += pasttime;
        }
    }


   void OnCollisionEnter(Collision other) 
    {
        
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("碰到金幣");
            Destroy(this.gameObject, 0.2f);
        }
    }

}
