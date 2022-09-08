/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	public sealed class FNVHasher : NetSerializerHasher // TypeDefIndex: 6923
	{
		// Fields
		private readonly Dictionary<string, ulong> _hashCache; // 0x10
		private readonly char[] _hashBuffer; // 0x18
	
		// Constructors
		public FNVHasher() {} // 0x00000001863BC2D0-0x00000001863BC380
	
		// Methods
		// [XID] // 0x00000001898924A0-0x00000001898924C0
		public override ulong GetHash(string type) => default; // 0x00000001863BBF70-0x00000001863BC130
		// [XID] // 0x0000000189961390-0x00000001899613B0
		public override ulong ReadHash(NetDataReader reader) => default; // 0x00000001863BC130-0x00000001863BC1F0
		// [XID] // 0x0000000189968A90-0x0000000189968AB0
		public override void WriteHash(ulong hash, NetDataWriter writer) {} // 0x00000001863BC1F0-0x00000001863BC2D0
	}
}
