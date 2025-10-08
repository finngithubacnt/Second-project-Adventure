using UnityEngine;
using UnityEngine.Timeline;

public class PlayerHealth : MonoBehaviour
{
    public float MaxHealthset;
    public float Phealth = 10;

    [System.Obsolete]
    private void Awake(bool Hp)
    {
        MaxHealthset = FindObjectOfType<MHP>(Hp);
    }
    void Update()
    {
        
        gameObject.GetComponentInChildren<UnityEngine.UI.Slider>().value = Phealth;
    }
}
