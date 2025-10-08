using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.Events;
public class pressuretriggereddoor : MonoBehaviour
{
    public UnityEvent onPlatePressed;
    public pressure_plate plate;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !plate.isOpen)
        {
            //anim.SetTrigger("Open");
            plate.isOpen = true;
            onPlatePressed.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
