using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace project1.UIs
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        [SerializeField] Button tryAgainButton;
        [SerializeField] Button exitButton;

        private void Awake()
        {
            if (gameOverPanel.activeSelf)
            {
                gameOverPanel.SetActive(false);
            }

            tryAgainButton.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }

        private void HandleOnGameOver()
        {
            gameOverPanel.SetActive(true);
            tryAgainButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);
        }
    }

}
