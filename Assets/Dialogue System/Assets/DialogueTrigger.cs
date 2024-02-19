using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialgue dialogue;

	public void TriggerDialogue ()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

}
