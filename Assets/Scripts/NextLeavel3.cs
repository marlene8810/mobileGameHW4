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
            Debug.Log("被騙拉!kk");
            EndMenu.SetActive(true);

            //延遲2秒
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        // 重新開啟當前場景
        SceneManager.LoadScene(0);
    }
}
