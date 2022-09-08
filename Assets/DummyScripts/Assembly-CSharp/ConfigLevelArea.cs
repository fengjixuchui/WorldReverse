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
public class ConfigLevelArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14968
{
	// Fields
	private SimpleSafeUInt32 idRawNum; // 0x10
	private SimpleSafeUInt32 levelRawNum; // 0x14
	private SimpleSafeUInt32 priorityRawNum; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPolygonArea _polygonData; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x000000018965B570-0x000000018965B590 */ get => default; /* [XID] */ /* 0x00000001896629C0-0x00000001896629E0 */ private set {} } // 0x000000018373C650-0x000000018373C720 0x000000018373B860-0x000000018373B940
	public uint level { /* [XID] */ /* 0x00000001897ACC60-0x00000001897ACC80 */ get => default; /* [XID] */ /* 0x0000000189672160-0x0000000189672180 */ private set {} } // 0x000000018373BD20-0x000000018373BDF0 0x000000018373BC40-0x000000018373BD20
	public uint priority { /* [XID] */ /* 0x00000001896799F0-0x0000000189679A10 */ get => default; /* [XID] */ /* 0x0000000189681100-0x0000000189681120 */ private set {} } // 0x000000018373BDF0-0x000000018373BEC0 0x000000018373B2E0-0x000000018373B3C0
	public ConfigPolygonArea polygonData { /* [XID] */ /* 0x0000000189688BA0-0x0000000189688BC0 */ get => default; /* [XID] */ /* 0x0000000189690660-0x0000000189690680 */ private set {} } // 0x000000018373AD60-0x000000018373AE00 0x000000018373B230-0x000000018373B2E0

	// Constructors
	public ConfigLevelArea() {} // 0x000000018373C7C0-0x000000018373C820

	// Methods
	// [XID] // 0x0000000189653C60-0x0000000189653C80
	public bool IsInArea(Vector3 worldPosition) => default; // 0x000000018373BEC0-0x000000018373BFC0
	// [XID] // 0x0000000189697EC0-0x0000000189697EE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018373C3C0-0x000000018373C510
	// [XID] // 0x000000018969F1D0-0x000000018969F1F0
	public void InitEmpty() {} // 0x000000018373B740-0x000000018373B860
	[BlackList] // 0x00000001896A6630-0x00000001896A6670
	// [XID] // 0x00000001896A6630-0x00000001896A6670
	public bool FromJson(JSONNode node) => default; // 0x000000018373B3C0-0x000000018373B740
	// [XID] // 0x00000001896B0790-0x00000001896B07B0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018373A340-0x000000018373A870
	// [XID] // 0x00000001896B8190-0x00000001896B81B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCA6 */, bool useObjectPool = false /* Metadata: 0x00AEFCAA */) => default; // 0x000000018373B940-0x000000018373BC40
	// [XID] // 0x00000001896BF250-0x00000001896BF270
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCAB */, bool useObjectPool = false /* Metadata: 0x00AEFCAF */) => default; // 0x000000018373AE00-0x000000018373B230
	[BlackList] // 0x00000001896C6B70-0x00000001896C6BB0
	// [XID] // 0x00000001896C6B70-0x00000001896C6BB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018373A870-0x000000018373AB40
	// [XID] // 0x00000001896D0F60-0x00000001896D0F80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018373BFC0-0x000000018373C3C0
	[BlackList] // 0x00000001896D8690-0x00000001896D86D0
	// [XID] // 0x00000001896D8690-0x00000001896D86D0
	public virtual void AutoAllocTypeFields() {} // 0x000000018373AB40-0x000000018373ABE0
	[BlackList] // 0x00000001896E2D40-0x00000001896E2D80
	// [XID] // 0x00000001896E2D40-0x00000001896E2D80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018373ABE0-0x000000018373AD60
	[BlackList] // 0x00000001896ED000-0x00000001896ED040
	// [XID] // 0x00000001896ED000-0x00000001896ED040
	public virtual void ReturnToObjectPool() {} // 0x000000018373C720-0x000000018373C7C0
	[BlackList] // 0x00000001896F77D0-0x00000001896F7810
	// [XID] // 0x00000001896F77D0-0x00000001896F7810
	public virtual void OnPoolAllocated() {} // 0x000000018373C5B0-0x000000018373C650
	[BlackList] // 0x0000000189701E60-0x0000000189701EA0
	// [XID] // 0x0000000189701E60-0x0000000189701EA0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018373C510-0x000000018373C5B0
}

