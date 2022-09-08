/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoScrollerJoypadController : MonoBaseJoypadController // TypeDefIndex: 30924
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _name; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _plusOwnName; // 0x40
		private string finalName; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _regionName; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _skipInactive; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private EventMapInfo[] _eventMaps; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _gridScroller; // 0x68
		public bool enable; // 0x70
		public bool reinitOnEnable; // 0x71
		public bool clearSelectorOnDisable; // 0x72
		private bool _initialized; // 0x73
	
		// Nested types
		[Serializable]
		public struct EventMapInfo // TypeDefIndex: 30925
		{
			// Fields
			public ContextEventType[] from; // 0x00
			public ContextEventType to; // 0x08
		}
	
		// Constructors
		public MonoScrollerJoypadController() {} // 0x0000000184114FF0-0x00000001841150C0
	
		// Methods
		// [XID] // 0x0000000189841AC0-0x0000000189841AE0
		public void OnEnable() {} // 0x0000000184114C20-0x0000000184114F10
		// [XID] // 0x0000000189848F90-0x0000000189848FB0
		public void OnDisable() {} // 0x0000000184114B10-0x0000000184114C20
		// [XID] // 0x0000000189850770-0x0000000189850790
		public override void SetBaseContext(BaseContext context) {} // 0x0000000184114F10-0x0000000184114FF0
		// [XID] // 0x0000000189857B20-0x0000000189857B40
		public override bool IsInvalid() => default; // 0x0000000184114920-0x0000000184114A10
		// [XID] // 0x000000018985EBF0-0x000000018985EC10
		public override bool IsActive() => default; // 0x0000000184114800-0x0000000184114920
		// [XID] // 0x0000000189866370-0x0000000189866390
		public override bool HandleJoypadControllerAction(JoypadControllerActionType action, object param) => default; // 0x0000000184114320-0x0000000184114800
		// [XID] // 0x000000018986DCA0-0x000000018986DCC0
		public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184114080-0x0000000184114320
	}
}
