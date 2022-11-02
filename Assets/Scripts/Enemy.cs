using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;

    private float hp = 10f;

    void Start()
    {
    }

    void Update()
    {
        //敵人追逐玩家
        Quaternion targtRotation =
            Quaternion
                .LookRotation(player.transform.position - transform.position);
        transform.rotation =
            Quaternion
                .Slerp(transform.rotation, targtRotation, 1 * Time.deltaTime);
        transform.position += transform.forward * 1f * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //先扣血
            hp -= 10;
            if (hp <= 0)
            {
                //刪除物件 設為停用、並移除
                other.gameObject.SetActive(false);
                Destroy(this.gameObject);
            }
        }
    }
}
