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
public class BaseServerBuffConfig : IAutoAllocRecycle // TypeDefIndex: 15406
{
	// Fields
	protected SimpleSafeUInt32 serverBuffIdRawNum; // 0x10
	protected ServerBuffType _serverBuffType; // 0x14
	protected string _abilityName; // 0x18
	protected string _modifierName; // 0x20

	// Properties
	public uint serverBuffId { /* [XID] */ /* 0x0000000189B403E0-0x0000000189B40400 */ get => default; /* [XID] */ /* 0x0000000189B47CA0-0x0000000189B47CC0 */ protected set {} } // 0x00000001839F4AA0-0x00000001839F4B70 0x00000001839F4320-0x00000001839F4400
	public ServerBuffType serverBuffType { /* [XID] */ /* 0x0000000189B4F590-0x0000000189B4F5B0 */ get => default; /* [XID] */ /* 0x0000000189B56E70-0x0000000189B56E90 */ protected set {} } // 0x00000001839F4400-0x00000001839F44A0 0x00000001839F3F60-0x00000001839F4010
	public string abilityName { /* [XID] */ /* 0x0000000189B5E7A0-0x0000000189B5E7C0 */ get => default; /* [XID] */ /* 0x0000000189B65D00-0x0000000189B65D20 */ protected set {} } // 0x00000001839F4A00-0x00000001839F4AA0 0x00000001839F4B70-0x00000001839F4C20
	public string modifierName { /* [XID] */ /* 0x0000000189953B10-0x0000000189953B30 */ get => default; /* [XID] */ /* 0x0000000189B749F0-0x0000000189B74A10 */ protected set {} } // 0x00000001839F4D60-0x00000001839F4E00 0x00000001839F44A0-0x00000001839F4550

	// Constructors
	public BaseServerBuffConfig() {} // 0x00000001839F4EA0-0x00000001839F4F00

	// Methods
	// [XID] // 0x0000000189B7C010-0x0000000189B7C030
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839F4010-0x00000001839F4320
	// [XID] // 0x0000000189B83920-0x0000000189B83940
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF144C */, bool useObjectPool = false /* Metadata: 0x00AF1450 */) => default; // 0x00000001839F4550-0x00000001839F4A00
	[BlackList] // 0x0000000189B8AB70-0x0000000189B8ABB0
	// [XID] // 0x0000000189B8AB70-0x0000000189B8ABB0
	public virtual void AutoAllocTypeFields() {} // 0x00000001839F3DE0-0x00000001839F3E80
	[BlackList] // 0x0000000189B95090-0x0000000189B950D0
	// [XID] // 0x0000000189B95090-0x0000000189B950D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839F3E80-0x00000001839F3F60
	[BlackList] // 0x0000000189B9F530-0x0000000189B9F570
	// [XID] // 0x0000000189B9F530-0x0000000189B9F570
	public virtual void ReturnToObjectPool() {} // 0x00000001839F4E00-0x00000001839F4EA0
	[BlackList] // 0x0000000189BA9D20-0x0000000189BA9D60
	// [XID] // 0x0000000189BA9D20-0x0000000189BA9D60
	public virtual void OnPoolAllocated() {} // 0x00000001839F4CC0-0x00000001839F4D60
	[BlackList] // 0x0000000189BB40F0-0x0000000189BB4130
	// [XID] // 0x0000000189BB40F0-0x0000000189BB4130
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839F4C20-0x00000001839F4CC0
}

