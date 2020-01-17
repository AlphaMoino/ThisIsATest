using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    GameObject cube;
    Transform target;
    public GameObject bulletObject;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        target = cube.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookVector = target.position - gameObject.transform.position;
        
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject test = Instantiate(bulletObject, target.transform.position + Vector3.right, transform.rotation);
            Destroy(test, 3);
        }
    }
}
