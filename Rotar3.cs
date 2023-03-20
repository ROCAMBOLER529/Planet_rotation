using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar3 : MonoBehaviour
{
    public float velocidad = 50f;
    public Vector3 vector;
    // public float rotation = 0f;
    // public file image;
    
    // Start is called before the first frame update
    void Start()
    {
        vector = new Vector3(0, velocidad, 0);
        
        // Migrar
        private runGame = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {       
        transform.Rotate(vector * Time.deltaTime);
        
        if (((DateTime.Now - lastExecution).TotalSeconds % 5000) == 0) {
            velocidad = velocidad - 5;
            vector.y = velocidad;
        }
    }
}
