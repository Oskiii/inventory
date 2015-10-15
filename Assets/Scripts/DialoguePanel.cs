using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;
using System.Collections;

public class DialoguePanel : MonoBehaviour {

	public GameObject dialoguePanelObject;
	public Text question;
	public Image iconImage;
	public Button button1;
	public Button button2;


	private static DialoguePanel dialoguePanel;
	
	public static DialoguePanel Instance () {
		if (!dialoguePanel) {
			dialoguePanel = FindObjectOfType(typeof (DialoguePanel)) as DialoguePanel;
			if (!dialoguePanel)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
		}
		
		return dialoguePanel;
	}
	

	public void Choice (string question, UnityAction yesEvent, UnityAction noEvent, UnityAction cancelEvent) {
		dialoguePanelObject.SetActive (true);
		
		button1.onClick.RemoveAllListeners();
		button1.onClick.AddListener (yesEvent);
		button1.onClick.AddListener (ClosePanel);
		
		button2.onClick.RemoveAllListeners();
		button2.onClick.AddListener (noEvent);
		button2.onClick.AddListener (ClosePanel);
		
		this.question.text = question;
		
		this.iconImage.gameObject.SetActive (false);
		button1.gameObject.SetActive (true);
		button2.gameObject.SetActive (true);
	}

	void ClosePanel () {
		dialoguePanelObject.SetActive (false);
	}

	void Start(){

	}

}
