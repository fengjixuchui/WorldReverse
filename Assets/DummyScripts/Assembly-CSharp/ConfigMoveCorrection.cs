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
public class ConfigMoveCorrection : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18574
{
	// Constructors
	public ConfigMoveCorrection() {} // 0x00000001843ABA90-0x00000001843ABAF0

	// Methods
	// [XID] // 0x00000001896ECA80-0x00000001896ECAA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843AB800-0x00000001843AB8B0
	// [XID] // 0x00000001896F4240-0x00000001896F4260
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001843AB6A0-0x00000001843AB750
	// [XID] // 0x00000001896FBA90-0x00000001896FBAB0
	public virtual ConfigMoveCorrection Clone(bool useObjectPool = false /* Metadata: 0x00AFA48B */) => default; // 0x00000001843AB3C0-0x00000001843AB4A0
	// [XID] // 0x0000000189702FF0-0x0000000189703010
	public virtual int GetHashNum() => default; // 0x00000001843AA830-0x00000001843AA900
	// [XID] // 0x000000018970A6C0-0x000000018970A6E0
	public virtual void InitEmpty() {} // 0x00000001843AAF30-0x00000001843AAFD0
	[BlackList] // 0x0000000189712150-0x0000000189712190
	// [XID] // 0x0000000189712150-0x0000000189712190
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001843AA9E0-0x00000001843AAD60
	// [XID] // 0x000000018971C580-0x000000018971C5A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001843AA370-0x00000001843AA420
	[BlackList] // 0x0000000189723A90-0x0000000189723AD0
	// [XID] // 0x0000000189723A90-0x0000000189723AD0
	public static ConfigMoveCorrection ParseFromJson(JSONNode node) => default; // 0x00000001843AB4A0-0x00000001843AB6A0
	// [XID] // 0x000000018972E1F0-0x000000018972E210
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA48C */, bool useObjectPool = false /* Metadata: 0x00AFA490 */) => default; // 0x00000001843AB0C0-0x00000001843AB3C0
	// [XID] // 0x00000001897358C0-0x00000001897358E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA491 */, bool useObjectPool = false /* Metadata: 0x00AFA495 */) => default; // 0x00000001843AA900-0x00000001843AA9E0
	// [XID] // 0x000000018973D450-0x000000018973D470
	public static ConfigMoveCorrection ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA496 */, bool useObjectPool = false /* Metadata: 0x00AFA49A */) => default; // 0x00000001843AAD60-0x00000001843AAF30
	[BlackList] // 0x0000000189744910-0x0000000189744950
	// [XID] // 0x0000000189744910-0x0000000189744950
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001843AA420-0x00000001843AA6F0
	// [XID] // 0x000000018974F350-0x000000018974F370
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843AB750-0x00000001843AB800
	[BlackList] // 0x00000001897569E0-0x0000000189756A20
	// [XID] // 0x00000001897569E0-0x0000000189756A20
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001843AAFD0-0x00000001843AB0C0
	[BlackList] // 0x00000001897612B0-0x00000001897612F0
	// [XID] // 0x00000001897612B0-0x00000001897612F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001843AA6F0-0x00000001843AA790
	[BlackList] // 0x000000018976B7A0-0x000000018976B7E0
	// [XID] // 0x000000018976B7A0-0x000000018976B7E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843AA790-0x00000001843AA830
	[BlackList] // 0x0000000189775DA0-0x0000000189775DE0
	// [XID] // 0x0000000189775DA0-0x0000000189775DE0
	public virtual void ReturnToObjectPool() {} // 0x00000001843AB9F0-0x00000001843ABA90
	[BlackList] // 0x0000000189780420-0x0000000189780460
	// [XID] // 0x0000000189780420-0x0000000189780460
	public virtual void OnPoolAllocated() {} // 0x00000001843AB950-0x00000001843AB9F0
	[BlackList] // 0x000000018978AC60-0x000000018978ACA0
	// [XID] // 0x000000018978AC60-0x000000018978ACA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843AB8B0-0x00000001843AB950
}

