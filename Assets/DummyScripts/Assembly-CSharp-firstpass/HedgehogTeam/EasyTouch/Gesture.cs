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
	public class Gesture : BaseFinger, ICloneable // TypeDefIndex: 7347
	{
		// Fields
		public EasyTouch.SwipeDirection swipe; // 0x78
		public float swipeLength; // 0x7C
		public Vector2 swipeVector; // 0x80
		public float deltaPinch; // 0x88
		public float twistAngle; // 0x8C
		public float twoFingerDistance; // 0x90
		public EasyTouch.EvtType type; // 0x94
	
		// Constructors
		public Gesture() {} // 0x0000000180B34880-0x0000000180B348F0
	
		// Methods
		// [XID] // 0x00000001897B8FE0-0x00000001897B9000
		public Gesture CloneGesture() => default; // 0x0000000180B33CA0-0x0000000180B33E30
		// [XID] // 0x00000001897C1130-0x00000001897C1150
		public object Clone() => default; // 0x0000000180B33E30-0x0000000180B33EE0
		// [IDTag] // 0x00000001897C8AC0-0x00000001897C8B00
		// [XID] // 0x00000001897C8AC0-0x00000001897C8B00
		public Vector3 GetTouchToWorldPoint(float z) => default; // 0x0000000180B341B0-0x0000000180B34340
		// [IDTag] // 0x00000001897D2F20-0x00000001897D2F60
		// [XID] // 0x00000001897D2F20-0x00000001897D2F60
		public Vector3 GetTouchToWorldPoint(Vector3 position3D) => default; // 0x0000000180B34340-0x0000000180B34530
		// [XID] // 0x00000001897DD660-0x00000001897DD680
		public float GetSwipeOrDragAngle() => default; // 0x0000000180B340A0-0x0000000180B341B0
		// [XID] // 0x00000001897E4FD0-0x00000001897E4FF0
		public Vector2 NormalizedPosition() => default; // 0x0000000180B34760-0x0000000180B34880
		// [XID] // 0x00000001897ECC10-0x00000001897ECC30
		public bool IsOverUIElement() => default; // 0x0000000180B34690-0x0000000180B34760
		// [XID] // 0x00000001897F44C0-0x00000001897F44E0
		public bool IsOverRectTransform(RectTransform tr, Camera camera = null) => default; // 0x0000000180B34530-0x0000000180B34690
		// [XID] // 0x00000001897FBFA0-0x00000001897FBFC0
		public GameObject GetCurrentFirstPickedUIElement(bool isTwoFinger = false /* Metadata: 0x00ADE99F */) => default; // 0x0000000180B33EE0-0x0000000180B33FC0
		// [XID] // 0x00000001898032B0-0x00000001898032D0
		public GameObject GetCurrentPickedObject(bool isTwoFinger = false /* Metadata: 0x00ADE9A0 */) => default; // 0x0000000180B33FC0-0x0000000180B340A0
	}
}
