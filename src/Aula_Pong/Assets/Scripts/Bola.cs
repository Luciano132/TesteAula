using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        float x;
        float y;
        // float x = Random.Range(0,2) == 0 ? -1:1;
        // float y = Random.Range(0,2) == 0 ? -1:1;
        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }

        GetComponent<Rigidbody>().velocity = new Vector2(10 * x, 10 * y);
    }
    void Update()
    {

    }
    void OnCollisionEnter(Collision batida)
    {
        audioSource.Play();
        if (batida.gameObject.name == "BarreiraEsquerda")
        {
            GameObject.Find("SistemaPontos2").GetComponent<SistemaPontos2>().pontos += 1;
            transform.position = new Vector3(0, 0, 12);
            Start();
        }
        else if (batida.gameObject.name == "BarreiraDireita")
        {
            GameObject.Find("SistemaPontos1").GetComponent<SistemaPontos1>().pontos += 1;
            transform.position = new Vector3(0, 0, 12);
            Start();
        }
        else
        {
            return;
        }
    }
}
