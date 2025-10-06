using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public bool isDead = false;
    public float Ehealth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ehealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponentInChildren<UnityEngine.UI.Slider>().value = Ehealth;

        if (Ehealth < 0.5 )
        {
           
            isDead = true;
        }

        if (isDead)
        {
            
           
            Destroy(gameObject);
        }
    }
}
