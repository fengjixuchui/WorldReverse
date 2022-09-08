/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Dest.Math;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using MoleMole.Config;
using SimpleJSON;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigPolygonArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14967
{
	// Fields
	private Polygon2 _polygon; // 0x10
	private Edge2 _minDisEdge; // 0x18
	private MoleMole.Config.Vector _minArea; // 0x3C
	private MoleMole.Config.Vector _maxArea; // 0x48
	private MoleMole.Config.Vector[] _roadPoints; // 0x58

	// Properties
	public MoleMole.Config.Vector minArea { /* [XID] */ /* 0x0000000189B9C840-0x0000000189B9C860 */ get => default; /* [XID] */ /* 0x0000000189BA3F10-0x0000000189BA3F30 */ private set {} } // 0x0000000181B66D80-0x0000000181B66E60 0x0000000181B66E60-0x0000000181B66F30
	public MoleMole.Config.Vector maxArea { /* [XID] */ /* 0x0000000189BAB4C0-0x0000000189BAB4E0 */ get => default; /* [XID] */ /* 0x0000000189BB2AF0-0x0000000189BB2B10 */ private set {} } // 0x0000000181B659D0-0x0000000181B65AB0 0x0000000181B65E90-0x0000000181B65F60
	public MoleMole.Config.Vector[] roadPoints { /* [XID] */ /* 0x0000000189BB9EC0-0x0000000189BB9EE0 */ get => default; /* [XID] */ /* 0x0000000189BC1EF0-0x0000000189BC1F10 */ private set {} } // 0x0000000181B65DF0-0x0000000181B65E90 0x0000000181B669D0-0x0000000181B66A80

	// Constructors
	public ConfigPolygonArea() {} // 0x0000000181B678C0-0x0000000181B67930

	// Methods
	// [XID] // 0x0000000189B7EF60-0x0000000189B7EF80
	private void BuildPolygon() {} // 0x0000000181B662E0-0x0000000181B66500
	// [XID] // 0x0000000189B86B20-0x0000000189B86B40
	public bool IsInArea(Vector3 worldPosition, bool needResolveHeight = false /* Metadata: 0x00AEFC9B */) => default; // 0x0000000181B66F30-0x0000000181B671F0
	// [XID] // 0x0000000189B8DCB0-0x0000000189B8DCD0
	public float GetLimitRegionDis(Vector2 c) => default; // 0x0000000181B66500-0x0000000181B668D0
	// [XID] // 0x0000000189B95190-0x0000000189B951B0
	public Vector2 GetNearestDirection(Vector2 c) => default; // 0x0000000181B65250-0x0000000181B65560
	// [XID] // 0x0000000189BC93E0-0x0000000189BC9400
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B67580-0x0000000181B676E0
	// [XID] // 0x0000000189BD0BB0-0x0000000189BD0BD0
	public void InitEmpty() {} // 0x0000000181B668D0-0x0000000181B669D0
	[BlackList] // 0x0000000189BD8150-0x0000000189BD8190
	// [XID] // 0x0000000189BD8150-0x0000000189BD8190
	public bool FromJson(JSONNode node) => default; // 0x0000000181B65F60-0x0000000181B662E0
	// [XID] // 0x00000001895E7F10-0x00000001895E7F30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181B64EB0-0x0000000181B65250
	// [XID] // 0x00000001895EF8E0-0x00000001895EF900
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC9C */, bool useObjectPool = false /* Metadata: 0x00AEFCA0 */) => default; // 0x0000000181B66A80-0x0000000181B66D80
	// [XID] // 0x00000001895F71A0-0x00000001895F71C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCA1 */, bool useObjectPool = false /* Metadata: 0x00AEFCA5 */) => default; // 0x0000000181B65AB0-0x0000000181B65DF0
	[BlackList] // 0x00000001895FE5A0-0x00000001895FE5E0
	// [XID] // 0x00000001895FE5A0-0x00000001895FE5E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B65560-0x0000000181B65830
	// [XID] // 0x0000000189609050-0x0000000189609070
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B671F0-0x0000000181B67580
	[BlackList] // 0x0000000189610870-0x00000001896108B0
	// [XID] // 0x0000000189610870-0x00000001896108B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181B65830-0x0000000181B658D0
	[BlackList] // 0x000000018961AE20-0x000000018961AE60
	// [XID] // 0x000000018961AE20-0x000000018961AE60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181B658D0-0x0000000181B659D0
	[BlackList] // 0x00000001896252B0-0x00000001896252F0
	// [XID] // 0x00000001896252B0-0x00000001896252F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181B67820-0x0000000181B678C0
	[BlackList] // 0x000000018962FC60-0x000000018962FCA0
	// [XID] // 0x000000018962FC60-0x000000018962FCA0
	public virtual void OnPoolAllocated() {} // 0x0000000181B67780-0x0000000181B67820
	[BlackList] // 0x000000018963A630-0x000000018963A670
	// [XID] // 0x000000018963A630-0x000000018963A670
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181B676E0-0x0000000181B67780
}

