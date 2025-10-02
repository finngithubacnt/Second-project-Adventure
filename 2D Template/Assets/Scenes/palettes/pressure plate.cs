using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressure_plate : MonoBehaviour
{
    public GameObject door;
    private Animator anim;
    private bool isOpen = false;
    void Start()
    {
        anim = door.GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            anim.SetTrigger("Open");
            isOpen = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isOpen)
        {
            anim.SetTrigger("Close");
            isOpen = false;
        }
    }
}