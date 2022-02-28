using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SelectCharacter
{
    public class MyGameManager : MonoBehaviour
    {
        // ¢ŠE‚É1‚Â‚¾‚¯‚ÌMyGameManager
        private static MyGameManager myGameManager;

        // ƒQ[ƒ€‘S‘Ì‚ÅŠÇ—‚·‚éƒf[ƒ^
        [SerializeField]
        private MyGameManagerData myGameManagerData = null;

        private void Awake()
        {
            // ¢ŠE‚É‚P‚Â‚¾‚¯‚Ì‚ÌMyGameManager‚É‚·‚éˆ—
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
