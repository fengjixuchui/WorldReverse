/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace HedgehogTeam.EasyTouch
{
	// [AddComponentMenu] // 0x0000000189AF9A70-0x0000000189AF9AA0
	public class QuickSwipe : QuickBase // TypeDefIndex: 7274
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnSwipeAction onSwipeAction; // 0x70
		public bool allowSwipeStartOverMe; // 0x78
		public ActionTriggering actionTriggering; // 0x7C
		public SwipeDirection swipeDirection; // 0x80
		private float axisActionValue; // 0x84
		public bool enableSimpleAction; // 0x88
	
		// Nested types
		[Serializable]
		public class OnSwipeAction : UnityEvent<Gesture> // TypeDefIndex: 7275
		{
			// Constructors
			public OnSwipeAction() {} // 0x0000000180C9A690-0x0000000180C9A700
		}
	
		public enum ActionTriggering // TypeDefIndex: 7276
		{
			InProgress = 0,
			End = 1
		}
	
		public enum SwipeDirection // TypeDefIndex: 7277
		{
			Vertical = 0,
			Horizontal = 1,
			DiagonalRight = 2,
			DiagonalLeft = 3,
			Up = 4,
			UpRight = 5,
			Right = 6,
			DownRight = 7,
			Down = 8,
			DownLeft = 9,
			Left = 10,
			UpLeft = 11,
			All = 12
		}
	
		// Constructors
		public QuickSwipe() {} // 0x0000000180CA16B0-0x0000000180CA17E0
	
		// Methods
		// [XID] // 0x0000000189B09F10-0x0000000189B09F30
		public override void OnEnable() {} // 0x0000000180CA0DD0-0x0000000180CA0F80
		// [XID] // 0x0000000189B11860-0x0000000189B11880
		public override void OnDisable() {} // 0x0000000180CA0D20-0x0000000180CA0DD0
		// [XID] // 0x0000000189B18AB0-0x0000000189B18AD0
		private void OnDestroy() {} // 0x0000000180CA0C80-0x0000000180CA0D20
		// [XID] // 0x0000000189B20170-0x0000000189B20190
		private void UnsubscribeEvent() {} // 0x0000000180CA1510-0x0000000180CA16B0
		// [XID] // 0x0000000189B27760-0x0000000189B27780
		private void On_Swipe(Gesture gesture) {} // 0x0000000180CA12D0-0x0000000180CA1450
		// [XID] // 0x0000000189B2EAF0-0x0000000189B2EB10
		private void On_SwipeEnd(Gesture gesture) {} // 0x0000000180CA11C0-0x0000000180CA12D0
		// [XID] // 0x0000000189B36300-0x0000000189B36320
		private void On_DragEnd(Gesture gesture) {} // 0x0000000180CA0F80-0x0000000180CA10A0
		// [XID] // 0x0000000189B3D8B0-0x0000000189B3D8D0
		private void On_Drag(Gesture gesture) {} // 0x0000000180CA10A0-0x0000000180CA11C0
		// [XID] // 0x0000000189B45760-0x0000000189B45780
		private bool isRightDirection(Gesture gesture) => default; // 0x0000000180CA17E0-0x0000000180CA1AA0
		// [XID] // 0x0000000189B4CD50-0x0000000189B4CD70
		private void DoAction(Gesture gesture) {} // 0x0000000180CA0B60-0x0000000180CA0C80
	}
}
