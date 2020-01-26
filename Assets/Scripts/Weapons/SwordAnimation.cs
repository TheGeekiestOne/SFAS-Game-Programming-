using UnityEngine;
using System.Collections;
/*
 * Created by : Ayran Olckers
 * 01/2020
 */
public class SwordAnimation : MonoBehaviour {
	

	public bool isSwinging;
	public void Start()
	{
		isSwinging = false;
	}
	 public void Swing(){
	 if (Input.GetMouseButtonDown(1))
     {
         GetComponent<Animator>().SetTrigger("RightClick");
     }
	}

	public void toggleIsSwinging()
	{
		if (isSwinging) {
			isSwinging = false;
		} else {
			isSwinging = true;
		}
	}
	 
	
}
