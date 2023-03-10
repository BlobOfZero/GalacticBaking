using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private int currentGold;
    public TextMeshProUGUI goldText;

    // Start is called before the first frame update
    void Start()
    {
        currentGold = 0;
        goldText.text = "Current Gold: " + currentGold;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
