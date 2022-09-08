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
public class ConfigAudioAmbience : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17552
{
	// Fields
	private SimpleSafeUInt32[] _effectiveSceneIds; // 0x10
	private MoleMole.Config.Vector[] _relativePositions; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioAmbiencePositionedEvent[] _positionedEvents; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAudioTreeInfo _treeInfo; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAudioDynamicRayInfo _dynamicRayInfo; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAudioArea2DInfo _area2DInfo; // 0x38

	// Properties
	public SimpleSafeUInt32[] effectiveSceneIds { /* [XID] */ /* 0x0000000189A3C610-0x0000000189A3C630 */ get => default; /* [XID] */ /* 0x0000000189A440D0-0x0000000189A440F0 */ private set {} } // 0x000000018346F300-0x000000018346F3A0 0x000000018346F250-0x000000018346F300
	public MoleMole.Config.Vector[] relativePositions { /* [XID] */ /* 0x0000000189A4B640-0x0000000189A4B660 */ get => default; /* [XID] */ /* 0x0000000189A52DA0-0x0000000189A52DC0 */ private set {} } // 0x0000000183470470-0x0000000183470510 0x00000001834703C0-0x0000000183470470
	public AudioAmbiencePositionedEvent[] positionedEvents { /* [XID] */ /* 0x0000000189A5A650-0x0000000189A5A670 */ get => default; /* [XID] */ /* 0x0000000189A61D90-0x0000000189A61DB0 */ private set {} } // 0x000000018346FC90-0x000000018346FD30 0x000000018346E9C0-0x000000018346EA70
	public ConfigAudioTreeInfo treeInfo { /* [XID] */ /* 0x0000000189A69CB0-0x0000000189A69CD0 */ get => default; /* [XID] */ /* 0x0000000189A70F80-0x0000000189A70FA0 */ private set {} } // 0x000000018346F8F0-0x000000018346F990 0x000000018346EB20-0x000000018346EBD0
	public ConfigAudioDynamicRayInfo dynamicRayInfo { /* [XID] */ /* 0x0000000189A78B80-0x0000000189A78BA0 */ get => default; /* [XID] */ /* 0x0000000189A7FF80-0x0000000189A7FFA0 */ private set {} } // 0x000000018346F720-0x000000018346F7C0 0x000000018346DD00-0x000000018346DDB0
	public ConfigAudioArea2DInfo area2DInfo { /* [XID] */ /* 0x000000018965E9B0-0x000000018965E9D0 */ get => default; /* [XID] */ /* 0x0000000189A8F550-0x0000000189A8F570 */ private set {} } // 0x000000018346EBD0-0x000000018346EC70 0x000000018346EA70-0x000000018346EB20

	// Constructors
	public ConfigAudioAmbience() {} // 0x00000001834708A0-0x0000000183470900

	// Methods
	// [XID] // 0x0000000189A96A80-0x0000000189A96AA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183470510-0x00000001834706C0
	// [XID] // 0x0000000189A9DED0-0x0000000189A9DEF0
	public void InitEmpty() {} // 0x000000018346F7C0-0x000000018346F8F0
	[BlackList] // 0x0000000189AA5960-0x0000000189AA59A0
	// [XID] // 0x0000000189AA5960-0x0000000189AA59A0
	public bool FromJson(JSONNode node) => default; // 0x000000018346F3A0-0x000000018346F720
	// [XID] // 0x0000000189AB0140-0x0000000189AB0160
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018346DDB0-0x000000018346E430
	// [XID] // 0x0000000189AB78D0-0x0000000189AB78F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72A7 */, bool useObjectPool = false /* Metadata: 0x00AF72AB */) => default; // 0x000000018346F990-0x000000018346FC90
	// [XID] // 0x0000000189ABF2D0-0x0000000189ABF2F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72AC */, bool useObjectPool = false /* Metadata: 0x00AF72B0 */) => default; // 0x000000018346EC70-0x000000018346F250
	[BlackList] // 0x0000000189AC6D40-0x0000000189AC6D80
	// [XID] // 0x0000000189AC6D40-0x0000000189AC6D80
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018346E430-0x000000018346E700
	// [XID] // 0x0000000189AD15B0-0x0000000189AD15D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018346FE80-0x00000001834703C0
	// [XID] // 0x0000000189AD9290-0x0000000189AD92B0
	public bool ShouldUtilizePositionedEventsInScene(uint sceneId) => default; // 0x000000018346FD30-0x000000018346FE80
	[BlackList] // 0x0000000189AE0D80-0x0000000189AE0DC0
	// [XID] // 0x0000000189AE0D80-0x0000000189AE0DC0
	public virtual void AutoAllocTypeFields() {} // 0x000000018346E700-0x000000018346E7A0
	[BlackList] // 0x0000000189AEB4B0-0x0000000189AEB4F0
	// [XID] // 0x0000000189AEB4B0-0x0000000189AEB4F0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018346E7A0-0x000000018346E9C0
	[BlackList] // 0x0000000189AF5D10-0x0000000189AF5D50
	// [XID] // 0x0000000189AF5D10-0x0000000189AF5D50
	public virtual void ReturnToObjectPool() {} // 0x0000000183470800-0x00000001834708A0
	[BlackList] // 0x0000000189B00330-0x0000000189B00370
	// [XID] // 0x0000000189B00330-0x0000000189B00370
	public virtual void OnPoolAllocated() {} // 0x0000000183470760-0x0000000183470800
	[BlackList] // 0x0000000189B0AAE0-0x0000000189B0AB20
	// [XID] // 0x0000000189B0AAE0-0x0000000189B0AB20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834706C0-0x0000000183470760
}

