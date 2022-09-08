/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	[CreateAssetMenu] // 0x0000000189B1BAE0-0x0000000189B1BB20
	public class BindingConfig : ScriptableObject // TypeDefIndex: 7593
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _nextActionSetID; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _nextActionID; // 0x1C
		public List<ActionSetData> actionSets; // 0x20
		public ControllerMappingData ps4Map; // 0x28
	
		// Properties
		public int nextActionSetID { /* [XID] */ /* 0x0000000189B33220-0x0000000189B33240 */ get => default; } // 0x0000000187DA95D0-0x0000000187DA9680 
		public int nextActionID { /* [XID] */ /* 0x0000000189B3AD10-0x0000000189B3AD30 */ get => default; } // 0x0000000187DA9520-0x0000000187DA95D0 
	
		// Constructors
		public BindingConfig() {} // 0x0000000187DA9470-0x0000000187DA9520
	
		// Methods
		// [XID] // 0x0000000189BAB8F0-0x0000000189BAB910
		private void OnEnable() {} // 0x0000000187DA9310-0x0000000187DA9470
	}
}
