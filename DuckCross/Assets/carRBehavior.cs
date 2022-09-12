using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carRBehavior : MonoBehaviour
{
    public float speed;     //currently only start from left
    float endX = -11;
    float startX = 11;
    
    public AudioSource hit;
    
    // Start is called before the first frame update
    void Start()
    {
        hit = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (start == 1){
        transform.position -= new Vector3(speed * Time.deltaTime, 0);
        CheckBoundary();
        //}

    }

    private void CheckBoundary() {
        if (transform.position.x <= endX)
        {
            transform.position = new Vector3(startX, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("car"))
        {
            Debug.Log("car!");
            hit.Play();
            Debug.Log(collision.transform.position);
            if (collision.GetComponent<bounceBack>() != null)
            {
                collision.GetComponent<bounceBack>().triggered = true;
            }
            else if(collision.GetComponent<teleportBack>()!= null)
            {
                collision.GetComponent<teleportBack>().triggered = true;
            }
        }
    }
}
