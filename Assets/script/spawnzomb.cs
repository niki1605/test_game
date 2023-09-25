using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnzomb : MonoBehaviour
{


    public GameObject zomb;
    int s;
    public int i;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (s == 0)
        {
            Instantiate(zomb, new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 3f)), Quaternion.identity);
            i++;
            if (i == 3)
            {

                s = 1;

            }
        }
    }
}
