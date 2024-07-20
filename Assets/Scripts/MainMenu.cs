using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string nombreEscena; // Nombre de la escena a cargar
    public GameObject controlsPanel; // Asigna esto en el Inspector
    public GameObject scoresPanel; // Asigna esto en el Inspector
    public GameObject mainMenuPanel; // Asigna el Canvas principal en el Inspector

     public void StartGame()
    {
        GameManager.ResetAll(); // Reinicia el contador de bajas y tiempo
        SceneManager.LoadScene(nombreEscena); // Cargar la escena del primer nivel
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ShowControls()
    {
        controlsPanel.SetActive(true); // Activa el panel de controles
        mainMenuPanel.SetActive(false); // Desactiva el menú principal
    }

    public void ShowScores()
    {
        scoresPanel.SetActive(true); // Activa el panel de puntuaciones
        mainMenuPanel.SetActive(false); // Desactiva el menú principal
    }

    public void ReturnToMainMenu()
    {
        controlsPanel.SetActive(false); // Desactiva el panel de controles
        scoresPanel.SetActive(false); // Desactiva el panel de puntuaciones
        mainMenuPanel.SetActive(true); // Activa el menú principal
    }

    public void QuitGame()
    {
        Application.Quit(); // Salir del juego
    }
}
