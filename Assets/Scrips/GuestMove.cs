using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestMove : MonoBehaviour
{
    public float speed;
    public int touchCount;

    private Transform point_01;
    private Transform point_02;

    bool dist;

    void Start()
    {
        point_01 = GameObject.Find("Point_01").transform;
        point_02 = GameObject.Find("Point_02").transform;

        randomSpeed();
        moveCast();
    }
    public void randomSpeed()
    {
        speed = Random.Range(0.005f, 0.02f);
    }

    public void moveCast()
    {
        //if (SceneManager.GetActiveScene().name == "Hotel Outside")
            if (Vector2.Distance(point_01.transform.position, transform.position) > Vector2.Distance(point_02.transform.position, transform.position))
            {
                dist = true;
            }
            else
            {
                dist = false;
            }
    }
    void Update()
    {
        if (dist)
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            transform.Translate(Vector3.left * speed);

            if (point_01.transform.position.x - 3 >= transform.transform.position.x)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.left * speed);

            if (point_02.transform.position.x + 3 <= transform.transform.position.x)
            {
                Destroy(this.gameObject);
            }
        }
        if (SceneManager.GetActiveScene().name == "Hotel Outside")
        {
            if (touchCount >= 3)
            {
                Destroy(gameObject);
            }
        }
    }
}
