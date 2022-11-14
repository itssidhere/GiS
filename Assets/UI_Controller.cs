using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UI_Controller : MonoBehaviour
{
    public Button startButton;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        startButton = root.Q<Button>("start-button");

        startButton.clicked += StartButtonPressed;
    }

    void StartButtonPressed() {
        SceneManager.LoadScene("Visualizer");
    }
    void Update()
    {
        
    }
}
