﻿using System.Collections.Generic;
using UnityEngine;

public class ModeController : MonoBehaviour
{

	public class Count
	{
		public int minimum;
		public int maximum;

		public Count(int min, int max)
		{
			minimum = min;
			maximum = max;
		}
	}

	public Field fields;
	[HideInInspector]
	public static List<FieldType> currentModefields = new List<FieldType>();

	void Start()
	{
		foreach (FieldType types in fields.fields)
			currentModefields.Add(types);
	}

	public static void GetCurrentShape(Shape shape)
	{
		foreach (FieldType types in currentModefields)
		{
			if (types.shape != shape) continue;
			
			GameManager.Instance.countToClear = types.cellsToSpawn;
			GameManager.Instance.countToSpawn = types.cellsToSpawn;
			GameManager.Instance.SetUpField(types);
			break;
		}
	}
}
