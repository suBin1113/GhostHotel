using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseScript : MonoBehaviour
{
 
    public GameObject[] hirePanel = new GameObject[5];
    public GameObject[] expandPanel = new GameObject[5];
    public GameObject[] purchasePanel = new GameObject[5];

    public GameObject panelSetting;
    public GameObject purchaseButton;

    Coin coinScript;
    Coin money;
    CoinManager coinManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        coinScript = GameObject.Find("Money").GetComponent<Coin>();
        //coinManagerScript = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        hirePanelOff();
        expandPanelOff();
        purchasePanelOff();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void hirePanelOff()
    {
        for(int i = 0; i <5; i++)
        {
            hirePanel[i].SetActive(false);
        }
    }

    public void expandPanelOff()
    {
        for (int i = 0; i < 5; i++)
        {
            expandPanel[i].SetActive(false);
        }
    }

    public void purchasePanelOff()
    {
        for (int i = 0; i < 5; i++)
        {
            purchasePanel[i].SetActive(false);
        }
    }

    public void PanelOn()
    {
        panelSetting.SetActive(true);
    }

    public void Purchase()
    {
        coinScript.DownMoney();
        //재화 부족하면 구매 불가
        //재화 있으면 구매 가능
    }
}
