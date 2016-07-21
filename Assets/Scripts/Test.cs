using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {


	void Start () {
		Info.FPS (60);


		//	データの作成
		Data.Setup ();
		MotionData data = new MotionData ();
		data.IsLoop = true;
		data.MaxFrame = 60;
		data.KeyFrame = keys;
		data.SlerpT = slerps;
		data.Pos = moves;
		data.Angles = angles;
		Data.Save ("基本_攻撃_1", data);
	}



	//++++++++++++++++++++++++++++++++++++++++
	//	各キーの時間
	//++++++++++++++++++++++++++++++++++++++++
	int[] keys = {
		0,
		30,
	};


	//++++++++++++++++++++++++++++++++++++++++
	//	補間割合
	//++++++++++++++++++++++++++++++++++++++++
	float[] slerps = {
		0.2f,
		0.2f,
	};


	//++++++++++++++++++++++++++++++++++++++++
	//	移動位置
	//++++++++++++++++++++++++++++++++++++++++
	Vector3[] moves = {
		new Vector3 (0, 0, 0),
		new Vector3 (0, 0, 0),
	};


	//++++++++++++++++++++++++++++++++++++++++
	//	回転角度
	//++++++++++++++++++++++++++++++++++++++++
	Vector3[][] angles = {
		new Vector3[] {
			new Vector3 (20, 30, 0),		//	胴体
			new Vector3 (20, 0, 0),			//	頭
			new Vector3 (60, 0, 20),		//	右肩
			new Vector3 (-60, 0, -20),		//	左肩
			new Vector3 (-80, 0, 0),		//	右足
			new Vector3 (40, 0, 0),			//	左足
			new Vector3 (-30, 0, 0),		//	右肘
			new Vector3 (-30, 0, 0),		//	左肘
			new Vector3 (30, 0, 0),			//	右膝
			new Vector3 (30, 0, 0),			//	左膝
		},
		new Vector3[] {
			new Vector3 (0, -30, 0),		//	胴体
			new Vector3 (20, 0, 0),			//	頭
			new Vector3 (-60, 0, 20),		//	右肩
			new Vector3 (60, 0, -20),		//	左肩
			new Vector3 (80, 0, 0),			//	右足
			new Vector3 (-40, 0, 0),		//	左足
			new Vector3 (-30, 0, 0),		//	右肘
			new Vector3 (-30, 0, 0),		//	左肘
			new Vector3 (30, 0, 0),			//	右膝
			new Vector3 (30, 0, 0),			//	左膝
		},
	};

}
