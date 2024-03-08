using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBall : MonoBehaviour
{
    private Button button;
    private Vector3 spawnPoint;
    public GameObject ball;
    public GameObject SpawnPointObject;
    public AudioClip spawnSound;

    private void Start()
    {
        button = GetComponent<Button>();
    }

    private void Update()
    {
        spawnPoint = SpawnPointObject.transform.position;
    }

    public void ButtonOn()
    {
        Instantiate(ball, spawnPoint, Quaternion.identity);
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(spawnSound);
    }

}
