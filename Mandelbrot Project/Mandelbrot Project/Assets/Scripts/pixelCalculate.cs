using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pixelCalculate : MonoBehaviour
{
    float xPosition;
    float yPosition;
    // Start is called before the first frame update
    void Start()
    {
        xPosition = transform.position.x/4 - 0.5f;
        yPosition = transform.position.y/4;
        if (MandelbrotFormula(xPosition, yPosition)){
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
    public bool MandelbrotFormula(float x, float y){
        float cX = x;
        float cY = y;
        float newX = 0;
        float newY = 0;
        for (float i = 0; i < 15; i++){
            newX = (cX*cX)-(cY*cY);
            newY = 2*cX*cY;
            cX = newX+x;
            cY = newY+y;
        }
        if(Mathf.Abs(newX+newY) > 100){
            return false;
        }
        return true;
    }
}
