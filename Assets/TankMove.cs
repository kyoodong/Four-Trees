using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * 5.0f * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * 5.0f * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * 5.0f * Time.deltaTime);
        }
    }
    
    
}
