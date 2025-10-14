using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float Phealth = 10;
    public int healingAmount = 1;
    public float healingFrequency = 1f;
    public GameObject slider;

    private Coroutine healingCoroutine;


    void Update()
    {

        maxHealth = GetComponent<MHP>().HpNum;
        Phealth = slider.GetComponentInChildren<UnityEngine.UI.Slider>().value;
    }

         public void StartHealing()
        {
        if (healingCoroutine != null)
        {
            StopCoroutine(healingCoroutine); // Stop any existing healing coroutine
        }
        healingCoroutine = StartCoroutine(RegenerateHealth());
        }

    public void StopHealing()
    {
        if (healingCoroutine != null)
        {
            StopCoroutine(healingCoroutine);
            healingCoroutine = null;
        }
    }

    private IEnumerator RegenerateHealth()
    {
        while (Phealth < maxHealth)
        {
            yield return new WaitForSeconds(healingFrequency);
            Phealth += healingAmount;
            if (Phealth > maxHealth)
            {
                Phealth = maxHealth; // Ensure health doesn't exceed max
            }
            Debug.Log("Current Health: " + Phealth); // For testing
        }
        healingCoroutine = null; // Reset coroutine reference when healing is complete
    }

    // Example of taking damage and triggering healing if needed
    public void TakeDamage(int damage)
    {
        Phealth -= damage;
        if (Phealth < 0)
        {
            Phealth = 0;
            // Handle death or other consequences
        }
        Debug.Log("Took " + damage + " damage. Current Health: " + Phealth);

        if (Phealth < maxHealth)
        {
            StartHealing(); // Start healing if not at full health
        }
    }
}




