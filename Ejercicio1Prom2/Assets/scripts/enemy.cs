using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float velocidadMovimiento = 1; 
    private Vector3 Movimiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward  * velocidadMovimiento * Time.deltaTime);
    }
}
