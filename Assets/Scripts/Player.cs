using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 10;

    public Joystick joyStick;

    public Transform firePoint;

    public GameObject bulletPrefab;

    public int KeyAmount;

    public Component doorCollider;

    private CharacterController controller;

    private float hp = 10f;

    private GameObject focusEnemy;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // 開始一直射擊的 Coroutine 函式
        StartCoroutine(KeepShooting());
    }

    void Update()
    {
        // 取得方向鍵輸入
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");
        // 取得虛擬搖桿輸入
        float h = joyStick.Horizontal;
        float v = joyStick.Vertical;

        // 合成方向向量
        Vector3 dir = new Vector3(h, 0, v);

        // 調整角色面對方向
        // 判斷方向向量長度是否大於 0.1（代表有輸入）
        if (dir.magnitude > 0.1f)
        {
            // 將方向向量轉為角度
            float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;

            // 使用 Lerp 漸漸轉向
            Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
            transform.rotation =
                Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }

        // 地心引力 (y)
        if (!controller.isGrounded)
        {
            dir.y = -9.8f * 30 * Time.deltaTime;
        }

        // 移動角色位置
        controller.Move(dir * speed * Time.deltaTime);
    }

    void Fire()
    {
        // 產生出子彈
        Instantiate(bulletPrefab,
        firePoint.transform.position,
        transform.rotation);
    }

    // 一直射擊的 Coroutine 函式
    IEnumerator KeepShooting()
    {
        while (true)
        {
            // 射擊
            Fire();

            // 暫停 0.5 秒
            yield return new WaitForSeconds(0.5f);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //先扣血
            hp -= 10;
            if (hp <= 0)
            {
                // 重新開啟當前場景
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            doorCollider.GetComponent<BoxCollider>().enabled = true;
            KeyAmount += 1;
            Destroy(other.gameObject);
        }
    }
}
