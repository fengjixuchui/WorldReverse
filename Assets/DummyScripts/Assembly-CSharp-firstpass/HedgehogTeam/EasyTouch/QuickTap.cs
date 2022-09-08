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
	// [AddComponentMenu] // 0x0000000189B54380-0x0000000189B543B0
	public class QuickTap : QuickBase // TypeDefIndex: 7278
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnTap onTap; // 0x70
		public ActionTriggering actionTriggering; // 0x78
		private Gesture currentGesture; // 0x80
	
		// Nested types
		[Serializable]
		public class OnTap : UnityEvent<Gesture> // TypeDefIndex: 7279
		{
			// Constructors
			public OnTap() {} // 0x0000000180C9A700-0x0000000180C9A770
		}
	
		public enum ActionTriggering // TypeDefIndex: 7280
		{
			Simple_Tap = 0,
			Double_Tap = 1
		}
	
		// Constructors
		public QuickTap() {} // 0x0000000180CA1EA0-0x0000000180CA1FB0
	
		// Methods
		// [XID] // 0x0000000189B64DC0-0x0000000189B64DE0
		private void Update() {} // 0x0000000180CA1D30-0x0000000180CA1EA0
		// [XID] // 0x0000000189B6C290-0x0000000189B6C2B0
		private void DoAction(Gesture gesture) {} // 0x0000000180CA1AA0-0x0000000180CA1D30
	}
}
