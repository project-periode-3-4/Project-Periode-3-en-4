using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

	public void loadRace () {
		Application.LoadLevel ("scene1");
	}
	public void color () {
		Application.LoadLevel ("autoColor");
	}

	public void loadCredits () {
		Application.LoadLevel ("Credits");
	}

	public void loadInstructions () {
		Application.LoadLevel ("Instructions");
	}

	public void back () {
		Application.LoadLevel ("Home");
	}

	public void exit () {
		Application.Quit();
	}
}
