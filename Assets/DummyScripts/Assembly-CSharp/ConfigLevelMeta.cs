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
public class ConfigLevelMeta : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18493
{
	// Fields
	private Dictionary<SimpleSafeUInt32, ConfigLevelBlockMeta[]> _sceneMeta; // 0x10

	// Properties
	public Dictionary<SimpleSafeUInt32, ConfigLevelBlockMeta[]> sceneMeta { /* [XID] */ /* 0x0000000189776B20-0x0000000189776B40 */ get => default; /* [XID] */ /* 0x0000000189ABABB0-0x0000000189ABABD0 */ private set {} } // 0x0000000183D38BA0-0x0000000183D38C40 0x0000000183D38FC0-0x0000000183D39070

	// Constructors
	public ConfigLevelMeta() {} // 0x0000000183D398F0-0x0000000183D39950

	// Methods
	// [XID] // 0x0000000189AC2340-0x0000000189AC2360
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D39630-0x0000000183D39710
	// [XID] // 0x0000000189AC9A80-0x0000000189AC9AA0
	public void InitEmpty() {} // 0x0000000183D39070-0x0000000183D39140
	[BlackList] // 0x0000000189AD1370-0x0000000189AD13B0
	// [XID] // 0x0000000189AD1370-0x0000000189AD13B0
	public bool FromJson(JSONNode node) => default; // 0x0000000183D38C40-0x0000000183D38FC0
	// [XID] // 0x0000000189ADC0A0-0x0000000189ADC0C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183D383A0-0x0000000183D38580
	// [XID] // 0x0000000189AE3A30-0x0000000189AE3A50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F4F */, bool useObjectPool = false /* Metadata: 0x00AF9F53 */) => default; // 0x0000000183D39140-0x0000000183D39440
	// [XID] // 0x0000000189AEB2D0-0x0000000189AEB2F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F54 */, bool useObjectPool = false /* Metadata: 0x00AF9F58 */) => default; // 0x0000000183D38990-0x0000000183D38BA0
	[BlackList] // 0x0000000189AF2C70-0x0000000189AF2CB0
	// [XID] // 0x0000000189AF2C70-0x0000000189AF2CB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D38580-0x0000000183D38850
	// [XID] // 0x0000000189AFD030-0x0000000189AFD050
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D39440-0x0000000183D39630
	[BlackList] // 0x0000000189B04820-0x0000000189B04860
	// [XID] // 0x0000000189B04820-0x0000000189B04860
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D38850-0x0000000183D388F0
	[BlackList] // 0x0000000189B0F030-0x0000000189B0F070
	// [XID] // 0x0000000189B0F030-0x0000000189B0F070
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D388F0-0x0000000183D38990
	[BlackList] // 0x0000000189B193F0-0x0000000189B19430
	// [XID] // 0x0000000189B193F0-0x0000000189B19430
	public virtual void ReturnToObjectPool() {} // 0x0000000183D39850-0x0000000183D398F0
	[BlackList] // 0x0000000189B23D20-0x0000000189B23D60
	// [XID] // 0x0000000189B23D20-0x0000000189B23D60
	public virtual void OnPoolAllocated() {} // 0x0000000183D397B0-0x0000000183D39850
	[BlackList] // 0x0000000189B2DF50-0x0000000189B2DF90
	// [XID] // 0x0000000189B2DF50-0x0000000189B2DF90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D39710-0x0000000183D397B0
}

