using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPontos2 : MonoBehaviour
{
    public int pontos;
    public GUIStyle Estilo;

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 100, 100), pontos.ToString(), Estilo);
    }
}
