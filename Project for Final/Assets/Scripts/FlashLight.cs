using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{ 
    public GameObject Flashlight;
    public AudioSource turnOn;
    public AudioSource turnOff;

    public bool on;
    public bool off;
    // Start is called before the first frame update
    void Start()
    {
        off = true;
        Flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (off && Input.GetButtonDown("F"))
        {
            Flashlight.SetActive(true);
            turnOn.Play();
            off = false;
            on = true;
        } 
        else if (on && Input.GetButtonDown("F"))
        {
            Flashlight.SetActive(false);
            turnOff.Play();
            on = false;
            off = true;
        }
    }
}
