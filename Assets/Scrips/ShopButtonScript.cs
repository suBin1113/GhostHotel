using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonScript : MonoBehaviour
{
    public GameObject hireScorllView;
    public GameObject expandScrollView;
    public GameObject purchaseScrollView;
    //public GameObject chooseImage;

    public List<GameObject> button_list;

    // Start is called before the first frame update
    void Start()
    {
        button_list = new List<GameObject>();
        //chooseImage.SetActive(false);
        PushHireButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PushHireButton()
    {
        hireScorllView.SetActive(true);
        expandScrollView.SetActive(false);
        purchaseScrollView.SetActive(false);
    }

    public void PushExpandButton()
    {
        expandScrollView.SetActive(true);
        hireScorllView.SetActive(false);
        purchaseScrollView.SetActive(false);
    }

    public void PushPurchaseButton()
    {
        purchaseScrollView.SetActive(true);
        hireScorllView.SetActive(false);
        expandScrollView.SetActive(false);
    }

    /*public void HireButtonOption()
    {
        //리스트 할당 및 기능 추가
        if (hireButton==true)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject btn = Instantiate(hireButton) as GameObject;
                button_list.Add(btn);
            }
        }
        
    }

    public void ExpandButtonOption()
    {
        //리스트 할당 및 기능 추가, 다시 생각해보기
        if (hireButton == true)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject btn2 = Instantiate(hireButton) as GameObject;
                button_list.Add(btn2);
                
                if (button_list[i]==true)
                {
                    //i 번째 버튼이 눌리면 구매 기능 나옴
                }
            }
        }
       
    }

    public void PurchaseButtonOption()
    {
        //리스트 할당 및 기능 추가
        if (hireButton == true)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject btn3 = Instantiate(hireButton) as GameObject;
                button_list.Add(btn3);
            }
        }
    }*/
}
