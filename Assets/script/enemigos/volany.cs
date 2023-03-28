using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volany : MonoBehaviour
{
    // declarandovariable
    public GameObject prefabAGenerar;
    public float intervalo = 5;
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervalo)
        {

            Instantiate(prefabAGenerar);
            timer -= intervalo;
        }
        
    }
}
