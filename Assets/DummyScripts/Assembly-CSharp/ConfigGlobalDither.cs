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
public class ConfigGlobalDither : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18117
{
	// Fields
	private SimpleSafeFloat ditherMinRangeRawNum; // 0x10
	private SimpleSafeFloat ditherMaxRangeRawNum; // 0x14
	private SimpleSafeFloat defaultDetectHeightRawNum; // 0x18
	private SimpleSafeUInt32 detectHeightCheckStepRawNum; // 0x1C

	// Properties
	public float ditherMinRange { /* [XID] */ /* 0x0000000189A69C10-0x0000000189A69C30 */ get => default; /* [XID] */ /* 0x0000000189A70F20-0x0000000189A70F40 */ private set {} } // 0x0000000181AA9510-0x0000000181AA95F0 0x0000000181AA8C70-0x0000000181AA8D50
	public float ditherMaxRange { /* [XID] */ /* 0x0000000189A78AA0-0x0000000189A78AC0 */ get => default; /* [XID] */ /* 0x0000000189A7FE40-0x0000000189A7FE60 */ private set {} } // 0x0000000181AA8230-0x0000000181AA8310 0x0000000181AA8890-0x0000000181AA8970
	public float defaultDetectHeight { /* [XID] */ /* 0x0000000189A87C00-0x0000000189A87C20 */ get => default; /* [XID] */ /* 0x0000000189A8F430-0x0000000189A8F450 */ private set {} } // 0x0000000181AA8E30-0x0000000181AA8F10 0x0000000181AA8D50-0x0000000181AA8E30
	public uint detectHeightCheckStep { /* [XID] */ /* 0x0000000189A96A00-0x0000000189A96A20 */ get => default; /* [XID] */ /* 0x0000000189A9DE10-0x0000000189A9DE30 */ private set {} } // 0x0000000181AA8690-0x0000000181AA8760 0x0000000181AA7450-0x0000000181AA7530

	// Constructors
	public ConfigGlobalDither() {} // 0x0000000181AA9690-0x0000000181AA9780

	// Methods
	// [XID] // 0x0000000189AA5880-0x0000000189AA58A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181AA9290-0x0000000181AA93D0
	// [XID] // 0x0000000189AACF20-0x0000000189AACF40
	public void InitEmpty() {} // 0x0000000181AA8760-0x0000000181AA8890
	[BlackList] // 0x0000000189AB4810-0x0000000189AB4850
	// [XID] // 0x0000000189AB4810-0x0000000189AB4850
	public bool FromJson(JSONNode node) => default; // 0x0000000181AA8310-0x0000000181AA8690
	// [XID] // 0x0000000189ABF1F0-0x0000000189ABF210
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181AA7530-0x0000000181AA7A40
	// [XID] // 0x0000000189AC6C00-0x0000000189AC6C20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BA9 */, bool useObjectPool = false /* Metadata: 0x00AF8BAD */) => default; // 0x0000000181AA8970-0x0000000181AA8C70
	// [XID] // 0x0000000189ACE430-0x0000000189ACE450
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BAE */, bool useObjectPool = false /* Metadata: 0x00AF8BB2 */) => default; // 0x0000000181AA7EE0-0x0000000181AA8230
	[BlackList] // 0x0000000189AD6220-0x0000000189AD6260
	// [XID] // 0x0000000189AD6220-0x0000000189AD6260
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181AA7A40-0x0000000181AA7D10
	// [XID] // 0x0000000189AE0BC0-0x0000000189AE0BE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181AA8F10-0x0000000181AA9290
	[BlackList] // 0x0000000189AE80D0-0x0000000189AE8110
	// [XID] // 0x0000000189AE80D0-0x0000000189AE8110
	public virtual void AutoAllocTypeFields() {} // 0x0000000181AA7D10-0x0000000181AA7DB0
	[BlackList] // 0x0000000189AF2CF0-0x0000000189AF2D30
	// [XID] // 0x0000000189AF2CF0-0x0000000189AF2D30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181AA7DB0-0x0000000181AA7EE0
	[BlackList] // 0x0000000189AFD150-0x0000000189AFD190
	// [XID] // 0x0000000189AFD150-0x0000000189AFD190
	public virtual void ReturnToObjectPool() {} // 0x0000000181AA95F0-0x0000000181AA9690
	[BlackList] // 0x0000000189B07830-0x0000000189B07870
	// [XID] // 0x0000000189B07830-0x0000000189B07870
	public virtual void OnPoolAllocated() {} // 0x0000000181AA9470-0x0000000181AA9510
	[BlackList] // 0x0000000189B12120-0x0000000189B12160
	// [XID] // 0x0000000189B12120-0x0000000189B12160
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181AA93D0-0x0000000181AA9470
}

