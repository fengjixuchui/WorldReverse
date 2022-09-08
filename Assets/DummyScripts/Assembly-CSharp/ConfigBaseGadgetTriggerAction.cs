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
public class ConfigBaseGadgetTriggerAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14950
{
	// Constructors
	public ConfigBaseGadgetTriggerAction() {} // 0x0000000181B621A0-0x0000000181B62200

	// Methods
	// [XID] // 0x0000000189AC0F50-0x0000000189AC0F70
	public virtual void DoTriggerAction(LCGadgetCombat gadgetCombat, uint otherID, int actionIdx) {} // 0x0000000181B609B0-0x0000000181B60A80
	// [XID] // 0x0000000189AC88F0-0x0000000189AC8910
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B61F10-0x0000000181B61FC0
	// [XID] // 0x0000000189AD00F0-0x0000000189AD0110
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181B61DB0-0x0000000181B61E60
	// [XID] // 0x0000000189AD7E60-0x0000000189AD7E80
	public virtual ConfigBaseGadgetTriggerAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFB8D */) => default; // 0x0000000181B61AD0-0x0000000181B61BB0
	// [XID] // 0x0000000189ADFA90-0x0000000189ADFAB0
	public virtual int GetHashNum() => default; // 0x0000000181B60F40-0x0000000181B61010
	// [XID] // 0x0000000189AE70B0-0x0000000189AE70D0
	public virtual void InitEmpty() {} // 0x0000000181B61640-0x0000000181B616E0
	[BlackList] // 0x0000000189AEED00-0x0000000189AEED40
	// [XID] // 0x0000000189AEED00-0x0000000189AEED40
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000181B610F0-0x0000000181B61470
	// [XID] // 0x0000000189AF9430-0x0000000189AF9450
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181B60A80-0x0000000181B60B30
	[BlackList] // 0x0000000189B00830-0x0000000189B00870
	// [XID] // 0x0000000189B00830-0x0000000189B00870
	public static ConfigBaseGadgetTriggerAction ParseFromJson(JSONNode node) => default; // 0x0000000181B61BB0-0x0000000181B61DB0
	// [XID] // 0x0000000189B0AEC0-0x0000000189B0AEE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB8E */, bool useObjectPool = false /* Metadata: 0x00AEFB92 */) => default; // 0x0000000181B617D0-0x0000000181B61AD0
	// [XID] // 0x0000000189B12740-0x0000000189B12760
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB93 */, bool useObjectPool = false /* Metadata: 0x00AEFB97 */) => default; // 0x0000000181B61010-0x0000000181B610F0
	// [XID] // 0x0000000189B19AF0-0x0000000189B19B10
	public static ConfigBaseGadgetTriggerAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB98 */, bool useObjectPool = false /* Metadata: 0x00AEFB9C */) => default; // 0x0000000181B61470-0x0000000181B61640
	[BlackList] // 0x0000000189B21050-0x0000000189B21090
	// [XID] // 0x0000000189B21050-0x0000000189B21090
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B60B30-0x0000000181B60E00
	// [XID] // 0x0000000189B2B670-0x0000000189B2B690
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B61E60-0x0000000181B61F10
	[BlackList] // 0x0000000189B32BA0-0x0000000189B32BE0
	// [XID] // 0x0000000189B32BA0-0x0000000189B32BE0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181B616E0-0x0000000181B617D0
	[BlackList] // 0x0000000189B3D1A0-0x0000000189B3D1E0
	// [XID] // 0x0000000189B3D1A0-0x0000000189B3D1E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181B60E00-0x0000000181B60EA0
	[BlackList] // 0x0000000189B47EA0-0x0000000189B47EE0
	// [XID] // 0x0000000189B47EA0-0x0000000189B47EE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181B60EA0-0x0000000181B60F40
	[BlackList] // 0x0000000189B52580-0x0000000189B525C0
	// [XID] // 0x0000000189B52580-0x0000000189B525C0
	public virtual void ReturnToObjectPool() {} // 0x0000000181B62100-0x0000000181B621A0
	[BlackList] // 0x0000000189B5CFD0-0x0000000189B5D010
	// [XID] // 0x0000000189B5CFD0-0x0000000189B5D010
	public virtual void OnPoolAllocated() {} // 0x0000000181B62060-0x0000000181B62100
	[BlackList] // 0x0000000189B67880-0x0000000189B678C0
	// [XID] // 0x0000000189B67880-0x0000000189B678C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181B61FC0-0x0000000181B62060
}

