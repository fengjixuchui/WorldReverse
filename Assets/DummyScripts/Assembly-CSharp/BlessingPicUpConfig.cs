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
public class BlessingPicUpConfig : IAutoAllocRecycle // TypeDefIndex: 15029
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 probRawNum; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896BB010-0x00000001896BB030 */ get => default; /* [XID] */ /* 0x00000001896C2180-0x00000001896C21A0 */ protected set {} } // 0x00000001843E9350-0x00000001843E9420 0x00000001843E8CF0-0x00000001843E8DD0
	public uint prob { /* [XID] */ /* 0x00000001896C9790-0x00000001896C97B0 */ get => default; /* [XID] */ /* 0x00000001896D0F40-0x00000001896D0F60 */ protected set {} } // 0x00000001843E8A00-0x00000001843E8AD0 0x00000001843E9130-0x00000001843E9210

	// Constructors
	public BlessingPicUpConfig() {} // 0x00000001843E94C0-0x00000001843E9520

	// Methods
	// [XID] // 0x00000001896D8670-0x00000001896D8690
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843E8AD0-0x00000001843E8CF0
	// [XID] // 0x00000001896E0020-0x00000001896E0040
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEE1 */, bool useObjectPool = false /* Metadata: 0x00AEFEE5 */) => default; // 0x00000001843E8DD0-0x00000001843E9130
	[BlackList] // 0x00000001896E7260-0x00000001896E72A0
	// [XID] // 0x00000001896E7260-0x00000001896E72A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001843E8880-0x00000001843E8920
	[BlackList] // 0x00000001896F1320-0x00000001896F1360
	// [XID] // 0x00000001896F1320-0x00000001896F1360
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843E8920-0x00000001843E8A00
	[BlackList] // 0x00000001896FC030-0x00000001896FC070
	// [XID] // 0x00000001896FC030-0x00000001896FC070
	public virtual void ReturnToObjectPool() {} // 0x00000001843E9420-0x00000001843E94C0
	[BlackList] // 0x0000000189706480-0x00000001897064C0
	// [XID] // 0x0000000189706480-0x00000001897064C0
	public virtual void OnPoolAllocated() {} // 0x00000001843E92B0-0x00000001843E9350
	[BlackList] // 0x0000000189710FB0-0x0000000189710FF0
	// [XID] // 0x0000000189710FB0-0x0000000189710FF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843E9210-0x00000001843E92B0
}

