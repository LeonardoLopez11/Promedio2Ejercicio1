using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public GameObject proyectilP;
    public Transform PosicionPlayer;
    public float velocidadProyectil = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    void Disparar()
    {

        GameObject proyectil = Instantiate(proyectilP, PosicionPlayer.position, PosicionPlayer.rotation);
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();
        Vector3 direcciónDeDisparo = PosicionPlayer.forward;
        rb.velocity = direcciónDeDisparo * velocidadProyectil;


        Destroy(proyectil, 1f);

    }


}
