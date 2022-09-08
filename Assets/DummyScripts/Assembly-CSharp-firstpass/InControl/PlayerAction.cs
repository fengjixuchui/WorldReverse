/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class PlayerAction : OneAxisInputControl // TypeDefIndex: 7609
	{
		// Fields
		public BindingListenOptions ListenOptions; // 0x88
		public BindingSourceType LastInputType; // 0x90
		public ulong LastInputTypeChangedTick; // 0xA0
		public InputDeviceClass LastDeviceClass; // 0xA8
		public InputDeviceStyle LastDeviceStyle; // 0xAC
		private readonly List<BindingSource> defaultBindings; // 0xC0
		private readonly List<BindingSource> regularBindings; // 0xC8
		private readonly List<BindingSource> visibleBindings; // 0xD0
		private readonly ReadOnlyCollection<BindingSource> bindings; // 0xD8
		private readonly ReadOnlyCollection<BindingSource> unfilteredBindings; // 0xE0
		private static readonly BindingSourceListener[] bindingSourceListeners; // 0x00
		private bool triggerBindingEnded; // 0xE8
		private bool triggerBindingChanged; // 0xE9
		private InputDevice device; // 0xF0
		private InputDevice activeDevice; // 0xF8
	
		// Properties
		public string Name { /* [XID] */ /* 0x00000001898FCFC0-0x00000001898FD000 */ get; private set; } // 0x0000000187F118C0-0x0000000187F11920 0x0000000187F11D90-0x0000000187F11DF0
		public PlayerActionSet Owner { /* [XID] */ /* 0x000000018990F320-0x000000018990F360 */ get; private set; } // 0x0000000187F11920-0x0000000187F11980 0x0000000187F11DF0-0x0000000187F11E60
		public object UserData { get; set; } // 0x0000000187F11A30-0x0000000187F11A90 0x0000000187F11E60-0x0000000187F11ED0
		public bool IsListeningForBinding { /* [XID] */ /* 0x0000000189A35D00-0x0000000189A35D20 */ get => default; } // 0x0000000187F11710-0x0000000187F11810 
		public ReadOnlyCollection<BindingSource> Bindings { /* [XID] */ /* 0x0000000189A3D310-0x0000000189A3D330 */ get => default; } // 0x0000000187F11500-0x0000000187F115B0 
		public ReadOnlyCollection<BindingSource> UnfilteredBindings { /* [XID] */ /* 0x000000018994DBC0-0x000000018994DBE0 */ get => default; } // 0x0000000187F11980-0x0000000187F11A30 
		internal InputDevice Device { /* [XID] */ /* 0x0000000189A71C30-0x0000000189A71C50 */ get => default; /* [XID] */ /* 0x000000018996B930-0x000000018996B950 */ set {} } // 0x0000000187F115B0-0x0000000187F11710 0x0000000187F11CD0-0x0000000187F11D90
		public InputDevice ActiveDevice { /* [XID] */ /* 0x0000000189A34000-0x0000000189A34020 */ get => default; } // 0x0000000187F11420-0x0000000187F11500 
		private bool LastInputTypeIsDevice { /* [XID] */ /* 0x0000000189A886C0-0x0000000189A886E0 */ get => default; } // 0x0000000187F11810-0x0000000187F118C0 
	
		// Events
		public event Action<BindingSourceType> OnLastInputTypeChanged;
		public event Action OnBindingsChanged;
	
		// Constructors
		public PlayerAction() {} // Dummy constructor
		public PlayerAction(string name, PlayerActionSet owner) {} // 0x0000000187F10FF0-0x0000000187F111E0
		static PlayerAction() {} // 0x0000000187F10DE0-0x0000000187F10FF0
	
		// Methods
		// [IDTag] // 0x000000018994DDC0-0x000000018994DE00
		// [XID] // 0x000000018994DDC0-0x000000018994DE00
		public void AddDefaultBinding(BindingSource binding) {} // 0x0000000187F0DF30-0x0000000187F0E190
		// [IDTag] // 0x0000000189958760-0x00000001899587A0
		// [XID] // 0x0000000189958760-0x00000001899587A0
		public void AddDefaultBinding(params /* 0x000000018989F6F0-0x000000018989F700 */ Key[] keys) {} // 0x0000000187F0DE50-0x0000000187F0DF30
		// [IDTag] // 0x000000018996A310-0x000000018996A350
		// [XID] // 0x000000018996A310-0x000000018996A350
		public void AddDefaultBinding(KeyCombo keyCombo) {} // 0x0000000187F0DD30-0x0000000187F0DE50
		// [IDTag] // 0x0000000189974CD0-0x0000000189974D10
		// [XID] // 0x0000000189974CD0-0x0000000189974D10
		public void AddDefaultBinding(Mouse control) {} // 0x0000000187F0DC50-0x0000000187F0DD30
		// [IDTag] // 0x000000018997F260-0x000000018997F2A0
		// [XID] // 0x000000018997F260-0x000000018997F2A0
		public void AddDefaultBinding(InputControlType control) {} // 0x0000000187F0E190-0x0000000187F0E270
		// [IDTag] // 0x000000018998A0B0-0x000000018998A0F0
		// [XID] // 0x000000018998A0B0-0x000000018998A0F0
		public bool AddBinding(BindingSource binding) => default; // 0x0000000187F0D960-0x0000000187F0DB70
		// [IDTag] // 0x0000000189994BE0-0x0000000189994C20
		// [XID] // 0x0000000189994BE0-0x0000000189994C20
		public void AddBinding(params /* 0x000000018989F6F0-0x000000018989F700 */ Key[] keys) {} // 0x0000000187F0D680-0x0000000187F0D760
		// [IDTag] // 0x00000001899A6DD0-0x00000001899A6E10
		// [XID] // 0x00000001899A6DD0-0x00000001899A6E10
		public void AddBinding(KeyCombo keyCombo) {} // 0x0000000187F0D840-0x0000000187F0D960
		// [IDTag] // 0x00000001899B1800-0x00000001899B1840
		// [XID] // 0x00000001899B1800-0x00000001899B1840
		public void AddBinding(Mouse control) {} // 0x0000000187F0DB70-0x0000000187F0DC50
		// [IDTag] // 0x00000001899BBCE0-0x00000001899BBD20
		// [XID] // 0x00000001899BBCE0-0x00000001899BBD20
		public void AddBinding(InputControlType control) {} // 0x0000000187F0D760-0x0000000187F0D840
		// [XID] // 0x000000018987F4B0-0x000000018987F4D0
		public bool InsertBindingAt(int index, BindingSource binding) => default; // 0x0000000187F0F0B0-0x0000000187F0F3D0
		// [XID] // 0x00000001899CDD70-0x00000001899CDD90
		public bool ReplaceBinding(BindingSource findBinding, BindingSource withBinding) => default; // 0x0000000187F0FE60-0x0000000187F10110
		// [XID] // 0x0000000189886AC0-0x0000000189886AE0
		public bool HasBinding(BindingSource binding) => default; // 0x0000000187F0EE80-0x0000000187F0EF80
		// [XID] // 0x00000001898AABA0-0x00000001898AABC0
		public BindingSource FindBinding(BindingSource binding) => default; // 0x0000000187F0EA10-0x0000000187F0EB20
		// [XID] // 0x00000001899E4330-0x00000001899E4350
		private void HardRemoveBinding(BindingSource binding) {} // 0x0000000187F0ED10-0x0000000187F0EE80
		// [XID] // 0x000000018989C080-0x000000018989C0A0
		public void RemoveBinding(BindingSource binding) {} // 0x0000000187F0FA90-0x0000000187F0FB90
		// [XID] // 0x00000001899F33A0-0x00000001899F33C0
		public void RemoveBindingAt(int index) {} // 0x0000000187F0F940-0x0000000187F0FA90
		// [XID] // 0x00000001899FAB30-0x00000001899FAB50
		private int CountBindingsOfType(BindingSourceType bindingSourceType) => default; // 0x0000000187F0E3D0-0x0000000187F0E530
		// [XID] // 0x0000000189A01D00-0x0000000189A01D20
		private void RemoveFirstBindingOfType(BindingSourceType bindingSourceType) {} // 0x0000000187F0FB90-0x0000000187F0FD20
		// [XID] // 0x0000000189946490-0x00000001899464B0
		private int IndexOfFirstInvalidBinding() => default; // 0x0000000187F0EF80-0x0000000187F0F0B0
		// [XID] // 0x0000000189A1DCE0-0x0000000189A1DD00
		public void ClearBindings() {} // 0x0000000187F0E270-0x0000000187F0E3D0
		// [XID] // 0x0000000189A181D0-0x0000000189A181F0
		public void ResetBindings() {} // 0x0000000187F10110-0x0000000187F102A0
		// [XID] // 0x00000001898D7D60-0x00000001898D7D80
		public void ListenForBinding() {} // 0x0000000187F0F620-0x0000000187F0F6C0
		// [XID] // 0x00000001898C8F20-0x00000001898C8F40
		public void ListenForBindingReplacing(BindingSource binding) {} // 0x0000000187F0F3D0-0x0000000187F0F620
		// [XID] // 0x0000000189A2E450-0x0000000189A2E470
		public void StopListeningForBinding() {} // 0x0000000187F10480-0x0000000187F10590
		// [XID] // 0x0000000189A4C2C0-0x0000000189A4C2E0
		private void RemoveOrphanedBindings() {} // 0x0000000187F0FD20-0x0000000187F0FE60
		// [XID] // 0x00000001899642D0-0x00000001899642F0
		internal void Update(ulong updateTick, float deltaTime, InputDevice device) {} // 0x0000000187F10C70-0x0000000187F10DE0
		// [XID] // 0x0000000189A5B120-0x0000000189A5B140
		private void UpdateBindings(ulong updateTick, float deltaTime) {} // 0x0000000187F10590-0x0000000187F10B00
		// [XID] // 0x0000000189A629A0-0x0000000189A629C0
		private void DetectBindings() {} // 0x0000000187F0E530-0x0000000187F0EA10
		// [XID] // 0x0000000189B187D0-0x0000000189B187F0
		private void UpdateVisibleBindings() {} // 0x0000000187F10B00-0x0000000187F10C70
		// [XID] // 0x0000000189A0F1C0-0x0000000189A0F1E0
		internal void Load(BinaryReader reader, ushort dataFormatVersion) {} // 0x0000000187F0F6C0-0x0000000187F0F940
		// [XID] // 0x0000000189A68EF0-0x0000000189A68F10
		internal void Save(BinaryWriter writer) {} // 0x0000000187F102A0-0x0000000187F10480
		// [XID] // 0x0000000189A9EB10-0x0000000189A9EB30
		public BindingSource GetBinding(BindingSourceType sourceType) => default; // 0x0000000187F0EB20-0x0000000187F0ED10
	}
}
