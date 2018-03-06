using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManage : MonoBehaviour {
	public Questions[] questions;
	private static List<Questions> unansweredQuestions;
	private Questions currentQuestion;

	void Start()
	{
		if (unansweredQuestions == null || unansweredQuestions.Count == 0) 
		{
			unansweredQuestions = questions.ToList<Questions>();
			Debug.Log ("Haha " + unansweredQuestions.Count);
		}
		SetCurrentQuestion();
		Debug.Log(currentQuestion.fact + "is" + currentQuestion.isTrue);	
	}
	void SetCurrentQuestion()
	{
		int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions[randomQuestionIndex];
		unansweredQuestions.RemoveAt(randomQuestionIndex);
	}

}
