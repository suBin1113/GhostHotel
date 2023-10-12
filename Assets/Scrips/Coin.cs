using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text scoreText;
    CoinManager coinManger;

    // Start is called before the first frame update
    void Start()
    {
        coinManger = GameObject.Find("Coin_Manager").GetComponent<CoinManager>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void AddMoney()
    {
        coinManger.money++;
    }
    public void DownMoney()
    {
        if (coinManger.money > 0)
        {
            coinManger.money--;
        }
    }
}
