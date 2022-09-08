/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlockRoutePage : BlockDataPage // TypeDefIndex: 19537
{
	// Fields
	private Dictionary<uint, ConfigRoute> _routeConfigs; // 0x20

	// Constructors
	public BlockRoutePage() {} // 0x0000000180F91110-0x0000000180F911A0

	// Methods
	// [XID] // 0x0000000189841620-0x0000000189841640
	public ConfigRoute GetConfig(uint routeId) => default; // 0x0000000180F90B30-0x0000000180F90C10
	// [XID] // 0x00000001896DF7A0-0x00000001896DF7C0
	protected override object SerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFCAA1 */) => default; // 0x0000000180F91000-0x0000000180F91110
	// [XID] // 0x00000001896E6B80-0x00000001896E6BA0
	protected override object SerializeJson(JSONNode node) => default; // 0x0000000180F90C10-0x0000000180F90D10
	// [XID] // 0x00000001896EE0D0-0x00000001896EE0F0
	protected override void OnSerialized(object obj, ulong path) {} // 0x0000000180F90DA0-0x0000000180F91000
}

