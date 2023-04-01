using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    private float velocidad = 30f;
    private int vueltas = 0;
    // private Vector3 vector;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * velocidad * Time.deltaTime);

        if (transform.localRotation.eulerAngles.y > 359.0f) {
            vueltas++;
        }

    }

    public void Ralentizar(float ralen) {
        velocidad = velocidad - ralen;
    }

    public float getVelocidad() {
        return velocidad;
    }

    public void AumentarVelocidad(float aceleracion) {
        velocidad = velocidad + aceleracion;
    }

    public void setVelocidad(float vel) {
        velocidad = vel;
    }

    public int getVueltas() {
        return vueltas;
    }
}
