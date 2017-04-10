using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss {

	private int mp = 53;

	public void Magic(int wasteMp){
		
		this.mp -= wasteMp;
		if (mp >= 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

}

public class Test : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

		int[] array = { 10, 20, 30, 40, 50 };
		for(int i = 0; i<array.Length; i++){
			Debug.Log (array [i]);
		}
		for(int i = array.Length-1 ; i>=0; i--){
			Debug.Log (array [i]);
		}
		Boss lastboss = new Boss ();

		for(int i = 0; i<10; i++){
			lastboss.Magic (5);
		}
		lastboss.Magic (5);
	}
}
