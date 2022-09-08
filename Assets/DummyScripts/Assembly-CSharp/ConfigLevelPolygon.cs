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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigLevelPolygon : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18499
{
	// Fields
	private SimpleSafeUInt32 localPolygonIdRawNum; // 0x10
	private SimpleSafeFloat yMaxRawNum; // 0x14
	private SimpleSafeFloat yMinRawNum; // 0x18
	private MoleMole.Config.Vector[] _vertices; // 0x20
	private ConfigLevelPolygonTag[] _tags; // 0x28

	// Properties
	public uint localPolygonId { /* [XID] */ /* 0x00000001898B84A0-0x00000001898B84C0 */ get => default; /* [XID] */ /* 0x00000001898BFC20-0x00000001898BFC40 */ private set {} } // 0x00000001827B4610-0x00000001827B46E0 0x00000001827B46E0-0x00000001827B47C0
	public float yMax { /* [XID] */ /* 0x00000001898C74E0-0x00000001898C7500 */ get => default; /* [XID] */ /* 0x00000001898CEAD0-0x00000001898CEAF0 */ private set {} } // 0x00000001827B5160-0x00000001827B5240 0x00000001827B57E0-0x00000001827B58C0
	public float yMin { /* [XID] */ /* 0x00000001898D6420-0x00000001898D6440 */ get => default; /* [XID] */ /* 0x00000001898DE120-0x00000001898DE140 */ private set {} } // 0x00000001827B4480-0x00000001827B4560 0x00000001827B4C60-0x00000001827B4D40
	public MoleMole.Config.Vector[] vertices { /* [XID] */ /* 0x00000001898E5920-0x00000001898E5940 */ get => default; /* [XID] */ /* 0x00000001898ED340-0x00000001898ED360 */ private set {} } // 0x00000001827B5740-0x00000001827B57E0 0x00000001827B5690-0x00000001827B5740
	public ConfigLevelPolygonTag[] tags { /* [XID] */ /* 0x00000001898F4AC0-0x00000001898F4AE0 */ get => default; /* [XID] */ /* 0x00000001898FC370-0x00000001898FC390 */ private set {} } // 0x00000001827B50C0-0x00000001827B5160 0x00000001827B4560-0x00000001827B4610

	// Constructors
	public ConfigLevelPolygon() {} // 0x00000001827B6070-0x00000001827B60D0

	// Methods
	// [XID] // 0x0000000189903DB0-0x0000000189903DD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827B5D30-0x00000001827B5E90
	// [XID] // 0x000000018990B370-0x000000018990B390
	public void InitEmpty() {} // 0x00000001827B5240-0x00000001827B5390
	[BlackList] // 0x0000000189913000-0x0000000189913040
	// [XID] // 0x0000000189913000-0x0000000189913040
	public bool FromJson(JSONNode node) => default; // 0x00000001827B4D40-0x00000001827B50C0
	// [XID] // 0x000000018991D730-0x000000018991D750
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001827B39F0-0x00000001827B3FF0
	// [XID] // 0x0000000189924F20-0x0000000189924F40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F8B */, bool useObjectPool = false /* Metadata: 0x00AF9F8F */) => default; // 0x00000001827B5390-0x00000001827B5690
	// [XID] // 0x000000018992C4E0-0x000000018992C500
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F90 */, bool useObjectPool = false /* Metadata: 0x00AF9F94 */) => default; // 0x00000001827B47C0-0x00000001827B4C60
	[BlackList] // 0x0000000189933AA0-0x0000000189933AE0
	// [XID] // 0x0000000189933AA0-0x0000000189933AE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001827B3FF0-0x00000001827B42C0
	// [XID] // 0x000000018993E470-0x000000018993E490
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001827B58C0-0x00000001827B5D30
	[BlackList] // 0x0000000189945A80-0x0000000189945AC0
	// [XID] // 0x0000000189945A80-0x0000000189945AC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001827B42C0-0x00000001827B4360
	[BlackList] // 0x00000001899501B0-0x00000001899501F0
	// [XID] // 0x00000001899501B0-0x00000001899501F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001827B4360-0x00000001827B4480
	[BlackList] // 0x000000018995A830-0x000000018995A870
	// [XID] // 0x000000018995A830-0x000000018995A870
	public virtual void ReturnToObjectPool() {} // 0x00000001827B5FD0-0x00000001827B6070
	[BlackList] // 0x0000000189965210-0x0000000189965250
	// [XID] // 0x0000000189965210-0x0000000189965250
	public virtual void OnPoolAllocated() {} // 0x00000001827B5F30-0x00000001827B5FD0
	[BlackList] // 0x000000018996F460-0x000000018996F4A0
	// [XID] // 0x000000018996F460-0x000000018996F4A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001827B5E90-0x00000001827B5F30
}

