/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace HedgehogTeam.EasyTouch
{
	public class BaseFinger // TypeDefIndex: 7291
	{
		// Fields
		public int fingerIndex; // 0x10
		public int touchCount; // 0x14
		public Vector2 startPosition; // 0x18
		public Vector2 position; // 0x20
		public Vector2 deltaPosition; // 0x28
		public float actionTime; // 0x30
		public float deltaTime; // 0x34
		public Camera pickedCamera; // 0x38
		public GameObject pickedObject; // 0x40
		public bool isGuiCamera; // 0x48
		public bool isOverGui; // 0x49
		public GameObject pickedUIElement; // 0x50
		public float altitudeAngle; // 0x58
		public float azimuthAngle; // 0x5C
		public float maximumPossiblePressure; // 0x60
		public float pressure; // 0x64
		public float radius; // 0x68
		public float radiusVariance; // 0x6C
		public TouchType touchType; // 0x70
	
		// Constructors
		public BaseFinger() {} // 0x0000000185A1E890-0x0000000185A1E8F0
	
		// Methods
		// [XID] // 0x0000000189609660-0x0000000189609680
		public Gesture GetGesture() => default; // 0x0000000185A1E700-0x0000000185A1E890
	}
}
