using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private float speed = 0.25f;
    private Vector2 nowPos;
    private Vector2 prePos;
    private Vector2 movePos;

    public Transform mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                prePos = touch.position - touch.deltaPosition;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                nowPos = touch.position - touch.deltaPosition;
                movePos = (Vector2)(prePos - nowPos) * Time.deltaTime * speed;
                mainCamera.transform.Translate(movePos);
                prePos = touch.position - touch.deltaPosition;
            }
        }
    }
}
