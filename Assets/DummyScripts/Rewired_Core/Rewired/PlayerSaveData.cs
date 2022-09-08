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

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public struct PlayerSaveData // TypeDefIndex: 4171
	{
		// Fields
		private JoystickMapSaveData[] ERCDZWeUfbhWspXCUbQQEzGQZlIp; // 0x00
		private KeyboardMapSaveData[] etoKHgQCCgiEHJvCjXEhEvJIBYi; // 0x08
		private MouseMapSaveData[] KWpWUdrKvCUShKMZzUhrQDJpTsA; // 0x10
		private CustomControllerMapSaveData[] EBwlpfUJKLXqBeLjBgAlKqdTALe; // 0x18
		private InputBehavior[] rayjpLNejuVGQGYRNbnWzmbpHmb; // 0x20
	
		// Properties
		public InputBehavior[] inputBehaviors { get => default; } // 0x0000000185559E70-0x0000000185559EF0 
		public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData { get => default; } // 0x0000000185559E00-0x0000000185559E70 
	
		// Constructors
		internal PlayerSaveData(JoystickMapSaveData[] joystickMapSaveData, KeyboardMapSaveData[] keyboardMapSaveData, MouseMapSaveData[] mouseMapSaveData, CustomControllerMapSaveData[] customControllerMapSaveData, IList<InputBehavior> inputBehaviors) : this() {
			ERCDZWeUfbhWspXCUbQQEzGQZlIp = default;
			etoKHgQCCgiEHJvCjXEhEvJIBYi = default;
			KWpWUdrKvCUShKMZzUhrQDJpTsA = default;
			EBwlpfUJKLXqBeLjBgAlKqdTALe = default;
			rayjpLNejuVGQGYRNbnWzmbpHmb = default;
		} // 0x0000000185559D40-0x0000000185559E00
	}
}
