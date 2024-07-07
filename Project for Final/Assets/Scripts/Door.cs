using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   
    public Animator door;
    public AudioSource DoorSound;
    public bool inReach;

    void Start()
    {
        door = GetComponent<Animator>();
        inReach = false;
    }

     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("open");
        if (collision.gameObject.tag == "Player")
        {
            inReach = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            inReach = false;
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    if ( other.gameObject.tag == "Reach")
    //    {
    //        inReach = true;
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "Reach")
    //    {
    //        inReach = false;
    //    }
    //}

    void Update()
    {

        if (inReach && Input.GetKeyDown(KeyCode.F))
        {
            DoorOpen();
        }
        else
        {
            DoorClose();
        }
    }

    void DoorOpen()
    {
        //Debug.Log("open");
        door.SetBool("Open", true);
        door.SetBool("Close", false);
        DoorSound.Play();
    }

    void DoorClose()
    {
        //Debug.Log("Close");
        door.SetBool("Open", false);
        door.SetBool("Close", true);
        //DoorSound.Play();
    }
}
