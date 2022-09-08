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
public class ConfigRecordMaterialParameters : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18874
{
	// Fields
	private SimpleSafeUInt32 materialTypeRawNum; // 0x10
	private string[] _textureNames; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private MaterialFloat[] _floats; // 0x20

	// Properties
	public uint materialType { /* [XID] */ /* 0x00000001899FE390-0x00000001899FE3B0 */ get => default; /* [XID] */ /* 0x0000000189A05C90-0x0000000189A05CB0 */ private set {} } // 0x00000001847B1CA0-0x00000001847B1D70 0x00000001847B2230-0x00000001847B2310
	public string[] textureNames { /* [XID] */ /* 0x0000000189A0CFC0-0x0000000189A0CFE0 */ get => default; /* [XID] */ /* 0x0000000189A147E0-0x0000000189A14800 */ private set {} } // 0x00000001847B2310-0x00000001847B23B0 0x00000001847B1D70-0x00000001847B1E20
	public MaterialFloat[] floats { /* [XID] */ /* 0x0000000189A1BB90-0x0000000189A1BBB0 */ get => default; /* [XID] */ /* 0x0000000189A23420-0x0000000189A23440 */ private set {} } // 0x00000001847B2970-0x00000001847B2A10 0x00000001847B1510-0x00000001847B15C0

	// Constructors
	public ConfigRecordMaterialParameters() {} // 0x00000001847B2AB0-0x00000001847B2B10

	// Methods
	// [XID] // 0x0000000189A2A740-0x0000000189A2A760
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001847B2710-0x00000001847B2830
	// [XID] // 0x0000000189A31C80-0x0000000189A31CA0
	public void InitEmpty() {} // 0x00000001847B1E20-0x00000001847B1F30
	[BlackList] // 0x0000000189A396D0-0x0000000189A39710
	// [XID] // 0x0000000189A396D0-0x0000000189A39710
	public bool FromJson(JSONNode node) => default; // 0x00000001847B1920-0x00000001847B1CA0
	// [XID] // 0x0000000189A43EF0-0x0000000189A43F10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001847B0CE0-0x00000001847B10C0
	// [XID] // 0x0000000189A4B480-0x0000000189A4B4A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1E9 */, bool useObjectPool = false /* Metadata: 0x00AFB1ED */) => default; // 0x00000001847B1F30-0x00000001847B2230
	// [XID] // 0x0000000189A52AA0-0x0000000189A52AC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1EE */, bool useObjectPool = false /* Metadata: 0x00AFB1F2 */) => default; // 0x00000001847B15C0-0x00000001847B1920
	[BlackList] // 0x0000000189A5A470-0x0000000189A5A4B0
	// [XID] // 0x0000000189A5A470-0x0000000189A5A4B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001847B10C0-0x00000001847B1390
	// [XID] // 0x0000000189A64EC0-0x0000000189A64EE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847B23B0-0x00000001847B2710
	[BlackList] // 0x0000000189A6C620-0x0000000189A6C660
	// [XID] // 0x0000000189A6C620-0x0000000189A6C660
	public virtual void AutoAllocTypeFields() {} // 0x00000001847B1390-0x00000001847B1430
	[BlackList] // 0x0000000189A76D70-0x0000000189A76DB0
	// [XID] // 0x0000000189A76D70-0x0000000189A76DB0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001847B1430-0x00000001847B1510
	[BlackList] // 0x0000000189A81790-0x0000000189A817D0
	// [XID] // 0x0000000189A81790-0x0000000189A817D0
	public virtual void ReturnToObjectPool() {} // 0x00000001847B2A10-0x00000001847B2AB0
	[BlackList] // 0x0000000189A8C210-0x0000000189A8C250
	// [XID] // 0x0000000189A8C210-0x0000000189A8C250
	public virtual void OnPoolAllocated() {} // 0x00000001847B28D0-0x00000001847B2970
	[BlackList] // 0x0000000189A967C0-0x0000000189A96800
	// [XID] // 0x0000000189A967C0-0x0000000189A96800
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847B2830-0x00000001847B28D0
}

