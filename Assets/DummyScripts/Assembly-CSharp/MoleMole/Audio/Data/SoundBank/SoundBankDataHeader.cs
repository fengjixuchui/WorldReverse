/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Data.SoundBank
{
	public struct SoundBankDataHeader // TypeDefIndex: 19391
	{
		// Fields
		public const long MAGIC = 7022344665465512258; // Metadata: 0x00AFC7EB
		public const uint VERSION = 65537; // Metadata: 0x00AFC7F3
		public ulong magic; // 0x00
		public uint version; // 0x08
		public float defaultCooldown; // 0x0C
		public int eventOffset; // 0x10
		public int eventCount; // 0x14
		public int bankIdOffset; // 0x18
		public int bankIdCount; // 0x1C
		public int conditionalOffset; // 0x20
		public int conditionalCount; // 0x24
		public int switchesByRtpcOffset; // 0x28
		public int switchesByRtpcCount; // 0x2C
		public int switchesEventOffset; // 0x30
		public int switchesEventCount; // 0x34
		public int statesByEventOffset; // 0x38
		public int statesByEventCount; // 0x3C
		public uint reserved1; // 0x40
		public uint reserved2; // 0x44
		public uint reserved3; // 0x48
		public uint reserved4; // 0x4C
	}
}
