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
public class ConfigMusicUIntMultiValueStimulusHandler : ConfigMusicMultiValueParameterizedStimulusHandler, IAutoAllocRecycle // TypeDefIndex: 18760
{
	// Fields
	private SimpleSafeUInt32[] _uintParams; // 0x28
	private static SimpleSafeUInt32Comparer _uint32Comparer; // 0x00

	// Properties
	public SimpleSafeUInt32[] uintParams { /* [XID] */ /* 0x0000000189741C80-0x0000000189741CA0 */ get => default; /* [XID] */ /* 0x00000001897495A0-0x00000001897495C0 */ private set {} } // 0x0000000181D6E130-0x0000000181D6E1D0 0x0000000181D6EA90-0x0000000181D6EB40
	protected static SimpleSafeUInt32Comparer uint32Comparer { /* [XID] */ /* 0x00000001897C63E0-0x00000001897C6400 */ get => default; } // 0x0000000181D6E9A0-0x0000000181D6EA90 

	// Constructors
	public ConfigMusicUIntMultiValueStimulusHandler() {} // 0x0000000181D6EF10-0x0000000181D6EF70

	// Methods
	// [XID] // 0x0000000189750980-0x00000001897509A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D6ED80-0x0000000181D6EE70
	// [XID] // 0x0000000189757E30-0x0000000189757E50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181D6E8C0-0x0000000181D6E9A0
	// [XID] // 0x000000018975F950-0x000000018975F970
	public override ConfigMusicStimulusHandler Clone(bool useObjectPool = false /* Metadata: 0x00AFAB41 */) => default; // 0x0000000181D6E4D0-0x0000000181D6E5B0
	// [XID] // 0x0000000189766EC0-0x0000000189766EE0
	public override int GetHashNum() => default; // 0x0000000181D6D360-0x0000000181D6D430
	// [XID] // 0x000000018976E3E0-0x000000018976E400
	public override void InitEmpty() {} // 0x0000000181D6DE90-0x0000000181D6DF60
	[BlackList] // 0x0000000189775D00-0x0000000189775D40
	// [XID] // 0x0000000189775D00-0x0000000189775D40
	public override bool FromJson(JSONNode node) => default; // 0x0000000181D6D880-0x0000000181D6DC00
	// [XID] // 0x00000001897803C0-0x00000001897803E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181D6CBF0-0x0000000181D6CE20
	[BlackList] // 0x0000000189787BE0-0x0000000189787C20
	// [XID] // 0x0000000189787BE0-0x0000000189787C20
	public static new ConfigMusicUIntMultiValueStimulusHandler ParseFromJson(JSONNode node) => default; // 0x0000000181D6E610-0x0000000181D6E860
	// [XID] // 0x0000000189792260-0x0000000189792280
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB42 */, bool useObjectPool = false /* Metadata: 0x00AFAB46 */) => default; // 0x0000000181D6E1D0-0x0000000181D6E4D0
	// [XID] // 0x00000001897997F0-0x0000000189799810
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB47 */, bool useObjectPool = false /* Metadata: 0x00AFAB4B */) => default; // 0x0000000181D6D510-0x0000000181D6D780
	// [XID] // 0x00000001897A1640-0x00000001897A1660
	public static new ConfigMusicUIntMultiValueStimulusHandler ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB4C */, bool useObjectPool = false /* Metadata: 0x00AFAB50 */) => default; // 0x0000000181D6DC00-0x0000000181D6DE20
	[BlackList] // 0x00000001897A8F00-0x00000001897A8F40
	// [XID] // 0x00000001897A8F00-0x00000001897A8F40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D6CE20-0x0000000181D6D0F0
	// [XID] // 0x00000001897B3CD0-0x00000001897B3CF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D6EB40-0x0000000181D6ED80
	[BlackList] // 0x00000001897BBAB0-0x00000001897BBAF0
	// [XID] // 0x00000001897BBAB0-0x00000001897BBAF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181D6E040-0x0000000181D6E130
	[BlackList] // 0x00000001897CDC00-0x00000001897CDC40
	// [XID] // 0x00000001897CDC00-0x00000001897CDC40
	public override void AutoAllocTypeFields() {} // 0x0000000181D6D0F0-0x0000000181D6D190
	[BlackList] // 0x00000001897D8810-0x00000001897D8850
	// [XID] // 0x00000001897D8810-0x00000001897D8850
	public override void AutoRecycleTypeFields() {} // 0x0000000181D6D190-0x0000000181D6D240
	[BlackList] // 0x00000001897E2AA0-0x00000001897E2AE0
	// [XID] // 0x00000001897E2AA0-0x00000001897E2AE0
	public override void ReturnToObjectPool() {} // 0x0000000181D6EE70-0x0000000181D6EF10
}

