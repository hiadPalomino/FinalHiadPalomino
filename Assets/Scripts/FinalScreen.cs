using UnityEngine;
using UnityEngine.UI;

public class FinalScreen : MonoBehaviour
{
    public Text killsText;
    public Text timeText;

    void Start()
    {
        UpdateFinalScreen();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void UpdateFinalScreen()
    {
        if (killsText != null)
        {
            killsText.text = "Total de Bajas: " + GameManager.TotalKills.ToString();
        }

        if (timeText != null)
        {
            timeText.text = "Tiempo Total: " + FormatTime(GameManager.TotalTime);
        }
    }

    string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
