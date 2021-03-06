﻿using UnityEngine;

public class AvatarController : MonoBehaviour
{

	public int Health;
	public int Attack;
	public int Shield;
	public int Type;
	
	void Start()
	{
		Health = Random.Range(1, 5);
		Attack = Random.Range(1, 5);
		Shield = Random.Range(1, 5);
		Type = Random.Range(1, 5);
	}

	public void SetSprite(Sprite avatarSprite)
	{
		GetComponent<SpriteRenderer>().sprite = avatarSprite;
	} 
}
