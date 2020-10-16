using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public float radius = 10;

    public GameObject instance;
    public int spawnRate = 5;

    public int max = 10;

    void Spawn()
    {
        GameObject cube = Instantiate(instance, new Vector3(Random.Range(-radius, radius), 1f, Random.Range(-radius, radius)), this.transform.rotation);
        cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        cube.transform.parent = this.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Spawn", 5);
    }

    void OnEnable()
    {
        StartCoroutine(SpawnCoroutine());
    }

    int count = 0;

    System.Collections.IEnumerator SpawnCoroutine()
    {
        while(true)
        {
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
            if (cubes.Length < max)
            {
                Spawn();
                yield return new WaitForSeconds(1.0f / (float)spawnRate);
            }
            yield return null;
        }
    }
}
