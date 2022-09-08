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
public class ConfigFlycloakFashion : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18081
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFlycloakFashionEffect _effects; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFlycloakFashionScale _scale; // 0x18

	// Properties
	public ConfigFlycloakFashionEffect effects { /* [XID] */ /* 0x0000000189B01AF0-0x0000000189B01B10 */ get => default; /* [XID] */ /* 0x0000000189B090B0-0x0000000189B090D0 */ private set {} } // 0x0000000183228AE0-0x0000000183228B80 0x0000000183227F00-0x0000000183227FB0
	public ConfigFlycloakFashionScale scale { /* [XID] */ /* 0x0000000189B10B10-0x0000000189B10B30 */ get => default; /* [XID] */ /* 0x0000000189B17CA0-0x0000000189B17CC0 */ private set {} } // 0x0000000183228650-0x00000001832286F0 0x0000000183229040-0x00000001832290F0

	// Constructors
	public ConfigFlycloakFashion() {} // 0x0000000183229190-0x00000001832291F0

	// Methods
	// [XID] // 0x0000000189B1F540-0x0000000189B1F560
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183228E00-0x0000000183228F00
	// [XID] // 0x0000000189B26DE0-0x0000000189B26E00
	public void InitEmpty() {} // 0x00000001832286F0-0x00000001832287E0
	[BlackList] // 0x0000000189B2DFD0-0x0000000189B2E010
	// [XID] // 0x0000000189B2DFD0-0x0000000189B2E010
	public bool FromJson(JSONNode node) => default; // 0x00000001832282D0-0x0000000183228650
	// [XID] // 0x0000000189B385D0-0x0000000189B385F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832276F0-0x00000001832279F0
	// [XID] // 0x0000000189B40060-0x0000000189B40080
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A69 */, bool useObjectPool = false /* Metadata: 0x00AF8A6D */) => default; // 0x00000001832287E0-0x0000000183228AE0
	// [XID] // 0x0000000189B478C0-0x0000000189B478E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A6E */, bool useObjectPool = false /* Metadata: 0x00AF8A72 */) => default; // 0x0000000183227FB0-0x00000001832282D0
	[BlackList] // 0x0000000189B4F030-0x0000000189B4F070
	// [XID] // 0x0000000189B4F030-0x0000000189B4F070
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832279F0-0x0000000183227CC0
	// [XID] // 0x0000000189B598E0-0x0000000189B59900
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183228B80-0x0000000183228E00
	[BlackList] // 0x0000000189B610F0-0x0000000189B61130
	// [XID] // 0x0000000189B610F0-0x0000000189B61130
	public virtual void AutoAllocTypeFields() {} // 0x0000000183227CC0-0x0000000183227D60
	[BlackList] // 0x0000000189B6B790-0x0000000189B6B7D0
	// [XID] // 0x0000000189B6B790-0x0000000189B6B7D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183227D60-0x0000000183227F00
	[BlackList] // 0x0000000189B75CB0-0x0000000189B75CF0
	// [XID] // 0x0000000189B75CB0-0x0000000189B75CF0
	public virtual void ReturnToObjectPool() {} // 0x00000001832290F0-0x0000000183229190
	[BlackList] // 0x0000000189B80170-0x0000000189B801B0
	// [XID] // 0x0000000189B80170-0x0000000189B801B0
	public virtual void OnPoolAllocated() {} // 0x0000000183228FA0-0x0000000183229040
	[BlackList] // 0x0000000189B8A8B0-0x0000000189B8A8F0
	// [XID] // 0x0000000189B8A8B0-0x0000000189B8A8F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183228F00-0x0000000183228FA0
}

