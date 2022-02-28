using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SelectCharacter
{
    public class ChooseCharacter : MonoBehaviour
    {
        private MyGameManagerData myGameManagerData;

        // ゲーム開始ボタン
        private GameObject gameStartButton;
        
        /// <summary>
        /// 開始処理
        /// </summary>
        void Start()
        {
            // 世界に１つだけのMyGameManagerからMyGameMAnagerDataを取得
            myGameManagerData = FindObjectOfType<MyGameManager>().GetMyGameManagerData();

            // ゲームスタートボタンを取得する
            gameStartButton = transform.parent.Find("ButtonPanel/GameStart").gameObject;

            // ゲーム開始ボタンを無効にする
            gameStartButton.SetActive(false);
        }

        /// <summary>
        /// キャラクター選択時に実行
        /// </summary>
        public void OnSelectCharacter(GameObject character)
        {
            // ボタンの選択状態を解除して選択したボタンのハイライト表示を可能にするために実行
            EventSystem.current.SetSelectedGameObject(null);

            // MyGameManagerDataにキャラクターデータをセットする
            myGameManagerData.SetCharacter(character);

            // スタートボタンを有効にする
            gameStartButton.SetActive(true);
        }

       // キャラクターを選択したときに背景をオンにする
       public void SwitchButtonBackground(int buttonNumber)
        {
            for(int i=0; i<transform.childCount;i++)
            {
                if(i==buttonNumber-1)
                {
                    transform.GetChild(i).Find("BackGround").gameObject.SetActive(true);
                }
                else
                {
                    transform.GetChild(i).Find("BackGround").gameObject.SetActive(false);
                }
            }
        }
    }
}
