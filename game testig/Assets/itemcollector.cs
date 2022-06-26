using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemcollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collisions)
    {
        if (collisions.CompareTag("item"))
        {
            Destroy(collisions.gameObject);
        }
    }
}
