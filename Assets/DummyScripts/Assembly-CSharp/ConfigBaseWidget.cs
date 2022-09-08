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
public class ConfigBaseWidget : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19124
{
	// Fields
	private SimpleSafeUInt32 materialIdRawNum; // 0x10
	private bool _isConsumeMaterial; // 0x14
	private bool _isEquipable; // 0x15
	private SimpleSafeUInt32 coolDownRawNum; // 0x18
	private SimpleSafeUInt32 coolDownOnFailRawNum; // 0x1C
	private SimpleSafeUInt32 coolDownGroupRawNum; // 0x20
	private bool _isCdUnderTimeScale; // 0x24
	private bool _isAllowedInDungeon; // 0x25
	private bool _isAllowedInRoom; // 0x26
	private OrnamentsType _ornamentsType; // 0x28

	// Properties
	public uint materialId { /* [XID] */ /* 0x00000001898159F0-0x0000000189815A10 */ get => default; /* [XID] */ /* 0x000000018981D3F0-0x000000018981D410 */ private set {} } // 0x000000018474D460-0x000000018474D530 0x000000018474D380-0x000000018474D460
	public bool isConsumeMaterial { /* [XID] */ /* 0x0000000189824860-0x0000000189824880 */ get => default; /* [XID] */ /* 0x000000018982C330-0x000000018982C350 */ private set {} } // 0x000000018474E620-0x000000018474E6C0 0x000000018474D230-0x000000018474D2E0
	public bool isEquipable { /* [XID] */ /* 0x0000000189833820-0x0000000189833840 */ get => default; /* [XID] */ /* 0x000000018983AD20-0x000000018983AD40 */ private set {} } // 0x000000018474D2E0-0x000000018474D380 0x000000018474DC30-0x000000018474DCE0
	public uint coolDown { /* [XID] */ /* 0x00000001898423A0-0x00000001898423C0 */ get => default; /* [XID] */ /* 0x00000001898497F0-0x0000000189849810 */ private set {} } // 0x000000018474CA90-0x000000018474CB60 0x000000018474C680-0x000000018474C760
	public uint coolDownOnFail { /* [XID] */ /* 0x0000000189850FD0-0x0000000189850FF0 */ get => default; /* [XID] */ /* 0x00000001898584A0-0x00000001898584C0 */ private set {} } // 0x000000018474EA20-0x000000018474EAF0 0x000000018474D980-0x000000018474DA60
	public uint coolDownGroup { /* [XID] */ /* 0x000000018985F4D0-0x000000018985F4F0 */ get => default; /* [XID] */ /* 0x0000000189866D50-0x0000000189866D70 */ private set {} } // 0x000000018474D530-0x000000018474D600 0x000000018474DFD0-0x000000018474E0B0
	public bool isCdUnderTimeScale { /* [XID] */ /* 0x000000018986E590-0x000000018986E5B0 */ get => default; /* [XID] */ /* 0x0000000189875980-0x00000001898759A0 */ private set {} } // 0x000000018474E4A0-0x000000018474E540 0x000000018474DE30-0x000000018474DEE0
	public bool isAllowedInDungeon { /* [XID] */ /* 0x000000018987D5E0-0x000000018987D600 */ get => default; /* [XID] */ /* 0x0000000189884470-0x0000000189884490 */ private set {} } // 0x000000018474DCE0-0x000000018474DD80 0x000000018474E8C0-0x000000018474E970
	public bool isAllowedInRoom { /* [XID] */ /* 0x000000018988BB80-0x000000018988BBA0 */ get => default; /* [XID] */ /* 0x0000000189893290-0x00000001898932B0 */ private set {} } // 0x000000018474C920-0x000000018474C9C0 0x000000018474DD80-0x000000018474DE30
	public OrnamentsType ornamentsType { /* [XID] */ /* 0x000000018989A9B0-0x000000018989A9D0 */ get => default; /* [XID] */ /* 0x00000001898A1C20-0x00000001898A1C40 */ private set {} } // 0x000000018474EAF0-0x000000018474EB90 0x000000018474F5E0-0x000000018474F690

