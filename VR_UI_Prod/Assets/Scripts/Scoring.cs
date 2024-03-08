using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int Points;
    public ScoreUI ScoreUI;
    public AudioClip scoreAudio;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(scoreAudio);
            ScoreUI.score += Points;
            Destroy(other.gameObject);
        }
    }
}
