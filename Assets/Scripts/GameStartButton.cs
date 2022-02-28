using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SelectCharacter
{
    public class GameStartButton : MonoBehaviour
    {
        private SceneTransition sceneTransition;

        //開始処理
        private void Start()
        {
            sceneTransition = FindObjectOfType<SceneTransition>();
        }

        public void OnGameStart()
        {
            // MyGameManagerDataに保存されている次のシーンに移動する
            sceneTransition.GameStart();
        }

    }
}
