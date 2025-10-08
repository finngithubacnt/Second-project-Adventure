using TMPro;
using UnityEngine;

public class MHP : MonoBehaviour
{
    public TextMeshProUGUI Hp;
    public float HpNum = 10;
    void Update()
    {
        Hp.text = HpNum.ToString();
    }
}
