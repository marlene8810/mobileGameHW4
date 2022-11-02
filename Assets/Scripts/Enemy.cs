using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float hp = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //先扣血
            hp -= 25;
            if (hp <= 0)
            {
                //刪除物件 設為停用、並移除 
                other.gameObject.SetActive(false);
                Destroy(this.gameObject);
            }

        }
    }
}
