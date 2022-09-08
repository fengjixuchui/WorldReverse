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
	// [AddComponentMenu] // 0x0000000189AA4D30-0x0000000189AA4D60
	public class QuickPinch : QuickBase // TypeDefIndex: 7270
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnPinchAction onPinchAction; // 0x70
		public bool isGestureOnMe; // 0x78
		public ActionTiggering actionTriggering; // 0x7C
		public ActionPinchDirection pinchDirection; // 0x80
		private float axisActionValue; // 0x84
		public bool enableSimpleAction; // 0x88
	
		// Nested types
		[Serializable]
		public class OnPinchAction : UnityEvent<Gesture> // TypeDefIndex: 7271
		{
			// Constructors
			public OnPinchAction() {} // 0x0000000180C9A620-0x0000000180C9A690
		}
	
		public enum ActionTiggering // TypeDefIndex: 7272
		{
			InProgress = 0,
			End = 1
		}
	
		public enum ActionPinchDirection // TypeDefIndex: 7273
		{
			All = 0,
			PinchIn = 1,
			PinchOut = 2
		}
	
		// Constructors
		public QuickPinch() {} // 0x0000000180CA0A40-0x0000000180CA0B60
	
		// Methods
		// [XID] // 0x0000000189AB5400-0x0000000189AB5420
		public override void OnEnable() {} // 0x0000000180CA0310-0x0000000180CA04B0
		// [XID] // 0x0000000189ABCF90-0x0000000189ABCFB0
		public override void OnDisable() {} // 0x0000000180CA0270-0x0000000180CA0310
		// [XID] // 0x0000000189AC4980-0x0000000189AC49A0
		private void OnDestroy() {} // 0x0000000180CA01D0-0x0000000180CA0270
		// [XID] // 0x0000000189ACBFA0-0x0000000189ACBFC0
		private void UnsubscribeEvent() {} // 0x0000000180CA08A0-0x0000000180CA0A40
		// [XID] // 0x0000000189AD3930-0x0000000189AD3950
		private void On_Pinch(Gesture gesture) {} // 0x0000000180CA0710-0x0000000180CA07E0
		// [XID] // 0x0000000189ADB4B0-0x0000000189ADB4D0
		private void On_PinchIn(Gesture gesture) {} // 0x0000000180CA0570-0x0000000180CA0640
		// [XID] // 0x0000000189AE2C20-0x0000000189AE2C40
		private void On_PinchOut(Gesture gesture) {} // 0x0000000180CA0640-0x0000000180CA0710
		// [XID] // 0x0000000189AEA760-0x0000000189AEA780
		private void On_PichEnd(Gesture gesture) {} // 0x0000000180CA04B0-0x0000000180CA0570
		// [XID] // 0x0000000189AF2090-0x0000000189AF20B0
		private void DoAction(Gesture gesture) {} // 0x0000000180C9FEE0-0x0000000180CA01D0
	}
}
