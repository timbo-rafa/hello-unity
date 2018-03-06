using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMeButton : MonoBehaviour {

	private int times = 0;

	public Button clickMeButton;

	public Text helloLabel;
	// Use this for initialization
	void Start () {
		this.clickMeButton.onClick.AddListener (this.clickHandler);
	}

	public void clickHandler() {
		times = times + 1;
		this.helloLabel.text = "Clicked " + times + " times!";
	}
}
