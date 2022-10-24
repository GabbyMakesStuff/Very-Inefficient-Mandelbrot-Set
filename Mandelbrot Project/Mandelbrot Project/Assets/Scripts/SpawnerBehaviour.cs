using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    public GameObject pixelCube;
    float cameraHorizontal;
    public float moveInterval;
    float nextMoveTime;
    public float precision;

    void Start()
    {
        cameraHorizontal = Camera.main.orthographicSize * Camera.main.aspect;
    }


    void Update()
    {
        // create a pixel object at the current position, then parent it to an empty (cleans up the hirearchy)
        GameObject newPixel = (GameObject)Instantiate(pixelCube, transform.position,Quaternion.identity);
        newPixel.transform.parent = GameObject.Find("pixelsFolder").transform;
        
        // Checks if it's inside the camera boundary
        if (transform.position.x > cameraHorizontal){
            // delete
            Destroy (gameObject);
        }
        // move right.
        transform.position = new Vector3(transform.position.x + precision, transform.position.y);
    }
}
