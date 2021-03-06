﻿using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour {
	public Animator animator;
	private Text damageText;

	void OnEnable()
	{
		animator = gameObject.GetComponentInChildren<Animator>();
		AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
		Destroy(gameObject, clipInfo[0].clip.length);
		damageText = animator.GetComponent<Text>();
	}

	public void SetText(string text)
	{
		damageText.text = text;
	}
}