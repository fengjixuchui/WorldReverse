/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigElementShield : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18106
{
	// Fields
	private ElementType[] _row; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<ElementType, ConfigElementShieldResistance> _shieldDamageRatiosMap; // 0x18

	// Properties
	public ElementType[] row { /* [XID] */ /* 0x000000018982AB70-0x000000018982AB90 */ get => default; /* [XID] */ /* 0x0000000189831FF0-0x0000000189832010 */ private set {} } // 0x0000000183C5BF00-0x0000000183C5BFA0 0x0000000183C5C7B0-0x0000000183C5C860
	public Dictionary<ElementType, ConfigElementShieldResistance> shieldDamageRatiosMap { /* [XID] */ /* 0x0000000189839720-0x0000000189839740 */ get => default; /* [XID] */ /* 0x0000000189840CC0-0x0000000189840CE0 */ private set {} } // 0x0000000183C5C710-0x0000000183C5C7B0 0x0000000183C5C860-0x0000000183C5C910

	// Constructors
	public ConfigElementShield() {} // 0x0000000183C5CEA0-0x0000000183C5CF00

	// Methods
	// [XID] // 0x0000000189848120-0x0000000189848140
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C5CBB0-0x0000000183C5CCC0
	// [XID] // 0x000000018984F8A0-0x000000018984F8C0
	public void InitEmpty() {} // 0x0000000183C5C320-0x0000000183C5C410
	[BlackList] // 0x0000000189856B00-0x0000000189856B40
	// [XID] // 0x0000000189856B00-0x0000000189856B40
	public bool FromJson(JSONNode node) => default; // 0x0000000183C5BFA0-0x0000000183C5C320
	// [XID] // 0x0000000189860F70-0x0000000189860F90
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183C5B3C0-0x0000000183C5B690
	// [XID] // 0x0000000189868770-0x0000000189868790
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B3B */, bool useObjectPool = false /* Metadata: 0x00AF8B3F */) => default; // 0x0000000183C5C410-0x0000000183C5C710
	// [XID] // 0x000000018986FC00-0x000000018986FC20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B40 */, bool useObjectPool = false /* Metadata: 0x00AF8B44 */) => default; // 0x0000000183C5BC30-0x0000000183C5BF00
	[BlackList] // 0x00000001898772D0-0x0000000189877310
	// [XID] // 0x00000001898772D0-0x0000000189877310
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C5B690-0x0000000183C5B960
	// [XID] // 0x0000000189881940-0x0000000189881960
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C5C910-0x0000000183C5CBB0
	// [XID] // 0x0000000189888F40-0x0000000189888F60
	public int GetRowIndexByElementType(ElementType e) => default; // 0x0000000183C5BAC0-0x0000000183C5BC30
	[BlackList] // 0x0000000189890280-0x00000001898902C0
	// [XID] // 0x0000000189890280-0x00000001898902C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C5B960-0x0000000183C5BA00
	[BlackList] // 0x000000018989AAB0-0x000000018989AAF0
	// [XID] // 0x000000018989AAB0-0x000000018989AAF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C5BA00-0x0000000183C5BAC0
	[BlackList] // 0x00000001898A4F80-0x00000001898A4FC0
	// [XID] // 0x00000001898A4F80-0x00000001898A4FC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183C5CE00-0x0000000183C5CEA0
	[BlackList] // 0x00000001898AF7B0-0x00000001898AF7F0
	// [XID] // 0x00000001898AF7B0-0x00000001898AF7F0
	public virtual void OnPoolAllocated() {} // 0x0000000183C5CD60-0x0000000183C5CE00
	[BlackList] // 0x00000001898BA140-0x00000001898BA180
	// [XID] // 0x00000001898BA140-0x00000001898BA180
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C5CCC0-0x0000000183C5CD60
}

