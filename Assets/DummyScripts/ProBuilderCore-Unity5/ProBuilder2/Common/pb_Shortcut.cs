/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_Shortcut // TypeDefIndex: 3425
	{
		// Fields
		public string action; // 0x10
		public string description; // 0x18
		public KeyCode key; // 0x20
		public EventModifiers eventModifiers; // 0x24
	
		// Constructors
		public pb_Shortcut() {} // Dummy constructor
		public pb_Shortcut(string a, string d, KeyCode k, EventModifiers e) {} // 0x0000000186BC9270-0x0000000186BC93F0
		public pb_Shortcut(string str) {} // 0x0000000186BC9070-0x0000000186BC9270
	
		// Methods
		public bool Matches(KeyCode key, EventModifiers modifiers) => default; // 0x0000000186BC8670-0x0000000186BC86F0
		public static int IndexOf(pb_Shortcut[] shortcuts, KeyCode k, EventModifiers e) => default; // 0x0000000186BC8570-0x0000000186BC8670
		public static IEnumerable<pb_Shortcut> DefaultShortcuts() => default; // 0x0000000186BC7DA0-0x0000000186BC8570
		public static IEnumerable<pb_Shortcut> ParseShortcuts(string str) => default; // 0x0000000186BC86F0-0x0000000186BC88C0
		public override string ToString() => default; // 0x0000000186BC8DF0-0x0000000186BC9070
		public string Serialize() => default; // 0x0000000186BC88C0-0x0000000186BC8C80
		public static string ShortcutsToString(pb_Shortcut[] shortcuts) => default; // 0x0000000186BC8C80-0x0000000186BC8DF0
	}
}
