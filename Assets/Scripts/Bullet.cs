using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 10;

    void Start()
    {
        Destroy(gameObject, 2f); // Destruir la bala después de 2 segundos
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Aquí puedes manejar la colisión si es necesario
    }
}
