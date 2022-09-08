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
public class ConfigGadgetAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17979
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGadgetStateAction[] _triggerEnterActionList; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGadgetStateAction[] _gadgetStateActionList; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGadgetStateAction[] _platformActionList; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGadgetStateAction[] _interactActionList; // 0x28

	// Properties
	public ConfigGadgetStateAction[] triggerEnterActionList { /* [XID] */ /* 0x000000018980FDD0-0x000000018980FDF0 */ get => default; /* [XID] */ /* 0x00000001898173E0-0x0000000189817400 */ private set {} } // 0x0000000185032D30-0x0000000185032DD0 0x0000000185031DA0-0x0000000185031E50
	public ConfigGadgetStateAction[] gadgetStateActionList { /* [XID] */ /* 0x000000018981ED40-0x000000018981ED60 */ get => default; /* [XID] */ /* 0x0000000189826230-0x0000000189826250 */ private set {} } // 0x0000000185032DD0-0x0000000185032E70 0x00000001850322F0-0x00000001850323A0
	public ConfigGadgetStateAction[] platformActionList { /* [XID] */ /* 0x000000018982D860-0x000000018982D880 */ get => default; /* [XID] */ /* 0x0000000189835030-0x0000000189835050 */ private set {} } // 0x0000000185031E50-0x0000000185031EF0 0x00000001850323A0-0x0000000185032450
	public ConfigGadgetStateAction[] interactActionList { /* [XID] */ /* 0x000000018983C710-0x000000018983C730 */ get => default; /* [XID] */ /* 0x0000000189843E80-0x0000000189843EA0 */ private set {} } // 0x0000000185032C90-0x0000000185032D30 0x0000000185032BE0-0x0000000185032C90

	// Constructors
	public ConfigGadgetAction() {} // 0x00000001850335A0-0x0000000185033600

	// Methods
	// [XID] // 0x000000018984B330-0x000000018984B350
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185033280-0x00000001850333C0
	// [XID] // 0x0000000189852500-0x0000000189852520
	public void InitEmpty() {} // 0x00000001850327D0-0x00000001850328E0
	[BlackList] // 0x0000000189859EB0-0x0000000189859EF0
	// [XID] // 0x0000000189859EB0-0x0000000189859EF0
	public bool FromJson(JSONNode node) => default; // 0x0000000185032450-0x00000001850327D0
	// [XID] // 0x0000000189864310-0x0000000189864330
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001850314D0-0x0000000185031960
	// [XID] // 0x000000018986B7E0-0x000000018986B800
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8579 */, bool useObjectPool = false /* Metadata: 0x00AF857D */) => default; // 0x00000001850328E0-0x0000000185032BE0
	// [XID] // 0x0000000189872B10-0x0000000189872B30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF857E */, bool useObjectPool = false /* Metadata: 0x00AF8582 */) => default; // 0x0000000185031EF0-0x00000001850322F0
	[BlackList] // 0x000000018987A7F0-0x000000018987A830
	// [XID] // 0x000000018987A7F0-0x000000018987A830
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185031960-0x0000000185031C30
	// [XID] // 0x00000001898846D0-0x00000001898846F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185032E70-0x0000000185033280
	[BlackList] // 0x000000018988BD00-0x000000018988BD40
	// [XID] // 0x000000018988BD00-0x000000018988BD40
	public virtual void AutoAllocTypeFields() {} // 0x0000000185031C30-0x0000000185031CD0
	[BlackList] // 0x0000000189895FC0-0x0000000189896000
	// [XID] // 0x0000000189895FC0-0x0000000189896000
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185031CD0-0x0000000185031DA0
	[BlackList] // 0x00000001898A04D0-0x00000001898A0510
	// [XID] // 0x00000001898A04D0-0x00000001898A0510
	public virtual void ReturnToObjectPool() {} // 0x0000000185033500-0x00000001850335A0
	[BlackList] // 0x00000001898AA9E0-0x00000001898AAA20
	// [XID] // 0x00000001898AA9E0-0x00000001898AAA20
	public virtual void OnPoolAllocated() {} // 0x0000000185033460-0x0000000185033500
	[BlackList] // 0x00000001898B5350-0x00000001898B5390
	// [XID] // 0x00000001898B5350-0x00000001898B5390
	public virtual void OnBeforePoolRecycled() {} // 0x00000001850333C0-0x0000000185033460
}

