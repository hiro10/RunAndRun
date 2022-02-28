using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SelectCharacter
{
    public class MyGameManager : MonoBehaviour
    {
        // ���E��1������MyGameManager
        private static MyGameManager myGameManager;

        // �Q�[���S�̂ŊǗ�����f�[�^
        [SerializeField]
        private MyGameManagerData myGameManagerData = null;

        private void Awake()
        {
            // ���E�ɂP�����̂�MyGameManager�ɂ��鏈��
            if(myGameManager==null)
            {
                myGameManager = this;
                DontDestroyOnLoad(this);

            }
            else
            {
                Destroy(gameObject);
            }
        }

        public MyGameManagerData GetMyGameManagerData()
        {
            return myGameManagerData;
        }
    }
}
