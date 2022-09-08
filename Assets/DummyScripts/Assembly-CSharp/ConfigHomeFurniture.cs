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
public class ConfigHomeFurniture : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18941
{
	// Fields
	private SimpleSafeUInt32 furnitureIdRawNum; // 0x10
	private MoleMole.Config.Vector _spawnPos; // 0x14
	private MoleMole.Config.Vector _spawnRot; // 0x20
	private SimpleSafeInt32 parentFurnitureIndexRawNum; // 0x2C

	// Properties
	public uint furnitureId { /* [XID] */ /* 0x0000000189905340-0x0000000189905360 */ get => default; /* [XID] */ /* 0x000000018990CCB0-0x000000018990CCD0 */ private set {} } // 0x0000000182CA3110-0x0000000182CA31E0 0x0000000182CA26B0-0x0000000182CA2790
	public MoleMole.Config.Vector spawnPos { /* [XID] */ /* 0x0000000189914400-0x0000000189914420 */ get => default; /* [XID] */ /* 0x000000018991BF00-0x000000018991BF20 */ private set {} } // 0x0000000182CA31E0-0x0000000182CA32C0 0x0000000182CA4000-0x0000000182CA40D0
	public MoleMole.Config.Vector spawnRot { /* [XID] */ /* 0x0000000189923640-0x0000000189923660 */ get => default; /* [XID] */ /* 0x000000018992ACA0-0x000000018992ACC0 */ private set {} } // 0x0000000182CA40D0-0x0000000182CA41B0 0x0000000182CA3F30-0x0000000182CA4000
	public int parentFurnitureIndex { /* [XID] */ /* 0x00000001899322A0-0x00000001899322C0 */ get => default; /* [XID] */ /* 0x0000000189939C90-0x0000000189939CB0 */ private set {} } // 0x0000000182CA32C0-0x0000000182CA3390 0x0000000182CA45F0-0x0000000182CA46D0

	// Constructors
	public ConfigHomeFurniture() {} // 0x0000000182CA4A40-0x0000000182CA4AA0

	// Methods
	// [XID] // 0x0000000189940E80-0x0000000189940EA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182CA46D0-0x0000000182CA4860
	// [XID] // 0x0000000189948900-0x0000000189948920
	public void InitEmpty() {} // 0x0000000182CA3AF0-0x0000000182CA3C30
	[BlackList] // 0x0000000189950070-0x00000001899500B0
	// [XID] // 0x0000000189950070-0x00000001899500B0
	public bool FromJson(JSONNode node) => default; // 0x0000000182CA3770-0x0000000182CA3AF0
	// [XID] // 0x000000018995A750-0x000000018995A770
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182CA2790-0x0000000182CA2C70
	// [XID] // 0x0000000189962290-0x00000001899622B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB463 */, bool useObjectPool = false /* Metadata: 0x00AFB467 */) => default; // 0x0000000182CA3C30-0x0000000182CA3F30
	// [XID] // 0x00000001899696C0-0x00000001899696E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB468 */, bool useObjectPool = false /* Metadata: 0x00AFB46C */) => default; // 0x0000000182CA3390-0x0000000182CA3770
	[BlackList] // 0x00000001899713A0-0x00000001899713E0
	// [XID] // 0x00000001899713A0-0x00000001899713E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182CA2C70-0x0000000182CA2F40
	// [XID] // 0x000000018997B800-0x000000018997B820
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182CA41B0-0x0000000182CA45F0
	[BlackList] // 0x00000001899832D0-0x0000000189983310
	// [XID] // 0x00000001899832D0-0x0000000189983310
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CA2F40-0x0000000182CA2FE0
	[BlackList] // 0x000000018998DAA0-0x000000018998DAE0
	// [XID] // 0x000000018998DAA0-0x000000018998DAE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CA2FE0-0x0000000182CA3110
	[BlackList] // 0x0000000189998570-0x00000001899985B0
	// [XID] // 0x0000000189998570-0x00000001899985B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182CA49A0-0x0000000182CA4A40
	[BlackList] // 0x00000001899A2E50-0x00000001899A2E90
	// [XID] // 0x00000001899A2E50-0x00000001899A2E90
	public virtual void OnPoolAllocated() {} // 0x0000000182CA4900-0x0000000182CA49A0
	[BlackList] // 0x00000001899AD8C0-0x00000001899AD900
	// [XID] // 0x00000001899AD8C0-0x00000001899AD900
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CA4860-0x0000000182CA4900
}

