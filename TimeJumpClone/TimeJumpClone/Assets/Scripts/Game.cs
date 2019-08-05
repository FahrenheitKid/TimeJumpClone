using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    GameObject[] prefabs;
    [SerializeField]
    GameObject[] prefabsTiles;

    // Start is called before the first frame update
    void Start()
    {
       // spawnPrefabs(prefabsTiles, Vector3.zero);
        //spawnPrefabs(prefabs, new Vector3(10, 5, 0), 3);
        //spawnMultiplePrefabs(prefabs, Vector3.zero, 10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnPrefabs(GameObject[] arrayPrefabs, Vector3 pos)
    {
        int i = Random.Range(0, arrayPrefabs.Length);

        Instantiate(arrayPrefabs[i], pos, Quaternion.identity);

    }

    public void spawnMultiplePrefabs(GameObject[] arrayPrefabs, Vector3 pos, int qtd)
    {
        int j = Random.Range(0, arrayPrefabs.Length);

        for(int i = 0; i < qtd; i++)
        Instantiate(arrayPrefabs[j], pos, Quaternion.identity);

    }

    public void spawnPrefabs(GameObject[] arrayPrefabs, Vector3 pos, int id)
    {
        if (id < 0 || id >= arrayPrefabs.Length) return;


        Instantiate(arrayPrefabs[id], pos, Quaternion.identity);
    }

}
