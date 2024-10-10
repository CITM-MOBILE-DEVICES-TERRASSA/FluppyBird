using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameplayState : GameState
{
    public override void EnterState(GameManager gameManager)
    {
        Debug.Log("Entering Gameplay State");
        Time.timeScale = 1f;
    }

    public override void UpdateState(GameManager gameManager)
    {
        // Pausar el juego
        if (Input.GetKeyDown(KeyCode.P))
        {
            gameManager.SwitchState(new PauseState());
        }
        // Lógica de gameover (ejemplo)
        if (gameManager.playerHealth <= 0)
        {
            gameManager.SwitchState(new GameOverState());
        }
    }

    public override void ExitState(GameManager gameManager)
    {
        // Nada específico al salir del gameplay
    }
}

