using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace project1.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();
            if(this.gameObject.activeSelf)
                { this.gameObject.SetActive(false); }
        }

        public void NoClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}

