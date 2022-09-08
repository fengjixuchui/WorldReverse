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
	public class TwoFingerGesture // TypeDefIndex: 7348
	{
		// Fields
		public EasyTouch.GestureType currentGesture; // 0x10
		public EasyTouch.GestureType oldGesture; // 0x14
		public int finger0; // 0x18
		public int finger1; // 0x1C
		public float startTimeAction; // 0x20
		public float timeSinceStartAction; // 0x24
		public Vector2 startPosition; // 0x28
		public Vector2 position; // 0x30
		public Vector2 deltaPosition; // 0x38
		public Vector2 oldStartPosition; // 0x40
		public float startDistance; // 0x48
		public float fingerDistance; // 0x4C
		public float oldFingerDistance; // 0x50
		public bool lockPinch; // 0x54
		public bool lockTwist; // 0x55
		public float lastPinch; // 0x58
		public float lastTwistAngle; // 0x5C
		public GameObject pickedObject; // 0x60
		public GameObject oldPickedObject; // 0x68
		public Camera pickedCamera; // 0x70
		public bool isGuiCamera; // 0x78
		public bool isOverGui; // 0x79
		public GameObject pickedUIElement; // 0x80
		public bool dragStart; // 0x88
		public bool swipeStart; // 0x89
		public bool inSingleDoubleTaps; // 0x8A
		public float tapCurentTime; // 0x8C
	
		// Constructors
		public TwoFingerGesture() {} // 0x0000000180CA76C0-0x0000000180CA7750
	
		// Methods
		// [XID] // 0x000000018980A970-0x000000018980A990
		public void ClearPickedObjectData() {} // 0x0000000180CA7560-0x0000000180CA7610
		// [XID] // 0x0000000189811EF0-0x0000000189811F10
		public void ClearPickedUIData() {} // 0x0000000180CA7610-0x0000000180CA76C0
	}
}
