using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string nombreEscena; // Nombre de la escena a cargar

    void Update()
    {
        // Incrementar el tiempo total con el tiempo transcurrido desde el último frame
        GameManager.AddTime(Time.deltaTime);
    }

    public void OnEnemyKilled()
    {
        // Incrementar el total de bajas cuando un enemigo es eliminado
        GameManager.AddKill();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si la colisión es con la cápsula
        if (other.tag=="Player")
        {
            // Carga la siguiente escena
            SceneManager.LoadScene(nombreEscena);
        }
    }
}
