/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct FirstPersonCoopCamConfig : IEmptyInitable, IHashable // TypeDefIndex: 18128
{
	// Fields
	private MoleMole.Config.Vector _camPositionOffset; // 0x00
	private MoleMole.Config.Vector _camTargetOffset; // 0x0C
	private SimpleSafeFloat camFOVRawNum; // 0x18

	// Properties
	public MoleMole.Config.Vector camPositionOffset { /* [XID] */ /* 0x00000001899BFB50-0x00000001899BFB70 */ get => default; /* [XID] */ /* 0x00000001899C72F0-0x00000001899C7310 */ private set {} } // 0x0000000184A8BC60-0x0000000184A8BD40 0x0000000184A8C650-0x0000000184A8C9D0
	public MoleMole.Config.Vector camTargetOffset { /* [XID] */ /* 0x00000001899CE8C0-0x00000001899CE8E0 */ get => default; /* [XID] */ /* 0x00000001899D6030-0x00000001899D6050 */ private set {} } // 0x0000000184A8C550-0x0000000184A8C650 0x0000000184A8CC30-0x0000000184A8CE30
	public float camFOV { /* [XID] */ /* 0x00000001899DD460-0x00000001899DD480 */ get => default; /* [XID] */ /* 0x00000001899E5180-0x00000001899E51A0 */ private set {} } // 0x0000000184A8B1D0-0x0000000184A8B280 0x0000000184A8C260-0x0000000184A8C430

	// Methods
	// [IDTag] // 0x00000001899EC4F0-0x00000001899EC530
	// [XID] // 0x00000001899EC4F0-0x00000001899EC530
	public bool Equals(FirstPersonCoopCamConfig otherVal) => default; // 0x0000000184A8C430-0x0000000184A8C550
	// [IDTag] // 0x00000001899F6D70-0x00000001899F6DB0
	// [XID] // 0x00000001899F6D70-0x00000001899F6DB0
	public override bool Equals(object other) => default; // 0x0000000184A8B6F0-0x0000000184A8BA80
	// [XID] // 0x0000000189A01050-0x0000000189A01070
	public override int GetHashCode() => default; // 0x0000000184A8BB70-0x0000000184A8BC60
	// [XID] // 0x0000000189A089F0-0x0000000189A08A10
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A8CB50-0x0000000184A8CC30
	// [XID] // 0x0000000189A0FF70-0x0000000189A0FF90
	public void InitEmpty() {} // 0x0000000184A8BE60-0x0000000184A8C170
	[BlackList] // 0x0000000189A173F0-0x0000000189A17430
	// [XID] // 0x0000000189A173F0-0x0000000189A17430
	public bool FromJson(JSONNode node) => default; // 0x0000000184A8BA80-0x0000000184A8BB70
	// [XID] // 0x0000000189A21AF0-0x0000000189A21B10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184A8AE00-0x0000000184A8B0E0
	// [XID] // 0x0000000189A29080-0x0000000189A290A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C17 */, bool useObjectPool = false /* Metadata: 0x00AF8C1B */) => default; // 0x0000000184A8C170-0x0000000184A8C260
	// [XID] // 0x0000000189A30690-0x0000000189A306B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C1C */, bool useObjectPool = false /* Metadata: 0x00AF8C20 */) => default; // 0x0000000184A8B5D0-0x0000000184A8B6F0
	[BlackList] // 0x0000000189A37FD0-0x0000000189A38010
	// [XID] // 0x0000000189A37FD0-0x0000000189A38010
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A8B0E0-0x0000000184A8B1D0
	// [XID] // 0x0000000189A42650-0x0000000189A42670
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A8C9D0-0x0000000184A8CB50
}

