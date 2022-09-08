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
public class ElementTypeModifier : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16984
{
	// Fields
	private ElementType _elementType; // 0x10

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189653920-0x0000000189653940 */ get => default; /* [XID] */ /* 0x000000018965B1D0-0x000000018965B1F0 */ private set {} } // 0x00000001849614D0-0x0000000184961570 0x0000000184961C90-0x0000000184961D40

	// Constructors
	public ElementTypeModifier() {} // 0x00000001849621B0-0x0000000184962210

	// Methods
	// [XID] // 0x00000001896626A0-0x00000001896626C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184961EF0-0x0000000184961FD0
	// [XID] // 0x000000018966A240-0x000000018966A260
	public void InitEmpty() {} // 0x00000001849618F0-0x0000000184961990
	[BlackList] // 0x0000000189671E80-0x0000000189671EC0
	// [XID] // 0x0000000189671E80-0x0000000189671EC0
	public bool FromJson(JSONNode node) => default; // 0x0000000184961570-0x00000001849618F0
	// [XID] // 0x000000018967C540-0x000000018967C560
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184960D10-0x0000000184960EF0
	// [XID] // 0x0000000189683B70-0x0000000189683B90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F8B */, bool useObjectPool = false /* Metadata: 0x00AF5F8F */) => default; // 0x0000000184961990-0x0000000184961C90
	// [XID] // 0x000000018968B8B0-0x000000018968B8D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F90 */, bool useObjectPool = false /* Metadata: 0x00AF5F94 */) => default; // 0x0000000184961300-0x00000001849614D0
	[BlackList] // 0x00000001896933E0-0x0000000189693420
	// [XID] // 0x00000001896933E0-0x0000000189693420
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184960EF0-0x00000001849611C0
	// [XID] // 0x000000018969DA10-0x000000018969DA30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184961D40-0x0000000184961EF0
	[BlackList] // 0x00000001896A4A80-0x00000001896A4AC0
	// [XID] // 0x00000001896A4A80-0x00000001896A4AC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001849611C0-0x0000000184961260
	[BlackList] // 0x00000001896AEF70-0x00000001896AEFB0
	// [XID] // 0x00000001896AEF70-0x00000001896AEFB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184961260-0x0000000184961300
	[BlackList] // 0x00000001896B9350-0x00000001896B9390
	// [XID] // 0x00000001896B9350-0x00000001896B9390
	public virtual void ReturnToObjectPool() {} // 0x0000000184962110-0x00000001849621B0
	[BlackList] // 0x00000001896C36A0-0x00000001896C36E0
	// [XID] // 0x00000001896C36A0-0x00000001896C36E0
	public virtual void OnPoolAllocated() {} // 0x0000000184962070-0x0000000184962110
	[BlackList] // 0x00000001896CDDD0-0x00000001896CDE10
	// [XID] // 0x00000001896CDDD0-0x00000001896CDE10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184961FD0-0x0000000184962070
}

