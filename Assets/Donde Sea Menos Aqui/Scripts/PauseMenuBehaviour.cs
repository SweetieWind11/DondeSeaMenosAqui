using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject m_pausePanel;
    void Start()
    {
        m_pausePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenAndClosePausePanel();
        }
    }
    public void OpenAndClosePausePanel()
    {
        //Cambia entre estados y comprueba si esta en game para ir a pausa y viceversa
        if (GameStateManager.Instance.CurrentState == GameStateManager.GameState.Game)
        {
            m_pausePanel.SetActive(true);
            StartCoroutine(GameStateManager.Instance.ChangeState(GameStateManager.GameState.Pause));
        }
        else if (GameStateManager.Instance.CurrentState == GameStateManager.GameState.Pause)
        {
            m_pausePanel.SetActive(false);
            StartCoroutine(GameStateManager.Instance.ChangeState(GameStateManager.GameState.Game));
        }

    }
}
