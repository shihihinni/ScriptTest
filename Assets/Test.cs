using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
        private int mp = 53;          // 体力

        // 攻撃用の関数
        public void Magic()
        {
                if (mp>=5)
                {
                        mp -= 5; 
                        Debug.Log( "魔法攻撃をした。残りMPは"+mp );
                }
                else if (5>mp)
                {
                        Debug.Log( "MPが足りないため、魔法が使えない。" );
                        
                }
                
                
        }

}

public class Test : MonoBehaviour
{

        void Start ()
        {
                // Bossクラスの変数を宣言してインスタンスを代入
                Boss lastboss = new Boss ();
                
                for (int i = 1; i <= 11; i++)
                {
                        // 攻撃用の関数を呼び出す
                        lastboss.Magic();
                }

        }

        // Update is called once per frame
        void Update ()
        {

        }
}