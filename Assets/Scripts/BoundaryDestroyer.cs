using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroyer : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject); // .gameObject is mentioning the whole object, not just the collider of the object
    }
}
