using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int Points;
    public ScoreUI ScoreUI;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ScoreUI.score += Points;
            Destroy(other.gameObject);
        }
    }
}
