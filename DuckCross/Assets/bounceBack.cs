using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceBack : MonoBehaviour
{
    public bool triggered = false;
    float currentLerpTime = 0;
    public float bounceSpeed = 1.5f;
    playerBehavior playerBehavior;
    // Start is called before the first frame update
    void Start()
    {
        playerBehavior = GetComponent<playerBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        BounceBack();
    }
    private void BounceBack()
    {
        if (triggered)
        {
            currentLerpTime += 0.5f;
            triggered = false;
        }

        if (currentLerpTime > 0)
        {
            playerBehavior.playerControl = false;               //player lose control if it is bouncing back
            currentLerpTime -= Time.deltaTime;
            transform.position += Vector3.down * Time.deltaTime* bounceSpeed;
        }
        if (currentLerpTime <= 0)
        {
            currentLerpTime = 0;
            playerBehavior.playerControl = true;
        }
    }
}
