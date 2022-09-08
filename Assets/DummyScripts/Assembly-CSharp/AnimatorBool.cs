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
public class AnimatorBool : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18864
{
	// Fields
	private string _name; // 0x10
	private bool _value; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x0000000189957620-0x0000000189957640 */ get => default; /* [XID] */ /* 0x000000018995F070-0x000000018995F090 */ private set {} } // 0x0000000181358C50-0x0000000181358CF0 0x0000000181358340-0x00000001813583F0
	public bool value { /* [XID] */ /* 0x00000001899668D0-0x00000001899668F0 */ get => default; /* [XID] */ /* 0x000000018996DCC0-0x000000018996DCE0 */ private set {} } // 0x0000000181357F20-0x0000000181357FC0 0x0000000181357E70-0x0000000181357F20

	// Constructors
	public AnimatorBool() {} // 0x0000000181358D90-0x0000000181358DF0

	// Methods
	// [XID] // 0x00000001899758B0-0x00000001899758D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181358A00-0x0000000181358B10
	// [XID] // 0x000000018997C970-0x000000018997C990
	public void InitEmpty() {} // 0x00000001813583F0-0x00000001813584C0
	[BlackList] // 0x0000000189984770-0x00000001899847B0
	// [XID] // 0x0000000189984770-0x00000001899847B0
	public bool FromJson(JSONNode node) => default; // 0x0000000181357FC0-0x0000000181358340
	// [XID] // 0x000000018998F2A0-0x000000018998F2C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181357520-0x00000001813577D0
	// [XID] // 0x0000000189996C60-0x0000000189996C80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB185 */, bool useObjectPool = false /* Metadata: 0x00AFB189 */) => default; // 0x00000001813584C0-0x00000001813587C0
	// [XID] // 0x000000018999E8F0-0x000000018999E910
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB18A */, bool useObjectPool = false /* Metadata: 0x00AFB18E */) => default; // 0x0000000181357BE0-0x0000000181357E70
	[BlackList] // 0x00000001899A62B0-0x00000001899A62F0
	// [XID] // 0x00000001899A62B0-0x00000001899A62F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001813577D0-0x0000000181357AA0
	// [XID] // 0x00000001899B0C30-0x00000001899B0C50
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001813587C0-0x0000000181358A00
	[BlackList] // 0x00000001899B7EB0-0x00000001899B7EF0
	// [XID] // 0x00000001899B7EB0-0x00000001899B7EF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181357AA0-0x0000000181357B40
	[BlackList] // 0x00000001899C28E0-0x00000001899C2920
	// [XID] // 0x00000001899C28E0-0x00000001899C2920
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181357B40-0x0000000181357BE0
	[BlackList] // 0x00000001899CCFD0-0x00000001899CD010
	// [XID] // 0x00000001899CCFD0-0x00000001899CD010
	public virtual void ReturnToObjectPool() {} // 0x0000000181358CF0-0x0000000181358D90
	[BlackList] // 0x00000001899D7550-0x00000001899D7590
	// [XID] // 0x00000001899D7550-0x00000001899D7590
	public virtual void OnPoolAllocated() {} // 0x0000000181358BB0-0x0000000181358C50
	[BlackList] // 0x00000001899E1EC0-0x00000001899E1F00
	// [XID] // 0x00000001899E1EC0-0x00000001899E1F00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181358B10-0x0000000181358BB0
}

