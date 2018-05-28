using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI部品を使うために必要!

public class GameDirector : MonoBehaviour {

    GameObject car;
    GameObject flag;
    GameObject distance;

    private void Start() { 
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("Flag");
        this.distance = GameObject.Find("Distance");
    }

	void Update () {
        float lenth = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "ゴールまで" + lenth.ToString("F2") + "m";	
	}
}
