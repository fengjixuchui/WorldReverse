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
public class CoopCondGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17746
{
	// Fields
	private LogicType _condCombType; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private CoopCond[] _coopCondList; // 0x18

	// Properties
	public LogicType condCombType { /* [XID] */ /* 0x0000000189900F30-0x0000000189900F50 */ get => default; /* [XID] */ /* 0x00000001899086D0-0x00000001899086F0 */ private set {} } // 0x0000000183B06390-0x0000000183B06430 0x0000000183B059A0-0x0000000183B05A50
	public CoopCond[] coopCondList { /* [XID] */ /* 0x000000018990FD70-0x000000018990FD90 */ get => default; /* [XID] */ /* 0x0000000189917900-0x0000000189917920 */ private set {} } // 0x0000000183B05580-0x0000000183B05620 0x0000000183B05E20-0x0000000183B05ED0

	// Constructors
	public CoopCondGroup() {} // 0x0000000183B064D0-0x0000000183B06530

	// Methods
	// [XID] // 0x000000018991EEC0-0x000000018991EEE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B06140-0x0000000183B06250
	// [XID] // 0x00000001899268E0-0x0000000189926900
	public void InitEmpty() {} // 0x0000000183B05A50-0x0000000183B05B20
	[BlackList] // 0x000000018992DE70-0x000000018992DEB0
	// [XID] // 0x000000018992DE70-0x000000018992DEB0
	public bool FromJson(JSONNode node) => default; // 0x0000000183B05620-0x0000000183B059A0
	// [XID] // 0x0000000189938270-0x0000000189938290
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183B04C00-0x0000000183B04EC0
	// [XID] // 0x000000018993FC40-0x000000018993FC60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7ABB */, bool useObjectPool = false /* Metadata: 0x00AF7ABF */) => default; // 0x0000000183B05B20-0x0000000183B05E20
	// [XID] // 0x0000000189947320-0x0000000189947340
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AC0 */, bool useObjectPool = false /* Metadata: 0x00AF7AC4 */) => default; // 0x0000000183B052E0-0x0000000183B05580
	[BlackList] // 0x000000018994EA20-0x000000018994EA60
	// [XID] // 0x000000018994EA20-0x000000018994EA60
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B04EC0-0x0000000183B05190
	// [XID] // 0x0000000189959110-0x0000000189959130
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B05ED0-0x0000000183B06140
	[BlackList] // 0x00000001899609A0-0x00000001899609E0
	// [XID] // 0x00000001899609A0-0x00000001899609E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B05190-0x0000000183B05230
	[BlackList] // 0x000000018996B030-0x000000018996B070
	// [XID] // 0x000000018996B030-0x000000018996B070
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B05230-0x0000000183B052E0
	[BlackList] // 0x0000000189975A70-0x0000000189975AB0
	// [XID] // 0x0000000189975A70-0x0000000189975AB0
	public virtual void ReturnToObjectPool() {} // 0x0000000183B06430-0x0000000183B064D0
	[BlackList] // 0x00000001899800C0-0x0000000189980100
	// [XID] // 0x00000001899800C0-0x0000000189980100
	public virtual void OnPoolAllocated() {} // 0x0000000183B062F0-0x0000000183B06390
	[BlackList] // 0x000000018998ACE0-0x000000018998AD20
	// [XID] // 0x000000018998ACE0-0x000000018998AD20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B06250-0x0000000183B062F0
}

