using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator door;

    public AudioSource doorSound;
    public bool inReach;
    private bool isOpen=false;



    void Start()
    {
        inReach = false;
        isOpen = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            Debug.Log(inReach);
            if (!isOpen)
            {
                isOpen = true;
                inReach = true;
               
            }
            else
            {
                isOpen = false;
                inReach = true;
            }
           
        }
    }

    void OnTriggerExit(Collider other)
    {
        
            inReach = false;
        
    }

    
    void Update()
    {

        if (inReach && isOpen && Input.GetButtonDown("Interact"))
        {
            DoorOpens();
            Debug.Log("1");
        }

        else if (inReach && !isOpen && Input.GetButtonDown("Interact"))
        {
            DoorCloses();
            Debug.Log("2");
        }

    }
    void DoorOpens()
    {
        isOpen=true;
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        doorSound.Play();

    }

    void DoorCloses()
    {
        isOpen=false;
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
    }


}