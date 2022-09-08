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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicBinaryCondition : ConfigMusicCondition, IAutoAllocRecycle // TypeDefIndex: 18650
{
	// Fields
	private SimpleSafeInt32 lhsIdRawNum; // 0x18
	private SimpleSafeInt32 rhsIdRawNum; // 0x1C

	// Properties
	public int lhsId { /* [XID] */ /* 0x0000000189A05CB0-0x0000000189A05CD0 */ get => default; /* [XID] */ /* 0x0000000189A0D000-0x0000000189A0D020 */ private set {} } // 0x00000001836319E0-0x0000000183631AB0 0x0000000183633700-0x00000001836337E0
	public int rhsId { /* [XID] */ /* 0x0000000189A148A0-0x0000000189A148C0 */ get => default; /* [XID] */ /* 0x0000000189A1BBF0-0x0000000189A1BC10 */ private set {} } // 0x0000000183632470-0x0000000183632540 0x0000000183632B60-0x0000000183632C40

	// Constructors
	public ConfigMusicBinaryCondition() {} // 0x0000000183633C80-0x0000000183633CE0

	// Methods
	// [XID] // 0x0000000189A23440-0x0000000189A23460
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183633AD0-0x0000000183633BE0
	// [XID] // 0x0000000189A2A7A0-0x0000000189A2A7C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183633650-0x0000000183633700
	// [XID] // 0x0000000189A31D00-0x0000000189A31D20
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA7BB */) => default; // 0x0000000183633260-0x0000000183633340
	// [XID] // 0x0000000189A39730-0x0000000189A39750
	public override int GetHashNum() => default; // 0x0000000183631D60-0x0000000183631E30
	// [XID] // 0x0000000189A40F30-0x0000000189A40F50
	public override void InitEmpty() {} // 0x0000000183632CB0-0x0000000183632D90
	[BlackList] // 0x0000000189A485B0-0x0000000189A485F0
	// [XID] // 0x0000000189A485B0-0x0000000189A485F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183632540-0x00000001836328C0
	// [XID] // 0x0000000189A52B80-0x0000000189A52BA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183631390-0x0000000183631710
	[BlackList] // 0x0000000189A5A4B0-0x0000000189A5A4F0
	// [XID] // 0x0000000189A5A4B0-0x0000000189A5A4F0
	public static new ConfigMusicBinaryCondition ParseFromJson(JSONNode node) => default; // 0x00000001836333A0-0x00000001836335F0
	// [XID] // 0x0000000189A64F00-0x0000000189A64F20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7BC */, bool useObjectPool = false /* Metadata: 0x00AFA7C0 */) => default; // 0x0000000183632F60-0x0000000183633260
	// [XID] // 0x0000000189A6C680-0x0000000189A6C6A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7C1 */, bool useObjectPool = false /* Metadata: 0x00AFA7C5 */) => default; // 0x0000000183632070-0x0000000183632370
	// [XID] // 0x0000000189A73E90-0x0000000189A73EB0
	public static new ConfigMusicBinaryCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7C6 */, bool useObjectPool = false /* Metadata: 0x00AFA7CA */) => default; // 0x0000000183632940-0x0000000183632B60
	[BlackList] // 0x0000000189A7B960-0x0000000189A7B9A0
	// [XID] // 0x0000000189A7B960-0x0000000189A7B9A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183631710-0x00000001836319E0
	// [XID] // 0x0000000189A86130-0x0000000189A86150
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001836337E0-0x0000000183633AD0
	[BlackList] // 0x0000000189A8DA50-0x0000000189A8DA90
	// [XID] // 0x0000000189A8DA50-0x0000000189A8DA90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183632E70-0x0000000183632F60
	// [XID] // 0x0000000189A98360-0x0000000189A98380
	public override MusicGameParam GetMusicGameParam(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) => default; // 0x0000000183631E30-0x0000000183631F90
	[BlackList] // 0x0000000189A9F730-0x0000000189A9F770
	// [XID] // 0x0000000189A9F730-0x0000000189A9F770
	public override void AutoAllocTypeFields() {} // 0x0000000183631AB0-0x0000000183631B50
	[BlackList] // 0x0000000189AA9B40-0x0000000189AA9B80
	// [XID] // 0x0000000189AA9B40-0x0000000189AA9B80
	public override void AutoRecycleTypeFields() {} // 0x0000000183631B50-0x0000000183631C40
	[BlackList] // 0x0000000189AB4750-0x0000000189AB4790
	// [XID] // 0x0000000189AB4750-0x0000000189AB4790
	public override void ReturnToObjectPool() {} // 0x0000000183633BE0-0x0000000183633C80
}

