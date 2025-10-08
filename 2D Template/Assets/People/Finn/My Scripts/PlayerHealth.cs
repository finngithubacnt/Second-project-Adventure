using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerHealth : MonoBehaviour
{
    public float MaxHealthset;
    public float Phealth = 10;
    void Update()
    {

        GetComponent<MHP>().HpNum = MaxHealthset;
        gameObject.GetComponentInChildren<UnityEngine.UI.Slider>().value = Phealth;
    }
}
