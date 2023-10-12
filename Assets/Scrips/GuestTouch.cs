using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestTouch : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouseDown");
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hitInFormation = Physics2D.Raycast(touchPos, Camera.main.transform.forward);
            if (hitInFormation.collider != null)
            {
                GameObject touchObject = hitInFormation.transform.gameObject;
                Debug.Log(touchObject);
                if (touchObject.transform.tag == "Guest")
                {
                    touchObject.GetComponent<GuestMove>().speed = 0;
                    touchObject.GetComponent<GuestMove>().touchCount++;
                }
            }
        }

        /*if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hitInfo = Physics2D.Raycast(touchPos, Camera.main.transform.forward * -1);

                if (hitInfo.collider.tag != null)
                {
                    Debug.Log("1");
                    GameObject touchObj = hitInfo.transform.gameObject;
                    if (touchObj.gameObject.tag == "Guest")
                    {
                        Debug.Log("2");
                    }
                } 
            }
        }*/
    }
}
