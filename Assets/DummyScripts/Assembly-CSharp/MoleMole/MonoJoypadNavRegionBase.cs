/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoypadNavRegionBase : MonoJoypadUIModule // TypeDefIndex: 30646
	{
		// Fields
		// [Header] // 0x00000001899C07C0-0x00000001899C0810
		[SerializeField] // 0x00000001899C07C0-0x00000001899C0810
		protected ContextNavDirConfig[] customNavContexts; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ManageModuleData[] _uiModules; // 0x70
		protected GameObject[] _handoverActiveObjectCache; // 0x78
		protected List<ManageModuleData> _dynamicUIModules; // 0x80
	
		// Properties
		public ManageModuleData[] uiModule { /* [XID] */ /* 0x00000001899D4030-0x00000001899D4050 */ get => default; } // 0x0000000183F86AA0-0x0000000183F86B40 
	
		// Nested types
		[Serializable]
		public struct ManageModuleData // TypeDefIndex: 30647
		{
			// Fields
			public MonoJoypadUIModule manageModule; // 0x00
			public bool focusOnActive; // 0x08
		}
	
		// Constructors
		public MonoJoypadNavRegionBase() {} // 0x0000000183F86A30-0x0000000183F86AA0
	
		// Methods
		// [XID] // 0x00000001899DB5C0-0x00000001899DB5E0
		protected override void Init() {} // 0x0000000183F861D0-0x0000000183F86390
		// [XID] // 0x00000001899E2CC0-0x00000001899E2CE0
		protected override JoypadCrossNavDir ContextToNavDir(ContextEventType context) => default; // 0x0000000183F86390-0x0000000183F864B0
		// [XID] // 0x00000001899EA3F0-0x00000001899EA410
		private void SetUIModuleFocus(bool focus) {} // 0x0000000183F85EE0-0x0000000183F861D0
		// [XID] // 0x00000001899F1DC0-0x00000001899F1DE0
		public void AddDynamicUIModule(MonoJoypadUIModule newModule, bool focusOnActive) {} // 0x0000000183F85A80-0x0000000183F85D90
		// [XID] // 0x00000001899F9600-0x00000001899F9620
		public void RemoveDynamicUIModule(MonoJoypadUIModule revModule) {} // 0x0000000183F86780-0x0000000183F86A30
		// [XID] // 0x0000000189A00920-0x0000000189A00940
		protected override void OnFocus(bool activateObj) {} // 0x0000000183F85D90-0x0000000183F85EE0
		// [XID] // 0x0000000189A08200-0x0000000189A08220
		protected override void OnLostFocus(bool activateObj) {} // 0x0000000183F86530-0x0000000183F86680
	}
}
