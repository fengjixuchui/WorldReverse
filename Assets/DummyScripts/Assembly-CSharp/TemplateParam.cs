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
public class TemplateParam : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18993
{
	// Fields
	private string _param; // 0x10

	// Properties
	public string param { /* [XID] */ /* 0x0000000189B49100-0x0000000189B49120 */ get => default; /* [XID] */ /* 0x0000000189B50740-0x0000000189B50760 */ private set {} } // 0x0000000184B37F60-0x0000000184B38000 0x0000000184B37EB0-0x0000000184B37F60

	// Constructors
	public TemplateParam() {} // 0x0000000184B380A0-0x0000000184B38100

	// Methods
	// [XID] // 0x0000000189B58060-0x0000000189B58080
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B37C90-0x0000000184B37D70
	// [XID] // 0x0000000189B5F9A0-0x0000000189B5F9C0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184B37A10-0x0000000184B37AE0
	// [XID] // 0x0000000189B67120-0x0000000189B67140
	public virtual TemplateParam Clone(bool useObjectPool = false /* Metadata: 0x00AFB69F */) => default; // 0x0000000184B37730-0x0000000184B37810
	// [XID] // 0x0000000189B6E380-0x0000000189B6E3A0
	public virtual int GetHashNum() => default; // 0x0000000184B36A40-0x0000000184B36B10
	// [XID] // 0x0000000189B75B50-0x0000000189B75B70
	public virtual void InitEmpty() {} // 0x0000000184B37270-0x0000000184B37340
	[BlackList] // 0x0000000189B7D020-0x0000000189B7D060
	// [XID] // 0x0000000189B7D020-0x0000000189B7D060
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184B36D20-0x0000000184B370A0
	// [XID] // 0x0000000189B87B00-0x0000000189B87B20
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B36450-0x0000000184B36630
	[BlackList] // 0x0000000189B8ECD0-0x0000000189B8ED10
	// [XID] // 0x0000000189B8ECD0-0x0000000189B8ED10
	public static TemplateParam ParseFromJson(JSONNode node) => default; // 0x0000000184B37810-0x0000000184B37A10
	// [XID] // 0x0000000189B99280-0x0000000189B992A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6A0 */, bool useObjectPool = false /* Metadata: 0x00AFB6A4 */) => default; // 0x0000000184B37430-0x0000000184B37730
	// [XID] // 0x0000000189BA0650-0x0000000189BA0670
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6A5 */, bool useObjectPool = false /* Metadata: 0x00AFB6A9 */) => default; // 0x0000000184B36B10-0x0000000184B36D20
	// [XID] // 0x0000000189BA7E50-0x0000000189BA7E70
	public static TemplateParam ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6AA */, bool useObjectPool = false /* Metadata: 0x00AFB6AE */) => default; // 0x0000000184B370A0-0x0000000184B37270
	[BlackList] // 0x0000000189BAF320-0x0000000189BAF360
	// [XID] // 0x0000000189BAF320-0x0000000189BAF360
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B36630-0x0000000184B36900
	// [XID] // 0x0000000189BB97C0-0x0000000189BB97E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B37AE0-0x0000000184B37C90
	[BlackList] // 0x0000000189BC1660-0x0000000189BC16A0
	// [XID] // 0x0000000189BC1660-0x0000000189BC16A0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184B37340-0x0000000184B37430
	[BlackList] // 0x0000000189BCBEE0-0x0000000189BCBF20
	// [XID] // 0x0000000189BCBEE0-0x0000000189BCBF20
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B36900-0x0000000184B369A0
	[BlackList] // 0x0000000189BD6380-0x0000000189BD63C0
	// [XID] // 0x0000000189BD6380-0x0000000189BD63C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B369A0-0x0000000184B36A40
	[BlackList] // 0x00000001895E5FF0-0x00000001895E6030
	// [XID] // 0x00000001895E5FF0-0x00000001895E6030
	public virtual void ReturnToObjectPool() {} // 0x0000000184B38000-0x0000000184B380A0
	[BlackList] // 0x00000001895F0800-0x00000001895F0840
	// [XID] // 0x00000001895F0800-0x00000001895F0840
	public virtual void OnPoolAllocated() {} // 0x0000000184B37E10-0x0000000184B37EB0
	[BlackList] // 0x00000001895FB030-0x00000001895FB070
	// [XID] // 0x00000001895FB030-0x00000001895FB070
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B37D70-0x0000000184B37E10
}

