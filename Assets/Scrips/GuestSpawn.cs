using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestSpawn : MonoBehaviour
{
    public GameObject guest_1;
    public GameObject guest_2;
    public GameObject guest_3;
    public GameObject spawner_1;
    public GameObject spawner_2;

    int num;

    // Start is called before the first frame update
    void Start()
    {
    }

    public Vector3 randomSpawn()
    {
        int num = Random.Range(0, 2);
        if (num == 0)
        {
            return spawner_1.transform.position + new Vector3(0, Random.Range(-1f, 1f), 0);
        }
        else
        {
            return spawner_2.transform.position + new Vector3(0, Random.Range(-1f, 1f), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Spawner").transform.childCount < 10)
        {
            num = Random.Range(0, 3);
            if (num == 1)
            {
                GameObject _obj = Instantiate(guest_1, randomSpawn(), Quaternion.identity);
                _obj.transform.parent = GameObject.Find("Spawner").transform;
            }
            else if (num ==2)
            {
                GameObject _obj = Instantiate(guest_2, randomSpawn(), Quaternion.identity);
                _obj.transform.parent = GameObject.Find("Spawner").transform;
            }
            else
            {
                GameObject _obj = Instantiate(guest_3, randomSpawn(), Quaternion.identity);
                _obj.transform.parent = GameObject.Find("Spawner").transform;
            }
        }
    }

}
