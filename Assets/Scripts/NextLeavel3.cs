using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLeavel3 : MonoBehaviour
{
    public GameObject EndMenu;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EndMenu.SetActive(true);
            SceneManager.LoadScene(0); // 切換場景到 主菜單
        }
    }
}
