/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public class LuaThreatInfo // TypeDefIndex: 21167
	{
		// Fields
		private bool _soundDirty; // 0x10
		private Vector3 _soundPos; // 0x14
		private float _volume; // 0x20
	
		// Properties
		[BlackList] // 0x0000000189811090-0x00000001898110A0
		public bool IsDirty { /* [XID] */ /* 0x0000000189A7CE30-0x0000000189A7CE50 */ get => default; } // 0x0000000184F18C20-0x0000000184F18CC0 
		public bool hasSound { /* [XID] */ /* 0x0000000189A8F070-0x0000000189A8F090 */ get => default; } // 0x0000000184F18CC0-0x0000000184F18D60 
		public Vector3 soundPos { /* [XID] */ /* 0x0000000189A965E0-0x0000000189A96600 */ get => default; } // 0x0000000184F18D60-0x0000000184F18E40 
		public float volume { /* [XID] */ /* 0x0000000189A9DB30-0x0000000189A9DB50 */ get => default; } // 0x0000000184F18E40-0x0000000184F18EF0 
	
		// Constructors
		public LuaThreatInfo() {} // 0x0000000184F18BB0-0x0000000184F18C20
	
		// Methods
		[BlackList] // 0x0000000189A84700-0x0000000189A84740
		// [XID] // 0x0000000189A84700-0x0000000189A84740
		public void Clear() {} // 0x0000000184F18A30-0x0000000184F18AD0
		[BlackList] // 0x0000000189AA5440-0x0000000189AA5480
		// [XID] // 0x0000000189AA5440-0x0000000189AA5480
		public void FromAISoundInfo(AISoundInfo soundInfo) {} // 0x0000000184F18AD0-0x0000000184F18BB0
	}
}
