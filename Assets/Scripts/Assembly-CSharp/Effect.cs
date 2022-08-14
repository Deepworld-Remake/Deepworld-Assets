using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Effect : Configurable
{
	public enum CollisionType
	{
		None = 0,
		Spawn = 1,
		Death = 2,
	}

	public Effect(Config config, string name, Dictionary<string, object> cfg) : base(default(Config), default(string), default(Dictionary<string, object>))
	{
	}

	public GameObject prefab;
	public float life;
	public bool collides;
	public float gravity;
	public float density;
	public float frequency;
	public float speedBase;
	public float speedRange;
	public float angularSpeedBase;
	public float angularSpeedRange;
	public float angleBase;
	public float angleRange;
	public Vector2 positionRange;
	public bool freezeRotation;
	public float scaleBase;
	public float scaleRange;
	public Color colorRange;
	public List<tk2dSpriteDefinition> sprites;
	public bool animatedSprite;
	public bool loopAnimation;
	public int fps;
	public string sound;
	public CollisionType collisionType;
	public Item.Damage damageType;
	public float damage;
}
