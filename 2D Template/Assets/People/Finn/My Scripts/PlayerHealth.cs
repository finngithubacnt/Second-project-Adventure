using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Phealth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Phealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponentInChildren<UnityEngine.UI.Slider>().value = Phealth;
    }
}
