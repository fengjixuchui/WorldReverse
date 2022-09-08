/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAudioPositionedOp : ConfigAudioOperation, IAutoAllocRecycle // TypeDefIndex: 17611
{
	// Fields
	private SimpleSafeFloat positioningRawNum; // 0x18

	// Properties
	public float positioning { /* [XID] */ /* 0x0000000189683A50-0x0000000189683A70 */ get => default; /* [XID] */ /* 0x000000018968B7D0-0x000000018968B7F0 */ private set {} } // 0x0000000181D2DBC0-0x0000000181D2DCA0 0x0000000181D2E2F0-0x0000000181D2E3D0

	// Constructors
	public ConfigAudioPositionedOp() {} // 0x0000000181D2E470-0x0000000181D2E4D0

	// Methods
	// [XID] // 0x0000000189693360-0x0000000189693380
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D2E1F0-0x0000000181D2E2F0
	// [XID] // 0x000000018969A5B0-0x000000018969A5D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181D2DF50-0x0000000181D2E000
	// [XID] // 0x00000001896A1E80-0x00000001896A1EA0
	public override ConfigAudioOperation Clone(bool useObjectPool = false /* Metadata: 0x00AF74A9 */) => default; // 0x0000000181D2DA80-0x0000000181D2DB60
	// [XID] // 0x00000001896A9220-0x00000001896A9240
	public override int GetHashNum() => default; // 0x0000000181D2C9B0-0x0000000181D2CA80
	// [XID] // 0x00000001896B0350-0x00000001896B0370
	public override void InitEmpty() {} // 0x0000000181D2D4E0-0x0000000181D2D5B0
	[BlackList] // 0x00000001896B7CB0-0x00000001896B7CF0
	// [XID] // 0x00000001896B7CB0-0x00000001896B7CF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181D2CED0-0x0000000181D2D250
	// [XID] // 0x00000001896C1BE0-0x00000001896C1C00
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181D2C1D0-0x0000000181D2C440
	[BlackList] // 0x00000001896C92B0-0x00000001896C92F0
	// [XID] // 0x00000001896C92B0-0x00000001896C92F0
	public static new ConfigAudioPositionedOp ParseFromJson(JSONNode node) => default; // 0x0000000181D2DCA0-0x0000000181D2DEF0
	// [XID] // 0x00000001896D35E0-0x00000001896D3600
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74AA */, bool useObjectPool = false /* Metadata: 0x00AF74AE */) => default; // 0x0000000181D2D780-0x0000000181D2DA80
	// [XID] // 0x00000001896DB160-0x00000001896DB180
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74AF */, bool useObjectPool = false /* Metadata: 0x00AF74B3 */) => default; // 0x0000000181D2CB60-0x0000000181D2CDD0
	// [XID] // 0x00000001896E2880-0x00000001896E28A0
	public static new ConfigAudioPositionedOp ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74B4 */, bool useObjectPool = false /* Metadata: 0x00AF74B8 */) => default; // 0x0000000181D2D250-0x0000000181D2D470
	[BlackList] // 0x00000001896E9EC0-0x00000001896E9F00
	// [XID] // 0x00000001896E9EC0-0x00000001896E9F00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D2C440-0x0000000181D2C710
	// [XID] // 0x00000001896F43A0-0x00000001896F43C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D2E000-0x0000000181D2E1F0
	[BlackList] // 0x00000001896FBC70-0x00000001896FBCB0
	// [XID] // 0x00000001896FBC70-0x00000001896FBCB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181D2D690-0x0000000181D2D780
	[BlackList] // 0x0000000189705FA0-0x0000000189705FE0
	// [XID] // 0x0000000189705FA0-0x0000000189705FE0
	public override void AutoAllocTypeFields() {} // 0x0000000181D2C710-0x0000000181D2C7B0
	[BlackList] // 0x0000000189710B90-0x0000000189710BD0
	// [XID] // 0x0000000189710B90-0x0000000189710BD0
	public override void AutoRecycleTypeFields() {} // 0x0000000181D2C7B0-0x0000000181D2C890
	[BlackList] // 0x000000018971B300-0x000000018971B340
	// [XID] // 0x000000018971B300-0x000000018971B340
	public override void ReturnToObjectPool() {} // 0x0000000181D2E3D0-0x0000000181D2E470
}

