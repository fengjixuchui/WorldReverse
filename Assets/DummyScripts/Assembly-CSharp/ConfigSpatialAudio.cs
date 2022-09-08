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
public class ConfigSpatialAudio : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19013
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigSpatialRoom[] _roomList; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigSpatialPortal[] _portalList; // 0x20
	private string _globalRoom; // 0x28

	// Properties
	public uint sceneId { /* [XID] */ /* 0x00000001899E3650-0x00000001899E3670 */ get => default; /* [XID] */ /* 0x00000001899EA9E0-0x00000001899EAA00 */ private set {} } // 0x0000000182ED4C00-0x0000000182ED4CD0 0x0000000182ED4FD0-0x0000000182ED50B0
	public ConfigSpatialRoom[] roomList { /* [XID] */ /* 0x00000001899F2540-0x00000001899F2560 */ get => default; /* [XID] */ /* 0x00000001899F9B10-0x00000001899F9B30 */ private set {} } // 0x0000000182ED49A0-0x0000000182ED4A40 0x0000000182ED50B0-0x0000000182ED5160
	public ConfigSpatialPortal[] portalList { /* [XID] */ /* 0x0000000189A00F30-0x0000000189A00F50 */ get => default; /* [XID] */ /* 0x0000000189A08810-0x0000000189A08830 */ private set {} } // 0x0000000182ED3BC0-0x0000000182ED3C60 0x0000000182ED48F0-0x0000000182ED49A0
	public string globalRoom { /* [XID] */ /* 0x0000000189A0FE10-0x0000000189A0FE30 */ get => default; /* [XID] */ /* 0x0000000189A172B0-0x0000000189A172D0 */ private set {} } // 0x0000000182ED4B60-0x0000000182ED4C00 0x0000000182ED4840-0x0000000182ED48F0

	// Constructors
	public ConfigSpatialAudio() {} // 0x0000000182ED5860-0x0000000182ED58C0

	// Methods
	// [XID] // 0x0000000189A1E9F0-0x0000000189A1EA10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182ED5540-0x0000000182ED5680
	// [XID] // 0x0000000189A26100-0x0000000189A26120
	public void InitEmpty() {} // 0x0000000182ED4A40-0x0000000182ED4B60
	[BlackList] // 0x0000000189A2D410-0x0000000189A2D450
	// [XID] // 0x0000000189A2D410-0x0000000189A2D450
	public bool FromJson(JSONNode node) => default; // 0x0000000182ED44C0-0x0000000182ED4840
	// [XID] // 0x0000000189A37F10-0x0000000189A37F30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182ED3710-0x0000000182ED3BC0
	// [XID] // 0x0000000189A3F6A0-0x0000000189A3F6C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB75B */, bool useObjectPool = false /* Metadata: 0x00AFB75F */) => default; // 0x0000000182ED4CD0-0x0000000182ED4FD0
	// [XID] // 0x0000000189A46D10-0x0000000189A46D30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB760 */, bool useObjectPool = false /* Metadata: 0x00AFB764 */) => default; // 0x0000000182ED40C0-0x0000000182ED44C0
	[BlackList] // 0x0000000189A4E5A0-0x0000000189A4E5E0
	// [XID] // 0x0000000189A4E5A0-0x0000000189A4E5E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182ED3C60-0x0000000182ED3F30
	// [XID] // 0x0000000189A58B40-0x0000000189A58B60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182ED5160-0x0000000182ED5540
	[BlackList] // 0x0000000189A60560-0x0000000189A605A0
	// [XID] // 0x0000000189A60560-0x0000000189A605A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182ED3F30-0x0000000182ED3FD0
	[BlackList] // 0x0000000189A6AFF0-0x0000000189A6B030
	// [XID] // 0x0000000189A6AFF0-0x0000000189A6B030
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182ED3FD0-0x0000000182ED40C0
	[BlackList] // 0x0000000189A753F0-0x0000000189A75430
	// [XID] // 0x0000000189A753F0-0x0000000189A75430
	public virtual void ReturnToObjectPool() {} // 0x0000000182ED57C0-0x0000000182ED5860
	[BlackList] // 0x0000000189A7FCA0-0x0000000189A7FCE0
	// [XID] // 0x0000000189A7FCA0-0x0000000189A7FCE0
	public virtual void OnPoolAllocated() {} // 0x0000000182ED5720-0x0000000182ED57C0
	[BlackList] // 0x0000000189A8A950-0x0000000189A8A990
	// [XID] // 0x0000000189A8A950-0x0000000189A8A990
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182ED5680-0x0000000182ED5720
}

