using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {
    PrimaryTrigger pT;
    public int points = 1;
    
    
    private void OnTriggerEnter(Collider collider)
    {
        
        pT = GetComponentInParent<PrimaryTrigger>();
        if (pT.ExpectCollider(collider))
        {
            ScoreKeeper sK = FindObjectOfType<ScoreKeeper>();
            sK.IncrementScore(points);
            
        }

    }
}
