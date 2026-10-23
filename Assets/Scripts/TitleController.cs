using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    
    public static TitleController instance;
    public InputActionReference start;
    // Called First
    void Awake()
    {
       instance = this; 
    }

    void OnEnable()
    {
        start.action.Enable();
    }

    void OnDisable()
    {
        start.action.Disable();
    }

    // Called Second
    void Start()
    {
        
    }

    // Called Every Frame After Start
    void Update()
    {
        if(start.action.WasPressedThisFrame())
        {
            SceneManager.LoadScene("Game");
        }
    }
}
