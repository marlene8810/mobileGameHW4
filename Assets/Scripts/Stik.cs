using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stik : MonoBehaviour
{
    public AudioClip dead;

    public AudioSource music;

    private void Awake()
    {
        music = gameObject.AddComponent<AudioSource>();
        music.playOnAwake = false;
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("踩到地刺");
            music.clip = dead;
            music.Play();

            // 重新開啟當前場景
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
