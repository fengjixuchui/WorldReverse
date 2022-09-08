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
public class SECTR_CombineStreamPathInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18966
{
	// Fields
	private ulong _layerLoaderPathHash; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private SECTR_PlatformStreamLayer[] _platformLayers; // 0x18

	// Properties
	public ulong layerLoaderPathHash { /* [XID] */ /* 0x0000000189A7E810-0x0000000189A7E830 */ get => default; /* [XID] */ /* 0x0000000189A860B0-0x0000000189A860D0 */ private set {} } // 0x00000001837A5F60-0x00000001837A6000 0x00000001837A63D0-0x00000001837A6480
	public SECTR_PlatformStreamLayer[] platformLayers { /* [XID] */ /* 0x0000000189A8D9D0-0x0000000189A8D9F0 */ get => default; /* [XID] */ /* 0x0000000189A94F70-0x0000000189A94F90 */ private set {} } // 0x00000001837A5EC0-0x00000001837A5F60 0x00000001837A6940-0x00000001837A69F0

	// Constructors
	public SECTR_CombineStreamPathInfo() {} // 0x00000001837A6A90-0x00000001837A6AF0

	// Methods
	// [XID] // 0x0000000189A9C8B0-0x0000000189A9C8D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837A66F0-0x00000001837A6800
	// [XID] // 0x0000000189AA3FA0-0x0000000189AA3FC0
	public void InitEmpty() {} // 0x00000001837A6000-0x00000001837A60D0
	[BlackList] // 0x0000000189AAB4B0-0x0000000189AAB4F0
	// [XID] // 0x0000000189AAB4B0-0x0000000189AAB4F0
	public bool FromJson(JSONNode node) => default; // 0x00000001837A5B40-0x00000001837A5EC0
	// [XID] // 0x0000000189AB5E80-0x0000000189AB5EA0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001837A51D0-0x00000001837A5480
	// [XID] // 0x0000000189ABD970-0x0000000189ABD990
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5C1 */, bool useObjectPool = false /* Metadata: 0x00AFB5C5 */) => default; // 0x00000001837A60D0-0x00000001837A63D0
	// [XID] // 0x0000000189AC5490-0x0000000189AC54B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5C6 */, bool useObjectPool = false /* Metadata: 0x00AFB5CA */) => default; // 0x00000001837A58A0-0x00000001837A5B40
	[BlackList] // 0x0000000189ACC8A0-0x0000000189ACC8E0
	// [XID] // 0x0000000189ACC8A0-0x0000000189ACC8E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001837A5480-0x00000001837A5750
	// [XID] // 0x0000000189AD76C0-0x0000000189AD76E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837A6480-0x00000001837A66F0
	[BlackList] // 0x0000000189ADF170-0x0000000189ADF1B0
	// [XID] // 0x0000000189ADF170-0x0000000189ADF1B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001837A5750-0x00000001837A57F0
	[BlackList] // 0x0000000189AE97B0-0x0000000189AE97F0
	// [XID] // 0x0000000189AE97B0-0x0000000189AE97F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837A57F0-0x00000001837A58A0
	[BlackList] // 0x0000000189AF4330-0x0000000189AF4370
	// [XID] // 0x0000000189AF4330-0x0000000189AF4370
	public virtual void ReturnToObjectPool() {} // 0x00000001837A69F0-0x00000001837A6A90
	[BlackList] // 0x0000000189AFE9B0-0x0000000189AFE9F0
	// [XID] // 0x0000000189AFE9B0-0x0000000189AFE9F0
	public virtual void OnPoolAllocated() {} // 0x00000001837A68A0-0x00000001837A6940
	[BlackList] // 0x0000000189B08F30-0x0000000189B08F70
	// [XID] // 0x0000000189B08F30-0x0000000189B08F70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837A6800-0x00000001837A68A0
}

