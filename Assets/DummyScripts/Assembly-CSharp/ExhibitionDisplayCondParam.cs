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
public class ExhibitionDisplayCondParam : IAutoAllocRecycle // TypeDefIndex: 15588
{
	// Fields
	protected ExhibitionDisplayCondParamType _paramType; // 0x10
	protected string _param; // 0x18

	// Properties
	public ExhibitionDisplayCondParamType paramType { /* [XID] */ /* 0x0000000189716A40-0x0000000189716A60 */ get => default; /* [XID] */ /* 0x000000018971E440-0x000000018971E460 */ protected set {} } // 0x00000001852022E0-0x0000000185202380 0x0000000185202230-0x00000001852022E0
	public string param { /* [XID] */ /* 0x0000000189725A00-0x0000000189725A20 */ get => default; /* [XID] */ /* 0x000000018972CFC0-0x000000018972CFE0 */ protected set {} } // 0x00000001852028E0-0x0000000185202980 0x0000000185202830-0x00000001852028E0

	// Constructors
	public ExhibitionDisplayCondParam() {} // 0x0000000185202A20-0x0000000185202A80

	// Methods
	// [XID] // 0x0000000189734750-0x0000000189734770
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185201FF0-0x0000000185202230
	// [XID] // 0x000000018973C100-0x000000018973C120
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1FE6 */, bool useObjectPool = false /* Metadata: 0x00AF1FEA */) => default; // 0x0000000185202380-0x00000001852026F0
	[BlackList] // 0x0000000189743890-0x00000001897438D0
	// [XID] // 0x0000000189743890-0x00000001897438D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185201EB0-0x0000000185201F50
	[BlackList] // 0x000000018974E2D0-0x000000018974E310
	// [XID] // 0x000000018974E2D0-0x000000018974E310
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185201F50-0x0000000185201FF0
	[BlackList] // 0x0000000189758450-0x0000000189758490
	// [XID] // 0x0000000189758450-0x0000000189758490
	public virtual void ReturnToObjectPool() {} // 0x0000000185202980-0x0000000185202A20
	[BlackList] // 0x0000000189762D90-0x0000000189762DD0
	// [XID] // 0x0000000189762D90-0x0000000189762DD0
	public virtual void OnPoolAllocated() {} // 0x0000000185202790-0x0000000185202830
	[BlackList] // 0x000000018976D360-0x000000018976D3A0
	// [XID] // 0x000000018976D360-0x000000018976D3A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001852026F0-0x0000000185202790
}

