using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public TMP_Text CoinText;
    public int coins = 0;

    // Update is called once per frame

    void Update()
    {
        CoinText.text = "Coins : " + coins;    
    }
}
