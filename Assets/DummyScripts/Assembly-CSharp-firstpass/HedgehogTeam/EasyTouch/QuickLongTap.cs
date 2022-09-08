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
	// [AddComponentMenu] // 0x0000000189A7DD40-0x0000000189A7DD70
	public class QuickLongTap : QuickBase // TypeDefIndex: 7267
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnLongTap onLongTap; // 0x70
		public ActionTriggering actionTriggering; // 0x78
		private Gesture currentGesture; // 0x80
	
		// Nested types
		[Serializable]
		public class OnLongTap : UnityEvent<Gesture> // TypeDefIndex: 7268
		{
			// Constructors
			public OnLongTap() {} // 0x0000000180C9A5B0-0x0000000180C9A620
		}
	
		public enum ActionTriggering // TypeDefIndex: 7269
		{
			Start = 0,
			InProgress = 1,
			End = 2
		}
	
		// Constructors
		public QuickLongTap() {} // 0x0000000180C9FDD0-0x0000000180C9FEE0
	
		// Methods
		// [XID] // 0x0000000189A8E930-0x0000000189A8E950
		private void Update() {} // 0x0000000180C9FB40-0x0000000180C9FDD0
		// [XID] // 0x0000000189A95D50-0x0000000189A95D70
		private void DoAction(Gesture gesture) {} // 0x0000000180C9F800-0x0000000180C9F8E0
		// [XID] // 0x0000000189A9D440-0x0000000189A9D460
		private bool IsOverMe(Gesture gesture) => default; // 0x0000000180C9F8E0-0x0000000180C9FB40
	}
}
