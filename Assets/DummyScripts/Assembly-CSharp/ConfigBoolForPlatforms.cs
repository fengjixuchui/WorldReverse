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
public class ConfigBoolForPlatforms : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18120
{
	// Fields
	private bool _ps4; // 0x10
	private bool _android; // 0x11
	private bool _ios; // 0x12
	private bool _pc; // 0x13
	private bool _editor; // 0x14

	// Properties
	public bool ps4 { /* [XID] */ /* 0x000000018976B880-0x000000018976B8A0 */ get => default; /* [XID] */ /* 0x0000000189772D40-0x0000000189772D60 */ private set {} } // 0x0000000184637FC0-0x0000000184638060 0x0000000184638100-0x00000001846381B0
	public bool android { /* [XID] */ /* 0x0000000189721700-0x0000000189721720 */ get => default; /* [XID] */ /* 0x0000000189782060-0x0000000189782080 */ private set {} } // 0x0000000184637800-0x00000001846378A0 0x0000000184636E10-0x0000000184636EC0
	public bool ios { /* [XID] */ /* 0x0000000189789420-0x0000000189789440 */ get => default; /* [XID] */ /* 0x0000000189790AB0-0x0000000189790AD0 */ private set {} } // 0x00000001846388C0-0x0000000184638960 0x0000000184637380-0x0000000184637430
	public bool pc { /* [XID] */ /* 0x0000000189728D00-0x0000000189728D20 */ get => default; /* [XID] */ /* 0x00000001897A0270-0x00000001897A0290 */ private set {} } // 0x00000001846381B0-0x0000000184638250 0x00000001846372D0-0x0000000184637380
	public bool editor { /* [XID] */ /* 0x00000001897A77C0-0x00000001897A77E0 */ get => default; /* [XID] */ /* 0x00000001897AF210-0x00000001897AF230 */ private set {} } // 0x0000000184638060-0x0000000184638100 0x00000001846368C0-0x0000000184636970

	// Constructors
	public ConfigBoolForPlatforms() {} // 0x0000000184638A00-0x0000000184638A70

	// Methods
	// [XID] // 0x00000001897B7030-0x00000001897B7050
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184638620-0x0000000184638780
	// [XID] // 0x00000001897BEEB0-0x00000001897BEED0
	public void InitEmpty() {} // 0x0000000184637C20-0x0000000184637CC0
	[BlackList] // 0x00000001897C64E0-0x00000001897C6520
	// [XID] // 0x00000001897C64E0-0x00000001897C6520
	public bool FromJson(JSONNode node) => default; // 0x00000001846378A0-0x0000000184637C20
	// [XID] // 0x00000001897D0B90-0x00000001897D0BB0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184636970-0x0000000184636E10
	// [XID] // 0x00000001897D8930-0x00000001897D8950
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BC7 */, bool useObjectPool = false /* Metadata: 0x00AF8BCB */) => default; // 0x0000000184637CC0-0x0000000184637FC0
	// [XID] // 0x00000001897DFA90-0x00000001897DFAB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BCC */, bool useObjectPool = false /* Metadata: 0x00AF8BD0 */) => default; // 0x0000000184637430-0x0000000184637800
	[BlackList] // 0x00000001897E70D0-0x00000001897E7110
	// [XID] // 0x00000001897E70D0-0x00000001897E7110
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184636EC0-0x0000000184637190
	// [XID] // 0x00000001897F2170-0x00000001897F2190
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184638250-0x0000000184638620
	[BlackList] // 0x00000001897F98A0-0x00000001897F98E0
	// [XID] // 0x00000001897F98A0-0x00000001897F98E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184637190-0x0000000184637230
	[BlackList] // 0x0000000189803EF0-0x0000000189803F30
	// [XID] // 0x0000000189803EF0-0x0000000189803F30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184637230-0x00000001846372D0
	[BlackList] // 0x000000018980E450-0x000000018980E490
	// [XID] // 0x000000018980E450-0x000000018980E490
	public virtual void ReturnToObjectPool() {} // 0x0000000184638960-0x0000000184638A00
	[BlackList] // 0x0000000189818DF0-0x0000000189818E30
	// [XID] // 0x0000000189818DF0-0x0000000189818E30
	public virtual void OnPoolAllocated() {} // 0x0000000184638820-0x00000001846388C0
	[BlackList] // 0x00000001898230D0-0x0000000189823110
	// [XID] // 0x00000001898230D0-0x0000000189823110
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184638780-0x0000000184638820
}

