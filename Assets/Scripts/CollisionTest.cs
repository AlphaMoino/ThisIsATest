using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    //nur am Start
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Eine Kollision hat stattgefunden.");
    }

    //jeden Frame
    private void OnCollisionStay(Collision collision)
    {
        
    }

    //wenn die Collision endet
    private void OnCollisionExit(Collision collision)
    {
        
    }

    /*
    //TRIGGER METHODEN
    //nur Collider wird mitgegeben
    //wenn ein Objekt in den Trigger geht
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Der Trigger wurde ausgelöst.");
    }*/
}
