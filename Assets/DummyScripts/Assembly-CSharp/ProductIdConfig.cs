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
public class ProductIdConfig : IAutoAllocRecycle // TypeDefIndex: 16149
{
	// Fields
	protected string _productId; // 0x10
	protected SimpleSafeUInt32 configIdRawNum; // 0x18
	protected bool _isInternal; // 0x1C
	protected string _entitlementId; // 0x20

	// Properties
	public string productId { /* [XID] */ /* 0x00000001896A4C00-0x00000001896A4C20 */ get => default; /* [XID] */ /* 0x00000001896AC3F0-0x00000001896AC410 */ protected set {} } // 0x000000018560AAE0-0x000000018560AB80 0x0000000185609AA0-0x0000000185609B50
	public uint configId { /* [XID] */ /* 0x00000001896B36D0-0x00000001896B36F0 */ get => default; /* [XID] */ /* 0x00000001896BAE50-0x00000001896BAE70 */ protected set {} } // 0x000000018560A3E0-0x000000018560A4B0 0x000000018560AA00-0x000000018560AAE0
	public bool isInternal { /* [XID] */ /* 0x00000001896C1FC0-0x00000001896C1FE0 */ get => default; /* [XID] */ /* 0x00000001896C9570-0x00000001896C9590 */ protected set {} } // 0x000000018560AC30-0x000000018560ACD0 0x000000018560AB80-0x000000018560AC30
	public string entitlementId { /* [XID] */ /* 0x00000001896D0D60-0x00000001896D0D80 */ get => default; /* [XID] */ /* 0x00000001896D83D0-0x00000001896D83F0 */ protected set {} } // 0x000000018560A960-0x000000018560AA00 0x000000018560A330-0x000000018560A3E0

	// Constructors
	public ProductIdConfig() {} // 0x000000018560AEB0-0x000000018560AF10

	// Methods
	// [IDTag] // 0x00000001896DFD40-0x00000001896DFD80
	// [XID] // 0x00000001896DFD40-0x00000001896DFD80
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185609CD0-0x000000018560A010
	// [IDTag] // 0x00000001896EA140-0x00000001896EA180
	// [XID] // 0x00000001896EA140-0x00000001896EA180
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018560A010-0x000000018560A330
	// [XID] // 0x00000001896F46C0-0x00000001896F46E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3286 */, bool useObjectPool = false /* Metadata: 0x00AF328A */) => default; // 0x000000018560A4B0-0x000000018560A960
	[BlackList] // 0x00000001896FBF10-0x00000001896FBF50
	// [XID] // 0x00000001896FBF10-0x00000001896FBF50
	public virtual void AutoAllocTypeFields() {} // 0x0000000185609B50-0x0000000185609BF0
	[BlackList] // 0x00000001897062A0-0x00000001897062E0
	// [XID] // 0x00000001897062A0-0x00000001897062E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185609BF0-0x0000000185609CD0
	[BlackList] // 0x0000000189710D90-0x0000000189710DD0
	// [XID] // 0x0000000189710D90-0x0000000189710DD0
	public virtual void ReturnToObjectPool() {} // 0x000000018560AE10-0x000000018560AEB0
	[BlackList] // 0x000000018971B520-0x000000018971B560
	// [XID] // 0x000000018971B520-0x000000018971B560
	public virtual void OnPoolAllocated() {} // 0x000000018560AD70-0x000000018560AE10
	[BlackList] // 0x00000001897258A0-0x00000001897258E0
	// [XID] // 0x00000001897258A0-0x00000001897258E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018560ACD0-0x000000018560AD70
}

