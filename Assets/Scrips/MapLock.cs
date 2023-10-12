using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapLock : MonoBehaviour
{
    public GameObject panel_purchase;
    public GameObject panel_Map;
    public Text textLock;

    void Start()
    {
        textLock.text = "";
    }

    void Update()
    {
        
    }

    public void onClick_Map()
    {
        panel_purchase.SetActive(true);
        textLock.text = "지하 2층 열기";
    }

    public void onClick_purchase()
    {
        panel_purchase.SetActive(false);
        panel_Map.SetActive(false);
    }

    public void onClick_Exit()
    {
        panel_purchase.SetActive(false);
    }
}
