using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemcollector : MonoBehaviour
{
    private int points = 0;
    [SerializeField] private Text pointstext;

    private void OnTriggerEnter2D(Collider2D collisions)
    {
        if (collisions.CompareTag("item"))
        {
            Destroy(collisions.gameObject);
            points++;
            pointstext.text = "Cherries: " + points;
        }
    }
}
