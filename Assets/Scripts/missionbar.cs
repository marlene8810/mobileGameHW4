using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionbar : MonoBehaviour
{
    public GameObject MissionBar;

    public float showTimer = 3;

    void Awake()
    {
        MissionBar.SetActive(true);
    }

    void Update()
    {
        showTimer -= Time.deltaTime;
        if (showTimer < 0)
        {
            MissionBar.SetActive(false);
        }
    }
}
