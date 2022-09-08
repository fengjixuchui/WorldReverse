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
public class ConfigMusicSingleCondition : ConfigMusicParameterCondition, IAutoAllocRecycle // TypeDefIndex: 18688
{
	// Fields
	private SimpleSafeFloat valueRawNum; // 0x20

	// Properties
	public float value { /* [XID] */ /* 0x0000000189A9C930-0x0000000189A9C950 */ get => default; /* [XID] */ /* 0x0000000189AA4060-0x0000000189AA4080 */ private set {} } // 0x0000000185094970-0x0000000185094A50 0x0000000185094810-0x00000001850948F0

	// Constructors
	public ConfigMusicSingleCondition() {} // 0x0000000185095E30-0x0000000185095E90

	// Methods
	// [XID] // 0x0000000189AAB570-0x0000000189AAB590
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185095C90-0x0000000185095D90
	// [XID] // 0x0000000189AB2EA0-0x0000000189AB2EC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001850959F0-0x0000000185095AA0
	// [XID] // 0x0000000189ABAB90-0x0000000189ABABB0
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA8EB */) => default; // 0x0000000185095600-0x00000001850956E0
	// [XID] // 0x0000000189AC22F0-0x0000000189AC2310
	public override int GetHashNum() => default; // 0x0000000185094370-0x0000000185094440
	// [XID] // 0x0000000189AC9A60-0x0000000189AC9A80
	public override void InitEmpty() {} // 0x0000000185095060-0x0000000185095130
	[BlackList] // 0x0000000189AD1330-0x0000000189AD1370
	// [XID] // 0x0000000189AD1330-0x0000000189AD1370
	public override bool FromJson(JSONNode node) => default; // 0x0000000185094A50-0x0000000185094DD0
	// [XID] // 0x0000000189ADC040-0x0000000189ADC060
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185093910-0x0000000185093B80
	[BlackList] // 0x0000000189AE39B0-0x0000000189AE39F0
	// [XID] // 0x0000000189AE39B0-0x0000000189AE39F0
	public static new ConfigMusicSingleCondition ParseFromJson(JSONNode node) => default; // 0x0000000185095740-0x0000000185095990
	// [XID] // 0x0000000189AEE540-0x0000000189AEE560
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA8EC */, bool useObjectPool = false /* Metadata: 0x00AFA8F0 */) => default; // 0x0000000185095300-0x0000000185095600
	// [XID] // 0x0000000189AF5AD0-0x0000000189AF5AF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA8F1 */, bool useObjectPool = false /* Metadata: 0x00AFA8F5 */) => default; // 0x0000000185094520-0x0000000185094790
	// [XID] // 0x0000000189AFCFD0-0x0000000189AFCFF0
	public static new ConfigMusicSingleCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA8F6 */, bool useObjectPool = false /* Metadata: 0x00AFA8FA */) => default; // 0x0000000185094DD0-0x0000000185094FF0
	[BlackList] // 0x0000000189B04780-0x0000000189B047C0
	// [XID] // 0x0000000189B04780-0x0000000189B047C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185093B80-0x0000000185093E50
	// [XID] // 0x0000000189B0EFD0-0x0000000189B0EFF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185095AA0-0x0000000185095C90
	[BlackList] // 0x0000000189B16290-0x0000000189B162D0
	// [XID] // 0x0000000189B16290-0x0000000189B162D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185095210-0x0000000185095300
	// [IDTag] // 0x0000000189B209F0-0x0000000189B20A30
	// [XID] // 0x0000000189B209F0-0x0000000189B20A30
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x00000001850941B0-0x00000001850942F0
	// [IDTag] // 0x0000000189B2B000-0x0000000189B2B040
	// [XID] // 0x0000000189B2B000-0x0000000189B2B040
	protected virtual bool IsMet(float paramValue) => default; // 0x0000000185094100-0x00000001850941B0
	[BlackList] // 0x0000000189B35300-0x0000000189B35340
	// [XID] // 0x0000000189B35300-0x0000000189B35340
	public override void AutoAllocTypeFields() {} // 0x0000000185093EE0-0x0000000185093F80
	[BlackList] // 0x0000000189B3FF80-0x0000000189B3FFC0
	// [XID] // 0x0000000189B3FF80-0x0000000189B3FFC0
	public override void AutoRecycleTypeFields() {} // 0x0000000185093F80-0x0000000185094060
	[BlackList] // 0x0000000189B4A810-0x0000000189B4A850
	// [XID] // 0x0000000189B4A810-0x0000000189B4A850
	public override void ReturnToObjectPool() {} // 0x0000000185095D90-0x0000000185095E30
}

