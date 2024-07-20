using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public Text killsText;

    void Start()
    {
        UpdateKillsUI();
    }

    void OnEnable()
    {
        // Suscribirse al evento de actualización de bajas
        GameManager.OnKillsChanged += UpdateKillsUI;
    }

    void OnDisable()
    {
        // Cancelar suscripción al evento de actualización de bajas
        GameManager.OnKillsChanged -= UpdateKillsUI;
    }

    void UpdateKillsUI()
    {
        if (killsText != null)
        {
            killsText.text = "Bajas: " + GameManager.TotalKills.ToString();
        }
    }
}
