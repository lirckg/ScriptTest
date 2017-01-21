using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2{
	private int hp = 100;	//体力
	private int power = 25;	//攻撃力
	private int mp = 53;	//魔法

	// 攻撃用の関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	// 防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}

	// 魔法用の関数
	public void Magic(){
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		}else{
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Kadai2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Boss2 boss = new Boss2 ();

		for (int i = 0; i < 15; i++) {
			boss.Magic ();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
