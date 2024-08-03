using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        float Xaxix = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float Yaxix = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(Xaxix, 0, Yaxix);
    }
}
