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
public class ConfigAIOrderMasterSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17397
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeInt32 servantSlotAmountRawNum; // 0x14

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001897C2680-0x00000001897C26A0 */ get => default; /* [XID] */ /* 0x0000000189ABDBD0-0x0000000189ABDBF0 */ private set {} } // 0x0000000183E6FC50-0x0000000183E6FCF0 0x0000000183E701A0-0x0000000183E70250
	public int servantSlotAmount { /* [XID] */ /* 0x0000000189AC56F0-0x0000000189AC5710 */ get => default; /* [XID] */ /* 0x0000000189ACCBC0-0x0000000189ACCBE0 */ private set {} } // 0x0000000183E70250-0x0000000183E70320 0x0000000183E6FDC0-0x0000000183E6FEA0

	// Constructors
	public ConfigAIOrderMasterSetting() {} // 0x0000000183E70880-0x0000000183E70920

	// Methods
	// [XID] // 0x0000000189AD4960-0x0000000189AD4980
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E70590-0x0000000183E706A0
	// [XID] // 0x0000000189ADC280-0x0000000189ADC2A0
	public void InitEmpty() {} // 0x0000000183E6FCF0-0x0000000183E6FDC0
	[BlackList] // 0x0000000189AE3C90-0x0000000189AE3CD0
	// [XID] // 0x0000000189AE3C90-0x0000000189AE3CD0
	public bool FromJson(JSONNode node) => default; // 0x0000000183E6F8D0-0x0000000183E6FC50
	// [XID] // 0x0000000189AEE7C0-0x0000000189AEE7E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183E6EF70-0x0000000183E6F240
	// [XID] // 0x0000000189AF5DF0-0x0000000189AF5E10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D2D */, bool useObjectPool = false /* Metadata: 0x00AF6D31 */) => default; // 0x0000000183E6FEA0-0x0000000183E701A0
	// [XID] // 0x0000000189AFD2B0-0x0000000189AFD2D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D32 */, bool useObjectPool = false /* Metadata: 0x00AF6D36 */) => default; // 0x0000000183E6F680-0x0000000183E6F8D0
	[BlackList] // 0x0000000189B04AA0-0x0000000189B04AE0
	// [XID] // 0x0000000189B04AA0-0x0000000189B04AE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E6F240-0x0000000183E6F510
	// [XID] // 0x0000000189B0F210-0x0000000189B0F230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E70320-0x0000000183E70590
	[BlackList] // 0x0000000189B16530-0x0000000189B16570
	// [XID] // 0x0000000189B16530-0x0000000189B16570
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E6F510-0x0000000183E6F5B0
	[BlackList] // 0x0000000189B20BF0-0x0000000189B20C30
	// [XID] // 0x0000000189B20BF0-0x0000000189B20C30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E6F5B0-0x0000000183E6F680
	[BlackList] // 0x0000000189B2B290-0x0000000189B2B2D0
	// [XID] // 0x0000000189B2B290-0x0000000189B2B2D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E707E0-0x0000000183E70880
	[BlackList] // 0x0000000189B354E0-0x0000000189B35520
	// [XID] // 0x0000000189B354E0-0x0000000189B35520
	public virtual void OnPoolAllocated() {} // 0x0000000183E70740-0x0000000183E707E0
	[BlackList] // 0x0000000189B40140-0x0000000189B40180
	// [XID] // 0x0000000189B40140-0x0000000189B40180
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E706A0-0x0000000183E70740
}

