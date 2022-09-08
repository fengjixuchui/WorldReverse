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
public class ConfigEntityAudio : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18040
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAnimationAudio _animAudio; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _initEvent; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _enableEvent; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _disableEvent; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _destroyEvent; // 0x30

	// Properties
	public ConfigAnimationAudio animAudio { /* [XID] */ /* 0x0000000189ABF230-0x0000000189ABF250 */ get => default; /* [XID] */ /* 0x0000000189AC6C40-0x0000000189AC6C60 */ private set {} } // 0x000000018256E0C0-0x000000018256E160 0x000000018256E010-0x000000018256E0C0
	public ConfigWwiseString initEvent { /* [XID] */ /* 0x0000000189ACE470-0x0000000189ACE490 */ get => default; /* [XID] */ /* 0x0000000189AD62C0-0x0000000189AD62E0 */ private set {} } // 0x000000018256F820-0x000000018256F8C0 0x000000018256F380-0x000000018256F430
	public ConfigWwiseString enableEvent { /* [XID] */ /* 0x00000001898E0540-0x00000001898E0560 */ get => default; /* [XID] */ /* 0x0000000189AE5580-0x0000000189AE55A0 */ private set {} } // 0x000000018256E6F0-0x000000018256E790 0x000000018256EB10-0x000000018256EBC0
	public ConfigWwiseString disableEvent { /* [XID] */ /* 0x0000000189AECA00-0x0000000189AECA20 */ get => default; /* [XID] */ /* 0x0000000189AF4430-0x0000000189AF4450 */ private set {} } // 0x000000018256FD30-0x000000018256FDD0 0x00000001825700A0-0x0000000182570150
	public ConfigWwiseString destroyEvent { /* [XID] */ /* 0x00000001895EB5F0-0x00000001895EB610 */ get => default; /* [XID] */ /* 0x0000000189B03310-0x0000000189B03330 */ private set {} } // 0x000000018256F630-0x000000018256F6D0 0x000000018256DF60-0x000000018256E010

	// Constructors
	public ConfigEntityAudio() {} // 0x00000001825701F0-0x0000000182570250

	// Methods
	// [XID] // 0x0000000189B0AA60-0x0000000189B0AA80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018256FDD0-0x000000018256FF60
	// [XID] // 0x0000000189B12160-0x0000000189B12180
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018256F6D0-0x000000018256F820
	// [XID] // 0x0000000189B19490-0x0000000189B194B0
	public virtual ConfigEntityAudio Clone(bool useObjectPool = false /* Metadata: 0x00AF878D */) => default; // 0x000000018256F2A0-0x000000018256F380
	// [XID] // 0x0000000189B20B50-0x0000000189B20B70
	public virtual int GetHashNum() => default; // 0x000000018256DE90-0x000000018256DF60
	// [XID] // 0x0000000189B28270-0x0000000189B28290
	public virtual void InitEmpty() {} // 0x000000018256ED90-0x000000018256EEB0
	[BlackList] // 0x0000000189B2F630-0x0000000189B2F670
	// [XID] // 0x0000000189B2F630-0x0000000189B2F670
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018256E790-0x000000018256EB10
	// [XID] // 0x0000000189B3A030-0x0000000189B3A050
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018256D270-0x000000018256D840
	[BlackList] // 0x0000000189B419B0-0x0000000189B419F0
	// [XID] // 0x0000000189B419B0-0x0000000189B419F0
	public static ConfigEntityAudio ParseFromJson(JSONNode node) => default; // 0x000000018256F430-0x000000018256F630
	// [XID] // 0x0000000189B4C1E0-0x0000000189B4C200
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF878E */, bool useObjectPool = false /* Metadata: 0x00AF8792 */) => default; // 0x000000018256EFA0-0x000000018256F2A0
	// [XID] // 0x0000000189B53820-0x0000000189B53840
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8793 */, bool useObjectPool = false /* Metadata: 0x00AF8797 */) => default; // 0x000000018256E160-0x000000018256E6F0
	// [XID] // 0x0000000189B5B050-0x0000000189B5B070
	public static ConfigEntityAudio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8798 */, bool useObjectPool = false /* Metadata: 0x00AF879C */) => default; // 0x000000018256EBC0-0x000000018256ED90
	[BlackList] // 0x0000000189B624F0-0x0000000189B62530
	// [XID] // 0x0000000189B624F0-0x0000000189B62530
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018256D840-0x000000018256DB10
	// [XID] // 0x0000000189B6CD60-0x0000000189B6CD80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018256F8C0-0x000000018256FD30
	[BlackList] // 0x0000000189B744F0-0x0000000189B74530
	// [XID] // 0x0000000189B744F0-0x0000000189B74530
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018256EEB0-0x000000018256EFA0
	[BlackList] // 0x0000000189B7E8E0-0x0000000189B7E920
	// [XID] // 0x0000000189B7E8E0-0x0000000189B7E920
	public virtual void AutoAllocTypeFields() {} // 0x000000018256DB10-0x000000018256DBB0
	[BlackList] // 0x0000000189B89210-0x0000000189B89250
	// [XID] // 0x0000000189B89210-0x0000000189B89250
	public virtual void AutoRecycleTypeFields() {} // 0x000000018256DBB0-0x000000018256DE90
	[BlackList] // 0x0000000189B93590-0x0000000189B935D0
	// [XID] // 0x0000000189B93590-0x0000000189B935D0
	public virtual void ReturnToObjectPool() {} // 0x0000000182570150-0x00000001825701F0
	[BlackList] // 0x0000000189B9D820-0x0000000189B9D860
	// [XID] // 0x0000000189B9D820-0x0000000189B9D860
	public virtual void OnPoolAllocated() {} // 0x0000000182570000-0x00000001825700A0
	[BlackList] // 0x0000000189BA7F30-0x0000000189BA7F70
	// [XID] // 0x0000000189BA7F30-0x0000000189BA7F70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018256FF60-0x0000000182570000
}

