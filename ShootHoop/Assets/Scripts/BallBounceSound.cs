using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
         var source = GetComponent<AudioSource>();
        source.Play();
    }
}
