/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class OverrideMap : IReusable // TypeDefIndex: 14606
{
	// Properties
	public Dictionary<EncryptedString, SafeFloat> floats { /* [XID] */ /* 0x00000001898AE840-0x00000001898AE880 */ get; /* [XID] */ /* 0x00000001898B8FC0-0x00000001898B9000 */ private set; } // 0x00000001845877C0-0x0000000184587820 0x0000000184586D50-0x0000000184586DB0
	public Dictionary<EncryptedString, string> strings { /* [XID] */ /* 0x00000001898C3430-0x00000001898C3470 */ get; /* [XID] */ /* 0x00000001898CDA90-0x00000001898CDAD0 */ private set; } // 0x0000000184586DB0-0x0000000184586E10 0x00000001845870D0-0x0000000184587130
	public int Count { /* [XID] */ /* 0x00000001895F2B30-0x00000001895F2B50 */ get => default; } // 0x00000001845873B0-0x00000001845875A0 

	// Nested types
	public class Spawner : ISpawner<OverrideMap> // TypeDefIndex: 14607
	{
		// Constructors
		public Spawner() {} // 0x00000001845A5020-0x00000001845A5080

		// Methods
		// [XID] // 0x0000000189914D50-0x0000000189914D70
		public OverrideMap Spawn() => default; // 0x00000001845A4F20-0x00000001845A5020
	}

	// Constructors
	public OverrideMap() {} // 0x0000000184587820-0x0000000184587880

	// Methods
	// [XID] // 0x00000001895FA3E0-0x00000001895FA400
	public bool TryGetFloat(EncryptedString key, out float value) {
		value = default;
		return default;
	} // 0x00000001845875A0-0x00000001845877C0
	// [XID] // 0x00000001898E0280-0x00000001898E02A0
	public bool SetFloat(EncryptedString key, float value) => default; // 0x0000000184586630-0x0000000184586960
	// [XID] // 0x00000001898E7DA0-0x00000001898E7DC0
	public bool TryGetString(EncryptedString key, out string value) {
		value = default;
		return default;
	} // 0x0000000184586B80-0x0000000184586D50
	// [XID] // 0x0000000189922960-0x0000000189922980
	public bool SetString(EncryptedString key, string value) => default; // 0x0000000184586E10-0x00000001845870D0
	// [XID] // 0x00000001898F6D50-0x00000001898F6D70
	public bool HasKey(EncryptedString key) => default; // 0x0000000184586960-0x0000000184586B80
	// [XID] // 0x00000001898FE4C0-0x00000001898FE4E0
	public bool ClearKey(EncryptedString key) => default; // 0x0000000184587130-0x00000001845873B0
	// [XID] // 0x0000000189905C40-0x0000000189905C60
	public void BeforeRecycle() {} // 0x0000000184586340-0x0000000184586630
}

