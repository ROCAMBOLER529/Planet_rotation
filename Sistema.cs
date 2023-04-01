using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sistema : MonoBehaviour
{    
    private float timer = 0f;
    private float ralen = 1f;
    private Planeta planetaScript;
    private SpriteRenderer vacioSprite;
    private bool pausa = false;

    public Sprite sprite; // referencia al sprite de Game Over
    public GameObject vacio; // el Objeto de fondo
    public GameObject planeta; // el Objeto planeta
    public Text contador; // el texto que cuenta el tiempo
    public Text contVueltas; // el texto que cuenta las vueltas
    
    // Start is called before the first frame update - arrancarJurgo()
    void Start()
    {
        planetaScript = planeta.GetComponent<Planeta>();
        vacioSprite = vacio.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {       
        if (getVel() == 0f) {
            contador.text = "You Lost";
            vacioSprite.sprite = sprite;
            contVueltas.text = "Max. de vueltas: " + planetaScript.getVueltas();
        } else {
            timer += Time.deltaTime;
            contador.text = "" + timer.ToString();
            sumarVueltas();

            if (timer >= ralen) {
                if (getVel() <= 15f) {
                    planetaScript.setVelocidad(0f);
                }

                planetaScript.Ralentizar(getVel() * 0.3f);
                Debug.Log("Ralentizar planeta");
                timer = 0f;
            }

            if (Input.GetKeyDown("space")) {
                planetaScript.AumentarVelocidad(5f);
                Debug.Log("AUMENTAR");
            }
        }  
    }

    private float getVel() {
        return planetaScript.getVelocidad();
    }

    // void mostrarInstrucciones() {

    // }

    // public void pausar() {
    //     if (pausa) {
    //         Time.timeScale = 1f;
            
    //         pausa = false;
    //     } else {
    //         Time.timeScale = 0f;

    //         pausa = true;
    //     }
    // }

    // void despausar() {
    //     pausa = false;
    // }

    // GameObject getMusica() {
    //     // return musica
    // }

    // void checkearSave() {

    // }

    // void autoSve() {

    // }

    void sumarVueltas() {
        contVueltas.text = "Vueltas: " + planetaScript.getVueltas();
    }

    // void maxVueltas() {

    // }

    // void sumarTaps(ticks) {
        
    // }

    // void cambiarDimension() {
    //
    // }

}
