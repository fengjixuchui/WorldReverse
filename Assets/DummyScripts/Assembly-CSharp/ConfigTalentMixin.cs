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
public class ConfigTalentMixin : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19038
{
	// Constructors
	public ConfigTalentMixin() {} // 0x0000000182901540-0x00000001829015A0

	// Methods
	// [XID] // 0x0000000189942630-0x0000000189942650
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829012B0-0x0000000182901360
	// [XID] // 0x0000000189949FA0-0x0000000189949FC0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182901150-0x0000000182901200
	// [XID] // 0x0000000189951AB0-0x0000000189951AD0
	public virtual ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB859 */) => default; // 0x0000000182900E70-0x0000000182900F50
	// [XID] // 0x0000000189958F90-0x0000000189958FB0
	public virtual int GetHashNum() => default; // 0x0000000182900230-0x0000000182900300
	// [XID] // 0x00000001899607E0-0x0000000189960800
	public virtual void InitEmpty() {} // 0x0000000182900930-0x00000001829009D0
	[BlackList] // 0x0000000189968040-0x0000000189968080
	// [XID] // 0x0000000189968040-0x0000000189968080
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001829003E0-0x0000000182900760
	// [XID] // 0x00000001899729F0-0x0000000189972A10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001828FFD70-0x00000001828FFE20
	[BlackList] // 0x000000018997A1B0-0x000000018997A1F0
	// [XID] // 0x000000018997A1B0-0x000000018997A1F0
	public static ConfigTalentMixin ParseFromJson(JSONNode node) => default; // 0x0000000182900F50-0x0000000182901150
	// [XID] // 0x0000000189984750-0x0000000189984770
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB85A */, bool useObjectPool = false /* Metadata: 0x00AFB85E */) => default; // 0x0000000182900AC0-0x0000000182900DC0
	// [XID] // 0x000000018998C170-0x000000018998C190
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB85F */, bool useObjectPool = false /* Metadata: 0x00AFB863 */) => default; // 0x0000000182900300-0x00000001829003E0
	// [XID] // 0x0000000189993EB0-0x0000000189993ED0
	public static ConfigTalentMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB864 */, bool useObjectPool = false /* Metadata: 0x00AFB868 */) => default; // 0x0000000182900760-0x0000000182900930
	[BlackList] // 0x000000018999B6E0-0x000000018999B720
	// [XID] // 0x000000018999B6E0-0x000000018999B720
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001828FFE20-0x00000001829000F0
	// [XID] // 0x00000001899A6270-0x00000001899A6290
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182901200-0x00000001829012B0
	[BlackList] // 0x00000001899AD800-0x00000001899AD840
	// [XID] // 0x00000001899AD800-0x00000001899AD840
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829009D0-0x0000000182900AC0
	// [XID] // 0x00000001899B7E30-0x00000001899B7E50
	public virtual BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x0000000182900DC0-0x0000000182900E70
	[BlackList] // 0x00000001899BFA30-0x00000001899BFA70
	// [XID] // 0x00000001899BFA30-0x00000001899BFA70
	public virtual void AutoAllocTypeFields() {} // 0x00000001829000F0-0x0000000182900190
	[BlackList] // 0x00000001899C9FA0-0x00000001899C9FE0
	// [XID] // 0x00000001899C9FA0-0x00000001899C9FE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182900190-0x0000000182900230
	[BlackList] // 0x00000001899D4550-0x00000001899D4590
	// [XID] // 0x00000001899D4550-0x00000001899D4590
	public virtual void ReturnToObjectPool() {} // 0x00000001829014A0-0x0000000182901540
	[BlackList] // 0x00000001899DE930-0x00000001899DE970
	// [XID] // 0x00000001899DE930-0x00000001899DE970
	public virtual void OnPoolAllocated() {} // 0x0000000182901400-0x00000001829014A0
	[BlackList] // 0x00000001899E92C0-0x00000001899E9300
	// [XID] // 0x00000001899E92C0-0x00000001899E9300
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182901360-0x0000000182901400
}

