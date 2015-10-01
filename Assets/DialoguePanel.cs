using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DialoguePanel : MonoBehaviour {

	public GameObject questionPanel;
	public GameObject answerPanel;
	public List<dialogueNode> nodeList;

	[System.Serializable]
	public class dialogueNode{
		public Sprite speakerIcon;
		public int dialogueNodeID;
		public string question;
		public string answer1;
		public string answer2;
		public string answer3;
		public int nextNodeID;
	}
	


	void Start(){

	}

}
