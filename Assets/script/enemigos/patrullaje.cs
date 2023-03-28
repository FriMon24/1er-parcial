using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrullaje : MonoBehaviour
{
    public GameObject plataforma;
    public float vel;
    public Transform puntoActual;
    public Transform [] points;
    public int PuntoSeleccionado;


    // Start is called before the first frame update
    void Start()
    {
        puntoActual = points[PuntoSeleccionado];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        plataforma.transform.position = Vector3.MoveTowards(plataforma.transform.position, puntoActual.position, Time.deltaTime * vel);
        if (plataforma.transform.position == puntoActual.position)
        {
            PuntoSeleccionado += 1;
            if (PuntoSeleccionado == points.Length)
            {
                PuntoSeleccionado = 0;
            }
            puntoActual = points[PuntoSeleccionado];
        }
    }
}
