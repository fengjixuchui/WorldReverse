/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.UI
{
	public interface IMouseInputSource // TypeDefIndex: 3612
	{
		// Properties
		int playerId { get; }
		bool enabled { get; }
		bool locked { get; }
		int buttonCount { get; }
		Vector2 screenPosition { get; }
		Vector2 screenPositionDelta { get; }
		Vector2 wheelDelta { get; }
	
		// Methods
		bool GetButtonDown(int button);
		bool GetButtonUp(int button);
		bool GetButton(int button);
	}
}
