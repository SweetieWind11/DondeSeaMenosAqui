using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance { get; private set; }

    // Este es un gamestatemanager pensado para poder
    // gestionar el estado de juego de manera mas facil que solo congelar el tiempo vea
    public enum GameState
    {
        Game,
        Pause,
        GameOver
    }
    public GameState CurrentState { get; private set; }

    private void Awake()
    {
        // Configurar singleton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator ChangeState(GameState newState)
    {
        switch (CurrentState)
        {
            case GameState.Game:
                    break;

            case GameState.Pause:
                break;

            case GameState.GameOver:
                break;
        }

     
        yield return null;

        CurrentState = newState;

        switch (newState)
        {
            case GameState.Game: //ps pa que se mueva lo dejo como gamestate por si quieres añadir mas cosas
                Time.timeScale = 1f;
                break;

            case GameState.Pause:
                Time.timeScale = 0f; //Pa evitar movimiento
                break;

            case GameState.GameOver: //Pa evitar movimiento x2 
                Time.timeScale = 0f;
                break;
        }
    }

}