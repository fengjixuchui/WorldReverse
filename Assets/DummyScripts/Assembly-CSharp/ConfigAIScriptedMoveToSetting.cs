/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAIScriptedMoveToSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17477
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIScriptedMoveToData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIScriptedMoveToData> _specification; // 0x30

	// Properties
	public ConfigAIScriptedMoveToData defaultSetting { /* [XID] */ /* 0x0000000189A610F0-0x0000000189A61110 */ get => default; /* [XID] */ /* 0x0000000189686A90-0x0000000189686AB0 */ set {} } // 0x00000001829784B0-0x0000000182978550 0x00000001829762F0-0x00000001829763A0
	public Dictionary<SimpleSafeInt32, ConfigAIScriptedMoveToData> specification { /* [XID] */ /* 0x000000018968E910-0x000000018968E930 */ get => default; /* [XID] */ /* 0x0000000189A77B80-0x0000000189A77BA0 */ set {} } // 0x00000001829769A0-0x0000000182976A40 0x0000000182977F10-0x0000000182977FC0

	// Constructors
	public ConfigAIScriptedMoveToSetting() {} // 0x0000000182978980-0x0000000182978A00

	// Methods
	// [XID] // 0x000000018969D990-0x000000018969D9B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182978830-0x00000001829788E0
	// [XID] // 0x00000001896A49C0-0x00000001896A49E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829783B0-0x00000001829784B0
	// [XID] // 0x00000001896AC170-0x00000001896AC190
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6FED */) => default; // 0x0000000182977FC0-0x00000001829780A0
	// [XID] // 0x00000001896B3470-0x00000001896B3490
	public override int GetHashNum() => default; // 0x0000000182976D50-0x0000000182976E20
	// [XID] // 0x00000001896BABF0-0x00000001896BAC10
	public override void InitEmpty() {} // 0x0000000182977950-0x0000000182977A40
	[BlackList] // 0x00000001896C1CC0-0x00000001896C1D00
	// [XID] // 0x00000001896C1CC0-0x00000001896C1D00
	public override bool FromJson(JSONNode node) => default; // 0x0000000182977340-0x00000001829776C0
	// [XID] // 0x00000001896CC490-0x00000001896CC4B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829763A0-0x00000001829766D0
	[BlackList] // 0x00000001896D3660-0x00000001896D36A0
	// [XID] // 0x00000001896D3660-0x00000001896D36A0
	public static new ConfigAIScriptedMoveToSetting ParseFromJson(JSONNode node) => default; // 0x0000000182978100-0x0000000182978350
	// [XID] // 0x00000001896DE0C0-0x00000001896DE0E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FEE */, bool useObjectPool = false /* Metadata: 0x00AF6FF2 */) => default; // 0x0000000182977C10-0x0000000182977F10
	// [XID] // 0x00000001896E55D0-0x00000001896E55F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FF3 */, bool useObjectPool = false /* Metadata: 0x00AF6FF7 */) => default; // 0x0000000182976F00-0x0000000182977240
	// [XID] // 0x00000001896ECC40-0x00000001896ECC60
	public static new ConfigAIScriptedMoveToSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FF8 */, bool useObjectPool = false /* Metadata: 0x00AF6FFC */) => default; // 0x00000001829776C0-0x00000001829778E0
	[BlackList] // 0x00000001896F43E0-0x00000001896F4420
	// [XID] // 0x00000001896F43E0-0x00000001896F4420
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829766D0-0x00000001829769A0
	// [XID] // 0x00000001896FEDD0-0x00000001896FEDF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182978550-0x0000000182978830
	[BlackList] // 0x0000000189706000-0x0000000189706040
	// [XID] // 0x0000000189706000-0x0000000189706040
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182977B20-0x0000000182977C10
	[BlackList] // 0x0000000189710C10-0x0000000189710C50
	// [XID] // 0x0000000189710C10-0x0000000189710C50
	public override void AutoAllocTypeFields() {} // 0x0000000182976A40-0x0000000182976AE0
	[BlackList] // 0x000000018971B380-0x000000018971B3C0
	// [XID] // 0x000000018971B380-0x000000018971B3C0
	public override void AutoRecycleTypeFields() {} // 0x0000000182976AE0-0x0000000182976C30
	[BlackList] // 0x0000000189725660-0x00000001897256A0
	// [XID] // 0x0000000189725660-0x00000001897256A0
	public override void ReturnToObjectPool() {} // 0x00000001829788E0-0x0000000182978980
}

