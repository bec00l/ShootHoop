using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryGoalTrigger : MonoBehaviour {

	

    void OnTriggerEnter(Collider collider)
    {
        GetComponentInChildren<SecondaryTrigger>().ExpectCollider(collider);
    }
}
