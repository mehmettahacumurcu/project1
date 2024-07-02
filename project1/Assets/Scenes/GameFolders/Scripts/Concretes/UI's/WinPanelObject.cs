using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace project1.UIs
{
    public class WinPanelObject : MonoBehaviour
    {
        [SerializeField] GameObject winPanel;
        [SerializeField] Button nextLevelButton;

        private void Awake()
        {
            if (winPanel.activeSelf)
            {
                winPanel.SetActive(false);
            }

            if (nextLevelButton.gameObject.activeSelf)
            {
                nextLevelButton.gameObject.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnSuccess += WinHandler;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnSuccess -= WinHandler;
        }

        private void WinHandler()
        {
            winPanel.SetActive(true);
            nextLevelButton.gameObject.SetActive(true);
        }
    }
}

