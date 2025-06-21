using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class GateOpener : MonoBehaviour
{

    public GameObject door;
    bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isOpen == false)
        {

            isOpen = true;
            door.transform.position += new Vector3(0, 20, 0);
        }


    }
    void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            isOpen = false;
            door.transform.position -= new Vector3(0, 20, 0);
        }
    }
}

