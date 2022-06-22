using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Use this for initialization
        void Start ()
        {
                // 要素数5の配列を初期化する
                int[] array = new int[5]{1,2,3,4,5};


                // 配列の要素をすべて表示する
                for (int i = 0; i < 5; i++)
                {
                        Debug.Log (array [i]);
                }
                for (int j = 4; 0<=j ; j--)
                {
                        Debug.Log (array [j]);
                }                


        }

        // Update is called once per frame
        void Update ()
        {

        }
}