using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class StartState : GameState
{
    public override void EnterState(GameManager gameManager)
    {
        Debug.Log("Entering Start State");
        // Mostrar UI para iniciar el juego
        gameManager.startCanvas.SetActive(true);
        gameManager.pauseCanvas.SetActive(false);
        gameManager.gameOverCanvas.SetActive(false);
        Time.timeScale = 0f;
    }

    public override void UpdateState(GameManager gameManager)
    {
        // Espera la entrada del jugador para iniciar el juego
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameManager.SwitchState(new GameplayState());
        }
    }

    public override void ExitState(GameManager gameManager)
    {
        gameManager.startCanvas.SetActive(false);
    }
}

