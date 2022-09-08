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
public class ConfigDie : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17692
{
	// Fields
	private bool _hasAnimatorDie; // 0x10
	private bool _muteAllShaderDieEff; // 0x11
	private bool _fallWhenAirDie; // 0x12
	private SimpleSafeFloat dieEndTimeRawNum; // 0x14
	private SimpleSafeFloat dieForceDisappearTimeRawNum; // 0x18
	private string _dieDisappearEffect; // 0x20
	private SimpleSafeFloat dieDisappearEffectDelayRawNum; // 0x28
	private E_ShaderData _dieShaderData; // 0x2C
	private SimpleSafeFloat dieShaderEnableDurationTimeRawNum; // 0x30
	private SimpleSafeFloat dieShaderDisableDurationTimeRawNum; // 0x34
	private SimpleSafeFloat dieModelFadeDelayRawNum; // 0x38
	private bool _useRagDoll; // 0x3C
	private SimpleSafeFloat ragDollDieEndTimeDelayRawNum; // 0x40

	// Properties
	public bool hasAnimatorDie { /* [XID] */ /* 0x000000018976F0A0-0x000000018976F0C0 */ get => default; /* [XID] */ /* 0x000000018992C5C0-0x000000018992C5E0 */ private set {} } // 0x00000001832F5DD0-0x00000001832F5E70 0x00000001832F3390-0x00000001832F3440
	public bool muteAllShaderDieEff { /* [XID] */ /* 0x0000000189776B40-0x0000000189776B60 */ get => default; /* [XID] */ /* 0x000000018993B830-0x000000018993B850 */ private set {} } // 0x00000001832F5240-0x00000001832F52E0 0x00000001832F4940-0x00000001832F49F0
	public bool fallWhenAirDie { /* [XID] */ /* 0x0000000189942910-0x0000000189942930 */ get => default; /* [XID] */ /* 0x000000018994A160-0x000000018994A180 */ private set {} } // 0x00000001832F4280-0x00000001832F4320 0x00000001832F36B0-0x00000001832F3760
	public float dieEndTime { /* [XID] */ /* 0x0000000189951C50-0x0000000189951C70 */ get => default; /* [XID] */ /* 0x0000000189959170-0x0000000189959190 */ private set {} } // 0x00000001832F49F0-0x00000001832F4AD0 0x00000001832F4320-0x00000001832F4400
	public float dieForceDisappearTime { /* [XID] */ /* 0x000000018978CF60-0x000000018978CF80 */ get => default; /* [XID] */ /* 0x0000000189968180-0x00000001899681A0 */ private set {} } // 0x00000001832F44E0-0x00000001832F45C0 0x00000001832F53C0-0x00000001832F54A0
	public string dieDisappearEffect { /* [XID] */ /* 0x00000001897943D0-0x00000001897943F0 */ get => default; /* [XID] */ /* 0x0000000189977200-0x0000000189977220 */ private set {} } // 0x00000001832F4AD0-0x00000001832F4B70 0x00000001832F4010-0x00000001832F40C0
	public float dieDisappearEffectDelay { /* [XID] */ /* 0x00000001897C3E10-0x00000001897C3E30 */ get => default; /* [XID] */ /* 0x0000000189986030-0x0000000189986050 */ private set {} } // 0x00000001832F34F0-0x00000001832F35D0 0x00000001832F40C0-0x00000001832F41A0
	public E_ShaderData dieShaderData { /* [XID] */ /* 0x000000018998DD00-0x000000018998DD20 */ get => default; /* [XID] */ /* 0x00000001899957B0-0x00000001899957D0 */ private set {} } // 0x00000001832F32F0-0x00000001832F3390 0x00000001832F3F60-0x00000001832F4010
	public float dieShaderEnableDurationTime { /* [XID] */ /* 0x000000018999D150-0x000000018999D170 */ get => default; /* [XID] */ /* 0x00000001899A4AB0-0x00000001899A4AD0 */ private set {} } // 0x00000001832F52E0-0x00000001832F53C0 0x00000001832F4B70-0x00000001832F4C50
	public float dieShaderDisableDurationTime { /* [XID] */ /* 0x00000001899AC570-0x00000001899AC590 */ get => default; /* [XID] */ /* 0x00000001899B3D20-0x00000001899B3D40 */ private set {} } // 0x00000001832F41A0-0x00000001832F4280 0x00000001832F4CF0-0x00000001832F4DD0
	public float dieModelFadeDelay { /* [XID] */ /* 0x00000001897D2E30-0x00000001897D2E50 */ get => default; /* [XID] */ /* 0x00000001899C2BC0-0x00000001899C2BE0 */ private set {} } // 0x00000001832F5CF0-0x00000001832F5DD0 0x00000001832F35D0-0x00000001832F36B0
	public bool useRagDoll { /* [XID] */ /* 0x00000001899CA140-0x00000001899CA160 */ get => default; /* [XID] */ /* 0x00000001899D1980-0x00000001899D19A0 */ private set {} } // 0x00000001832F4C50-0x00000001832F4CF0 0x00000001832F3440-0x00000001832F34F0
	public float ragDollDieEndTimeDelay { /* [XID] */ /* 0x00000001897E2040-0x00000001897E2060 */ get => default; /* [XID] */ /* 0x00000001899E04E0-0x00000001899E0500 */ private set {} } // 0x00000001832F20E0-0x00000001832F21C0 0x00000001832F4400-0x00000001832F44E0

