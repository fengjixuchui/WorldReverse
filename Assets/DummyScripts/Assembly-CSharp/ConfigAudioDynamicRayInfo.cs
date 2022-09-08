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
public class ConfigAudioDynamicRayInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17550
{
	// Fields
	private SimpleSafeInt32 rayPerFrameRawNum; // 0x10
	private SimpleSafeFloat movingLerpRatioRawNum; // 0x14
	private SimpleSafeFloat standLerpRatioRawNum; // 0x18
	private SimpleSafeFloat rayMaxDistanceRawNum; // 0x1C
	private bool _isDebug; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _rtpcParam; // 0x28

	// Properties
	public int rayPerFrame { /* [XID] */ /* 0x0000000189A3D310-0x0000000189A3D330 */ get => default; /* [XID] */ /* 0x0000000189894AF0-0x0000000189894B10 */ private set {} } // 0x0000000183A22100-0x0000000183A221D0 0x0000000183A22DB0-0x0000000183A22E90
	public float movingLerpRatio { /* [XID] */ /* 0x000000018989C080-0x000000018989C0A0 */ get => default; /* [XID] */ /* 0x00000001898A3740-0x00000001898A3760 */ private set {} } // 0x0000000183A20CC0-0x0000000183A20DA0 0x0000000183A21AA0-0x0000000183A21B80
	public float standLerpRatio { /* [XID] */ /* 0x00000001898AABA0-0x00000001898AABC0 */ get => default; /* [XID] */ /* 0x00000001898B24B0-0x00000001898B24D0 */ private set {} } // 0x0000000183A22A90-0x0000000183A22B70 0x0000000183A22550-0x0000000183A22630
	public float rayMaxDistance { /* [XID] */ /* 0x0000000189B79960-0x0000000189B79980 */ get => default; /* [XID] */ /* 0x00000001898C15A0-0x00000001898C15C0 */ private set {} } // 0x0000000183A22C20-0x0000000183A22D00 0x0000000183A22020-0x0000000183A22100
	public bool isDebug { /* [XID] */ /* 0x00000001898C8F20-0x00000001898C8F40 */ get => default; /* [XID] */ /* 0x00000001898D06E0-0x00000001898D0700 */ private set {} } // 0x0000000183A21960-0x0000000183A21A00 0x0000000183A22D00-0x0000000183A22DB0
	public ConfigWwiseString rtpcParam { /* [XID] */ /* 0x00000001898D7D60-0x00000001898D7D80 */ get => default; /* [XID] */ /* 0x00000001898DFAC0-0x00000001898DFAE0 */ private set {} } // 0x0000000183A21A00-0x0000000183A21AA0 0x0000000183A22B70-0x0000000183A22C20

	// Constructors
	public ConfigAudioDynamicRayInfo() {} // 0x0000000183A236A0-0x0000000183A23790

	// Methods
	// [XID] // 0x00000001898E75B0-0x00000001898E75D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A23340-0x0000000183A234C0
	// [XID] // 0x00000001898EEDA0-0x00000001898EEDC0
	public void InitEmpty() {} // 0x0000000183A22630-0x0000000183A22790
	[BlackList] // 0x00000001898F66C0-0x00000001898F6700
	// [XID] // 0x00000001898F66C0-0x00000001898F6700
	public bool FromJson(JSONNode node) => default; // 0x0000000183A221D0-0x0000000183A22550
	// [XID] // 0x0000000189900FB0-0x0000000189900FD0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A20DA0-0x0000000183A21430
	// [XID] // 0x00000001899087F0-0x0000000189908810
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7293 */, bool useObjectPool = false /* Metadata: 0x00AF7297 */) => default; // 0x0000000183A22790-0x0000000183A22A90
	// [XID] // 0x000000018990FDD0-0x000000018990FDF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7298 */, bool useObjectPool = false /* Metadata: 0x00AF729C */) => default; // 0x0000000183A21B80-0x0000000183A22020
	[BlackList] // 0x00000001899179A0-0x00000001899179E0
	// [XID] // 0x00000001899179A0-0x00000001899179E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A21430-0x0000000183A21700
	// [XID] // 0x0000000189922180-0x00000001899221A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A22E90-0x0000000183A23340
	[BlackList] // 0x0000000189929960-0x00000001899299A0
	// [XID] // 0x0000000189929960-0x00000001899299A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A21700-0x0000000183A217A0
	[BlackList] // 0x0000000189933CA0-0x0000000189933CE0
	// [XID] // 0x0000000189933CA0-0x0000000189933CE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A217A0-0x0000000183A21960
	[BlackList] // 0x000000018993E5B0-0x000000018993E5F0
	// [XID] // 0x000000018993E5B0-0x000000018993E5F0
	public virtual void ReturnToObjectPool() {} // 0x0000000183A23600-0x0000000183A236A0
	[BlackList] // 0x0000000189948C80-0x0000000189948CC0
	// [XID] // 0x0000000189948C80-0x0000000189948CC0
	public virtual void OnPoolAllocated() {} // 0x0000000183A23560-0x0000000183A23600
	[BlackList] // 0x0000000189953270-0x00000001899532B0
	// [XID] // 0x0000000189953270-0x00000001899532B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A234C0-0x0000000183A23560
}

