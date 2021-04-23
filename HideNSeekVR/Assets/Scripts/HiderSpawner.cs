using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiderSpawner : MonoBehaviour
{
    public GameObject HiderPrefab;
    public GameObject[] spawnPositions;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <spawnPositions.Length; i++)
        {
            Instantiate(HiderPrefab, spawnPositions[i].transform.position, spawnPositions[i].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
