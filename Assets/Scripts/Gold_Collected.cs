using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gold_Collected : MonoBehaviour
{
    public TextMeshProUGUI coins_Text;
    public TextMeshProUGUI Scrolls_Text;
    private int prefabsCount;

    void Start()
    {
        int coins = Random.Range(1500,4500);
        coins_Text.text = "Gold Collected: " + coins;
        //int prefabsCount = RiddleInteraction.Prefabs.Count;
        Scrolls_Text.text = "Scrolls: " + prefabsCount;
    }
}
