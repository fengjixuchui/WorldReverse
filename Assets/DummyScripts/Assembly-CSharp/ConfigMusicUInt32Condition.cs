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
public class ConfigMusicUInt32Condition : ConfigMusicParameterCondition, IAutoAllocRecycle // TypeDefIndex: 18672
{
	// Fields
	private SimpleSafeUInt32 valueRawNum; // 0x20

	// Properties
	public uint value { /* [XID] */ /* 0x0000000189B54EB0-0x0000000189B54ED0 */ get => default; /* [XID] */ /* 0x0000000189B5C8F0-0x0000000189B5C910 */ private set {} } // 0x00000001832FAF80-0x00000001832FB050 0x00000001832FAE20-0x00000001832FAF00

	// Constructors
	public ConfigMusicUInt32Condition() {} // 0x00000001832FC460-0x00000001832FC4C0

	// Methods
	// [XID] // 0x0000000189B63F10-0x0000000189B63F30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832FC2D0-0x00000001832FC3C0
	// [XID] // 0x0000000189B6B710-0x0000000189B6B730
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001832FBFF0-0x00000001832FC0A0
	// [XID] // 0x0000000189B72CD0-0x0000000189B72CF0
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA86B */) => default; // 0x00000001832FBC00-0x00000001832FBCE0
	// [XID] // 0x0000000189B7A250-0x0000000189B7A270
	public override int GetHashNum() => default; // 0x00000001832FA980-0x00000001832FAA50
	// [XID] // 0x0000000189B819B0-0x0000000189B819D0
	public override void InitEmpty() {} // 0x00000001832FB660-0x00000001832FB730
	[BlackList] // 0x0000000189B890B0-0x0000000189B890F0
	// [XID] // 0x0000000189B890B0-0x0000000189B890F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001832FB050-0x00000001832FB3D0
	// [XID] // 0x0000000189B93530-0x0000000189B93550
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001832F9F30-0x00000001832FA190
	[BlackList] // 0x0000000189B9AA60-0x0000000189B9AAA0
	// [XID] // 0x0000000189B9AA60-0x0000000189B9AAA0
	public static new ConfigMusicUInt32Condition ParseFromJson(JSONNode node) => default; // 0x00000001832FBD40-0x00000001832FBF90
	// [XID] // 0x0000000189BA5210-0x0000000189BA5230
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA86C */, bool useObjectPool = false /* Metadata: 0x00AFA870 */) => default; // 0x00000001832FB900-0x00000001832FBC00
	// [XID] // 0x0000000189BAC370-0x0000000189BAC390
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA871 */, bool useObjectPool = false /* Metadata: 0x00AFA875 */) => default; // 0x00000001832FAB30-0x00000001832FADA0
	// [XID] // 0x0000000189BB3BF0-0x0000000189BB3C10
	public static new ConfigMusicUInt32Condition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA876 */, bool useObjectPool = false /* Metadata: 0x00AFA87A */) => default; // 0x00000001832FB3D0-0x00000001832FB5F0
	[BlackList] // 0x0000000189BBB190-0x0000000189BBB1D0
	// [XID] // 0x0000000189BBB190-0x0000000189BBB1D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001832FA190-0x00000001832FA460
	// [XID] // 0x0000000189BC5D40-0x0000000189BC5D60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832FC0A0-0x00000001832FC2D0
	[BlackList] // 0x0000000189BCD740-0x0000000189BCD780
	// [XID] // 0x0000000189BCD740-0x0000000189BCD780
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001832FB810-0x00000001832FB900
	// [IDTag] // 0x0000000189BD7B30-0x0000000189BD7B70
	// [XID] // 0x0000000189BD7B30-0x0000000189BD7B70
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x00000001832FA710-0x00000001832FA850
	// [IDTag] // 0x00000001895E7790-0x00000001895E77D0
	// [XID] // 0x00000001895E7790-0x00000001895E77D0
	protected virtual bool IsMet(uint paramValue) => default; // 0x00000001832FA850-0x00000001832FA900
	[BlackList] // 0x00000001895F1F90-0x00000001895F1FD0
	// [XID] // 0x00000001895F1F90-0x00000001895F1FD0
	public override void AutoAllocTypeFields() {} // 0x00000001832FA4F0-0x00000001832FA590
	[BlackList] // 0x00000001895FC790-0x00000001895FC7D0
	// [XID] // 0x00000001895FC790-0x00000001895FC7D0
	public override void AutoRecycleTypeFields() {} // 0x00000001832FA590-0x00000001832FA670
	[BlackList] // 0x0000000189606F00-0x0000000189606F40
	// [XID] // 0x0000000189606F00-0x0000000189606F40
	public override void ReturnToObjectPool() {} // 0x00000001832FC3C0-0x00000001832FC460
}

