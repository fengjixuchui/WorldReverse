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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class SelectActionPointByAllAvatarsOrientation : ConfigActionPointSelectType, IAutoAllocRecycle // TypeDefIndex: 17893
{
	// Fields
	private SimpleSafeUInt32[] _actionPointIDs; // 0x10
	private SimpleSafeFloat angleRawNum; // 0x18
	private SimpleSafeFloat distanceRawNum; // 0x1C
	private bool _signType; // 0x20
	public static Action<SelectActionPointByAllAvatarsOrientation, bool> postProcessData; // 0x00
	public static Action<SelectActionPointByAllAvatarsOrientation> postInitEmpty; // 0x08
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private HashSet<uint> actionPointIdSet; // 0x28

	// Properties
	public SimpleSafeUInt32[] actionPointIDs { /* [XID] */ /* 0x0000000189872B30-0x0000000189872B50 */ get => default; /* [XID] */ /* 0x000000018987A830-0x000000018987A850 */ private set {} } // 0x00000001844E57B0-0x00000001844E5850 0x00000001844E4F50-0x00000001844E5000
	public float angle { /* [XID] */ /* 0x0000000189881980-0x00000001898819A0 */ get => default; /* [XID] */ /* 0x0000000189889000-0x0000000189889020 */ private set {} } // 0x00000001844E5060-0x00000001844E5140 0x00000001844E6C70-0x00000001844E6D50
	public float distance { /* [XID] */ /* 0x0000000189890320-0x0000000189890340 */ get => default; /* [XID] */ /* 0x0000000189897860-0x0000000189897880 */ private set {} } // 0x00000001844E4320-0x00000001844E4400 0x00000001844E78A0-0x00000001844E7980
	public bool signType { /* [XID] */ /* 0x000000018989ED00-0x000000018989ED20 */ get => default; /* [XID] */ /* 0x00000001898A6780-0x00000001898A67A0 */ private set {} } // 0x00000001844E7800-0x00000001844E78A0 0x00000001844E6E50-0x00000001844E6F00

	// Constructors
	public SelectActionPointByAllAvatarsOrientation() {} // 0x00000001844E86C0-0x00000001844E8780
	static SelectActionPointByAllAvatarsOrientation() {} // 0x00000001844E84E0-0x00000001844E86C0

	// Methods
	// [XID] // 0x00000001898ADF10-0x00000001898ADF30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844E80F0-0x00000001844E8240
	// [XID] // 0x00000001898B53F0-0x00000001898B5410
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001844E7C30-0x00000001844E7D10
	// [XID] // 0x00000001898BCE60-0x00000001898BCE80
	public override ConfigActionPointSelectType Clone(bool useObjectPool = false /* Metadata: 0x00AF8069 */) => default; // 0x00000001844E76C0-0x00000001844E77A0
	// [XID] // 0x00000001898C45E0-0x00000001898C4600
	public override int GetHashNum() => default; // 0x00000001844E4E80-0x00000001844E4F50
	// [XID] // 0x00000001898CBC10-0x00000001898CBC30
	public override void InitEmpty() {} // 0x00000001844E6FD0-0x00000001844E7170
	[BlackList] // 0x00000001898D3430-0x00000001898D3470
	// [XID] // 0x00000001898D3430-0x00000001898D3470
	public override bool FromJson(JSONNode node) => default; // 0x00000001844E58D0-0x00000001844E5CD0
	// [XID] // 0x00000001898DE280-0x00000001898DE2A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001844E4400-0x00000001844E4900
	[BlackList] // 0x00000001898E5A40-0x00000001898E5A80
	// [XID] // 0x00000001898E5A40-0x00000001898E5A80
	public static new SelectActionPointByAllAvatarsOrientation ParseFromJson(JSONNode node) => default; // 0x00000001844E7980-0x00000001844E7BD0
	// [XID] // 0x00000001898F0320-0x00000001898F0340
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF806A */, bool useObjectPool = false /* Metadata: 0x00AF806E */) => default; // 0x00000001844E7340-0x00000001844E76C0
	// [XID] // 0x00000001898F7DD0-0x00000001898F7DF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF806F */, bool useObjectPool = false /* Metadata: 0x00AF8073 */) => default; // 0x00000001844E5360-0x00000001844E5730
	// [XID] // 0x00000001898FF470-0x00000001898FF490
	public static new SelectActionPointByAllAvatarsOrientation ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8074 */, bool useObjectPool = false /* Metadata: 0x00AF8078 */) => default; // 0x00000001844E69F0-0x00000001844E6C10
	[BlackList] // 0x0000000189906BD0-0x0000000189906C10
	// [XID] // 0x0000000189906BD0-0x0000000189906C10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001844E4900-0x00000001844E4BD0
	// [XID] // 0x0000000189911380-0x00000001899113A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001844E7D10-0x00000001844E80F0
	[BlackList] // 0x0000000189918F60-0x0000000189918FA0
	// [XID] // 0x0000000189918F60-0x0000000189918FA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001844E7250-0x00000001844E7340
	// [XID] // 0x00000001899237C0-0x00000001899237E0
	public override void OnPoolAllocated() {} // 0x00000001844E8340-0x00000001844E83E0
	// [XID] // 0x000000018992AE80-0x000000018992AEA0
	public override void OnBeforePoolRecycled() {} // 0x00000001844E8240-0x00000001844E8340
	// [XID] // 0x00000001899324C0-0x00000001899324E0
	private static void OnPostInitEmpty(SelectActionPointByAllAvatarsOrientation data) {} // 0x00000001844E6F00-0x00000001844E6FD0
	// [XID] // 0x0000000189939F10-0x0000000189939F30
	private static void OnPostProcessData(SelectActionPointByAllAvatarsOrientation data, bool usePool) {} // 0x00000001844E5140-0x00000001844E52E0
	// [XID] // 0x0000000189941100-0x0000000189941120
	public override LevelActionPoint GetActionPoint(ActionPointType actionPointType, BaseEntity targetEntity, BaseEntity selfEntity) => default; // 0x00000001844E5CD0-0x00000001844E69F0
	[BlackList] // 0x0000000189948BC0-0x0000000189948C00
	// [XID] // 0x0000000189948BC0-0x0000000189948C00
	public override void AutoAllocTypeFields() {} // 0x00000001844E4BD0-0x00000001844E4C70
	[BlackList] // 0x00000001899531F0-0x0000000189953230
	// [XID] // 0x00000001899531F0-0x0000000189953230
	public override void AutoRecycleTypeFields() {} // 0x00000001844E4C70-0x00000001844E4D60
	[BlackList] // 0x000000018995DAF0-0x000000018995DB30
	// [XID] // 0x000000018995DAF0-0x000000018995DB30
	public override void ReturnToObjectPool() {} // 0x00000001844E8440-0x00000001844E84E0
}

