using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quinternion2 : MonoBehaviour
{
    GameObject cube;
    Transform target;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        target = cube.GetComponent<Transform>();
        offset = target.position - gameObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);

    }
}
