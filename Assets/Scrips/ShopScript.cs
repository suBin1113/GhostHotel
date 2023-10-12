using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    // Start is called before the first frame update
    //상점 기능 구현 스크립트

    GameObject gameManager;
    public GameObject button;
 
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    public void OpenShop()
    {
        gameManager.GetComponent<GameManager>().PushButton_shop();
        button.SetActive(false);
    }

    public void CloseShop()
    {
        gameManager.GetComponent<GameManager>().PushButton_exit();
        button.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
