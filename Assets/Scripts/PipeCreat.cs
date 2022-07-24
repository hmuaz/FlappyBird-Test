using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCreat : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate = 1f;

    private float maxHeight = 2f;
    private float minHeight = -1f;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate); 
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }



    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
