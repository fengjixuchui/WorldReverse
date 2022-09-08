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
public class ConfigEliteShield : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18108
{
	// Fields
	private ElementType[] _row; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigEliteShieldResistance> _shieldDamageRatiosMap; // 0x18

	// Properties
	public ElementType[] row { /* [XID] */ /* 0x000000018997E460-0x000000018997E480 */ get => default; /* [XID] */ /* 0x0000000189985F30-0x0000000189985F50 */ private set {} } // 0x0000000183471440-0x00000001834714E0 0x0000000183471CF0-0x0000000183471DA0
	public Dictionary<string, ConfigEliteShieldResistance> shieldDamageRatiosMap { /* [XID] */ /* 0x000000018998DBA0-0x000000018998DBC0 */ get => default; /* [XID] */ /* 0x0000000189995670-0x0000000189995690 */ private set {} } // 0x0000000183471C50-0x0000000183471CF0 0x0000000183471DA0-0x0000000183471E50

	// Constructors
	public ConfigEliteShield() {} // 0x00000001834723E0-0x0000000183472440

	// Methods
	// [XID] // 0x000000018999D070-0x000000018999D090
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001834720F0-0x0000000183472200
	// [XID] // 0x00000001899A4A10-0x00000001899A4A30
	public void InitEmpty() {} // 0x0000000183471860-0x0000000183471950
	[BlackList] // 0x00000001899AC470-0x00000001899AC4B0
	// [XID] // 0x00000001899AC470-0x00000001899AC4B0
	public bool FromJson(JSONNode node) => default; // 0x00000001834714E0-0x0000000183471860
	// [XID] // 0x00000001899B6810-0x00000001899B6830
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183470900-0x0000000183470BD0
	// [XID] // 0x00000001899BE370-0x00000001899BE390
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B4F */, bool useObjectPool = false /* Metadata: 0x00AF8B53 */) => default; // 0x0000000183471950-0x0000000183471C50
	// [XID] // 0x00000001899C5AF0-0x00000001899C5B10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B54 */, bool useObjectPool = false /* Metadata: 0x00AF8B58 */) => default; // 0x0000000183471170-0x0000000183471440
	[BlackList] // 0x00000001899CD150-0x00000001899CD190
	// [XID] // 0x00000001899CD150-0x00000001899CD190
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183470BD0-0x0000000183470EA0
	// [XID] // 0x00000001899D7750-0x00000001899D7770
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183471E50-0x00000001834720F0
	// [XID] // 0x00000001899DEB30-0x00000001899DEB50
	public int GetRowIndexByElementType(ElementType e) => default; // 0x0000000183471000-0x0000000183471170
	[BlackList] // 0x00000001899E6750-0x00000001899E6790
	// [XID] // 0x00000001899E6750-0x00000001899E6790
	public virtual void AutoAllocTypeFields() {} // 0x0000000183470EA0-0x0000000183470F40
	[BlackList] // 0x00000001899F0B90-0x00000001899F0BD0
	// [XID] // 0x00000001899F0B90-0x00000001899F0BD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183470F40-0x0000000183471000
	[BlackList] // 0x00000001899FB7F0-0x00000001899FB830
	// [XID] // 0x00000001899FB7F0-0x00000001899FB830
	public virtual void ReturnToObjectPool() {} // 0x0000000183472340-0x00000001834723E0
	[BlackList] // 0x0000000189A05D90-0x0000000189A05DD0
	// [XID] // 0x0000000189A05D90-0x0000000189A05DD0
	public virtual void OnPoolAllocated() {} // 0x00000001834722A0-0x0000000183472340
	[BlackList] // 0x0000000189A0FF90-0x0000000189A0FFD0
	// [XID] // 0x0000000189A0FF90-0x0000000189A0FFD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183472200-0x00000001834722A0
}

