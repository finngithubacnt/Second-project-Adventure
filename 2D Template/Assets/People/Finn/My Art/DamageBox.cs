using UnityEngine;

public class DamageBox : MonoBehaviour
{
 
    public bool isAttacking = false;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if enemyhealth component
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null && isAttacking == false)
        {
            Debug.Log("Collided with enemy");
            isAttacking = true;
            enemyHealth.Ehealth -= 3;
            Debug.Log("Enemy health reduced by 3");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Reset attack
        if (collision.gameObject.GetComponent<EnemyHealth>() != null)
        {
            isAttacking = false;
        }

    }
}