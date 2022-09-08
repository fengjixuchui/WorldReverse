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
public class ConfigMoveStateAudio : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18634
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigStateAudioEvent[] _onStateBegin; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigStateAudioEvent[] _onStateEnd; // 0x18

	// Properties
	public ConfigStateAudioEvent[] onStateBegin { /* [XID] */ /* 0x000000018978FEC0-0x000000018978FEE0 */ get => default; /* [XID] */ /* 0x0000000189A1BC10-0x0000000189A1BC30 */ private set {} } // 0x0000000182D09770-0x0000000182D09810 0x0000000182D08C80-0x0000000182D08D30
	public ConfigStateAudioEvent[] onStateEnd { /* [XID] */ /* 0x0000000189797730-0x0000000189797750 */ get => default; /* [XID] */ /* 0x0000000189A2A7C0-0x0000000189A2A7E0 */ private set {} } // 0x0000000182D08440-0x0000000182D084E0 0x0000000182D08BD0-0x0000000182D08C80

	// Constructors
	public ConfigMoveStateAudio() {} // 0x0000000182D09DA0-0x0000000182D09E00

	// Methods
	// [XID] // 0x0000000189A31D20-0x0000000189A31D40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D09AB0-0x0000000182D09BC0
	// [XID] // 0x0000000189A39750-0x0000000189A39770
	public void InitEmpty() {} // 0x0000000182D09380-0x0000000182D09470
	[BlackList] // 0x0000000189A40F50-0x0000000189A40F90
	// [XID] // 0x0000000189A40F50-0x0000000189A40F90
	public bool FromJson(JSONNode node) => default; // 0x0000000182D09000-0x0000000182D09380
	// [XID] // 0x0000000189A4B500-0x0000000189A4B520
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D084E0-0x0000000182D087B0
	// [XID] // 0x0000000189A52BA0-0x0000000189A52BC0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA67F */, bool useObjectPool = false /* Metadata: 0x00AFA683 */) => default; // 0x0000000182D09470-0x0000000182D09770
	// [XID] // 0x0000000189A5A4F0-0x0000000189A5A510
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA684 */, bool useObjectPool = false /* Metadata: 0x00AFA688 */) => default; // 0x0000000182D08D30-0x0000000182D09000
	[BlackList] // 0x0000000189A61BF0-0x0000000189A61C30
	// [XID] // 0x0000000189A61BF0-0x0000000189A61C30
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D087B0-0x0000000182D08A80
	// [XID] // 0x0000000189A6C6A0-0x0000000189A6C6C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D09810-0x0000000182D09AB0
	[BlackList] // 0x0000000189A73EB0-0x0000000189A73EF0
	// [XID] // 0x0000000189A73EB0-0x0000000189A73EF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D08A80-0x0000000182D08B20
	[BlackList] // 0x0000000189A7E850-0x0000000189A7E890
	// [XID] // 0x0000000189A7E850-0x0000000189A7E890
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D08B20-0x0000000182D08BD0
	[BlackList] // 0x0000000189A89370-0x0000000189A893B0
	// [XID] // 0x0000000189A89370-0x0000000189A893B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D09D00-0x0000000182D09DA0
	[BlackList] // 0x0000000189A936F0-0x0000000189A93730
	// [XID] // 0x0000000189A936F0-0x0000000189A93730
	public virtual void OnPoolAllocated() {} // 0x0000000182D09C60-0x0000000182D09D00
	[BlackList] // 0x0000000189A9DD70-0x0000000189A9DDB0
	// [XID] // 0x0000000189A9DD70-0x0000000189A9DDB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D09BC0-0x0000000182D09C60
}

