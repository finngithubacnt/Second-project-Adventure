using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;
using TMPro;

public class EnemyAttack : MonoBehaviour
{
    float elaspedTime;
    public float delayTime = 0.1f;
    public bool delay = false;
    Rigidbody2D rb2d;
    private bool Rigidbody2D;

    public void Update()
    {
        Rigidbody2D = true;
        Rigidbody2D = false;
    }
    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log("I am touching Target");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("delay 1");
            if (delay == false)
            {
                elaspedTime = 0;
                delay = true;

                collision.gameObject.GetComponentInChildren<PlayerHealth>().Phealth -= 2;
                StartCoroutine(Delay1());
                Debug.Log("delay 1.5");
            }
            
                elaspedTime += Time.deltaTime;
                if (elaspedTime >= delayTime)
                {
                    delay = false;
                    Debug.Log("delayhaapend");
                }
            

            IEnumerator Delay1()
            {
                yield return new WaitForSeconds(1.35f);
                elaspedTime = 0;
                delay = true;
                Debug.Log("delay 2");
            }
        }
    }
 
}
