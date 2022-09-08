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
	// [AddComponentMenu] // 0x0000000189A29CA0-0x0000000189A29CD0
	public class QuickEnterOverExist : QuickBase // TypeDefIndex: 7263
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnTouchEnter onTouchEnter; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnTouchOver onTouchOver; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public OnTouchExit onTouchExit; // 0x80
		private bool[] fingerOver; // 0x88
	
		// Nested types
		[Serializable]
		public class OnTouchEnter : UnityEvent<Gesture> // TypeDefIndex: 7264
		{
			// Constructors
			public OnTouchEnter() {} // 0x0000000180C9A770-0x0000000180C9A7E0
		}
	
		[Serializable]
		public class OnTouchOver : UnityEvent<Gesture> // TypeDefIndex: 7265
		{
			// Constructors
			public OnTouchOver() {} // 0x0000000180C9A8C0-0x0000000180C9A930
		}
	
		[Serializable]
		public class OnTouchExit : UnityEvent<Gesture> // TypeDefIndex: 7266
		{
			// Constructors
			public OnTouchExit() {} // 0x0000000180C9A7E0-0x0000000180C9A850
		}
	
		// Constructors
		public QuickEnterOverExist() {} // 0x0000000180C9F6D0-0x0000000180C9F800
	
		// Methods
		// [XID] // 0x0000000189A49270-0x0000000189A49290
		private new void Awake() {} // 0x0000000180C9EA90-0x0000000180C9EB60
		// [XID] // 0x0000000189A50B60-0x0000000189A50B80
		public override void OnEnable() {} // 0x0000000180C9ECB0-0x0000000180C9EDF0
		// [XID] // 0x0000000189A58020-0x0000000189A58040
		public override void OnDisable() {} // 0x0000000180C9EC00-0x0000000180C9ECB0
		// [XID] // 0x0000000189A5FCC0-0x0000000189A5FCE0
		private void OnDestroy() {} // 0x0000000180C9EB60-0x0000000180C9EC00
		// [XID] // 0x0000000189A67720-0x0000000189A67740
		private void UnsubscribeEvent() {} // 0x0000000180C9F590-0x0000000180C9F6D0
		// [XID] // 0x0000000189A6EC40-0x0000000189A6EC60
		private void On_TouchDown(Gesture gesture) {} // 0x0000000180C9EDF0-0x0000000180C9F390
		// [XID] // 0x0000000189A764C0-0x0000000189A764E0
		private void On_TouchUp(Gesture gesture) {} // 0x0000000180C9F390-0x0000000180C9F4D0
	}
}