	// Constructors
	public ConfigDie() {} // 0x00000001832F6280-0x00000001832F63A0

	// Methods
	// [XID] // 0x0000000189767A30-0x0000000189767A50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832F5E70-0x00000001832F60A0
	// [XID] // 0x00000001899EF590-0x00000001899EF5B0
	public void InitEmpty() {} // 0x00000001832F4DD0-0x00000001832F4F40
	[BlackList] // 0x00000001899F6E30-0x00000001899F6E70
	// [XID] // 0x00000001899F6E30-0x00000001899F6E70
	public bool FromJson(JSONNode node) => default; // 0x00000001832F45C0-0x00000001832F4940
	// [XID] // 0x0000000189A01110-0x0000000189A01130
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832F21C0-0x00000001832F2E30
	// [XID] // 0x0000000189A08AF0-0x0000000189A08B10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77F3 */, bool useObjectPool = false /* Metadata: 0x00AF77F7 */) => default; // 0x00000001832F4F40-0x00000001832F5240
	// [XID] // 0x0000000189A10090-0x0000000189A100B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77F8 */, bool useObjectPool = false /* Metadata: 0x00AF77FC */) => default; // 0x00000001832F3760-0x00000001832F3F60
	[BlackList] // 0x0000000189A17570-0x0000000189A175B0
	// [XID] // 0x0000000189A17570-0x0000000189A175B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832F2E30-0x00000001832F3100
	// [XID] // 0x0000000189A21BD0-0x0000000189A21BF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832F54A0-0x00000001832F5CF0
	[BlackList] // 0x0000000189A29140-0x0000000189A29180
	// [XID] // 0x0000000189A29140-0x0000000189A29180
	public virtual void AutoAllocTypeFields() {} // 0x00000001832F3100-0x00000001832F31A0
	[BlackList] // 0x0000000189A336E0-0x0000000189A33720
	// [XID] // 0x0000000189A336E0-0x0000000189A33720
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832F31A0-0x00000001832F32F0
	[BlackList] // 0x0000000189A3E090-0x0000000189A3E0D0
	// [XID] // 0x0000000189A3E090-0x0000000189A3E0D0
	public virtual void ReturnToObjectPool() {} // 0x00000001832F61E0-0x00000001832F6280
	[BlackList] // 0x0000000189A48770-0x0000000189A487B0
	// [XID] // 0x0000000189A48770-0x0000000189A487B0
	public virtual void OnPoolAllocated() {} // 0x00000001832F6140-0x00000001832F61E0
	[BlackList] // 0x0000000189A52D20-0x0000000189A52D60
	// [XID] // 0x0000000189A52D20-0x0000000189A52D60
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832F60A0-0x00000001832F6140
}

