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
public class ConfigEffectPath : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17932
{
	// Fields
	private Dictionary<string, ulong> _effectPaths; // 0x10

	// Properties
	public Dictionary<string, ulong> effectPaths { /* [XID] */ /* 0x0000000189A6C780-0x0000000189A6C7A0 */ get => default; /* [XID] */ /* 0x0000000189A74090-0x0000000189A740B0 */ private set {} } // 0x0000000183A16880-0x0000000183A16920 0x0000000183A16920-0x0000000183A169D0

	// Constructors
	public ConfigEffectPath() {} // 0x0000000183A177E0-0x0000000183A17860

	// Methods
	// [XID] // 0x0000000189A7BA00-0x0000000189A7BA20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A17520-0x0000000183A17600
	// [XID] // 0x0000000189A832C0-0x0000000189A832E0
	public void InitEmpty() {} // 0x0000000183A16F60-0x0000000183A17030
	[BlackList] // 0x0000000189A8AB80-0x0000000189A8ABC0
	// [XID] // 0x0000000189A8AB80-0x0000000189A8ABC0
	public bool FromJson(JSONNode node) => default; // 0x0000000183A16BE0-0x0000000183A16F60
	// [XID] // 0x0000000189A951B0-0x0000000189A951D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A16290-0x0000000183A16470
	// [XID] // 0x00000001896E4A50-0x00000001896E4A70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8271 */, bool useObjectPool = false /* Metadata: 0x00AF8275 */) => default; // 0x0000000183A17030-0x0000000183A17330
	// [XID] // 0x0000000189AA41E0-0x0000000189AA4200
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8276 */, bool useObjectPool = false /* Metadata: 0x00AF827A */) => default; // 0x0000000183A169D0-0x0000000183A16BE0
	[BlackList] // 0x0000000189AAB670-0x0000000189AAB6B0
	// [XID] // 0x0000000189AAB670-0x0000000189AAB6B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A16470-0x0000000183A16740
	// [XID] // 0x0000000189AB5FC0-0x0000000189AB5FE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A17330-0x0000000183A17520
	[BlackList] // 0x0000000189ABDA50-0x0000000189ABDA90
	// [XID] // 0x0000000189ABDA50-0x0000000189ABDA90
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A16740-0x0000000183A167E0
	[BlackList] // 0x0000000189AC8410-0x0000000189AC8450
	// [XID] // 0x0000000189AC8410-0x0000000189AC8450
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A167E0-0x0000000183A16880
	[BlackList] // 0x0000000189AD2E20-0x0000000189AD2E60
	// [XID] // 0x0000000189AD2E20-0x0000000189AD2E60
	public virtual void ReturnToObjectPool() {} // 0x0000000183A17740-0x0000000183A177E0
	[BlackList] // 0x0000000189ADDBE0-0x0000000189ADDC20
	// [XID] // 0x0000000189ADDBE0-0x0000000189ADDC20
	public virtual void OnPoolAllocated() {} // 0x0000000183A176A0-0x0000000183A17740
	[BlackList] // 0x0000000189AE8170-0x0000000189AE81B0
	// [XID] // 0x0000000189AE8170-0x0000000189AE81B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A17600-0x0000000183A176A0
}

