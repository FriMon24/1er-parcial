using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemigoshorizontal : MonoBehaviour
{
    public int tiempodespera;
    public string muerte;
    public float FactorDeVel;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * Time.deltaTime * FactorDeVel);
    }

    private void Update()
    {
        Destroy(this.gameObject, tiempodespera);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            SceneManager.LoadScene(muerte);
        }
        Destroy(this.gameObject);
    }
}

