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
public class ConfigBaseStateLayer : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19035
{
	// Fields
	private SimpleSafeInt32 layerIndexRawNum; // 0x10
	private string _layerIndexName; // 0x18
	protected Dictionary<int, ConfigBaseStateIDInfo> _stateHashIDs; // 0x20

	// Properties
	public int layerIndex { /* [XID] */ /* 0x0000000189795080-0x00000001897950A0 */ get => default; /* [XID] */ /* 0x000000018979D490-0x000000018979D4B0 */ private set {} } // 0x0000000182FDCD10-0x0000000182FDCDE0 0x0000000182FDB3D0-0x0000000182FDB4B0
	public string layerIndexName { /* [XID] */ /* 0x0000000189A44A40-0x0000000189A44A60 */ get => default; /* [XID] */ /* 0x00000001897ABCA0-0x00000001897ABCC0 */ private set {} } // 0x0000000182FDBC60-0x0000000182FDBD00 0x0000000182FDD2A0-0x0000000182FDD350

	// Constructors
	public ConfigBaseStateLayer() {} // 0x0000000182FDD4E0-0x0000000182FDD570

	// Methods
	// [XID] // 0x00000001897B3C70-0x00000001897B3C90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182FDD050-0x0000000182FDD160
	// [XID] // 0x00000001897BBA50-0x00000001897BBA70
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182FDCC40-0x0000000182FDCD10
	// [XID] // 0x00000001897C32D0-0x00000001897C32F0
	public virtual ConfigBaseStateLayer Clone(bool useObjectPool = false /* Metadata: 0x00AFB839 */) => default; // 0x0000000182FDC960-0x0000000182FDCA40
	// [XID] // 0x00000001897CAA90-0x00000001897CAAB0
	public virtual int GetHashNum() => default; // 0x0000000182FDB8F0-0x0000000182FDB9C0
	// [XID] // 0x00000001897D2090-0x00000001897D20B0
	public virtual void InitEmpty() {} // 0x0000000182FDC3C0-0x0000000182FDC4C0
	[BlackList] // 0x00000001897D9F10-0x00000001897D9F50
	// [XID] // 0x00000001897D9F10-0x00000001897D9F50
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000182FDBD00-0x0000000182FDC080
	// [XID] // 0x00000001897E42B0-0x00000001897E42D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182FDB0F0-0x0000000182FDB3D0
	[BlackList] // 0x00000001897EBE00-0x00000001897EBE40
	// [XID] // 0x00000001897EBE00-0x00000001897EBE40
	public static ConfigBaseStateLayer ParseFromJson(JSONNode node) => default; // 0x0000000182FDCA40-0x0000000182FDCC40
	// [XID] // 0x00000001897F6420-0x00000001897F6440
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB83A */, bool useObjectPool = false /* Metadata: 0x00AFB83E */) => default; // 0x0000000182FDC5B0-0x0000000182FDC8B0
	// [XID] // 0x00000001897FDB00-0x00000001897FDB20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB83F */, bool useObjectPool = false /* Metadata: 0x00AFB843 */) => default; // 0x0000000182FDB9C0-0x0000000182FDBC60
	// [XID] // 0x00000001898052B0-0x00000001898052D0
	public static ConfigBaseStateLayer ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB844 */, bool useObjectPool = false /* Metadata: 0x00AFB848 */) => default; // 0x0000000182FDC150-0x0000000182FDC320
	[BlackList] // 0x000000018980C870-0x000000018980C8B0
	// [XID] // 0x000000018980C870-0x000000018980C8B0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FDB4B0-0x0000000182FDB780
	// [XID] // 0x00000001898171E0-0x0000000189817200
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182FDCDE0-0x0000000182FDD050
	[BlackList] // 0x000000018981EB20-0x000000018981EB60
	// [XID] // 0x000000018981EB20-0x000000018981EB60
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182FDC4C0-0x0000000182FDC5B0
	[BlackList] // 0x0000000189829170-0x00000001898291B0
	// [XID] // 0x0000000189829170-0x00000001898291B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182FDB780-0x0000000182FDB820
	[BlackList] // 0x0000000189833840-0x0000000189833880
	// [XID] // 0x0000000189833840-0x0000000189833880
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182FDB820-0x0000000182FDB8F0
	[BlackList] // 0x000000018983DAE0-0x000000018983DB20
	// [XID] // 0x000000018983DAE0-0x000000018983DB20
	public virtual void ReturnToObjectPool() {} // 0x0000000182FDD440-0x0000000182FDD4E0
	[BlackList] // 0x0000000189848020-0x0000000189848060
	// [XID] // 0x0000000189848020-0x0000000189848060
	public virtual void OnPoolAllocated() {} // 0x0000000182FDD200-0x0000000182FDD2A0
	[BlackList] // 0x0000000189852340-0x0000000189852380
	// [XID] // 0x0000000189852340-0x0000000189852380
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182FDD160-0x0000000182FDD200
	// [XID] // 0x000000018985C8F0-0x000000018985C910
	public virtual void GetContainerAnimatorStates(Action<int, string, Dictionary<string, string[]>> func) {} // 0x0000000182FDC8B0-0x0000000182FDC960
	// [XID] // 0x00000001899701E0-0x0000000189970200
	public virtual void InitLayer() {} // 0x0000000182FDC320-0x0000000182FDC3C0
	// [XID] // 0x000000018986B5C0-0x000000018986B5E0
	public bool HasStateID(int id) => default; // 0x0000000182FDC080-0x0000000182FDC150
	// [XID] // 0x0000000189872990-0x00000001898729B0
	public ConfigBaseStateIDInfo GetStateID(int id) => default; // 0x0000000182FDD350-0x0000000182FDD440
}

