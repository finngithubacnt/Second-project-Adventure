using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class pressure_plate : MonoBehaviour
{
    public GameObject door;
    private Animator anim;
    private bool isOpen = false;

    public UnityEvent onPlatePressed;

    void Start()
    {
        anim = door.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            //anim.SetTrigger("Open");
            isOpen = true;
            onPlatePressed.Invoke();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isOpen)
        {
            //anim.SetTrigger("Close");
            isOpen = false;
        }
    }
}