using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftLenght;
    private void Start()
    {
        leftLenght = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;

        if(transform.position.x < leftLenght)
        {
            Destroy(gameObject);
        }
    }
}
