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
	// [AddComponentMenu] // 0x0000000189B73990-0x0000000189B739C0
	public class QuickTouch : QuickBase // TypeDefIndex: 7281
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnTouch onTouch; // 0x70
		public OnTouchNotOverMe onTouchNotOverMe; // 0x78
		public ActionTriggering actionTriggering; // 0x80
		private Gesture currentGesture; // 0x88
	
		// Nested types
		[Serializable]
		public class OnTouch : UnityEvent<Gesture> // TypeDefIndex: 7282
		{
			// Constructors
			public OnTouch() {} // 0x0000000180C9A930-0x0000000180C9A9A0
		}
	
		[Serializable]
		public class OnTouchNotOverMe : UnityEvent<Gesture> // TypeDefIndex: 7283
		{
			// Constructors
			public OnTouchNotOverMe() {} // 0x0000000180C9A850-0x0000000180C9A8C0
		}
	
		public enum ActionTriggering // TypeDefIndex: 7284
		{
			Start = 0,
			Down = 1,
			Up = 2
		}
	
		// Constructors
		public QuickTouch() {} // 0x0000000180CA25F0-0x0000000180CA2700
	
		// Methods
		// [XID] // 0x0000000189B84280-0x0000000189B842A0
		private void Update() {} // 0x0000000180CA22F0-0x0000000180CA25F0
		// [XID] // 0x0000000189B8B0D0-0x0000000189B8B0F0
		private void DoAction(Gesture gesture) {} // 0x0000000180CA1FB0-0x0000000180CA2090
		// [XID] // 0x0000000189B928C0-0x0000000189B928E0
		private bool IsOverMe(Gesture gesture) => default; // 0x0000000180CA2090-0x0000000180CA22F0
	}
}
