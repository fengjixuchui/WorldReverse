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
public class ConfigGloablMiscs : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17810
{
	// Fields
	private SimpleSafeFloat airFlowAccRawNum; // 0x10
	private SimpleSafeUInt32 paimonGadgetIDRawNum; // 0x14
	private string _cureEffect; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarFocusGroup _avatarFocus; // 0x20
	private string _gadgetUICutSenceCfgPath; // 0x28
	private string _gadgetUICameraLookCfgPath; // 0x30
	private string _weaponAnimCurvePath; // 0x38

	// Properties
	public float airFlowAcc { /* [XID] */ /* 0x0000000189A0F240-0x0000000189A0F260 */ get => default; /* [XID] */ /* 0x00000001896D8070-0x00000001896D8090 */ private set {} } // 0x00000001828DA1E0-0x00000001828DA2C0 0x00000001828DB6D0-0x00000001828DB7B0
	public uint paimonGadgetID { /* [XID] */ /* 0x0000000189B827E0-0x0000000189B82800 */ get => default; /* [XID] */ /* 0x00000001896E6D60-0x00000001896E6D80 */ private set {} } // 0x00000001828DB600-0x00000001828DB6D0 0x00000001828DACA0-0x00000001828DAD80
	public string cureEffect { /* [XID] */ /* 0x0000000189BCB440-0x0000000189BCB460 */ get => default; /* [XID] */ /* 0x00000001896F5B80-0x00000001896F5BA0 */ private set {} } // 0x00000001828DA640-0x00000001828DA6E0 0x00000001828DAF80-0x00000001828DB030
	public ConfigAvatarFocusGroup avatarFocus { /* [XID] */ /* 0x000000018974D2F0-0x000000018974D310 */ get => default; /* [XID] */ /* 0x0000000189704870-0x0000000189704890 */ private set {} } // 0x00000001828DAC00-0x00000001828DACA0 0x00000001828D9B20-0x00000001828D9BD0
	public string gadgetUICutSenceCfgPath { /* [XID] */ /* 0x000000018970C050-0x000000018970C070 */ get => default; /* [XID] */ /* 0x00000001897139E0-0x0000000189713A00 */ private set {} } // 0x00000001828DB030-0x00000001828DB0D0 0x00000001828DA6E0-0x00000001828DA790
	public string gadgetUICameraLookCfgPath { /* [XID] */ /* 0x000000018971B240-0x000000018971B260 */ get => default; /* [XID] */ /* 0x0000000189722560-0x0000000189722580 */ private set {} } // 0x00000001828D8DC0-0x00000001828D8E60 0x00000001828DAD80-0x00000001828DAE30
	public string weaponAnimCurvePath { /* [XID] */ /* 0x0000000189729C20-0x0000000189729C40 */ get => default; /* [XID] */ /* 0x00000001897312E0-0x0000000189731300 */ private set {} } // 0x00000001828DAEE0-0x00000001828DAF80 0x00000001828DAE30-0x00000001828DAEE0

	// Constructors
	public ConfigGloablMiscs() {} // 0x00000001828DBB30-0x00000001828DBB90

	// Methods
	// [XID] // 0x0000000189738AF0-0x0000000189738B10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828DB7B0-0x00000001828DB950
	// [XID] // 0x0000000189740960-0x0000000189740980
	public void InitEmpty() {} // 0x00000001828DA790-0x00000001828DA900
	[BlackList] // 0x0000000189747C70-0x0000000189747CB0
	// [XID] // 0x0000000189747C70-0x0000000189747CB0
	public bool FromJson(JSONNode node) => default; // 0x00000001828DA2C0-0x00000001828DA640
	// [XID] // 0x0000000189752170-0x0000000189752190
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001828D8E60-0x00000001828D9620
	// [XID] // 0x00000001897597C0-0x00000001897597E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7D81 */, bool useObjectPool = false /* Metadata: 0x00AF7D85 */) => default; // 0x00000001828DA900-0x00000001828DAC00
	// [XID] // 0x00000001897613B0-0x00000001897613D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7D86 */, bool useObjectPool = false /* Metadata: 0x00AF7D8A */) => default; // 0x00000001828D9BD0-0x00000001828DA1E0
	[BlackList] // 0x0000000189768700-0x0000000189768740
	// [XID] // 0x0000000189768700-0x0000000189768740
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001828D9620-0x00000001828D98F0
	// [XID] // 0x0000000189772D60-0x0000000189772D80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828DB0D0-0x00000001828DB600
	[BlackList] // 0x000000018977A460-0x000000018977A4A0
	// [XID] // 0x000000018977A460-0x000000018977A4A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001828D98F0-0x00000001828D9990
	[BlackList] // 0x0000000189784F80-0x0000000189784FC0
	// [XID] // 0x0000000189784F80-0x0000000189784FC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001828D9990-0x00000001828D9B20
	[BlackList] // 0x000000018978F3E0-0x000000018978F420
	// [XID] // 0x000000018978F3E0-0x000000018978F420
	public virtual void ReturnToObjectPool() {} // 0x00000001828DBA90-0x00000001828DBB30
	[BlackList] // 0x0000000189799990-0x00000001897999D0
	// [XID] // 0x0000000189799990-0x00000001897999D0
	public virtual void OnPoolAllocated() {} // 0x00000001828DB9F0-0x00000001828DBA90
	[BlackList] // 0x00000001897A49B0-0x00000001897A49F0
	// [XID] // 0x00000001897A49B0-0x00000001897A49F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001828DB950-0x00000001828DB9F0
}

