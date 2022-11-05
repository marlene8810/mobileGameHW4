using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fack : MonoBehaviour
{
    public GameObject FakeFlag;

    void start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("被騙拉!kk");
            FakeFlag.SetActive(true);
            Invoke("Restart", 1f);
        }
    }

    void Restart()
    {
        // 重新開啟當前場景
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
