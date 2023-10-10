using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float velocidad = 5.0f; 
    private Rigidbody rb;
    private int level = 1; 
    
    void Start()
    {
        StartCoroutine(AumentodeNivel());

        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);
        rb.velocity = movimiento * velocidad;

    }

    void SubirNivel() {
        level++;
        Debug.Log(" Se subió de nivel " + level);
    
    
    }

    IEnumerator AumentodeNivel()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            SubirNivel();
        }
    }

}
