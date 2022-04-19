using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cylinderPrefab;
    public bool canSpawn = true;
    public float spawnYPlus = 30;
    public void SpawnCylinder()
    {
        if (canSpawn)
        {
            Instantiate(cylinderPrefab, new Vector3(cylinderPrefab.gameObject.transform.position.x, cylinderPrefab.gameObject.transform.position.y - (spawnYPlus), cylinderPrefab.gameObject.transform.position.z), Quaternion.identity);
            spawnYPlus += 30; 
            canSpawn = false;
        }
    
    
    }

    
}
