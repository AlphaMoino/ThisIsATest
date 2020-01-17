using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTest : MonoBehaviour
{
    GameObject capsule;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.Find("Capsule");
        target = capsule.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookVector = target.position - gameObject.transform.position;
        gameObject.transform.rotation = Quaternion.LookRotation(lookVector);
    }
}
