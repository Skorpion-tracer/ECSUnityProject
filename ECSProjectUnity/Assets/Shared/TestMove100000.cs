using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove100000 : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
    }

    int i;
    int x;
    int y;
    int z;
    int j;
    // Update is called once per frame
    void Update()
    {
        if (i < 10000)
        {
            Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
        }
        i++;
        if (j < 1000)
        {
            x += 5; 
            j ++;
        }
        else if (j > 2000)
        {
            y += 5;
            j ++;
        }
        else if (j < 2000)
        {
            z += 5;
            j ++;
        }
    }
}
