using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar3 : MonoBehaviour
{    
    private boolean pausa;
    private int tapss;
    private int time = [];
    
    // Pasar a planeta
    private int vueltas;
    
    public GameObject planeta;
    public GameObject interface;
    
    // Start is called before the first frame update - arrancarJurgo()
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        
    }

    void mostrarInstrucciones() {

    }

    void pausar() {
        pausa = true;
    }

    void despausar() {
        pausa = false;
    }

    float getVelocidad() {
        return planeta.velocidad;
    }

    GameObject getMusica() {
        // return musica
    }

    void checkearSave() {

    }

    void autoSve() {

    }

    int contVueltas(vueltas) {
        return vueltas;
    }

    void maxVueltas() {

    }

    int contTaps(ticks) {
        return ticks++;
    }

}
