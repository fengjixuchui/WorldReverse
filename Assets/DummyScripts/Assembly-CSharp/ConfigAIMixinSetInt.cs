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
public class ConfigAIMixinSetInt : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17508
{
	// Fields
	private string _intID; // 0x10
	private SimpleSafeInt32 valueRawNum; // 0x18

	// Properties
	public string intID { /* [XID] */ /* 0x0000000189A3E170-0x0000000189A3E190 */ get => default; /* [XID] */ /* 0x0000000189A45880-0x0000000189A458A0 */ private set {} } // 0x0000000182FAB2E0-0x0000000182FAB380 0x0000000182FABB00-0x0000000182FABBB0
	public int value { /* [XID] */ /* 0x0000000189A4CE80-0x0000000189A4CEA0 */ get => default; /* [XID] */ /* 0x0000000189A54610-0x0000000189A54630 */ private set {} } // 0x0000000182FAB210-0x0000000182FAB2E0 0x0000000182FAB130-0x0000000182FAB210

	// Constructors
	public ConfigAIMixinSetInt() {} // 0x0000000182FAC110-0x0000000182FAC290

	// Methods
	// [XID] // 0x00000001897F4400-0x00000001897F4420
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182FABE20-0x0000000182FABF30
	// [XID] // 0x0000000189A639D0-0x0000000189A639F0
	public void InitEmpty() {} // 0x0000000182FAB700-0x0000000182FAB800
	[BlackList] // 0x0000000189A6B230-0x0000000189A6B270
	// [XID] // 0x0000000189A6B230-0x0000000189A6B270
	public bool FromJson(JSONNode node) => default; // 0x0000000182FAB380-0x0000000182FAB700
	// [XID] // 0x0000000189A75690-0x0000000189A756B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182FAA710-0x0000000182FAAA20
	// [XID] // 0x0000000189A7D3D0-0x0000000189A7D3F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7125 */, bool useObjectPool = false /* Metadata: 0x00AF7129 */) => default; // 0x0000000182FAB800-0x0000000182FABB00
	// [XID] // 0x0000000189A84BE0-0x0000000189A84C00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF712A */, bool useObjectPool = false /* Metadata: 0x00AF712E */) => default; // 0x0000000182FAAE70-0x0000000182FAB130
	[BlackList] // 0x0000000189A8C450-0x0000000189A8C490
	// [XID] // 0x0000000189A8C450-0x0000000189A8C490
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FAAA20-0x0000000182FAACF0
	// [XID] // 0x0000000189A96AA0-0x0000000189A96AC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182FABBB0-0x0000000182FABE20
	[BlackList] // 0x0000000189A9DEF0-0x0000000189A9DF30
	// [XID] // 0x0000000189A9DEF0-0x0000000189A9DF30
	public virtual void AutoAllocTypeFields() {} // 0x0000000182FAACF0-0x0000000182FAAD90
	[BlackList] // 0x0000000189AA8440-0x0000000189AA8480
	// [XID] // 0x0000000189AA8440-0x0000000189AA8480
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182FAAD90-0x0000000182FAAE70
	[BlackList] // 0x0000000189AB30A0-0x0000000189AB30E0
	// [XID] // 0x0000000189AB30A0-0x0000000189AB30E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182FAC070-0x0000000182FAC110
	[BlackList] // 0x0000000189ABDB10-0x0000000189ABDB50
	// [XID] // 0x0000000189ABDB10-0x0000000189ABDB50
	public virtual void OnPoolAllocated() {} // 0x0000000182FABFD0-0x0000000182FAC070
	[BlackList] // 0x0000000189AC84F0-0x0000000189AC8530
	// [XID] // 0x0000000189AC84F0-0x0000000189AC8530
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182FABF30-0x0000000182FABFD0
}

