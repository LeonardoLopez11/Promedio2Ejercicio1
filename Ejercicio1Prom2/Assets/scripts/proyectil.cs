using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public GameObject proyectilP;
    public Transform PosicionPlayer;


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
        rb.velocity = transform.forward * 5;

        Destroy(proyectil, 1f);

    }


}
