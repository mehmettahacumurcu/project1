using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace project1.UIs
{
    public class WinPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}

