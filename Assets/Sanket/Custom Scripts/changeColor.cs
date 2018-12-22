using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {

	public void changeMeToWhite(){
		Debug.Log ("color recieved = " + Color.white.ToString());
		changeMe (Color.white);
	}


	public void changeMeToBlack(){

		//Color colorRecieved = Color.
		Debug.Log ("color recieved = " + Color.black.ToString());
		changeMe (Color.black);
	}

	public void changeMeToRed(){

		//Color colorRecieved = Color.
		Debug.Log ("color recieved = " + Color.green.ToString());
		changeMe (Color.red);
	}

	public void changeMeToSilver(){

		//Color colorRecieved = Color.
		Debug.Log ("color recieved = " + Color.green.ToString());
		changeMe (Color.gray);
	}

	public void changeMeToBlue(){

		//Color colorRecieved = Color.
		Debug.Log ("color recieved = " + Color.blue.ToString());
		changeMe (Color.HSVToRGB(0,82,218));
	}

	private void changeMe(Color color){

		GameObject[] objects = GameObject.FindGameObjectsWithTag ("carPaintMesh");
		foreach (GameObject obj in objects) {
			Material[] mats = obj.GetComponent<Renderer>().materials;
			foreach (Material mat in mats) {
				//Debug.Log (mat.name);
				bool a = mat.name.Contains ("CarPaint");
				//Debug.Log (a);
				if (mat.name.Contains ("CarPaint")) {
					//Debug.Log ("------------------COMPARISON--------------");
					//Debug.Log (mat.name);
					mat.color = color;
				}
			}
			obj.GetComponent<Renderer> ().materials = mats;
		}

	}
		
}
