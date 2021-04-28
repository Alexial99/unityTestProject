using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
	private float _countHitedCube = 0f;
	[SerializeField]
	private Text _text;

	private const string BarrierName = "cube :";
	
	public  void changeText()
	{
		_countHitedCube++;
		_text.text = BarrierName  + _countHitedCube;
	}
}