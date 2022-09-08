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
public class FetterConditionConfig : IAutoAllocRecycle // TypeDefIndex: 15409
{
	// Fields
	protected FetterCondType _condType; // 0x10
	protected SimpleSafeUInt32[] _paramList; // 0x18

	// Properties
	public FetterCondType condType { /* [XID] */ /* 0x00000001896C2080-0x00000001896C20A0 */ get => default; /* [XID] */ /* 0x00000001896C96D0-0x00000001896C96F0 */ protected set {} } // 0x000000018173A560-0x000000018173A600 0x0000000181739AB0-0x0000000181739B60
	public SimpleSafeUInt32[] paramList { /* [XID] */ /* 0x00000001896D0E20-0x00000001896D0E40 */ get => default; /* [XID] */ /* 0x00000001896D8530-0x00000001896D8550 */ protected set {} } // 0x0000000181739CA0-0x0000000181739D40 0x000000018173A140-0x000000018173A1F0

	// Constructors
	public FetterConditionConfig() {} // 0x000000018173A7E0-0x000000018173A840

	// Methods
	// [XID] // 0x00000001896DFF20-0x00000001896DFF40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181739D40-0x000000018173A140
	// [XID] // 0x00000001896E7140-0x00000001896E7160
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF145B */, bool useObjectPool = false /* Metadata: 0x00AF145F */) => default; // 0x000000018173A1F0-0x000000018173A560
	[BlackList] // 0x00000001896EE7B0-0x00000001896EE7F0
	// [XID] // 0x00000001896EE7B0-0x00000001896EE7F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181739B60-0x0000000181739C00
	[BlackList] // 0x00000001896F8C40-0x00000001896F8C80
	// [XID] // 0x00000001896F8C40-0x00000001896F8C80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181739C00-0x0000000181739CA0
	[BlackList] // 0x00000001897035F0-0x0000000189703630
	// [XID] // 0x00000001897035F0-0x0000000189703630
	public virtual void ReturnToObjectPool() {} // 0x000000018173A740-0x000000018173A7E0
	[BlackList] // 0x000000018970DCD0-0x000000018970DD10
	// [XID] // 0x000000018970DCD0-0x000000018970DD10
	public virtual void OnPoolAllocated() {} // 0x000000018173A6A0-0x000000018173A740
	[BlackList] // 0x00000001897182D0-0x0000000189718310
	// [XID] // 0x00000001897182D0-0x0000000189718310
	public virtual void OnBeforePoolRecycled() {} // 0x000000018173A600-0x000000018173A6A0
}

