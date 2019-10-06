using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
	public GameObject carPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;

	public GameObject unitychan;


	private int startPos = -160;
	private int goalPos =120;
	private float posRange = 3.4f;

	private float difference; //最後にアイテム生成した位置から進んだ距離

	public float generatePosZ; //アイテム生成時のunitychanのZ座標



	// Use this for initialization
	void Start () {

		this.unitychan = GameObject.Find ("unitychan"); //unitychanの情報取得
		this.generatePosZ = -240;

		}

	void Update () {

		this.difference = this.unitychan.transform.position.z - generatePosZ;


		if( difference > 15 ){


				int num = Random.Range (1,11);
				if(num <= 2){
					for(float j = -1; j <= 1; j += 0.4f){
						GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, unitychan.transform.position.z + 45);
					}
				}else{
					for(int j = -1; j <= 1; j++){
						int item = Random.Range(1,11);
						int offsetZ = Random.Range(-5,6);
						if(1 <= item && item <=6){
							GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 45 + offsetZ);
						}else if(7 <= item && item <= 9){
							GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3(posRange * j , car.transform.position.y, unitychan.transform.position.z + 45 + offsetZ);
						}

					    }
		             }
			                generatePosZ = unitychan.transform.position.z;//アイテム生成時の座標を更新
		       }

	}


		
			


}
