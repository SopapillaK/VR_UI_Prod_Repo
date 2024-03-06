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

    private void Start()
    {
        button = GetComponent<Button>();
        spawnPoint = SpawnPointObject.transform.position;
    }

    public void ButtonOn()
    {
        Instantiate(ball, spawnPoint, Quaternion.identity);
    }

}
