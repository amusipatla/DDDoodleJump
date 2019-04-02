using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{

    public GameObject platformPrefabBasic;
    public GameObject platformPrefab50;
    public GameObject platformPrefab100;
    public GameObject platformPrefab200;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        float type = 0.75f;

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            type = Random.Range(0f, 1f);

            if (type < .7f)
            {
                Instantiate(platformPrefabBasic, spawnPosition, Quaternion.identity);
            } else if (type < .85f)
            {
                Instantiate(platformPrefab50, spawnPosition, Quaternion.identity);
            } else if (type < .95f)
            {
                Instantiate(platformPrefab100, spawnPosition, Quaternion.identity);
            } else
            {
                Instantiate(platformPrefab200, spawnPosition, Quaternion.identity);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
