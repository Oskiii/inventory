using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {

	public Sprite charIcon;
	public string charName;
	public List<DialogueNode> charDialogue;

	[System.Serializable]
	public class DialogueNode{
		public int dialogueID;
		public string dialogue;
		public int nextID;
		public bool hasAnswers;
		public AnswerNode answer1;
		public AnswerNode answer2;

	}

	[System.Serializable]
	public class AnswerNode{
		public string answer;
		public string nextID;
	}

	void Start(){
		charDialogue = new List<DialogueNode>();
	}

}
