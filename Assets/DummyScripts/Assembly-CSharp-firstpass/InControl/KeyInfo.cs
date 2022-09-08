/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public struct KeyInfo // TypeDefIndex: 7605
	{
		// Fields
		private readonly Key key; // 0x00
		private readonly string name; // 0x08
		private readonly string macName; // 0x10
		private readonly KeyCode[] keyCodes; // 0x18
		public static readonly KeyInfo[] KeyList; // 0x00
	
		// Properties
		public bool IsPressed { /* [XID] */ /* 0x00000001897EB070-0x00000001897EB090 */ get => default; } // 0x0000000188850A60-0x0000000188850B10 
		public string Name { /* [XID] */ /* 0x00000001897F2DC0-0x00000001897F2DE0 */ get => default; } // 0x0000000188850BE0-0x0000000188850DB0 
		public Key Key { /* [XID] */ /* 0x00000001899E5D00-0x00000001899E5D20 */ get => default; } // 0x0000000188850B10-0x0000000188850BE0 
	
		// Constructors
		private KeyInfo(Key key, string name, params /* 0x000000018989F6F0-0x000000018989F700 */ KeyCode[] keyCodes) : this() {
			this.key = default;
			this.name = default;
			macName = default;
			this.keyCodes = default;
		} // 0x0000000188850910-0x0000000188850A60
		private KeyInfo(Key key, string name, string macName, params /* 0x000000018989F6F0-0x000000018989F700 */ KeyCode[] keyCodes) : this() {
			this.key = default;
			this.name = default;
			this.macName = default;
			this.keyCodes = default;
		} // 0x0000000188850870-0x0000000188850910
		static KeyInfo() {
			KeyList = default;
		} // 0x000000018884B820-0x0000000188850870
	}
}
