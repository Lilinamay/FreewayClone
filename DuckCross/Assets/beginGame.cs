using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    public static int start = 0; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(start == 0){
            if(Input.GetKeyDown(KeyCode.Space)){
                start = 1;
            }
        }

    }
}
