using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shopImage;

    void Start()
    {
        shopImage.SetActive(false);
    }
    public void PushButton_shop()
    {
        shopImage.SetActive(true);
    }
    public void PushButton_exit()
    {
        shopImage.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
