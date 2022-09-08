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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigShapeCircle : ConfigBaseShape, IAutoAllocRecycle // TypeDefIndex: 18984
{
	// Fields
	private SimpleSafeFloat radiusRawNum; // 0x20

	// Properties
	public float radius { /* [XID] */ /* 0x00000001897A15A0-0x00000001897A15C0 */ get => default; /* [XID] */ /* 0x00000001897A8EA0-0x00000001897A8EC0 */ private set {} } // 0x00000001816316E0-0x00000001816317C0 0x0000000181631AB0-0x0000000181631B90

	// Constructors
	public ConfigShapeCircle() {} // 0x0000000181631C30-0x0000000181631C90

	// Methods
	// [XID] // 0x00000001897B0740-0x00000001897B0760
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001816319B0-0x0000000181631AB0
	// [XID] // 0x00000001897B84C0-0x00000001897B84E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181631630-0x00000001816316E0
	// [XID] // 0x00000001897C05A0-0x00000001897C05C0
	public override ConfigBaseShape Clone(bool useObjectPool = false /* Metadata: 0x00AFB64F */) => default; // 0x0000000181631240-0x0000000181631320
	// [XID] // 0x00000001897C7E30-0x00000001897C7E50
	public override int GetHashNum() => default; // 0x000000018162FE60-0x000000018162FF30
	// [XID] // 0x00000001897CF110-0x00000001897CF130
	public override void InitEmpty() {} // 0x0000000181630CA0-0x0000000181630D70
	[BlackList] // 0x00000001897D6920-0x00000001897D6960
	// [XID] // 0x00000001897D6920-0x00000001897D6960
	public override bool FromJson(JSONNode node) => default; // 0x0000000181630380-0x0000000181630700
	// [XID] // 0x00000001897E1240-0x00000001897E1260
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018162F680-0x000000018162F8F0
	[BlackList] // 0x00000001897E8AF0-0x00000001897E8B30
	// [XID] // 0x00000001897E8AF0-0x00000001897E8B30
	public static new ConfigShapeCircle ParseFromJson(JSONNode node) => default; // 0x0000000181631380-0x00000001816315D0
	// [XID] // 0x00000001897F3770-0x00000001897F3790
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB650 */, bool useObjectPool = false /* Metadata: 0x00AFB654 */) => default; // 0x0000000181630F40-0x0000000181631240
	// [XID] // 0x00000001897FB130-0x00000001897FB150
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB655 */, bool useObjectPool = false /* Metadata: 0x00AFB659 */) => default; // 0x0000000181630010-0x0000000181630280
	// [XID] // 0x0000000189802540-0x0000000189802560
	public static new ConfigShapeCircle ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB65A */, bool useObjectPool = false /* Metadata: 0x00AFB65E */) => default; // 0x00000001816307F0-0x0000000181630A10
	[BlackList] // 0x0000000189809A10-0x0000000189809A50
	// [XID] // 0x0000000189809A10-0x0000000189809A50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018162F8F0-0x000000018162FBC0
	// [XID] // 0x0000000189814010-0x0000000189814030
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001816317C0-0x00000001816319B0
	[BlackList] // 0x000000018981BBE0-0x000000018981BC20
	// [XID] // 0x000000018981BBE0-0x000000018981BC20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181630E50-0x0000000181630F40
	[BlackList] // 0x0000000189826050-0x0000000189826090
	// [XID] // 0x0000000189826050-0x0000000189826090
	public override void AutoAllocTypeFields() {} // 0x000000018162FBC0-0x000000018162FC60
	[BlackList] // 0x0000000189830720-0x0000000189830760
	// [XID] // 0x0000000189830720-0x0000000189830760
	public override void AutoRecycleTypeFields() {} // 0x000000018162FC60-0x000000018162FD40
	[BlackList] // 0x000000018983AD60-0x000000018983ADA0
	// [XID] // 0x000000018983AD60-0x000000018983ADA0
	public override void ReturnToObjectPool() {} // 0x0000000181631B90-0x0000000181631C30
	// [XID] // 0x00000001898452F0-0x0000000189845310
	public override BaseShape CreateShape(Vector3 position, Vector3 direction, bool useHeight, float height, float sizeRatio) => default; // 0x0000000181630A10-0x0000000181630C30
}

