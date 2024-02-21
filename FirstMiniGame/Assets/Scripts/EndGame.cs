using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager Manager;
    private Vector3 pos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Manager.LevelComplete();
            pos = other.gameObject.transform.position;
            other.gameObject.transform.position = pos;
        }
    }
}
