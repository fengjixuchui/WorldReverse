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
public class ConfigKeyboardLayoutItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18457
{
	// Fields
	private Dictionary<ConfigKeyCode, string> _keyCodeFriendlyName; // 0x10

	// Properties
	public Dictionary<ConfigKeyCode, string> keyCodeFriendlyName { /* [XID] */ /* 0x0000000189A66800-0x0000000189A66820 */ get => default; /* [XID] */ /* 0x0000000189A6E000-0x0000000189A6E020 */ private set {} } // 0x00000001811F6420-0x00000001811F64C0 0x00000001811F6890-0x00000001811F6940

	// Constructors
	public ConfigKeyboardLayoutItem() {} // 0x00000001811F6DF0-0x00000001811F7060

	// Methods
	// [XID] // 0x0000000189A754D0-0x0000000189A754F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001811F6B30-0x00000001811F6C10
	// [XID] // 0x0000000189A7D210-0x0000000189A7D230
	public void InitEmpty() {} // 0x00000001811F64C0-0x00000001811F6590
	[BlackList] // 0x0000000189A849E0-0x0000000189A84A20
	// [XID] // 0x0000000189A849E0-0x0000000189A84A20
	public bool FromJson(JSONNode node) => default; // 0x00000001811F60A0-0x00000001811F6420
	// [XID] // 0x0000000189A8F350-0x0000000189A8F370
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001811F58A0-0x00000001811F5A80
	// [XID] // 0x0000000189A968C0-0x0000000189A968E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9919 */, bool useObjectPool = false /* Metadata: 0x00AF991D */) => default; // 0x00000001811F6590-0x00000001811F6890
	// [XID] // 0x0000000189A9DDB0-0x0000000189A9DDD0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF991E */, bool useObjectPool = false /* Metadata: 0x00AF9922 */) => default; // 0x00000001811F5E90-0x00000001811F60A0
	[BlackList] // 0x0000000189AA5840-0x0000000189AA5880
	// [XID] // 0x0000000189AA5840-0x0000000189AA5880
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001811F5A80-0x00000001811F5D50
	// [XID] // 0x0000000189AAFFC0-0x0000000189AAFFE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001811F6940-0x00000001811F6B30
	[BlackList] // 0x0000000189AB76F0-0x0000000189AB7730
	// [XID] // 0x0000000189AB76F0-0x0000000189AB7730
	public virtual void AutoAllocTypeFields() {} // 0x00000001811F5D50-0x00000001811F5DF0
	[BlackList] // 0x0000000189AC2360-0x0000000189AC23A0
	// [XID] // 0x0000000189AC2360-0x0000000189AC23A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001811F5DF0-0x00000001811F5E90
	[BlackList] // 0x0000000189ACC980-0x0000000189ACC9C0
	// [XID] // 0x0000000189ACC980-0x0000000189ACC9C0
	public virtual void ReturnToObjectPool() {} // 0x00000001811F6D50-0x00000001811F6DF0
	[BlackList] // 0x0000000189AD77A0-0x0000000189AD77E0
	// [XID] // 0x0000000189AD77A0-0x0000000189AD77E0
	public virtual void OnPoolAllocated() {} // 0x00000001811F6CB0-0x00000001811F6D50
	[BlackList] // 0x0000000189AE2040-0x0000000189AE2080
	// [XID] // 0x0000000189AE2040-0x0000000189AE2080
	public virtual void OnBeforePoolRecycled() {} // 0x00000001811F6C10-0x00000001811F6CB0
}

