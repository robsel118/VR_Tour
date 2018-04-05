using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {
        
    void Update () {

        transform.LookAt(2*gameObject.transform.position - Vector3.zero);
    }
}
