using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    menu,
    inGame,
    pause,
    gameOver
}

public class GameManager : MonoBehaviour
{
    #region Singleton 
    public static GameManager sharedInstance;
    #endregion
    [SerializeField] GameState currentGameState;
    private PlayerMovement movement;
  


    private void Awake()
    {
        #region Singleton
        if (sharedInstance == null)
            sharedInstance = this;
        #endregion
    }
    void Start()
    {
        currentGameState = GameState.gameOver;
        movement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            StartGame();
        }

    }

    public void StartGame()
    {
        SetGameState(GameState.inGame);
    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    public void BackToGame()
    {
        SetGameState(GameState.menu);
    }

    private void SetGameState(GameState newGameState)
    {
        if(newGameState == GameState.menu)
        {

        }
        else if(newGameState == GameState.inGame)
        {
            // Panel de In Game
            movement.StartGame();

            // Ocultar menu de pausa
            MenuManager.sharedInstance.HidePauseCanvas();
        }
        else if(newGameState == GameState.pause)
        {
            // Mostrar Menu de Pausa
            MenuManager.sharedInstance.ShowPauseCanvas();
        }
        else if(newGameState == GameState.gameOver)
        {
            // Panel de Muerte
        }

    }
}
