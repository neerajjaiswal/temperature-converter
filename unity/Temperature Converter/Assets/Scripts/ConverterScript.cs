using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConverterScript : MonoBehaviour {

	public Text inputTemperature;
	public Text outputTemperature;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void handleCelsiusButtonClick(){
		Debug.Log ("handleCelsiusButtonClick");

		float fahrenheit = float.Parse(inputTemperature.text);

		float celsius = ((fahrenheit - 32)*5)/9;

		outputTemperature.text = celsius.ToString()+" Celsius";

	}

	public void handleFahrenheitButtonClick(){
		Debug.Log ("handleFahrenheitButtonClick");

		float celsius = float.Parse(inputTemperature.text);

		float fahrenheit = (celsius * 9 / 5) + 32;

		outputTemperature.text = fahrenheit.ToString()+" Fahrenheit";
	}
}
