using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pbjectspawner : MonoBehaviour
{
    public Vector2 nuevaPos;
    public GameObject prefabAcrear;
    public float intervaloPcrear = 5;
    float timer;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervaloPcrear)
        {
            GameObject NewObjeto = Instantiate(prefabAcrear);
            Vector2 PosicionNew = nuevaPos;
            PosicionNew = (Vector2)transform.position + nuevaPos;
            NewObjeto.transform.position = PosicionNew;
            timer -= intervaloPcrear;
        }
    }
}
