using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotar : MonoBehaviour
{
    // Start is called before the first frame update
    public float floatingAmplitude = 1f; // Amplitud de la flotaci�n
    public float floatingSpeed = 1f; // Velocidad de flotaci�n

    private Vector3 initialPosition; // Posici�n inicial del objeto
    void Start()
    {
        initialPosition = transform.position; // Guardar la posici�n inicial
    }

    // Update is called once per frame
    void Update()
    {
        // Calcular la posici�n de flotaci�n usando la funci�n sinusoidal
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatingSpeed) * floatingAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
