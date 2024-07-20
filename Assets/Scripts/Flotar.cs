using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotar : MonoBehaviour
{
    // Start is called before the first frame update
    public float floatingAmplitude = 1f; // Amplitud de la flotación
    public float floatingSpeed = 1f; // Velocidad de flotación

    private Vector3 initialPosition; // Posición inicial del objeto
    void Start()
    {
        initialPosition = transform.position; // Guardar la posición inicial
    }

    // Update is called once per frame
    void Update()
    {
        // Calcular la posición de flotación usando la función sinusoidal
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatingSpeed) * floatingAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
