using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour
{
    private Collider expectedCollider;
    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider == expectedCollider)
        {
            var scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore(2);
        }
    }
}
