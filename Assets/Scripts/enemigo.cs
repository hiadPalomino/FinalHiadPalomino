using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100; // Vida máxima del enemigo
    private int currentHealth; // Vida actual del enemigo
    public Text healthText; // Texto para mostrar la vida del enemigo en la interfaz de usuario
    public int daño = 10;
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 private void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisión es con un objeto de la etiqueta "Enemigo"
        if (collision.gameObject.CompareTag("Bala"))
        {
            TakeDamage(daño);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    

    void Die()
    {
        Destroy(gameObject);
        GameManager.AddKill();
    }
    void UpdateHealthUI()
    {
        healthText.text = "Vida: " + currentHealth.ToString(); // Actualizar el texto de la vida en la interfaz de usuario
    }
}
