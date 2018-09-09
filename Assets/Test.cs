using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        //配列arrayを初期化
        int [] array = { 40, 30, 52, 56, 99};

        //配列arrayの各要素を表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //配列arrayの各要素を逆順に表示
        for (int m = array.Length -1 ; 0 <= m ; m--) {      
            Debug.Log(array[m]);
        }

    }
        // Update is called once per frame
        void Update () {
		
	}
}
