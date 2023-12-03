using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSurroundDetection : MonoBehaviour
{
    public ColliderDetector leftCollider;
    public ColliderDetector rightCollider;
    public ColliderDetector backCollider;

    public GameObject leftAlert;
    public GameObject rightAlert;
    public GameObject backAlert;

    

    // Update is called once per frame
    void Update()
    {
        /*
        Collider[] left = Physics.OverlapBox(leftCollider.bounds.center, leftCollider.bounds.extents, Quaternion.identity, 0);
        Collider[] right = Physics.OverlapBox(rightCollider.bounds.center, rightCollider.bounds.extents, Quaternion.identity, 0);
        Collider[] back = Physics.OverlapBox(backCollider.bounds.center, backCollider.bounds.extents, Quaternion.identity, 0);
        
        
        if (left.Length > 0)
            Debug.Log("Left");
        if (right.Length > 0)
            Debug.Log("Right");
        if (back.Length > 0)
            Debug.Log("Back");
        //Debug.Log(left.Length);
        */
        if(leftCollider.numObjectsInside>0) leftAlert.SetActive(true);
        else leftAlert.SetActive(false);

        if(rightCollider.numObjectsInside>0) rightAlert.SetActive(true);
        else rightAlert.SetActive(false);

        if(backCollider.numObjectsInside>0) backAlert.SetActive(true);
        else backAlert.SetActive(false);

   

    }

}
