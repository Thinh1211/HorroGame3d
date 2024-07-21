using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator door;

    public AudioSource doorSound;
    public bool inReach;




    void Start()
    {
        inReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
        }
    }

    
    void Update()
    {

        if (inReach && Input.GetButtonDown("Interact"))
        {
            DoorOpens();
            Debug.Log("1");
        }

        else
        {
            DoorCloses();
            Debug.Log("2");
        }

    }
    void DoorOpens()
    {
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        doorSound.Play();

    }

    void DoorCloses()
    {
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
    }


}