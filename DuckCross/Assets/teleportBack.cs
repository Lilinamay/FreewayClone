using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportBack : MonoBehaviour
{
    public bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            transform.position = new Vector3(transform.position.x, GetComponent<playerBehavior>().startY);
            triggered = false;
        }
    }
}
