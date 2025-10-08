using Unity.VisualScripting;
using UnityEngine;

public class swordswings : MonoBehaviour
{
    public bool isswing = false; 
    public bool swordstate = true;
    public Animator animator; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            isswing = true; 
        }
        if (swordstate == true)
        {
           if (isswing = true)
            {

                animator.Play("SwordSwing");
            }
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            isswing = true;
        }
        if (swordstate == true)
        {
            if (isswing = true)
            {

                animator.Play("SwordSwing");
            }


        }
    }
}

