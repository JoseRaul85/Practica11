using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCompuesto : MonoBehaviour
{
    [SerializeField] float velocidad_movimiento = 10f;

    // Update is called once per frame
    void Update()
    {
        // Movimiento hacia adelante y atrás
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocidad_movimiento * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * velocidad_movimiento * Time.deltaTime;
        }

        // Movimiento hacia la izquierda y derecha
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -1 * velocidad_movimiento * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidad_movimiento * Time.deltaTime;
        }
    }
}
