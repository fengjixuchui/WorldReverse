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
public class ConfigMusicShifter : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18741
{
	// Fields
	private SimpleSafeInt32 targetSongIdRawNum; // 0x10
	private SimpleSafeInt32 rootConditionIdRawNum; // 0x14

	// Properties
	public int targetSongId { /* [XID] */ /* 0x0000000189A6B090-0x0000000189A6B0B0 */ get => default; /* [XID] */ /* 0x0000000189A72810-0x0000000189A72830 */ private set {} } // 0x00000001841A9770-0x00000001841A9840 0x00000001841A9690-0x00000001841A9770
	public int rootConditionId { /* [XID] */ /* 0x0000000189A7A3D0-0x0000000189A7A3F0 */ get => default; /* [XID] */ /* 0x0000000189A81830-0x0000000189A81850 */ private set {} } // 0x00000001841A9F60-0x00000001841AA030 0x00000001841A9E80-0x00000001841A9F60

	// Constructors
	public ConfigMusicShifter() {} // 0x00000001841AAAE0-0x00000001841AAB40

	// Methods
	// [XID] // 0x0000000189A89350-0x0000000189A89370
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841AA7F0-0x00000001841AA900
	// [XID] // 0x0000000189A90BD0-0x0000000189A90BF0
	public void InitEmpty() {} // 0x00000001841AA030-0x00000001841AA110
	[BlackList] // 0x0000000189A98320-0x0000000189A98360
	// [XID] // 0x0000000189A98320-0x0000000189A98360
	public bool FromJson(JSONNode node) => default; // 0x00000001841A9B00-0x00000001841A9E80
	// [XID] // 0x0000000189AA25E0-0x0000000189AA2600
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841A8F10-0x00000001841A9240
	// [XID] // 0x0000000189AA9B20-0x0000000189AA9B40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAA9B */, bool useObjectPool = false /* Metadata: 0x00AFAA9F */) => default; // 0x00000001841AA110-0x00000001841AA410
	// [XID] // 0x0000000189AB1A80-0x0000000189AB1AA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAA0 */, bool useObjectPool = false /* Metadata: 0x00AFAAA4 */) => default; // 0x00000001841A9840-0x00000001841A9B00
	[BlackList] // 0x0000000189AB8D00-0x0000000189AB8D40
	// [XID] // 0x0000000189AB8D00-0x0000000189AB8D40
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001841A9240-0x00000001841A9510
	// [XID] // 0x0000000189AC3E60-0x0000000189AC3E80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841AA550-0x00000001841AA7F0
	// [XID] // 0x0000000189ACB280-0x0000000189ACB2A0
	public bool CanShift(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> gameParamLookup) => default; // 0x00000001841AA410-0x00000001841AA550
	[BlackList] // 0x0000000189AD2D20-0x0000000189AD2D60
	// [XID] // 0x0000000189AD2D20-0x0000000189AD2D60
	public virtual void AutoAllocTypeFields() {} // 0x00000001841A9510-0x00000001841A95B0
	[BlackList] // 0x0000000189ADDAB0-0x0000000189ADDAF0
	// [XID] // 0x0000000189ADDAB0-0x0000000189ADDAF0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841A95B0-0x00000001841A9690
	[BlackList] // 0x0000000189AE8050-0x0000000189AE8090
	// [XID] // 0x0000000189AE8050-0x0000000189AE8090
	public virtual void ReturnToObjectPool() {} // 0x00000001841AAA40-0x00000001841AAAE0
	[BlackList] // 0x0000000189AF2C10-0x0000000189AF2C50
	// [XID] // 0x0000000189AF2C10-0x0000000189AF2C50
	public virtual void OnPoolAllocated() {} // 0x00000001841AA9A0-0x00000001841AAA40
	[BlackList] // 0x0000000189AFCF90-0x0000000189AFCFD0
	// [XID] // 0x0000000189AFCF90-0x0000000189AFCFD0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841AA900-0x00000001841AA9A0
}

