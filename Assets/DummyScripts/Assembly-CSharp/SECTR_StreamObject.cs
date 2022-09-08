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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class SECTR_StreamObject : IEmptyInitable, IHashable, IAutoAllocRecycle, ISerializationCallbackReceiver, IReusable // TypeDefIndex: 18971
{
	// Fields
	private SECTR_StreamObjectType _type; // 0x10
	private ulong _gameObjectPathHash; // 0x18
	private string _objPatternName; // 0x20
	private SimpleSafeFloat magitudeRawNum; // 0x28
	private MoleMole.Config.Vector _position; // 0x2C
	private MoleMole.Config.Vector _rotation; // 0x38
	private MoleMole.Config.Vector _scale; // 0x44

	// Properties
	public SECTR_StreamObjectType type { /* [XID] */ /* 0x0000000189891800-0x0000000189891820 */ get => default; /* [XID] */ /* 0x0000000189899170-0x0000000189899190 */ set {} } // 0x00000001821C62A0-0x00000001821C6340 0x00000001821C58C0-0x00000001821C5970
	public ulong gameObjectPathHash { /* [XID] */ /* 0x00000001898A0310-0x00000001898A0330 */ get => default; /* [XID] */ /* 0x00000001898A7A70-0x00000001898A7A90 */ set {} } // 0x00000001821C52B0-0x00000001821C5350 0x00000001821C5650-0x00000001821C5700
	public string objPatternName { /* [XID] */ /* 0x00000001898AF630-0x00000001898AF650 */ get => default; /* [XID] */ /* 0x00000001898B6A10-0x00000001898B6A30 */ set {} } // 0x00000001821C4F20-0x00000001821C4FC0 0x00000001821C4940-0x00000001821C49F0
	public float magitude { /* [XID] */ /* 0x00000001898BE1E0-0x00000001898BE200 */ get => default; /* [XID] */ /* 0x00000001898C5AD0-0x00000001898C5AF0 */ set {} } // 0x00000001821C4FC0-0x00000001821C50A0 0x00000001821C42F0-0x00000001821C43D0
	public MoleMole.Config.Vector position { /* [XID] */ /* 0x00000001898CD1E0-0x00000001898CD200 */ get => default; /* [XID] */ /* 0x00000001898D4AF0-0x00000001898D4B10 */ set {} } // 0x00000001821C5700-0x00000001821C57E0 0x00000001821C51E0-0x00000001821C52B0
	public MoleMole.Config.Vector rotation { /* [XID] */ /* 0x00000001898DC4F0-0x00000001898DC510 */ get => default; /* [XID] */ /* 0x00000001898E3F80-0x00000001898E3FA0 */ set {} } // 0x00000001821C57E0-0x00000001821C58C0 0x00000001821C4D70-0x00000001821C4E40
	public MoleMole.Config.Vector scale { /* [XID] */ /* 0x00000001898EBA30-0x00000001898EBA50 */ get => default; /* [XID] */ /* 0x00000001898F3200-0x00000001898F3220 */ set {} } // 0x00000001821C4E40-0x00000001821C4F20 0x00000001821C6340-0x00000001821C6410

	// Nested types
	public class Spawner : ISpawner<SECTR_StreamObject> // TypeDefIndex: 18972
	{
		// Constructors
		public Spawner() {} // 0x00000001821B5CC0-0x00000001821B5D20

		// Methods
		// [XID] // 0x0000000189987630-0x0000000189987650
		public SECTR_StreamObject Spawn() => default; // 0x00000001821B5BC0-0x00000001821B5CC0
	}

	// Constructors
	public SECTR_StreamObject() {} // 0x00000001821C64B0-0x00000001821C6510

	// Methods
	// [XID] // 0x00000001898FA900-0x00000001898FA920
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001821C5F20-0x00000001821C5FD0
	// [XID] // 0x0000000189902500-0x0000000189902520
	public void InitEmpty() {} // 0x00000001821C50A0-0x00000001821C51E0
	[BlackList] // 0x0000000189909A60-0x0000000189909AA0
	// [XID] // 0x0000000189909A60-0x0000000189909AA0
	public bool FromJson(JSONNode node) => default; // 0x00000001821C49F0-0x00000001821C4D70
	// [XID] // 0x00000001899143E0-0x0000000189914400
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001821C36A0-0x00000001821C3DD0
	// [XID] // 0x000000018991BEE0-0x000000018991BF00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5F3 */, bool useObjectPool = false /* Metadata: 0x00AFB5F7 */) => default; // 0x00000001821C5350-0x00000001821C5650
	// [XID] // 0x0000000189923620-0x0000000189923640
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5F8 */, bool useObjectPool = false /* Metadata: 0x00AFB5FC */) => default; // 0x00000001821C43D0-0x00000001821C4940
	[BlackList] // 0x000000018992AC60-0x000000018992ACA0
	// [XID] // 0x000000018992AC60-0x000000018992ACA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001821C3DD0-0x00000001821C40A0
	// [XID] // 0x0000000189935070-0x0000000189935090
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001821C5970-0x00000001821C5F20
	[BlackList] // 0x000000018993CC30-0x000000018993CC70
	// [XID] // 0x000000018993CC30-0x000000018993CC70
	public virtual void AutoAllocTypeFields() {} // 0x00000001821C40A0-0x00000001821C4140
	[BlackList] // 0x00000001899471C0-0x0000000189947200
	// [XID] // 0x00000001899471C0-0x0000000189947200
	public virtual void AutoRecycleTypeFields() {} // 0x00000001821C4140-0x00000001821C4250
	[BlackList] // 0x0000000189951AD0-0x0000000189951B10
	// [XID] // 0x0000000189951AD0-0x0000000189951B10
	public virtual void ReturnToObjectPool() {} // 0x00000001821C6410-0x00000001821C64B0
	[BlackList] // 0x000000018995BEA0-0x000000018995BEE0
	// [XID] // 0x000000018995BEA0-0x000000018995BEE0
	public virtual void OnPoolAllocated() {} // 0x00000001821C6200-0x00000001821C62A0
	[BlackList] // 0x0000000189966890-0x00000001899668D0
	// [XID] // 0x0000000189966890-0x00000001899668D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001821C60C0-0x00000001821C6160
	// [XID] // 0x0000000189971380-0x00000001899713A0
	public void OnBeforeSerialize() {} // 0x00000001821C6160-0x00000001821C6200
	// [XID] // 0x0000000189978D70-0x0000000189978D90
	public void OnAfterDeserialize() {} // 0x00000001821C5FD0-0x00000001821C60C0
	// [XID] // 0x000000018997FE40-0x000000018997FE60
	public void BeforeRecycle() {} // 0x00000001821C4250-0x00000001821C42F0
}

