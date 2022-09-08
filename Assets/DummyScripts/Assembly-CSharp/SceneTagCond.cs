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
public class SceneTagCond : IAutoAllocRecycle // TypeDefIndex: 16098
{
	// Fields
	protected SceneTagCondType _condType; // 0x10
	protected long _param1; // 0x18
	protected long _param2; // 0x20

	// Properties
	public SceneTagCondType condType { /* [XID] */ /* 0x0000000189A36DB0-0x0000000189A36DD0 */ get => default; /* [XID] */ /* 0x0000000189A3E3B0-0x0000000189A3E3D0 */ protected set {} } // 0x0000000182E30DC0-0x0000000182E30E60 0x0000000182E30300-0x0000000182E303B0
	public long param1 { /* [XID] */ /* 0x0000000189A45A80-0x0000000189A45AA0 */ get => default; /* [XID] */ /* 0x0000000189A4D1A0-0x0000000189A4D1C0 */ protected set {} } // 0x0000000182E30500-0x0000000182E305A0 0x0000000182E30860-0x0000000182E30910
	public long param2 { /* [XID] */ /* 0x0000000189A548D0-0x0000000189A548F0 */ get => default; /* [XID] */ /* 0x0000000189A5C360-0x0000000189A5C380 */ protected set {} } // 0x0000000182E30910-0x0000000182E309B0 0x0000000182E30E60-0x0000000182E30F10

	// Constructors
	public SceneTagCond() {} // 0x0000000182E310F0-0x0000000182E31150

	// Methods
	// [XID] // 0x0000000189A63D50-0x0000000189A63D70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E305A0-0x0000000182E30860
	// [XID] // 0x0000000189A6B5F0-0x0000000189A6B610
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3036 */, bool useObjectPool = false /* Metadata: 0x00AF303A */) => default; // 0x0000000182E309B0-0x0000000182E30DC0
	[BlackList] // 0x0000000189A72D60-0x0000000189A72DA0
	// [XID] // 0x0000000189A72D60-0x0000000189A72DA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E303B0-0x0000000182E30450
	[BlackList] // 0x0000000189A7D750-0x0000000189A7D790
	// [XID] // 0x0000000189A7D750-0x0000000189A7D790
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E30450-0x0000000182E30500
	[BlackList] // 0x0000000189A87F80-0x0000000189A87FC0
	// [XID] // 0x0000000189A87F80-0x0000000189A87FC0
	public virtual void ReturnToObjectPool() {} // 0x0000000182E31050-0x0000000182E310F0
	[BlackList] // 0x0000000189A92650-0x0000000189A92690
	// [XID] // 0x0000000189A92650-0x0000000189A92690
	public virtual void OnPoolAllocated() {} // 0x0000000182E30FB0-0x0000000182E31050
	[BlackList] // 0x0000000189A9CD10-0x0000000189A9CD50
	// [XID] // 0x0000000189A9CD10-0x0000000189A9CD50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E30F10-0x0000000182E30FB0
}

