using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleS : MonoBehaviour
{
    public GameObject spawnerPrefab;
    float cameraVertical;
    float cameraHorizontal;
    public float precision;
    // Start is called before the first frame update
    void Start()
    {
        cameraVertical = Camera.main.orthographicSize;
        cameraHorizontal = Camera.main.orthographicSize * Camera.main.aspect;
        transform.position = new Vector3(-cameraHorizontal, -cameraVertical);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject newSpawner = (GameObject)Instantiate(spawnerPrefab, transform.position, Quaternion.identity);
        
        newSpawner.transform.parent = GameObject.Find("spawnersFolder").transform;

        if (transform.position.y > cameraVertical){
            Destroy (gameObject);
        }

        transform.position = new Vector3(transform.position.x, transform.position.y + precision);
    }
}
