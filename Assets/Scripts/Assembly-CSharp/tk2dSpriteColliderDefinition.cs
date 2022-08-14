using System;
using UnityEngine;

[Serializable]
public class tk2dSpriteColliderDefinition
{
	public enum Type
	{
		Box = 0,
		Circle = 1,
	}

	public tk2dSpriteColliderDefinition(tk2dSpriteColliderDefinition.Type type, Vector3 origin, float angle)
	{
	}

	public Type type;
	public Vector3 origin;
	public float angle;
	public string name;
	public Vector3[] vectors;
	public float[] floats;
}
