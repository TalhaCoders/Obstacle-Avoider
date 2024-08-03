using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    [SerializeField] int score;

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log(score);
        }
    }
}
