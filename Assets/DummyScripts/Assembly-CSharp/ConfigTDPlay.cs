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
public class ConfigTDPlay : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18125
{
	// Fields
	private SimpleSafeFloat attackSpeed_CRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<TDPlayTowerType, ConfigTDPlayTowerData> _towerDatas; // 0x18

	// Properties
	public float attackSpeed_C { /* [XID] */ /* 0x0000000189B40040-0x0000000189B40060 */ get => default; /* [XID] */ /* 0x0000000189B478A0-0x0000000189B478C0 */ private set {} } // 0x0000000183A65D00-0x0000000183A65DE0 0x0000000183A66280-0x0000000183A66360
	public Dictionary<TDPlayTowerType, ConfigTDPlayTowerData> towerDatas { /* [XID] */ /* 0x0000000189B4F010-0x0000000189B4F030 */ get => default; /* [XID] */ /* 0x0000000189B569D0-0x0000000189B569F0 */ private set {} } // 0x0000000183A65EE0-0x0000000183A65F80 0x0000000183A66360-0x0000000183A66410

	// Constructors
	public ConfigTDPlay() {} // 0x0000000183A66970-0x0000000183A66A00

	// Methods
	// [XID] // 0x0000000189B5E240-0x0000000189B5E260
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A66680-0x0000000183A66790
	// [XID] // 0x0000000189B65760-0x0000000189B65780
	public void InitEmpty() {} // 0x0000000183A65DE0-0x0000000183A65EE0
	[BlackList] // 0x0000000189B6CD00-0x0000000189B6CD40
	// [XID] // 0x0000000189B6CD00-0x0000000189B6CD40
	public bool FromJson(JSONNode node) => default; // 0x0000000183A65980-0x0000000183A65D00
	// [XID] // 0x0000000189B77270-0x0000000189B77290
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A64F90-0x0000000183A65280
	// [XID] // 0x0000000189B7E8C0-0x0000000189B7E8E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BF9 */, bool useObjectPool = false /* Metadata: 0x00AF8BFD */) => default; // 0x0000000183A65F80-0x0000000183A66280
	// [XID] // 0x0000000189B865C0-0x0000000189B865E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BFE */, bool useObjectPool = false /* Metadata: 0x00AF8C02 */) => default; // 0x0000000183A656E0-0x0000000183A65980
	[BlackList] // 0x0000000189B8D670-0x0000000189B8D6B0
	// [XID] // 0x0000000189B8D670-0x0000000189B8D6B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A65280-0x0000000183A65550
	// [XID] // 0x0000000189B97C40-0x0000000189B97C60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A66410-0x0000000183A66680
	[BlackList] // 0x0000000189B9EF50-0x0000000189B9EF90
	// [XID] // 0x0000000189B9EF50-0x0000000189B9EF90
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A65550-0x0000000183A655F0
	[BlackList] // 0x0000000189BA9700-0x0000000189BA9740
	// [XID] // 0x0000000189BA9700-0x0000000189BA9740
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A655F0-0x0000000183A656E0
	[BlackList] // 0x0000000189BB3C90-0x0000000189BB3CD0
	// [XID] // 0x0000000189BB3C90-0x0000000189BB3CD0
	public virtual void ReturnToObjectPool() {} // 0x0000000183A668D0-0x0000000183A66970
	[BlackList] // 0x0000000189BBE050-0x0000000189BBE090
	// [XID] // 0x0000000189BBE050-0x0000000189BBE090
	public virtual void OnPoolAllocated() {} // 0x0000000183A66830-0x0000000183A668D0
	[BlackList] // 0x0000000189BC8DE0-0x0000000189BC8E20
	// [XID] // 0x0000000189BC8DE0-0x0000000189BC8E20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A66790-0x0000000183A66830
}

