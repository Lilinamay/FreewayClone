using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class playerBehavior : MonoBehaviour
{
    public float pSpeed = 4;
    public KeyCode upKey;
    public KeyCode downKey;
    int y = 0;  //use to track player key control 
    float endY = 5;
    public float startY = -5;
    public int score = 0;
    public bool playerControl = true;   //use to disable/able player control
 

    [SerializeField] TMP_Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckBoundary();
        if (playerControl)
        {
            keyInput();
        }

        if (playerControl)
        {
            transform.position += new Vector3(0, y * pSpeed * Time.deltaTime);
        }
        scoreDisplay.text = score.ToString();
    }

    public void keyInput()
    {
        if (Input.GetKey(upKey))            //need to add condition when the player can't move
        {
            y = 1;
        }
        else if (Input.GetKey(downKey))
        {
            y = -1;
        }
        else
        {
            y = 0;
        }
    }

    private void CheckBoundary()
    {
        if (transform.position.y >= endY)
        {
            transform.position = new Vector3(transform.position.x, startY);
            score++;
        }

        if (transform.position.y <= startY)
        {
            transform.position = new Vector3(transform.position.x, startY);
        }
    }




}
