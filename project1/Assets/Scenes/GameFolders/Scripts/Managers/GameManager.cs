using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace project1.managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public event System.Action OnSuccess;
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            SingletonPatternHandler();
        }

        private void SingletonPatternHandler()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }
        public void Success()
        {
           OnSuccess?.Invoke();
        }

        public void OnLevelWasLoaded(int level = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(level));
        }

        private IEnumerator LoadLevelSceneAsync(int levelindex = 0)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelindex);
        }

        public void Exit()
        {
            Debug.Log("Exit process triggered.");
            Application.Quit();
        }
    }

}
