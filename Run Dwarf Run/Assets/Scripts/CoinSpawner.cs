using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class CoinSpawner : MonoBehaviour
{
    // variable que contiene al prefab
    public GameObject coinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //float x = Random.Range(5f, 140f);
        Vector3 position = new Vector3(140f, 130f, 0);
        Quaternion rotation = new Quaternion();
        // Instantiate(coinPrefab, position, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
