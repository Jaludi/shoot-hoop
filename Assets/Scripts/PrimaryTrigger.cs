using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryTrigger : MonoBehaviour {
    Collider stored;
    void OnTriggerEnter(Collider collider)
    {
        stored = collider;
        
    
    }
    public bool ExpectCollider(Collider c)
    {
        if (stored == c)
            return true;
        else
        {
            return false;
        }
    }
}
