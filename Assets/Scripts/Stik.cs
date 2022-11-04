using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stik : MonoBehaviour
{
    public AudioClip StickSound;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("踩到地刺");
            source.PlayOneShot(StickSound, 1f);

            // 重新開啟當前場景
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
