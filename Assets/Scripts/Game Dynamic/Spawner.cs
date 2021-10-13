using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject herbivoreOne;
    public GameObject herbivoreTwo;
    public GameObject predatorOne;
    public GameObject predatorTwo;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos, pos2, pos3, pos4;

        for (int i=0; i< Random.value * 10; i++)
        {
            pos = new Vector3(Random.Range(-6f, 0f), 0f, Random.Range(-6f, 0f));
            Instantiate(herbivoreOne, pos, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));

            pos2 = new Vector3(Random.Range(0f, 6f), 0f, Random.Range(0f, -6f));
            Instantiate(herbivoreTwo, pos2, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));

            pos3 = new Vector3(Random.Range(0f, -6f), 0f, Random.Range(0f, -6f));
            Instantiate(predatorOne, pos3, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));

            pos4 = new Vector3(Random.Range(-6f, 0f), 0f, Random.Range(6f, 0f));
            Instantiate(predatorTwo, pos4, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