	// Constructors
	public ConfigBaseWidget() {} // 0x000000018474F730-0x000000018474F7E0

	// Methods
	// [XID] // 0x00000001898A9470-0x00000001898A9490
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018474F2C0-0x000000018474F4A0
	// [XID] // 0x00000001898B0CA0-0x00000001898B0CC0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018474E970-0x000000018474EA20
	// [XID] // 0x00000001898B8380-0x00000001898B83A0
	public virtual ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC2A3 */) => default; // 0x000000018474E540-0x000000018474E620
	// [XID] // 0x00000001898BFB40-0x00000001898BFB60
	public virtual int GetHashNum() => default; // 0x000000018474C9C0-0x000000018474CA90
	// [XID] // 0x00000001898C73E0-0x00000001898C7400
	public virtual void InitEmpty() {} // 0x000000018474DEE0-0x000000018474DFD0
	[BlackList] // 0x00000001898CE970-0x00000001898CE9B0
	// [XID] // 0x00000001898CE970-0x00000001898CE9B0
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018474D600-0x000000018474D980
	// [XID] // 0x00000001898D93F0-0x00000001898D9410
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018474BA00-0x000000018474C3B0
	[BlackList] // 0x00000001898E0FE0-0x00000001898E1020
	// [XID] // 0x00000001898E0FE0-0x00000001898E1020
	public static ConfigBaseWidget ParseFromJson(JSONNode node) => default; // 0x000000018474E6C0-0x000000018474E8C0
	// [XID] // 0x00000001898EBA10-0x00000001898EBA30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2A4 */, bool useObjectPool = false /* Metadata: 0x00AFC2A8 */) => default; // 0x000000018474E1A0-0x000000018474E4A0
	// [XID] // 0x00000001898F31E0-0x00000001898F3200
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2A9 */, bool useObjectPool = false /* Metadata: 0x00AFC2AD */) => default; // 0x000000018474CB60-0x000000018474D230
	// [XID] // 0x00000001898FA8C0-0x00000001898FA8E0
	public static ConfigBaseWidget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2AE */, bool useObjectPool = false /* Metadata: 0x00AFC2B2 */) => default; // 0x000000018474DA60-0x000000018474DC30
	[BlackList] // 0x0000000189902480-0x00000001899024C0
	// [XID] // 0x0000000189902480-0x00000001899024C0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018474C3B0-0x000000018474C680
	// [XID] // 0x000000018990CC50-0x000000018990CC70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018474EB90-0x000000018474F2C0
	[BlackList] // 0x0000000189914380-0x00000001899143C0
	// [XID] // 0x0000000189914380-0x00000001899143C0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018474E0B0-0x000000018474E1A0
	[BlackList] // 0x000000018991EC80-0x000000018991ECC0
	// [XID] // 0x000000018991EC80-0x000000018991ECC0
	public virtual void AutoAllocTypeFields() {} // 0x000000018474C760-0x000000018474C800
	[BlackList] // 0x0000000189929660-0x00000001899296A0
	// [XID] // 0x0000000189929660-0x00000001899296A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018474C800-0x000000018474C920
	[BlackList] // 0x00000001899339A0-0x00000001899339E0
	// [XID] // 0x00000001899339A0-0x00000001899339E0
	public virtual void ReturnToObjectPool() {} // 0x000000018474F690-0x000000018474F730
	[BlackList] // 0x000000018993E3B0-0x000000018993E3F0
	// [XID] // 0x000000018993E3B0-0x000000018993E3F0
	public virtual void OnPoolAllocated() {} // 0x000000018474F540-0x000000018474F5E0
	[BlackList] // 0x0000000189948880-0x00000001899488C0
	// [XID] // 0x0000000189948880-0x00000001899488C0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018474F4A0-0x000000018474F540
}

