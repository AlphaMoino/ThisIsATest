using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 10;
    public bool is3D = true;
    private float horizontal_movement;
    private float vertical_movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(is3D)
        {
            horizontal_movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            vertical_movement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        else
        {
            horizontal_movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        
        transform.Translate(horizontal_movement, 0, vertical_movement);
    }
}
