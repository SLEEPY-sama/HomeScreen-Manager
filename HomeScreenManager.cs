using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene loading

public class HomeScreenManager : MonoBehaviour
{
    // 🔹 Function to Load Garage Scene
    public void LoadGarage()
    {
        SceneManager.LoadScene(0);
    }

    // 🔹 Function to Start the Game
    public void StartGame()
    {
        PlayerPrefs.SetInt("SelectedCar", 2);
        PlayerPrefs.Save(); // Ensure data is saved

        // 🔹 Load game scene (index 1)
        SceneManager.LoadScene(1);

    }

    // 🔹 Function to Open Settings
    public void OpenSettings()
    {
        SceneManager.LoadScene(2);
    }

    // 🔹 Function to Quit the Game
    public void QuitGame()
    {
        // Works in Build Mode (won't work in Unity Editor)
        Application.Quit();

        // 🔹 To make sure it works in the editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
