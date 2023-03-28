using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform Jugador;
    public float offset = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Jugador.position.x + offset, Jugador.position.y + offset, transform.position.z);
    }
}
