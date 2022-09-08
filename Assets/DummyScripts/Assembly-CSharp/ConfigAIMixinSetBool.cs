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
public class ConfigAIMixinSetBool : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17507
{
	// Fields
	private string _boolID; // 0x10
	private bool _value; // 0x18

	// Properties
	public string boolID { /* [XID] */ /* 0x00000001899A30B0-0x00000001899A30D0 */ get => default; /* [XID] */ /* 0x00000001899AAB80-0x00000001899AABA0 */ private set {} } // 0x000000018361A2A0-0x000000018361A340 0x0000000183619E20-0x0000000183619ED0
	public bool value { /* [XID] */ /* 0x00000001899B2550-0x00000001899B2570 */ get => default; /* [XID] */ /* 0x00000001899B98B0-0x00000001899B98D0 */ private set {} } // 0x0000000183619A00-0x0000000183619AA0 0x0000000183619950-0x0000000183619A00

	// Constructors
	public ConfigAIMixinSetBool() {} // 0x000000018361A870-0x000000018361A8D0

	// Methods
	// [XID] // 0x00000001899C13D0-0x00000001899C13F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018361A580-0x000000018361A690
	// [XID] // 0x00000001899C8A00-0x00000001899C8A20
	public void InitEmpty() {} // 0x0000000183619ED0-0x0000000183619FA0
	[BlackList] // 0x00000001899D0350-0x00000001899D0390
	// [XID] // 0x00000001899D0350-0x00000001899D0390
	public bool FromJson(JSONNode node) => default; // 0x0000000183619AA0-0x0000000183619E20
	// [XID] // 0x00000001899DA7A0-0x00000001899DA7C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183619000-0x00000001836192B0
	// [XID] // 0x00000001899E21A0-0x00000001899E21C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF711B */, bool useObjectPool = false /* Metadata: 0x00AF711F */) => default; // 0x0000000183619FA0-0x000000018361A2A0
	// [XID] // 0x00000001899E9680-0x00000001899E96A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7120 */, bool useObjectPool = false /* Metadata: 0x00AF7124 */) => default; // 0x00000001836196C0-0x0000000183619950
	[BlackList] // 0x00000001899F0CD0-0x00000001899F0D10
	// [XID] // 0x00000001899F0CD0-0x00000001899F0D10
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001836192B0-0x0000000183619580
	// [XID] // 0x00000001899FB8F0-0x00000001899FB910
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018361A340-0x000000018361A580
	[BlackList] // 0x0000000189A02C30-0x0000000189A02C70
	// [XID] // 0x0000000189A02C30-0x0000000189A02C70
	public virtual void AutoAllocTypeFields() {} // 0x0000000183619580-0x0000000183619620
	[BlackList] // 0x0000000189A0D2C0-0x0000000189A0D300
	// [XID] // 0x0000000189A0D2C0-0x0000000189A0D300
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183619620-0x00000001836196C0
	[BlackList] // 0x0000000189A175D0-0x0000000189A17610
	// [XID] // 0x0000000189A175D0-0x0000000189A17610
	public virtual void ReturnToObjectPool() {} // 0x000000018361A7D0-0x000000018361A870
	[BlackList] // 0x0000000189A21C10-0x0000000189A21C50
	// [XID] // 0x0000000189A21C10-0x0000000189A21C50
	public virtual void OnPoolAllocated() {} // 0x000000018361A730-0x000000018361A7D0
	[BlackList] // 0x0000000189A2C050-0x0000000189A2C090
	// [XID] // 0x0000000189A2C050-0x0000000189A2C090
	public virtual void OnBeforePoolRecycled() {} // 0x000000018361A690-0x000000018361A730
}

