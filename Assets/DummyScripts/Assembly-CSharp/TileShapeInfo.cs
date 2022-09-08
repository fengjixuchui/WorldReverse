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
public class TileShapeInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14584
{
	// Constructors
	public TileShapeInfo() {} // 0x0000000183AFDE40-0x0000000183AFDEA0

	// Methods
	// [XID] // 0x0000000189AD6A90-0x0000000189AD6AB0
	public virtual Bounds GetBounds(Vector3 pos, Quaternion rotate) => default; // 0x0000000183AFD700-0x0000000183AFD850
	// [XID] // 0x0000000189ADE2C0-0x0000000189ADE2E0
	public virtual bool IsCapsuleInShape(Vector3 selfPos, Quaternion selfRotate, Vector3 targetCenter, float targetRadius, float targetHeight) => default; // 0x0000000183AFCB00-0x0000000183AFCC40
	// [XID] // 0x0000000189AE5D80-0x0000000189AE5DA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AFDBB0-0x0000000183AFDC60
	// [XID] // 0x0000000189AED170-0x0000000189AED190
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183AFDA50-0x0000000183AFDB00
	// [XID] // 0x0000000189AF4C00-0x0000000189AF4C20
	public virtual TileShapeInfo Clone(bool useObjectPool = false /* Metadata: 0x00AEB91B */) => default; // 0x0000000183AFD620-0x0000000183AFD700
	// [XID] // 0x0000000189AFC180-0x0000000189AFC1A0
	public virtual int GetHashNum() => default; // 0x0000000183AFC950-0x0000000183AFCA20
	// [XID] // 0x0000000189B03AF0-0x0000000189B03B10
	public virtual void InitEmpty() {} // 0x0000000183AFD190-0x0000000183AFD230
	[BlackList] // 0x0000000189B0B140-0x0000000189B0B180
	// [XID] // 0x0000000189B0B140-0x0000000189B0B180
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183AFCC40-0x0000000183AFCFC0
	// [XID] // 0x0000000189B154B0-0x0000000189B154D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AFC490-0x0000000183AFC540
	[BlackList] // 0x0000000189B1CF30-0x0000000189B1CF70
	// [XID] // 0x0000000189B1CF30-0x0000000189B1CF70
	public static TileShapeInfo ParseFromJson(JSONNode node) => default; // 0x0000000183AFD850-0x0000000183AFDA50
	// [XID] // 0x0000000189B27440-0x0000000189B27460
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEB91C */, bool useObjectPool = false /* Metadata: 0x00AEB920 */) => default; // 0x0000000183AFD320-0x0000000183AFD620
	// [XID] // 0x0000000189B2E600-0x0000000189B2E620
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEB921 */, bool useObjectPool = false /* Metadata: 0x00AEB925 */) => default; // 0x0000000183AFCA20-0x0000000183AFCB00
	// [XID] // 0x0000000189B35CB0-0x0000000189B35CD0
	public static TileShapeInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEB926 */, bool useObjectPool = false /* Metadata: 0x00AEB92A */) => default; // 0x0000000183AFCFC0-0x0000000183AFD190
	[BlackList] // 0x0000000189B3D3C0-0x0000000189B3D400
	// [XID] // 0x0000000189B3D3C0-0x0000000189B3D400
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AFC540-0x0000000183AFC810
	// [XID] // 0x0000000189B48170-0x0000000189B48190
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AFDB00-0x0000000183AFDBB0
	[BlackList] // 0x0000000189B4F910-0x0000000189B4F950
	// [XID] // 0x0000000189B4F910-0x0000000189B4F950
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183AFD230-0x0000000183AFD320
	[BlackList] // 0x0000000189B5A100-0x0000000189B5A140
	// [XID] // 0x0000000189B5A100-0x0000000189B5A140
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AFC810-0x0000000183AFC8B0
	[BlackList] // 0x0000000189B64910-0x0000000189B64950
	// [XID] // 0x0000000189B64910-0x0000000189B64950
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AFC8B0-0x0000000183AFC950
	[BlackList] // 0x0000000189B6ED10-0x0000000189B6ED50
	// [XID] // 0x0000000189B6ED10-0x0000000189B6ED50
	public virtual void ReturnToObjectPool() {} // 0x0000000183AFDDA0-0x0000000183AFDE40
	[BlackList] // 0x0000000189B79410-0x0000000189B79450
	// [XID] // 0x0000000189B79410-0x0000000189B79450
	public virtual void OnPoolAllocated() {} // 0x0000000183AFDD00-0x0000000183AFDDA0
	[BlackList] // 0x0000000189B83D60-0x0000000189B83DA0
	// [XID] // 0x0000000189B83D60-0x0000000189B83DA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AFDC60-0x0000000183AFDD00
}

