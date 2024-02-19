﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialgueProto : MonoBehaviour{
	public TextMeshProUGUI textComponent;
	public string[] lines;
	[SerializeField] public float textSpeed;
	private int index;


	public string name;


	public string[] sentences;

	void Start()
	{
		textComponent.text = string.Empty;
		StartDialouge();
	}
    private void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			if(textComponent.text == lines[index])
			{
				NextLine();
			}
			else
			{
				StopAllCoroutines();
				textComponent.text = lines[index];
			}
		}
    }

    void StartDialouge()
	{
		index = 0;
		StartCoroutine(TypeLine());
		
		
		
	}

	IEnumerator TypeLine()
	{
		foreach(char c in lines[index].ToCharArray())
		{
			textComponent.text += c;
			yield return new WaitForSeconds(textSpeed);
		}
	}

	void NextLine()
	{
		if(index < lines.Length - 1)
		{
			index++;
			textComponent.text = string.Empty;
			StartCoroutine(TypeLine());
		}
		else
		{
			gameObject.SetActive(false);
		}
	}



}
