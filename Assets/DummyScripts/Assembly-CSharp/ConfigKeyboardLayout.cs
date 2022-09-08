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
public class ConfigKeyboardLayout : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18458
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<KeyboardType, ConfigKeyboardLayoutItem> _configKeyboardLayouts; // 0x10
	private Dictionary<InputActionGroupType, InputActionType[]> _inputActionTypeGroups; // 0x18

	// Properties
	public Dictionary<KeyboardType, ConfigKeyboardLayoutItem> configKeyboardLayouts { /* [XID] */ /* 0x000000018964CE10-0x000000018964CE30 */ get => default; /* [XID] */ /* 0x0000000189B03270-0x0000000189B03290 */ private set {} } // 0x000000018414EFD0-0x000000018414F070 0x000000018414F340-0x000000018414F3F0
	public Dictionary<InputActionGroupType, InputActionType[]> inputActionTypeGroups { /* [XID] */ /* 0x0000000189B0AA00-0x0000000189B0AA20 */ get => default; /* [XID] */ /* 0x0000000189B12080-0x0000000189B120A0 */ private set {} } // 0x000000018414EDD0-0x000000018414EE70 0x000000018414F770-0x000000018414F820

	// Constructors
	public ConfigKeyboardLayout() {} // 0x00000001841501A0-0x0000000184150200

	// Methods
	// [XID] // 0x0000000189B19430-0x0000000189B19450
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018414FEB0-0x000000018414FFC0
	// [XID] // 0x0000000189B20A50-0x0000000189B20A70
	public void InitEmpty() {} // 0x000000018414F820-0x000000018414F910
	[BlackList] // 0x0000000189B28150-0x0000000189B28190
	// [XID] // 0x0000000189B28150-0x0000000189B28190
	public bool FromJson(JSONNode node) => default; // 0x000000018414F3F0-0x000000018414F770
	// [XID] // 0x0000000189B32640-0x0000000189B32660
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018414E830-0x000000018414EB00
	// [XID] // 0x0000000189B39EF0-0x0000000189B39F10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9923 */, bool useObjectPool = false /* Metadata: 0x00AF9927 */) => default; // 0x000000018414F910-0x000000018414FC10
	// [XID] // 0x0000000189B41870-0x0000000189B41890
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9928 */, bool useObjectPool = false /* Metadata: 0x00AF992C */) => default; // 0x000000018414F070-0x000000018414F340
	[BlackList] // 0x0000000189B49260-0x0000000189B492A0
	// [XID] // 0x0000000189B49260-0x0000000189B492A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018414EB00-0x000000018414EDD0
	// [XID] // 0x0000000189B53760-0x0000000189B53780
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018414FC10-0x000000018414FEB0
	[BlackList] // 0x0000000189B5AF70-0x0000000189B5AFB0
	// [XID] // 0x0000000189B5AF70-0x0000000189B5AFB0
	public virtual void AutoAllocTypeFields() {} // 0x000000018414EE70-0x000000018414EF10
	[BlackList] // 0x0000000189B65660-0x0000000189B656A0
	// [XID] // 0x0000000189B65660-0x0000000189B656A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018414EF10-0x000000018414EFD0
	[BlackList] // 0x0000000189B6FD20-0x0000000189B6FD60
	// [XID] // 0x0000000189B6FD20-0x0000000189B6FD60
	public virtual void ReturnToObjectPool() {} // 0x0000000184150100-0x00000001841501A0
	[BlackList] // 0x0000000189B7A2B0-0x0000000189B7A2F0
	// [XID] // 0x0000000189B7A2B0-0x0000000189B7A2F0
	public virtual void OnPoolAllocated() {} // 0x0000000184150060-0x0000000184150100
	[BlackList] // 0x0000000189B84EF0-0x0000000189B84F30
	// [XID] // 0x0000000189B84EF0-0x0000000189B84F30
	public virtual void OnBeforePoolRecycled() {} // 0x000000018414FFC0-0x0000000184150060
}

