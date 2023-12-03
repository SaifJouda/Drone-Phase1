using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetector : MonoBehaviour
{
    public int numObjectsInside=0;

    private void OnTriggerEnter(Collider other)
    {
        numObjectsInside++;
    }

    private void OnTriggerExit(Collider other)
    {
        numObjectsInside--;        
    }
}
