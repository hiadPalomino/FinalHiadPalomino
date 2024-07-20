using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_aleatorio : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 3f; // Velocidad de movimiento del agente
    void Start()
    {
        // Iniciar el movimiento aleatorio
        InvokeRepeating("RandomMove", 0f, 2f); // Llamar al método RandomMove cada 2 segundos 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomMove()
    {
        // Generar una dirección de movimiento aleatoria
        Vector3 randomDirection = new Vector3(UnityEngine.Random.Range(-1f, 1f), 0f, UnityEngine.Random.Range(-1f, 1f)).normalized;

        // Calcular la posición objetivo a la que se moverá el agente
        Vector3 targetPosition = transform.position + randomDirection * 5f; // Moverse 5 unidades en la dirección aleatoria

        // Iniciar el movimiento hacia la posición objetivo
        StartCoroutine(MoveToPosition(targetPosition));
    }
    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        // Mover gradualmente al agente hacia la posición objetivo
        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
