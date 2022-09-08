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
public class ConfigMusicTransitions : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18742
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMusicShifter[] _shifters; // 0x10

	// Properties
	public ConfigMusicShifter[] shifters { /* [XID] */ /* 0x0000000189B209D0-0x0000000189B209F0 */ get => default; /* [XID] */ /* 0x0000000189B28090-0x0000000189B280B0 */ private set {} } // 0x0000000183B84340-0x0000000183B843E0 0x0000000183B84050-0x0000000183B84100
	public MusicGameParam gameParamMask { /* [XID] */ /* 0x0000000189B716B0-0x0000000189B716F0 */ get; /* [XID] */ /* 0x0000000189B7B970-0x0000000189B7B9B0 */ set; } // 0x0000000183B83C20-0x0000000183B83C80 0x0000000183B842E0-0x0000000183B84340

	// Constructors
	public ConfigMusicTransitions() {} // 0x0000000183B84890-0x0000000183B848F0

	// Methods
	// [XID] // 0x0000000189B2F450-0x0000000189B2F470
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B845D0-0x0000000183B846B0
	// [XID] // 0x0000000189B36D50-0x0000000189B36D70
	public void InitEmpty() {} // 0x0000000183B83C80-0x0000000183B83D50
	[BlackList] // 0x0000000189B3E5A0-0x0000000189B3E5E0
	// [XID] // 0x0000000189B3E5A0-0x0000000189B3E5E0
	public bool FromJson(JSONNode node) => default; // 0x0000000183B838A0-0x0000000183B83C20
	// [XID] // 0x0000000189B491A0-0x0000000189B491C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183B83060-0x0000000183B83240
	// [XID] // 0x0000000189B50820-0x0000000189B50840
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAA5 */, bool useObjectPool = false /* Metadata: 0x00AFAAA9 */) => default; // 0x0000000183B83D50-0x0000000183B84050
	// [XID] // 0x0000000189B58120-0x0000000189B58140
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAAA */, bool useObjectPool = false /* Metadata: 0x00AFAAAE */) => default; // 0x0000000183B83690-0x0000000183B838A0
	[BlackList] // 0x0000000189B5FA60-0x0000000189B5FAA0
	// [XID] // 0x0000000189B5FA60-0x0000000189B5FAA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B83240-0x0000000183B83510
	// [XID] // 0x0000000189B6A050-0x0000000189B6A070
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B843E0-0x0000000183B845D0
	// [XID] // 0x0000000189B86480-0x0000000189B864A0
	public void BuildGameParamMask(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) {} // 0x0000000183B84100-0x0000000183B842E0
	[BlackList] // 0x0000000189B8D4F0-0x0000000189B8D530
	// [XID] // 0x0000000189B8D4F0-0x0000000189B8D530
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B83510-0x0000000183B835B0
	[BlackList] // 0x0000000189B97AA0-0x0000000189B97AE0
	// [XID] // 0x0000000189B97AA0-0x0000000189B97AE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B835B0-0x0000000183B83690
	[BlackList] // 0x0000000189BA21B0-0x0000000189BA21F0
	// [XID] // 0x0000000189BA21B0-0x0000000189BA21F0
	public virtual void ReturnToObjectPool() {} // 0x0000000183B847F0-0x0000000183B84890
	[BlackList] // 0x0000000189BAC2F0-0x0000000189BAC330
	// [XID] // 0x0000000189BAC2F0-0x0000000189BAC330
	public virtual void OnPoolAllocated() {} // 0x0000000183B84750-0x0000000183B847F0
	[BlackList] // 0x0000000189BB69B0-0x0000000189BB69F0
	// [XID] // 0x0000000189BB69B0-0x0000000189BB69F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B846B0-0x0000000183B84750
}

