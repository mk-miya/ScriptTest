using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int mp = 53;          // 魔力
	private int power = 25; // 攻撃力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	// 魔法用の関数
	public  void Magic() { 

		if (this.mp < 5) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			// 残りmpを減らす
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは"+this.mp);
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Boss lastboss = new Boss ();
		int[] array = new int[5];

		array [0] = 1;
		array [1] = 2;
		array [2] = 3;
		array [3] = 4;
		array [4] = 5;

		// 各要素を順番に表示
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		// 各要素を逆順に表示
		for (int j = 4; j >= 0; j--) {
			Debug.Log (array [j]);
		}

		// Magic関数の呼び出し
		for (int k = 0; k < 11 ; k++) {
			lastboss.Magic();
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
