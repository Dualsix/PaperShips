using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //public variables
    public float balloons;
    //private variables
    private bool stun;

    private float timer;

    private bool can1_i;
    private bool can1_d;
    private bool can1_a;
    private bool can1_u;

    private bool can2_i;
    private bool can2_d;
    private bool can2_a;
    private bool can2_u;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        stun = false;
        //inicializamos a true
        can1_i = true;
        can1_d = true;
        can1_a = true;
        can1_u = true;

        can2_i = true;
        can2_d = true;
        can2_a = true;
        can2_u = true;

        balloons = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (stun)
        {
            timer += Time.deltaTime;
        }
        if(timer > 1 && stun)
        {
            stun = false;
            timer = 0;
        }
        //conseguimos el ancho y alto de la pantalla
        float height = 2f * Camera.main.orthographicSize;
        float width = height * Camera.main.aspect;


            //bloquear movs P1
            if (gameObject.tag == "P1")
            {
                //bloquear el movimiento del personaje uno a la derecha
                if (transform.position.x + 1 >= (Camera.main.transform.position.x))
                {
                    can1_d = false;
                }
                else
                {
                    can1_d = true;
                }
                //bloquear el movimiento del personaje uno a la izquierda
                if (transform.position.x - 2 <= (Camera.main.transform.position.x - width / 2))
                {
                    can1_i = false;
                }
                else
                {
                    can1_i = true;
                }
                //bloquear el movimiento del personaje a la arriba
                if (transform.position.y + 1 >= (Camera.main.transform.position.y + height / 2))
                {
                    can1_u = false;
                }
                else
                {
                    can1_u = true;
                }
                //bloquear el movimiento del personaje a la abajo
                if (transform.position.y - 0.8 <= (Camera.main.transform.position.y - height / 2))
                {
                    can1_a = false;
                }
                else
                {
                    can1_a = true;
                }
            }

            //bloquear movs P2
            if (gameObject.tag == "P2")
            {
                //bloquear el movimiento del personaje uno a la derecha
                if (transform.position.x + 2 >= (Camera.main.transform.position.x + width / 2))
                {
                    can2_d = false;
                }
                else
                {
                    can2_d = true;
                }

                //bloquear el movimiento del personaje uno a la izquierda
                if (transform.position.x - 1 <= Camera.main.transform.position.x)
                {
                    can2_i = false;
                }
                else
                {
                    can2_i = true;
                }
                //bloquear el movimiento del personaje a la arriba
                if (transform.position.y + 1 >= (Camera.main.transform.position.y + height / 2))
                {
                    can2_u = false;
                }
                else
                {
                    can2_u = true;
                }
                //bloquear el movimiento del personaje a la abajo
                if (transform.position.y - 0.8 <= (Camera.main.transform.position.y - height / 2))
                {
                    can2_a = false;
                }
                else
                {
                    can2_a = true;
                }
            
        }

        if(balloons <= 0)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

    void FixedUpdate()
    {
        if (!stun)
        {
            //ponemos el movimiento del primer jugador
            if (gameObject.tag == "P1")
            {
                //si pulsa la a movemos a la izquierda
                if (Input.GetKey("a") && can1_i)
                {
                    transform.position -= new Vector3(0.1f, 0.0f, 0.0f);
                }
                //si pulsa la d movemos derecha
                if (Input.GetKey("d") && can1_d)
                {
                    transform.position += new Vector3(0.1f, 0.0f, 0.0f);
                }
                //si pulsa la s movemos abajo
                if (Input.GetKey("s") && can1_a)
                {
                    transform.position -= new Vector3(0.0f, 0.1f, 0.0f);
                }
                //si pulsa la w movemos arriba
                if (Input.GetKey("w") && can1_u)
                {
                    transform.position += new Vector3(0.0f, 0.1f, 0.0f);
                }
            }
            // el movimiento del segundo jugador
            if (gameObject.tag == "P2")
            {
                //si pulsa la flecha izquierda movemos a la izquierda
                if (Input.GetKey(KeyCode.LeftArrow) && can2_i)
                {
                    transform.position -= new Vector3(0.1f, 0.0f, 0.0f);
                }
                //si pulsa la flecha derecha movemos derecha
                if (Input.GetKey(KeyCode.RightArrow) && can2_d)
                {
                    transform.position += new Vector3(0.1f, 0.0f, 0.0f);
                }
                //si pulsa la arriba movemos arriba
                if (Input.GetKey(KeyCode.UpArrow) && can2_u)
                {
                    transform.position += new Vector3(0.0f, 0.1f, 0.0f);
                }
                //si pulsa la abajo movemos abajo
                if (Input.GetKey(KeyCode.DownArrow) && can2_a)
                {
                    transform.position -= new Vector3(0.0f, 0.1f, 0.0f);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.gameObject.tag == "P1")
        {
            if (collision.gameObject.tag == "ball_p2" && !stun)
            {
                stun = true;
                timer = 0;
            }
        }

        if (gameObject.gameObject.tag == "P2")
        {
            if (collision.gameObject.tag == "ball_p1" && !stun)
            {
                stun = true;
                timer = 0;
            }
        }
    }
}
