using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    
    public float velocidad;

    // Update is called once per frame
    void Update () {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        GetComponent<Rigidbody>().AddForce(movimiento * velocidad * Time.deltaTime);
    }


}
