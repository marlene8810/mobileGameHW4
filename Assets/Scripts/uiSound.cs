using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiSound : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
    }

    void Update()
    {
    }

    public void PlayClickSoud()
    {
        source.Play();
    }
}
