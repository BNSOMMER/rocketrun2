using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public Button pauseButton; // Der 2D-Button, der das Spiel pausieren soll
    public GameObject Pause;

    private bool isPaused = false; // Eine boolsche Variable, die anzeigt, ob das Spiel pausiert ist oder nicht

    // Wird aufgerufen, wenn der 2D-Button gedrückt wird
    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0; // Das Spiel wird angehalten
            isPaused = true; // isPaused wird auf true gesetzt
            Pause.SetActive(true);
        }
        else
        {
            Time.timeScale = 1; // Das Spiel wird fortgesetzt
            isPaused = false; // isPaused wird auf false gesetzt
            Pause.SetActive(false);
        }
    }

    // Wird aufgerufen, wenn das Spiel gestartet wird
    private void Start()
    {
        pauseButton.onClick.AddListener(PauseGame); // Der Methode PauseGame wird als Listener für den Button hinzugefügt
    }

    

}

