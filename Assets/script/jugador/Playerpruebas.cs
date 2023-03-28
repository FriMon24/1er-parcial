using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerpruebas : MonoBehaviour
{
    //variables generales
    private Rigidbody2D rb;
    private Animator animator;

    //variables para salto
    public LayerMask CapaPiso;
    public Transform RevisarPiso;
    public float fuerzaSalto = 500f;
    private bool staenpiso = true;
    private float radio = 0.08f;

    //variables caminata
    private bool stakminando;
    private float speed = 5.5f;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //carga el rigidbody del objeto que tiene este script
        animator = GetComponent<Animator>(); //carga el animator del objeto que tiene este script
    }

    private void FixedUpdate()
    {
        staenpiso = Physics2D.OverlapCircle(RevisarPiso.position, radio, CapaPiso);
        animator.SetBool("Misaltando", !staenpiso);
    }
    // Update is called once per frame
    void Update()
    {
        //movimiento derecha
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("Micaminando", true);
            stakminando = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            speed = 5.5f;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Micaminando", false);
            stakminando = false;
        }

        //movimiento izquierda
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("Micaminando", true);
            stakminando = true;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            speed = -5.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Micaminando", false);
            stakminando = false;
        }

        //aplicar fuerza de caminata 
        if (stakminando)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        //salto
       if (staenpiso)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(new Vector2(0, fuerzaSalto));
            }
        }
        
    }
}
