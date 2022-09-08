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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class EnvAnimalGatherExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15571
{
	// Fields
	protected SimpleSafeUInt32 animalIdRawNum; // 0x10
	protected EntityType _entityType; // 0x14
	protected SimpleSafeUInt32 gatherItemIdRawNum; // 0x18
	protected SimpleSafeUInt32 escapeRadiusRawNum; // 0x1C
	protected SimpleSafeUInt32 escapeTimeRawNum; // 0x20
	protected SimpleSafeUInt32 aliveTimeRawNum; // 0x24
	protected string _excludeWeathers; // 0x28

	// Properties
	public uint animalId { /* [XID] */ /* 0x0000000189A03090-0x0000000189A030B0 */ get => default; /* [XID] */ /* 0x0000000189A0A600-0x0000000189A0A620 */ protected set {} } // 0x0000000184915EE0-0x0000000184915FB0 0x0000000184914490-0x0000000184914570
	public EntityType entityType { /* [XID] */ /* 0x0000000189A11EE0-0x0000000189A11F00 */ get => default; /* [XID] */ /* 0x0000000189A191D0-0x0000000189A191F0 */ protected set {} } // 0x0000000184915230-0x00000001849152D0 0x0000000184914740-0x00000001849147F0
	public uint gatherItemId { /* [XID] */ /* 0x0000000189A20970-0x0000000189A20990 */ get => default; /* [XID] */ /* 0x0000000189A27D80-0x0000000189A27DA0 */ protected set {} } // 0x0000000184915480-0x0000000184915550 0x0000000184915550-0x0000000184915630
	public uint escapeRadius { /* [XID] */ /* 0x0000000189A2F4B0-0x0000000189A2F4D0 */ get => default; /* [XID] */ /* 0x0000000189A36EB0-0x0000000189A36ED0 */ protected set {} } // 0x0000000184915FB0-0x0000000184916080 0x00000001849153A0-0x0000000184915480
	public uint escapeTime { /* [XID] */ /* 0x0000000189A3E510-0x0000000189A3E530 */ get => default; /* [XID] */ /* 0x0000000189A45BA0-0x0000000189A45BC0 */ protected set {} } // 0x00000001849152D0-0x00000001849153A0 0x00000001849147F0-0x00000001849148D0
	public uint aliveTime { /* [XID] */ /* 0x0000000189A4D340-0x0000000189A4D360 */ get => default; /* [XID] */ /* 0x0000000189A54AB0-0x0000000189A54AD0 */ protected set {} } // 0x0000000184915E10-0x0000000184915EE0 0x0000000184916080-0x0000000184916160
	public string excludeWeathers { /* [XID] */ /* 0x0000000189A5C540-0x0000000189A5C560 */ get => default; /* [XID] */ /* 0x0000000189A63E30-0x0000000189A63E50 */ protected set {} } // 0x0000000184915630-0x00000001849156D0 0x00000001849156D0-0x0000000184915780

	// Constructors
	public EnvAnimalGatherExcelConfig() {} // 0x0000000184916340-0x0000000184916430

	// Methods
	// [IDTag] // 0x0000000189A6B730-0x0000000189A6B770
	// [XID] // 0x0000000189A6B730-0x0000000189A6B770
	public virtual bool ParseFromLine(string line) => default; // 0x00000001849148D0-0x0000000184914D90
	// [IDTag] // 0x0000000189A75BF0-0x0000000189A75C30
	// [XID] // 0x0000000189A75BF0-0x0000000189A75C30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184914D90-0x0000000184915230
	// [XID] // 0x0000000189A80320-0x0000000189A80340
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F6B */, bool useObjectPool = false /* Metadata: 0x00AF1F6F */) => default; // 0x0000000184915780-0x0000000184915E10
	[BlackList] // 0x0000000189A880A0-0x0000000189A880E0
	// [XID] // 0x0000000189A880A0-0x0000000189A880E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184914570-0x0000000184914610
	[BlackList] // 0x0000000189A927F0-0x0000000189A92830
	// [XID] // 0x0000000189A927F0-0x0000000189A92830
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184914610-0x0000000184914740
	[BlackList] // 0x0000000189A9CE90-0x0000000189A9CED0
	// [XID] // 0x0000000189A9CE90-0x0000000189A9CED0
	public virtual void ReturnToObjectPool() {} // 0x00000001849162A0-0x0000000184916340
	[BlackList] // 0x0000000189AA74E0-0x0000000189AA7520
	// [XID] // 0x0000000189AA74E0-0x0000000189AA7520
	public virtual void OnPoolAllocated() {} // 0x0000000184916200-0x00000001849162A0
	[BlackList] // 0x0000000189AB1F80-0x0000000189AB1FC0
	// [XID] // 0x0000000189AB1F80-0x0000000189AB1FC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184916160-0x0000000184916200
}

