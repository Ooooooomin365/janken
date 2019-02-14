using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
	public void trygu() {
		int n = Random.Range(0,3);	
		switch(n){
			case 0:
				this.gu.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetodraw();
				break;
					
			case 1:
				this.choki.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetowin();
				break;
					
			case 2:
				this.pa.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetolose();
				break;
		}
	}
	
	public void trychoki() {
		int m = Random.Range(0,3);	
		switch(m){
			case 0:
				this.gu.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetolose();
				break;
					
			case 1:
				this.choki.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetodraw();
				break;
					
			case 2:
				this.pa.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetowin();
				break;
		}
	}
	
	public void trypa(){
		int l = Random.Range(0,3);	
		switch(l){
			case 0:
				this.gu.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetowin();
				break;
					
			case 1:
				this.choki.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetolose();
				break;
					
			case 2:
				this.pa.GetComponent<Image>().enabled = true;
				this.begin.GetComponent<Text>().enabled = false;
				movetodraw();
				break;
		}
	}
	
	public void movetowin(){
		FadeManager.Instance.LoadScene("WinScene", 2.0f);
	}
	
	public void movetodraw(){
		FadeManager.Instance.LoadScene("DrawScene", 2.0f);
	}
	
	public void movetolose(){
		FadeManager.Instance.LoadScene("LoseScene", 2.0f);
	}
}
