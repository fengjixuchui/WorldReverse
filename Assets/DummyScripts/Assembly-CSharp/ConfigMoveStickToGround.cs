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
public class ConfigMoveStickToGround : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18604
{
	// Fields
	private SimpleSafeFloat maxStepHeightRawNum; // 0x10
	private SimpleSafeFloat maxSlopeAngleRawNum; // 0x14
	private SimpleSafeFloat heightToGroundRawNum; // 0x18
	private SimpleSafeFloat flexibleRangeRawNum; // 0x1C
	private bool _isStickToWater; // 0x20
	private UnstickAction _unstickWhenDownSlide; // 0x24
	private UnstickAction _unstickWhenUpSlide; // 0x28

	// Properties
	public float maxStepHeight { /* [XID] */ /* 0x000000018996C6B0-0x000000018996C6D0 */ get => default; /* [XID] */ /* 0x0000000189974110-0x0000000189974130 */ private set {} } // 0x0000000182189210-0x00000001821892F0 0x0000000182189B70-0x0000000182189C50
	public float maxSlopeAngle { /* [XID] */ /* 0x000000018997B840-0x000000018997B860 */ get => default; /* [XID] */ /* 0x0000000189983350-0x0000000189983370 */ private set {} } // 0x0000000182188CA0-0x0000000182188D80 0x00000001821892F0-0x00000001821893D0
	public float heightToGround { /* [XID] */ /* 0x000000018998AB00-0x000000018998AB20 */ get => default; /* [XID] */ /* 0x0000000189992430-0x0000000189992450 */ private set {} } // 0x0000000182189A90-0x0000000182189B70 0x000000018218A310-0x000000018218A3F0
	public float flexibleRange { /* [XID] */ /* 0x000000018999A1D0-0x000000018999A1F0 */ get => default; /* [XID] */ /* 0x00000001899A18B0-0x00000001899A18D0 */ private set {} } // 0x000000018218AFE0-0x000000018218B0C0 0x000000018218A080-0x000000018218A160
	public bool isStickToWater { /* [XID] */ /* 0x00000001899A9120-0x00000001899A9140 */ get => default; /* [XID] */ /* 0x00000001899B0C50-0x00000001899B0C70 */ private set {} } // 0x00000001821893D0-0x0000000182189470 0x0000000182189470-0x0000000182189520
	public UnstickAction unstickWhenDownSlide { /* [XID] */ /* 0x00000001899B7EF0-0x00000001899B7F10 */ get => default; /* [XID] */ /* 0x00000001899BFAD0-0x00000001899BFAF0 */ private set {} } // 0x000000018218A6F0-0x000000018218A790 0x0000000182189FD0-0x000000018218A080
	public UnstickAction unstickWhenUpSlide { /* [XID] */ /* 0x00000001899C7290-0x00000001899C72B0 */ get => default; /* [XID] */ /* 0x00000001899CE8A0-0x00000001899CE8C0 */ private set {} } // 0x000000018218AC70-0x000000018218AD10 0x000000018218A260-0x000000018218A310

	// Constructors
	public ConfigMoveStickToGround() {} // 0x000000018218B160-0x000000018218B1D0

	// Methods
	// [XID] // 0x00000001899D5F70-0x00000001899D5F90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018218AD10-0x000000018218AEA0
	// [XID] // 0x00000001899DD3A0-0x00000001899DD3C0
	public void InitEmpty() {} // 0x000000018218A160-0x000000018218A260
	[BlackList] // 0x00000001899E50A0-0x00000001899E50E0
	// [XID] // 0x00000001899E50A0-0x00000001899E50E0
	public bool FromJson(JSONNode node) => default; // 0x0000000182189C50-0x0000000182189FD0
	// [XID] // 0x00000001899EF390-0x00000001899EF3B0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001821884A0-0x0000000182188CA0
	// [XID] // 0x00000001899F6D10-0x00000001899F6D30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA58B */, bool useObjectPool = false /* Metadata: 0x00AFA58F */) => default; // 0x000000018218A3F0-0x000000018218A6F0
	// [XID] // 0x00000001899FE3B0-0x00000001899FE3D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA590 */, bool useObjectPool = false /* Metadata: 0x00AFA594 */) => default; // 0x0000000182189520-0x0000000182189A90
	[BlackList] // 0x0000000189A05CD0-0x0000000189A05D10
	// [XID] // 0x0000000189A05CD0-0x0000000189A05D10
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182188D80-0x0000000182189050
	// [XID] // 0x0000000189A0FEB0-0x0000000189A0FED0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018218A790-0x000000018218AC70
	[BlackList] // 0x0000000189A17350-0x0000000189A17390
	// [XID] // 0x0000000189A17350-0x0000000189A17390
	public virtual void AutoAllocTypeFields() {} // 0x0000000182189050-0x00000001821890F0
	[BlackList] // 0x0000000189A219B0-0x0000000189A219F0
	// [XID] // 0x0000000189A219B0-0x0000000189A219F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001821890F0-0x0000000182189210
	[BlackList] // 0x0000000189A2BDF0-0x0000000189A2BE30
	// [XID] // 0x0000000189A2BDF0-0x0000000189A2BE30
	public virtual void ReturnToObjectPool() {} // 0x000000018218B0C0-0x000000018218B160
	[BlackList] // 0x0000000189A36870-0x0000000189A368B0
	// [XID] // 0x0000000189A36870-0x0000000189A368B0
	public virtual void OnPoolAllocated() {} // 0x000000018218AF40-0x000000018218AFE0
	[BlackList] // 0x0000000189A40F90-0x0000000189A40FD0
	// [XID] // 0x0000000189A40F90-0x0000000189A40FD0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018218AEA0-0x000000018218AF40
}

