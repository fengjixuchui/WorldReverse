/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct TextMapLevelStruct : IEmptyInitable, IHashable // TypeDefIndex: 19077
{
	// Fields
	private SimpleSafeInt32 minFileNumRawNum; // 0x00
	private SimpleSafeInt32 maxFileNumRawNum; // 0x04
	private SimpleSafeInt32 autoChangeStepRawNum; // 0x08

	// Properties
	public int minFileNum { /* [XID] */ /* 0x0000000189BBDF90-0x0000000189BBDFB0 */ get => default; /* [XID] */ /* 0x0000000189BC5C00-0x0000000189BC5C20 */ set {} } // 0x00000001856112F0-0x00000001856113E0 0x0000000185610610-0x00000001856106D0
	public int maxFileNum { /* [XID] */ /* 0x0000000189BCD660-0x0000000189BCD680 */ get => default; /* [XID] */ /* 0x0000000189BD4BB0-0x0000000189BD4BD0 */ set {} } // 0x00000001856100C0-0x0000000185610450 0x0000000185610990-0x0000000185610CA0
	public int autoChangeStep { /* [XID] */ /* 0x0000000189BDC660-0x0000000189BDC680 */ get => default; /* [XID] */ /* 0x00000001895E9010-0x00000001895E9030 */ set {} } // 0x00000001856107B0-0x00000001856108A0 0x00000001856113E0-0x00000001856113F0

	// Methods
	// [IDTag] // 0x00000001895F07C0-0x00000001895F0800
	// [XID] // 0x00000001895F07C0-0x00000001895F0800
	public bool Equals(TextMapLevelStruct otherVal) => default; // 0x0000000185610DD0-0x0000000185611150
	// [IDTag] // 0x00000001895FAFB0-0x00000001895FAFF0
	// [XID] // 0x00000001895FAFB0-0x00000001895FAFF0
	public override bool Equals(object other) => default; // 0x000000018560FFE0-0x00000001856100C0
	// [XID] // 0x0000000189605570-0x0000000189605590
	public override int GetHashCode() => default; // 0x0000000185610530-0x0000000185610610
	// [XID] // 0x000000018960CF20-0x000000018960CF40
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185611210-0x00000001856112F0
	// [XID] // 0x00000001896145C0-0x00000001896145E0
	public void InitEmpty() {} // 0x00000001856108A0-0x0000000185610990
	[BlackList] // 0x000000018961BEB0-0x000000018961BEF0
	// [XID] // 0x000000018961BEB0-0x000000018961BEF0
	public bool FromJson(JSONNode node) => default; // 0x0000000185610450-0x0000000185610530
	// [XID] // 0x00000001896263E0-0x0000000189626400
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018560F7D0-0x000000018560FAB0
	// [XID] // 0x000000018962DD70-0x000000018962DD90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB9CF */, bool useObjectPool = false /* Metadata: 0x00AFB9D3 */) => default; // 0x0000000185610CA0-0x0000000185610DD0
	// [XID] // 0x00000001896359B0-0x00000001896359D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB9D4 */, bool useObjectPool = false /* Metadata: 0x00AFB9D8 */) => default; // 0x000000018560FEC0-0x000000018560FFE0
	[BlackList] // 0x000000018963D070-0x000000018963D0B0
	// [XID] // 0x000000018963D070-0x000000018963D0B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018560FAB0-0x000000018560FB60
	// [XID] // 0x0000000189647650-0x0000000189647670
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185611150-0x0000000185611210
}

