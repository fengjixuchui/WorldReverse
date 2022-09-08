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
public class H5ActivityCondConfig : IAutoAllocRecycle // TypeDefIndex: 15692
{
	// Fields
	protected H5ActivityCondType _type; // 0x10
	protected string _paramStr; // 0x18

	// Properties
	public H5ActivityCondType type { /* [XID] */ /* 0x0000000189A65540-0x0000000189A65560 */ get => default; /* [XID] */ /* 0x0000000189A6CC40-0x0000000189A6CC60 */ protected set {} } // 0x0000000184EAEA60-0x0000000184EAEB00 0x0000000184EAE870-0x0000000184EAE920
	public string paramStr { /* [XID] */ /* 0x0000000189A743D0-0x0000000189A743F0 */ get => default; /* [XID] */ /* 0x0000000189A7BD80-0x0000000189A7BDA0 */ protected set {} } // 0x0000000184EAE170-0x0000000184EAE210 0x0000000184EAE7C0-0x0000000184EAE870

	// Constructors
	public H5ActivityCondConfig() {} // 0x0000000184EAEBA0-0x0000000184EAEC00

	// Methods
	// [XID] // 0x0000000189A837A0-0x0000000189A837C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184EAE210-0x0000000184EAE450
	// [XID] // 0x0000000189A8AFC0-0x0000000189A8AFE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF233B */, bool useObjectPool = false /* Metadata: 0x00AF233F */) => default; // 0x0000000184EAE450-0x0000000184EAE7C0
	[BlackList] // 0x0000000189A92790-0x0000000189A927D0
	// [XID] // 0x0000000189A92790-0x0000000189A927D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184EAE030-0x0000000184EAE0D0
	[BlackList] // 0x0000000189A9CE50-0x0000000189A9CE90
	// [XID] // 0x0000000189A9CE50-0x0000000189A9CE90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184EAE0D0-0x0000000184EAE170
	[BlackList] // 0x0000000189AA7480-0x0000000189AA74C0
	// [XID] // 0x0000000189AA7480-0x0000000189AA74C0
	public virtual void ReturnToObjectPool() {} // 0x0000000184EAEB00-0x0000000184EAEBA0
	[BlackList] // 0x0000000189AB1F20-0x0000000189AB1F60
	// [XID] // 0x0000000189AB1F20-0x0000000189AB1F60
	public virtual void OnPoolAllocated() {} // 0x0000000184EAE9C0-0x0000000184EAEA60
	[BlackList] // 0x0000000189ABC980-0x0000000189ABC9C0
	// [XID] // 0x0000000189ABC980-0x0000000189ABC9C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184EAE920-0x0000000184EAE9C0
}

