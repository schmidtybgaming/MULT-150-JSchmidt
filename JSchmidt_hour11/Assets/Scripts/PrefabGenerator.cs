using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 spawnRange;

    // Start is called before the first frame update
    void Start()
        
    {
        for (int i = 1; i <= 1; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), 1f,
                Random.Range(-spawnRange.z, spawnRange.z));
            Instantiate<GameObject>(prefab, spawnRange, Quaternion.identity);

    }
    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attacted to 
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
