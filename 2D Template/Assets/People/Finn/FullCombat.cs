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
    public GameObject Bow1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (SwordEquipped == true & Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.Play("sword");
            // Attack with sword
        }
        else if (bowEquipped == true & Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.Play("Bow");
            // Instantiate the projectile prefab at the fire point's position and rotation
            GameObject projectile = Instantiate(ArrowPrefab, firePoint.position, firePoint.rotation);

            // Get the Rigidbody2D component of the instantiated projectile
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

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
            gameObject.SetActive(bowEquipped);
            //Attack With Bow
        }
    }
}
