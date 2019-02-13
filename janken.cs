using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class janken : MonoBehaviour {

	
	public GameObject begin;
	
	public GameObject gu;
	
	public GameObject choki;
	
	public GameObject pa;
	

	// Use this for initialization
	void Start () {
		
		this.choki = GameObject.Find("choki");
		
		this.gu = GameObject.Find("gu");
		
		this.pa = GameObject.Find("pa");
		
		this.begin = GameObject.Find("begin");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			int n = Random.Range(0,3);
			
			switch(n){
				case 0:
					this.gu.GetComponent<Image>().enabled = true;
					this.begin.GetComponent<Text>().enabled = false;
					
					break;
					
				case 1:
					this.choki.GetComponent<Image>().enabled = true;
					this.begin.GetComponent<Text>().enabled = false;
					
					break;
					
				case 2:
					this.pa.GetComponent<Image>().enabled = true;
					this.begin.GetComponent<Text>().enabled = false;
					
					break;
			}
		}
	}
}
