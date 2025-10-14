using UnityEngine;

public class FullCombat : MonoBehaviour
{
    public bool SwordEquipped = false;
    public bool bowEquipped = false;
    public Animator animator;
    public GameObject ArrowPrefab;
    public Transform  firePoint;
    public GameObject Sword;
    public GameObject Bow;
    public GameObject Bow1;//drawn bow
    public float ArrowSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SwordEquipped == true)
        {
            Sword.SetActive(true);
        }
        if (bowEquipped == true)
        {
            Bow.SetActive(true);
        }
        if (SwordEquipped == true & Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.Play("sword");
            Sword.SetActive(true);
            // Attack with sword
        }
        else if (SwordEquipped == false)
        {
            Sword.SetActive(false);
        }
        if (bowEquipped == true & Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.Play("Bow");
            // Instantiate the projectile prefab at the fire point's position and rotation
            GameObject projectile = Instantiate(ArrowPrefab, firePoint.position, firePoint.rotation);

            // Get the Rigidbody2D component of the instantiated projectile
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            ArrowPrefab.GetComponent<Rigidbody2D>().linearVelocity = transform.right * ArrowSpeed;
            // Attack with bow
        }





        if (SwordEquipped == true)
        {
            gameObject.SetActive(SwordEquipped);
            // Attack with sword
        }
        if (bowEquipped == true)
        {
          
            gameObject.SetActive(bowEquipped);
            //Attack With Bow
        }
    }
}
