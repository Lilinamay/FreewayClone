using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carBehavior : MonoBehaviour
{
    public float speed;     //currently only start from left
    float endX = 10;
    float startX = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0);
        CheckBoundary();

    }

    private void CheckBoundary() {
        if (transform.position.x >= endX)
        {
            transform.position = new Vector3(startX, transform.position.y);
        }
    }

}
