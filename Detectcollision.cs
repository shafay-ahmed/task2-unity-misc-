using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectcollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        scoreManager.AddScore(10);

    }
}





    