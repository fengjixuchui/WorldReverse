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
public class ProudSkillOpenConfig : IAutoAllocRecycle // TypeDefIndex: 15226
{
	// Fields
	protected SimpleSafeUInt32 proudSkillGroupIdRawNum; // 0x10
	protected SimpleSafeUInt32 needAvatarPromoteLevelRawNum; // 0x14

	// Properties
	public uint proudSkillGroupId { /* [XID] */ /* 0x000000018985FD10-0x000000018985FD30 */ get => default; /* [XID] */ /* 0x0000000189867430-0x0000000189867450 */ protected set {} } // 0x0000000184565AE0-0x0000000184565BB0 0x0000000184565580-0x0000000184565660
	public uint needAvatarPromoteLevel { /* [XID] */ /* 0x000000018986EBD0-0x000000018986EBF0 */ get => default; /* [XID] */ /* 0x0000000189876060-0x0000000189876080 */ protected set {} } // 0x00000001845654B0-0x0000000184565580 0x0000000184565A00-0x0000000184565AE0

	// Constructors
	public ProudSkillOpenConfig() {} // 0x00000001845660F0-0x0000000184566150

	// Methods
	// [XID] // 0x000000018987DC80-0x000000018987DCA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001845657E0-0x0000000184565A00
	// [XID] // 0x0000000189884C10-0x0000000189884C30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0458 */, bool useObjectPool = false /* Metadata: 0x00AF045C */) => default; // 0x0000000184565BB0-0x0000000184565F10
	[BlackList] // 0x000000018988C240-0x000000018988C280
	// [XID] // 0x000000018988C240-0x000000018988C280
	public virtual void AutoAllocTypeFields() {} // 0x0000000184565660-0x0000000184565700
	[BlackList] // 0x0000000189896660-0x00000001898966A0
	// [XID] // 0x0000000189896660-0x00000001898966A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184565700-0x00000001845657E0
	[BlackList] // 0x00000001898A0970-0x00000001898A09B0
	// [XID] // 0x00000001898A0970-0x00000001898A09B0
	public virtual void ReturnToObjectPool() {} // 0x0000000184566050-0x00000001845660F0
	[BlackList] // 0x00000001898AAF40-0x00000001898AAF80
	// [XID] // 0x00000001898AAF40-0x00000001898AAF80
	public virtual void OnPoolAllocated() {} // 0x0000000184565FB0-0x0000000184566050
	[BlackList] // 0x00000001898B5970-0x00000001898B59B0
	// [XID] // 0x00000001898B5970-0x00000001898B59B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184565F10-0x0000000184565FB0
}

