using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;

    public float speed;

    public ParticleSystem blood;

    public float hp;

    public Animator animator;

    void Start()
    {
        blood = blood.GetComponent<ParticleSystem>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("idle", true);

        //敵人追逐玩家
        Quaternion targtRotation =
            Quaternion
                .LookRotation(player.transform.position - transform.position);
        transform.rotation =
            Quaternion
                .Slerp(transform.rotation,
                targtRotation,
                speed * Time.deltaTime);
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
                GetComponent<MeshRenderer>().material.color = Color.red;
                animator.SetBool("idle", false);
                Debug.Log("被傷害");
                animator.SetTrigger("Hurt");

                Instantiate(blood, transform.position, Quaternion.identity);

                //刪除物件 設為停用、並移除
                other.gameObject.SetActive(true);
                Destroy(this.gameObject);
            }
        }
    }
}
