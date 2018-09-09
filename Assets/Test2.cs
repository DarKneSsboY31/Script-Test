using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;     //魔力

    public void Magic() {
        for(int i = mp;i > 0; i-= 5) { 
        if(mp > 5) { 
        //魔法攻撃の関数の作成、魔法が津会える状態（MP 5以上）なら、魔法使用の表示+MP　5消費
        this.mp -= 5;
        Debug.Log( "魔法攻撃をした。残りMPは"+mp+"。");
        }
        else
        {
        //魔力が5以下の場合、使えない旨を表示
        Debug.Log("MPが足りない為、魔法が使えない。");
        }
    }
}
}

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Bossクラスの変数を宣言。インスタンスの代入。
        Boss bigmagic = new Boss();

        //魔法の関数を呼び出す。
        bigmagic.Magic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}