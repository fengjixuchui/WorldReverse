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
public class ConfigAudioMapInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17593
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _areaStateKey; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAudioMapArea[] _areas; // 0x18
	private Dictionary<uint, ConfigAudioMapArea> _indexedAreas; // 0x20

	// Properties
	public ConfigWwiseString areaStateKey { /* [XID] */ /* 0x000000018996DF20-0x000000018996DF40 */ get => default; /* [XID] */ /* 0x0000000189975AF0-0x0000000189975B10 */ private set {} } // 0x0000000184D51A20-0x0000000184D51AC0 0x0000000184D51AC0-0x0000000184D51B70
	public ConfigAudioMapArea[] areas { /* [XID] */ /* 0x000000018997CAD0-0x000000018997CAF0 */ get => default; /* [XID] */ /* 0x00000001899848B0-0x00000001899848D0 */ private set {} } // 0x0000000184D515A0-0x0000000184D51640 0x0000000184D514F0-0x0000000184D515A0

	// Constructors
	public ConfigAudioMapInfo() {} // 0x0000000184D52270-0x0000000184D522D0

	// Methods
	// [XID] // 0x000000018998C2D0-0x000000018998C2F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D51F80-0x0000000184D52090
	// [XID] // 0x0000000189994050-0x0000000189994070
	public void InitEmpty() {} // 0x0000000184D51400-0x0000000184D514F0
	[BlackList] // 0x000000018999B840-0x000000018999B880
	// [XID] // 0x000000018999B840-0x000000018999B880
	public bool FromJson(JSONNode node) => default; // 0x0000000184D51080-0x0000000184D51400
	// [XID] // 0x00000001899A6450-0x00000001899A6470
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184D505E0-0x0000000184D508D0
	// [XID] // 0x00000001899ADB20-0x00000001899ADB40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7415 */, bool useObjectPool = false /* Metadata: 0x00AF7419 */) => default; // 0x0000000184D51640-0x0000000184D51940
	// [XID] // 0x00000001899B53A0-0x00000001899B53C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF741A */, bool useObjectPool = false /* Metadata: 0x00AF741E */) => default; // 0x0000000184D50D80-0x0000000184D51080
	[BlackList] // 0x00000001899BC9D0-0x00000001899BCA10
	// [XID] // 0x00000001899BC9D0-0x00000001899BCA10
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D508D0-0x0000000184D50BA0
	// [XID] // 0x00000001899C7350-0x00000001899C7370
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D51B70-0x0000000184D51E00
	// [XID] // 0x00000001899CE920-0x00000001899CE940
	public void BuildIndexedAreaTable() {} // 0x0000000184D51E00-0x0000000184D51F80
	// [XID] // 0x00000001899D60D0-0x00000001899D60F0
	public ConfigAudioMapArea GetAreaById(uint id) => default; // 0x0000000184D51940-0x0000000184D51A20
	[BlackList] // 0x00000001899DD560-0x00000001899DD5A0
	// [XID] // 0x00000001899DD560-0x00000001899DD5A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D50BA0-0x0000000184D50C40
	[BlackList] // 0x00000001899E8080-0x00000001899E80C0
	// [XID] // 0x00000001899E8080-0x00000001899E80C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D50C40-0x0000000184D50D80
	[BlackList] // 0x00000001899F2800-0x00000001899F2840
	// [XID] // 0x00000001899F2800-0x00000001899F2840
	public virtual void ReturnToObjectPool() {} // 0x0000000184D521D0-0x0000000184D52270
	[BlackList] // 0x00000001899FCE30-0x00000001899FCE70
	// [XID] // 0x00000001899FCE30-0x00000001899FCE70
	public virtual void OnPoolAllocated() {} // 0x0000000184D52130-0x0000000184D521D0
	[BlackList] // 0x0000000189A07390-0x0000000189A073D0
	// [XID] // 0x0000000189A07390-0x0000000189A073D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D52090-0x0000000184D52130
}

