using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace project1.abstracts.utils
{
    public abstract class SingletonHandler<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }


       

        protected void SingletonPatternHandler(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

