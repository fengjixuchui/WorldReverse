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
public class ConfigMusicTimeTransitions : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18745
{
	// Fields
	private SimpleSafeFloat intervalRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _repetitives; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMusicFixedTimeTransitions[] _fixedTimes; // 0x20

	// Properties
	public float interval { /* [XID] */ /* 0x000000018977BBC0-0x000000018977BBE0 */ get => default; /* [XID] */ /* 0x00000001897835B0-0x00000001897835D0 */ private set {} } // 0x0000000181476B10-0x0000000181476BF0 0x0000000181476150-0x0000000181476230
	public ConfigMusicTransitions repetitives { /* [XID] */ /* 0x000000018973E660-0x000000018973E680 */ get => default; /* [XID] */ /* 0x0000000189792280-0x00000001897922A0 */ private set {} } // 0x00000001814765B0-0x0000000181476650 0x0000000181476650-0x0000000181476700
	public ConfigMusicFixedTimeTransitions[] fixedTimes { /* [XID] */ /* 0x0000000189799810-0x0000000189799830 */ get => default; /* [XID] */ /* 0x00000001897A1660-0x00000001897A1680 */ private set {} } // 0x0000000181476D40-0x0000000181476DE0 0x0000000181476DE0-0x0000000181476E90

	// Constructors
	public ConfigMusicTimeTransitions() {} // 0x00000001814774D0-0x0000000181477530

	// Methods
	// [XID] // 0x00000001897A8F40-0x00000001897A8F60
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001814771B0-0x00000001814772F0
	// [XID] // 0x00000001897B0780-0x00000001897B07A0
	public void InitEmpty() {} // 0x0000000181476700-0x0000000181476810
	[BlackList] // 0x00000001897B8520-0x00000001897B8560
	// [XID] // 0x00000001897B8520-0x00000001897B8560
	public bool FromJson(JSONNode node) => default; // 0x0000000181476230-0x00000001814765B0
	// [XID] // 0x00000001897C3330-0x00000001897C3350
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001814754E0-0x00000001814758F0
	// [XID] // 0x00000001897CAAF0-0x00000001897CAB10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAC3 */, bool useObjectPool = false /* Metadata: 0x00AFAAC7 */) => default; // 0x0000000181476810-0x0000000181476B10
	// [XID] // 0x00000001897D2150-0x00000001897D2170
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAC8 */, bool useObjectPool = false /* Metadata: 0x00AFAACC */) => default; // 0x0000000181475DC0-0x0000000181476150
	[BlackList] // 0x00000001897D9FF0-0x00000001897DA030
	// [XID] // 0x00000001897D9FF0-0x00000001897DA030
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001814758F0-0x0000000181475BC0
	// [XID] // 0x00000001897E43B0-0x00000001897E43D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181476E90-0x00000001814771B0
	// [XID] // 0x00000001897EBE80-0x00000001897EBEA0
	public void BuildGameParamMask(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) {} // 0x0000000181476BF0-0x0000000181476D40
	[BlackList] // 0x00000001897F37B0-0x00000001897F37F0
	// [XID] // 0x00000001897F37B0-0x00000001897F37F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181475BC0-0x0000000181475C60
	[BlackList] // 0x00000001897FDB60-0x00000001897FDBA0
	// [XID] // 0x00000001897FDB60-0x00000001897FDBA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181475C60-0x0000000181475DC0
	[BlackList] // 0x0000000189808200-0x0000000189808240
	// [XID] // 0x0000000189808200-0x0000000189808240
	public virtual void ReturnToObjectPool() {} // 0x0000000181477430-0x00000001814774D0
	[BlackList] // 0x0000000189812900-0x0000000189812940
	// [XID] // 0x0000000189812900-0x0000000189812940
	public virtual void OnPoolAllocated() {} // 0x0000000181477390-0x0000000181477430
	[BlackList] // 0x000000018981D470-0x000000018981D4B0
	// [XID] // 0x000000018981D470-0x000000018981D4B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001814772F0-0x0000000181477390
}

