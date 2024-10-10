using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : GameState
{
    public override void EnterState(GameManager gameManager)
    {
        Debug.Log("Entering Game Over State");
        gameManager.gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        // Iniciar un retraso para reiniciar el juego
        gameManager.StartCoroutine(RestartAfterDelay(gameManager, 2f));
    }

    public override void UpdateState(GameManager gameManager)
    {
        // No se necesita update, el juego se reinicia tras el retraso
    }

    public override void ExitState(GameManager gameManager)
    {
        gameManager.gameOverCanvas.SetActive(false);
    }

    private IEnumerator RestartAfterDelay(GameManager gameManager, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        gameManager.SwitchState(new StartState());
    }
}

