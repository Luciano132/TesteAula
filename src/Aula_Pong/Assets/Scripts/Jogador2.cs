using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador2 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if ((Input.GetAxisRaw("Vertical2") > 0) && (transform.position.y < 5)) {
            transform.Translate(0, 0.1f, 0);
        } else if ((Input.GetAxisRaw("Vertical2") < 0) && (transform.position.y > -5)) {
            transform.Translate(0, -0.1f, 0);
        }   
    }
}