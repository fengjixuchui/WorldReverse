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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigLevelNpcBornPos : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18784
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigNpcBornPos[] _bornPosList; // 0x18

	// Properties
	public uint sceneId { /* [XID] */ /* 0x0000000189761290-0x00000001897612B0 */ get => default; /* [XID] */ /* 0x0000000189768640-0x0000000189768660 */ private set {} } // 0x0000000185182CB0-0x0000000185182D80 0x0000000185183360-0x0000000185183440
	public ConfigNpcBornPos[] bornPosList { /* [XID] */ /* 0x000000018976FCD0-0x000000018976FCF0 */ get => default; /* [XID] */ /* 0x0000000189777490-0x00000001897774B0 */ private set {} } // 0x0000000185182200-0x00000001851822A0 0x0000000185182150-0x0000000185182200

	// Constructors
	public ConfigLevelNpcBornPos() {} // 0x0000000185183AA0-0x0000000185183B00

	// Methods
	// [XID] // 0x000000018977EC00-0x000000018977EC20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851837B0-0x00000001851838C0
	// [XID] // 0x00000001897864E0-0x0000000189786500
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185183440-0x0000000185183510
	// [XID] // 0x000000018978DB50-0x000000018978DB70
	public virtual ConfigLevelNpcBornPos Clone(bool useObjectPool = false /* Metadata: 0x00AFAC23 */) => default; // 0x0000000185183080-0x0000000185183160
	// [XID] // 0x00000001897950E0-0x0000000189795100
	public virtual int GetHashNum() => default; // 0x0000000185182080-0x0000000185182150
	// [XID] // 0x000000018979D510-0x000000018979D530
	public virtual void InitEmpty() {} // 0x0000000185182AC0-0x0000000185182BC0
	[BlackList] // 0x00000001897A47F0-0x00000001897A4830
	// [XID] // 0x00000001897A47F0-0x00000001897A4830
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000185182570-0x00000001851828F0
	// [XID] // 0x00000001897AF190-0x00000001897AF1B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185181930-0x0000000185181C30
	[BlackList] // 0x00000001897B6F30-0x00000001897B6F70
	// [XID] // 0x00000001897B6F30-0x00000001897B6F70
	public static ConfigLevelNpcBornPos ParseFromJson(JSONNode node) => default; // 0x0000000185183160-0x0000000185183360
	// [XID] // 0x00000001897C1AF0-0x00000001897C1B10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC24 */, bool useObjectPool = false /* Metadata: 0x00AFAC28 */) => default; // 0x0000000185182D80-0x0000000185183080
	// [XID] // 0x00000001897C9480-0x00000001897C94A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC29 */, bool useObjectPool = false /* Metadata: 0x00AFAC2D */) => default; // 0x00000001851822A0-0x0000000185182570
	// [XID] // 0x00000001897D0A70-0x00000001897D0A90
	public static ConfigLevelNpcBornPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC2E */, bool useObjectPool = false /* Metadata: 0x00AFAC32 */) => default; // 0x00000001851828F0-0x0000000185182AC0
	[BlackList] // 0x00000001897D87D0-0x00000001897D8810
	// [XID] // 0x00000001897D87D0-0x00000001897D8810
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000185181C30-0x0000000185181F00
	// [XID] // 0x00000001897E2A80-0x00000001897E2AA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185183510-0x00000001851837B0
	[BlackList] // 0x00000001897EA240-0x00000001897EA280
	// [XID] // 0x00000001897EA240-0x00000001897EA280
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185182BC0-0x0000000185182CB0
	[BlackList] // 0x00000001897F4DB0-0x00000001897F4DF0
	// [XID] // 0x00000001897F4DB0-0x00000001897F4DF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185181F00-0x0000000185181FA0
	[BlackList] // 0x00000001897FF510-0x00000001897FF550
	// [XID] // 0x00000001897FF510-0x00000001897FF550
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185181FA0-0x0000000185182080
	[BlackList] // 0x0000000189809A70-0x0000000189809AB0
	// [XID] // 0x0000000189809A70-0x0000000189809AB0
	public virtual void ReturnToObjectPool() {} // 0x0000000185183A00-0x0000000185183AA0
	[BlackList] // 0x0000000189814030-0x0000000189814070
	// [XID] // 0x0000000189814030-0x0000000189814070
	public virtual void OnPoolAllocated() {} // 0x0000000185183960-0x0000000185183A00
	[BlackList] // 0x000000018981EBC0-0x000000018981EC00
	// [XID] // 0x000000018981EBC0-0x000000018981EC00
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851838C0-0x0000000185183960
}

