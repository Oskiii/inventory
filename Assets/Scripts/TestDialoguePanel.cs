using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class TestDialoguePanel : MonoBehaviour {
	private DialoguePanel dialoguePanel;
	
	private UnityAction myYesAction;
	private UnityAction myNoAction;
	private UnityAction myCancelAction;
	
	void Awake () {
		dialoguePanel = DialoguePanel.Instance ();
		
		myYesAction = new UnityAction (TestYesFunction);
		myNoAction = new UnityAction (TestNoFunction);
		myCancelAction = new UnityAction (TestCancelFunction);
	}
	
	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestYNC () {
		dialoguePanel.Choice ("Would you like a poke in the eye?\nHow about with a sharp stick?", myYesAction, myNoAction, myCancelAction);
	}
	
	//  These are wrapped into UnityActions
	void TestYesFunction () {
		print ("Heck yeah! Yup!");
	}
	
	void TestNoFunction () {
		print("No way, José!");
	}
	
	void TestCancelFunction () {
		print ("I give up!");
	}
}
