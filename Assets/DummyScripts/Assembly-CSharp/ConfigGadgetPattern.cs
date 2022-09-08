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
public class ConfigGadgetPattern : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18090
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCollision _collision; // 0x10

	// Properties
	public ConfigCollision collision { /* [XID] */ /* 0x0000000189A3EC30-0x0000000189A3EC50 */ get => default; /* [XID] */ /* 0x00000001897E43F0-0x00000001897E4410 */ private set {} } // 0x0000000182944290-0x0000000182944330 0x0000000182942C70-0x0000000182942D20

	// Constructors
	public ConfigGadgetPattern() {} // 0x00000001829447D0-0x0000000182944830

	// Methods
	// [XID] // 0x00000001897EBF20-0x00000001897EBF40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182944510-0x00000001829445F0
	// [XID] // 0x00000001897F3890-0x00000001897F38B0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829441C0-0x0000000182944290
	// [XID] // 0x00000001897FB210-0x00000001897FB230
	public virtual ConfigGadgetPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF8A9D */) => default; // 0x0000000182943EE0-0x0000000182943FC0
	// [XID] // 0x0000000189802660-0x0000000189802680
	public virtual int GetHashNum() => default; // 0x00000001829431B0-0x0000000182943280
	// [XID] // 0x0000000189809BB0-0x0000000189809BD0
	public virtual void InitEmpty() {} // 0x0000000182943A20-0x0000000182943AF0
	[BlackList] // 0x0000000189811360-0x00000001898113A0
	// [XID] // 0x0000000189811360-0x00000001898113A0
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001829434D0-0x0000000182943850
	// [XID] // 0x000000018981BCE0-0x000000018981BD00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182942A70-0x0000000182942C70
	[BlackList] // 0x0000000189823110-0x0000000189823150
	// [XID] // 0x0000000189823110-0x0000000189823150
	public static ConfigGadgetPattern ParseFromJson(JSONNode node) => default; // 0x0000000182943FC0-0x00000001829441C0
	// [XID] // 0x000000018982D7E0-0x000000018982D800
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A9E */, bool useObjectPool = false /* Metadata: 0x00AF8AA2 */) => default; // 0x0000000182943BE0-0x0000000182943EE0
	// [XID] // 0x0000000189835010-0x0000000189835030
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AA3 */, bool useObjectPool = false /* Metadata: 0x00AF8AA7 */) => default; // 0x0000000182943280-0x00000001829434D0
	// [XID] // 0x000000018983C6D0-0x000000018983C6F0
	public static ConfigGadgetPattern ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AA8 */, bool useObjectPool = false /* Metadata: 0x00AF8AAC */) => default; // 0x0000000182943850-0x0000000182943A20
	[BlackList] // 0x0000000189843E20-0x0000000189843E60
	// [XID] // 0x0000000189843E20-0x0000000189843E60
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000182942D20-0x0000000182942FF0
	// [XID] // 0x000000018984E2C0-0x000000018984E2E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182944330-0x0000000182944510
	[BlackList] // 0x00000001898553F0-0x0000000189855430
	// [XID] // 0x00000001898553F0-0x0000000189855430
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182943AF0-0x0000000182943BE0
	[BlackList] // 0x000000018985F690-0x000000018985F6D0
	// [XID] // 0x000000018985F690-0x000000018985F6D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182942FF0-0x0000000182943090
	[BlackList] // 0x0000000189869EE0-0x0000000189869F20
	// [XID] // 0x0000000189869EE0-0x0000000189869F20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182943090-0x00000001829431B0
	[BlackList] // 0x0000000189874060-0x00000001898740A0
	// [XID] // 0x0000000189874060-0x00000001898740A0
	public virtual void ReturnToObjectPool() {} // 0x0000000182944730-0x00000001829447D0
	[BlackList] // 0x000000018987EBE0-0x000000018987EC20
	// [XID] // 0x000000018987EBE0-0x000000018987EC20
	public virtual void OnPoolAllocated() {} // 0x0000000182944690-0x0000000182944730
	[BlackList] // 0x0000000189888F60-0x0000000189888FA0
	// [XID] // 0x0000000189888F60-0x0000000189888FA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829445F0-0x0000000182944690
}

