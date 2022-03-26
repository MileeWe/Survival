using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(15*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-15* Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 15 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -15 * Time.deltaTime);
        }
    }
}
