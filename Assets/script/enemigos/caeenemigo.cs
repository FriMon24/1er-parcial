using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class caeenemigo : MonoBehaviour
{
    public string EscenaMorir;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(EscenaMorir);
        }
        Destroy(this.gameObject);
    }
}
