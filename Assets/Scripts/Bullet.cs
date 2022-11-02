using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;

    // 計時秒數 
    float lifeTime = 0;

    void Start()
    {
        // 設定一個持續的方向力，往面對方向（forward = +z) 
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 50;
    }

    // Update is called once per frame
    void Update()
    {
        // 計時三秒後刪除 
        lifeTime += Time.deltaTime;
        if (lifeTime > 3)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //當碰撞到tag 為 coin 的物件 
        if (other.gameObject.tag == "BOX")
        {
            //刪除物件 設為停用、並移除 
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }

    void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
