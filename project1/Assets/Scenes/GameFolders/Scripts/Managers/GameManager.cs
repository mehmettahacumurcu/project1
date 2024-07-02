using project1.abstracts.utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace project1.managers
{
    public class GameManager : SingletonHandler<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnSuccess;

        private void Awake()
        {
            SingletonPatternHandler(this);
            
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
            Debug.Log("Gameover Invoked.");
        }

        public void Success()
        {
            OnSuccess?.Invoke();
            Debug.Log("Success Invoked.");
        }

        public void LoadLevelScene(int level = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(level));
        }

        private IEnumerator LoadLevelSceneAsync(int levelindex = 0)
        {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelindex);
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }

        public void Exit()
        {
            Debug.Log("Exit process triggered.");
            Application.Quit();
        }
    }

}
