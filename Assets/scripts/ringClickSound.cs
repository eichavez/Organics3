using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringClickSound : MonoBehaviour
{
    AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        clip = gameObject.GetComponent<AudioSource>().clip;
    }

    void Update()
    { //if button pushed do RingButton
        if(Input.GetMouseButtonDown(0))
        {
            RingButton();
        }
    }

    public void RingButton()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
