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
	// [AddComponentMenu] // 0x0000000189B99D80-0x0000000189B99DB0
	public class QuickTwist : QuickBase // TypeDefIndex: 7285
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnTwistAction onTwistAction; // 0x70
		public bool isGestureOnMe; // 0x78
		public ActionTiggering actionTriggering; // 0x7C
		public ActionRotationDirection rotationDirection; // 0x80
		private float axisActionValue; // 0x84
		public bool enableSimpleAction; // 0x88
	
		// Nested types
		[Serializable]
		public class OnTwistAction : UnityEvent<Gesture> // TypeDefIndex: 7286
		{
			// Constructors
			public OnTwistAction() {} // 0x0000000180C9A9A0-0x0000000180C9AA10
		}
	
		public enum ActionTiggering // TypeDefIndex: 7287
		{
			InProgress = 0,
			End = 1
		}
	
		public enum ActionRotationDirection // TypeDefIndex: 7288
		{
			All = 0,
			Clockwise = 1,
			Counterclockwise = 2
		}
	
		// Constructors
		public QuickTwist() {} // 0x0000000180CA3150-0x0000000180CA3270
	
		// Methods
		// [XID] // 0x0000000189BAA3A0-0x0000000189BAA3C0
		public override void OnEnable() {} // 0x0000000180CA2C70-0x0000000180CA2DB0
		// [XID] // 0x0000000189BB1B40-0x0000000189BB1B60
		public override void OnDisable() {} // 0x0000000180CA2BD0-0x0000000180CA2C70
		// [XID] // 0x0000000189BB8C40-0x0000000189BB8C60
		private void OnDestroy() {} // 0x0000000180CA2B30-0x0000000180CA2BD0
		// [XID] // 0x0000000189BC0680-0x0000000189BC06A0
		private void UnsubscribeEvent() {} // 0x0000000180CA3010-0x0000000180CA3150
		// [XID] // 0x0000000189BC7F50-0x0000000189BC7F70
		private void On_Twist(Gesture gesture) {} // 0x0000000180CA2E80-0x0000000180CA2F50
		// [XID] // 0x0000000189BCFBF0-0x0000000189BCFC10
		private void On_TwistEnd(Gesture gesture) {} // 0x0000000180CA2DB0-0x0000000180CA2E80
		// [XID] // 0x0000000189BD6FB0-0x0000000189BD6FD0
		private bool IsRightRotation(Gesture gesture) => default; // 0x0000000180CA29D0-0x0000000180CA2B30
		// [XID] // 0x0000000189BDECC0-0x0000000189BDECE0
		private void DoAction(Gesture gesture) {} // 0x0000000180CA2700-0x0000000180CA29D0
	}
}
