/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class Keyboard : ControllerWithMap // TypeDefIndex: 3651
	{
		// Fields
		private static Keyboard singleton; // 0x00
		private readonly IUnifiedKeyboardSource _source; // 0x100
		private ModifierKeyFlags currentModfierKeyFlags; // 0x108
		private ModifierKeyFlags currentModfierKeyFlagsDouble; // 0x10C
		private Func<KeyboardKeyCode, int> _getKeyIndexDelegate; // 0x110
		private readonly int[] keyCodeToKeyIndex; // 0x118
		private static KeyboardKeyCode[] __keyIndexToKeyboardKeyCode; // 0x08
		private readonly int maxKeyValue; // 0x120
		private static Guid s_deviceInstanceGuid; // 0x10
	
		// Properties
		private static KeyboardKeyCode[] keyIndexToKeyboardKeyCode { get => default; } // 0x00000001852FD2A0-0x00000001852FD470 
		public override Guid deviceInstanceGuid { get => default; } // 0x00000001852FD180-0x00000001852FD2A0 
	
		// Constructors
		public Keyboard() {} // Dummy constructor
		internal Keyboard(string name, IUnifiedKeyboardSource source) {} // 0x00000001852FCC20-0x00000001852FD040
		private Keyboard(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, HardwareControllerMap_Game hardwareMap, int buttonCount, ControllerDataUpdater dataUpdater) {} // 0x00000001852FD040-0x00000001852FD180
	
		// Methods
		public bool GetKey(KeyCode keyCode) => default; // 0x00000001852FAF70-0x00000001852FB0C0
		public bool GetKeyDown(KeyCode keyCode) => default; // 0x00000001852FAA40-0x00000001852FAB90
		public float GetKeyTimePressed(KeyCode keyCode) => default; // 0x00000001852FAE10-0x00000001852FAF70
		public float GetModifierKeyTimePressed(ModifierKey key) => default; // 0x00000001852FB230-0x00000001852FB3D0
		public KeyCode GetKeyCodeByButtonIndex(int buttonIndex) => default; // 0x00000001852FA840-0x00000001852FA950
		public KeyCode GetKeyCodeById(int elementIdentifierId) => default; // 0x00000001852FA950-0x00000001852FAA40
		public IEnumerable<ControllerPollingInfo> PollForAllKeys() => default; // 0x00000001852FC120-0x00000001852FC1C0
		public IEnumerable<ControllerPollingInfo> PollForAllKeysDown() => default; // 0x00000001852FC080-0x00000001852FC120
		public override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown() => default; // 0x00000001852FC010-0x00000001852FC080
		public static bool IsModifierKey(KeyCode key) => default; // 0x00000001852FB4A0-0x00000001852FB540
		internal static bool IsModifierKey(KeyboardKeyCode key) => default; // 0x00000001852FB3D0-0x00000001852FB4A0
		public static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key) => default; // 0x00000001852FB5A0-0x00000001852FB670
		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key) => default; // 0x00000001852FB7F0-0x00000001852FB900
		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key) => default; // 0x00000001852FB6D0-0x00000001852FB7F0
		public static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key) => default; // 0x00000001852FBF80-0x00000001852FC010
		public static string GetKeyName(KeyCode key) => default; // 0x00000001852FAB90-0x00000001852FAD00
		public static string GetKeyName(KeyCode key, ModifierKeyFlags flags) => default; // 0x00000001852FAD00-0x00000001852FAE10
		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool abbreviate) => default; // 0x00000001852FB970-0x00000001852FBF80
		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags) => default; // 0x00000001852FB900-0x00000001852FB970
		internal static KeyboardKeyCode KeyCodeToKeyboardKeyCode(KeyCode keyCode) => default; // 0x00000001852FB540-0x00000001852FB5A0
		internal static KeyCode KeyboardKeyCodeToKeyCode(KeyboardKeyCode keyCode) => default; // 0x00000001852FB670-0x00000001852FB6D0
		internal static ModifierKeyFlags ConvertModifierKeyFlagsSingleToDouble(ModifierKeyFlags flags) => default; // 0x00000001852F9E90-0x00000001852F9FC0
		internal static int GetDoubledModifierKeyCount(ModifierKeyFlags flags) => default; // 0x00000001852FA5E0-0x00000001852FA750
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex) => default; // 0x00000001852FB1A0-0x00000001852FB230
		internal static int GetElementIdentifierIdByKeyCode(KeyboardKeyCode keyCode) => default; // 0x00000001852FA750-0x00000001852FA840
		internal static void FixKeyboardAssignments(ref int elementIdentifierId, ref KeyCode keyCode) {} // 0x00000001852F9FC0-0x00000001852FA0E0
		internal override void UpdateData(UpdateLoopType updateLoop) {} // 0x00000001852FCB70-0x00000001852FCC20
		internal void UpdateData_AndroidKeyboardDisabled(UpdateLoopType updateLoop) {} // 0x00000001852FC770-0x00000001852FCB70
		internal bool GetKey(KeyboardKeyCode keyCode) => default; // 0x00000001852FB0C0-0x00000001852FB1A0
		internal bool AllRequiredKeysPressed(KeyboardKeyCode keyCode, ModifierKeyFlags doubledFlags) => default; // 0x00000001852F9A80-0x00000001852F9C20
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal int GetButtonIndex(KeyboardKeyCode keyCode) => default; // 0x00000001852FA0E0-0x00000001852FA180
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void BakeMap(ControllerMap controllerMap) {} // 0x00000001852F9CA0-0x00000001852F9E00
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void BakeActionElementMap(ControllerMap controllerMap, ActionElementMap map) {} // 0x00000001852F9C20-0x00000001852F9CA0
		internal override void Clear() {} // 0x00000001852F9E00-0x00000001852F9E90
		private bool GetControlButtons(out Button leftButton, out Button rightButton, ModifierKey key) {
			leftButton = default;
			rightButton = default;
			return default;
		} // 0x00000001852FA180-0x00000001852FA5E0
		private void UpdateCurrentModifierKeyFlags() {} // 0x00000001852FC1C0-0x00000001852FC770
	}
}
