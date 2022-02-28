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

        // �Q�[���J�n�{�^��
        private GameObject gameStartButton;
        
        /// <summary>
        /// �J�n����
        /// </summary>
        void Start()
        {
            // ���E�ɂP������MyGameManager����MyGameMAnagerData���擾
            myGameManagerData = FindObjectOfType<MyGameManager>().GetMyGameManagerData();

            // �Q�[���X�^�[�g�{�^�����擾����
            gameStartButton = transform.parent.Find("ButtonPanel/GameStart").gameObject;

            // �Q�[���J�n�{�^���𖳌��ɂ���
            gameStartButton.SetActive(false);
        }

        /// <summary>
        /// �L�����N�^�[�I�����Ɏ��s
        /// </summary>
        public void OnSelectCharacter(GameObject character)
        {
            // �{�^���̑I����Ԃ��������đI�������{�^���̃n�C���C�g�\�����\�ɂ��邽�߂Ɏ��s
            EventSystem.current.SetSelectedGameObject(null);

            // MyGameManagerData�ɃL�����N�^�[�f�[�^���Z�b�g����
            myGameManagerData.SetCharacter(character);

            // �X�^�[�g�{�^����L���ɂ���
            gameStartButton.SetActive(true);
        }

       // �L�����N�^�[��I�������Ƃ��ɔw�i���I���ɂ���
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
