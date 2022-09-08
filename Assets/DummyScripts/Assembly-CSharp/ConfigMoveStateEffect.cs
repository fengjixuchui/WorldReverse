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
public class ConfigMoveStateEffect : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18018
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFootprint _footprint; // 0x10

	// Properties
	public ConfigFootprint footprint { /* [XID] */ /* 0x0000000189AB3000-0x0000000189AB3020 */ get => default; /* [XID] */ /* 0x0000000189ABAC90-0x0000000189ABACB0 */ private set {} } // 0x0000000185089310-0x00000001850893B0 0x0000000185088E90-0x0000000185088F40

	// Constructors
	public ConfigMoveStateEffect() {} // 0x0000000185089850-0x00000001850898B0

	// Methods
	// [XID] // 0x0000000189AC2500-0x0000000189AC2520
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185089590-0x0000000185089670
	// [XID] // 0x0000000189AC9C20-0x0000000189AC9C40
	public void InitEmpty() {} // 0x0000000185088F40-0x0000000185089010
	[BlackList] // 0x0000000189AD1430-0x0000000189AD1470
	// [XID] // 0x0000000189AD1430-0x0000000189AD1470
	public bool FromJson(JSONNode node) => default; // 0x0000000185088B10-0x0000000185088E90
	// [XID] // 0x0000000189ADC140-0x0000000189ADC160
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185088230-0x0000000185088430
	// [XID] // 0x0000000189AE3B50-0x0000000189AE3B70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86D5 */, bool useObjectPool = false /* Metadata: 0x00AF86D9 */) => default; // 0x0000000185089010-0x0000000185089310
	// [XID] // 0x0000000189AEB3B0-0x0000000189AEB3D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86DA */, bool useObjectPool = false /* Metadata: 0x00AF86DE */) => default; // 0x00000001850888C0-0x0000000185088B10
	[BlackList] // 0x0000000189AF2D50-0x0000000189AF2D90
	// [XID] // 0x0000000189AF2D50-0x0000000189AF2D90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185088430-0x0000000185088700
	// [XID] // 0x0000000189AFD1D0-0x0000000189AFD1F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001850893B0-0x0000000185089590
	[BlackList] // 0x0000000189B049C0-0x0000000189B04A00
	// [XID] // 0x0000000189B049C0-0x0000000189B04A00
	public virtual void AutoAllocTypeFields() {} // 0x0000000185088700-0x00000001850887A0
	[BlackList] // 0x0000000189B0F0F0-0x0000000189B0F130
	// [XID] // 0x0000000189B0F0F0-0x0000000189B0F130
	public virtual void AutoRecycleTypeFields() {} // 0x00000001850887A0-0x00000001850888C0
	[BlackList] // 0x0000000189B194B0-0x0000000189B194F0
	// [XID] // 0x0000000189B194B0-0x0000000189B194F0
	public virtual void ReturnToObjectPool() {} // 0x00000001850897B0-0x0000000185089850
	[BlackList] // 0x0000000189B23DC0-0x0000000189B23E00
	// [XID] // 0x0000000189B23DC0-0x0000000189B23E00
	public virtual void OnPoolAllocated() {} // 0x0000000185089710-0x00000001850897B0
	[BlackList] // 0x0000000189B2E010-0x0000000189B2E050
	// [XID] // 0x0000000189B2E010-0x0000000189B2E050
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185089670-0x0000000185089710
}

