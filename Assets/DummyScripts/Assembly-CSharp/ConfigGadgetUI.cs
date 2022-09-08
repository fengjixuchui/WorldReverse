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
public class ConfigGadgetUI : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17964
{
	// Fields
	private string _gadgetUIBtnCfgPath; // 0x10
	private string _uiName; // 0x18
	private bool _alwaysInteractive; // 0x20
	private TouchInteractType _onTouch; // 0x24
	private SimpleSafeUInt32 openRewardIdRawNum; // 0x28

	// Properties
	public string gadgetUIBtnCfgPath { /* [XID] */ /* 0x000000018970A7E0-0x000000018970A800 */ get => default; /* [XID] */ /* 0x00000001897122F0-0x0000000189712310 */ private set {} } // 0x000000018244DF70-0x000000018244E010 0x000000018244DA20-0x000000018244DAD0
	public string uiName { /* [XID] */ /* 0x0000000189719930-0x0000000189719950 */ get => default; /* [XID] */ /* 0x0000000189720E50-0x0000000189720E70 */ private set {} } // 0x000000018244CE40-0x000000018244CEE0 0x000000018244E1A0-0x000000018244E250
	public bool alwaysInteractive { /* [XID] */ /* 0x0000000189728550-0x0000000189728570 */ get => default; /* [XID] */ /* 0x000000018972FCB0-0x000000018972FCD0 */ private set {} } // 0x000000018244D480-0x000000018244D520 0x000000018244D520-0x000000018244D5D0
	public TouchInteractType onTouch { /* [XID] */ /* 0x00000001897376E0-0x0000000189737700 */ get => default; /* [XID] */ /* 0x000000018973F1E0-0x000000018973F200 */ private set {} } // 0x000000018244DED0-0x000000018244DF70 0x000000018244E010-0x000000018244E0C0
	public uint openRewardId { /* [XID] */ /* 0x0000000189746400-0x0000000189746420 */ get => default; /* [XID] */ /* 0x000000018974DEB0-0x000000018974DED0 */ private set {} } // 0x000000018244D950-0x000000018244DA20 0x000000018244E0C0-0x000000018244E1A0

	// Constructors
	public ConfigGadgetUI() {} // 0x000000018244E980-0x000000018244EA00

	// Methods
	// [XID] // 0x00000001897555F0-0x0000000189755610
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018244E640-0x000000018244E7A0
	// [XID] // 0x000000018975C750-0x000000018975C770
	public void InitEmpty() {} // 0x000000018244DAD0-0x000000018244DBD0
	[BlackList] // 0x0000000189763FE0-0x0000000189764020
	// [XID] // 0x0000000189763FE0-0x0000000189764020
	public bool FromJson(JSONNode node) => default; // 0x000000018244D5D0-0x000000018244D950
	// [XID] // 0x000000018976E5E0-0x000000018976E600
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018244C630-0x000000018244CB70
	// [XID] // 0x0000000189775FC0-0x0000000189775FE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8513 */, bool useObjectPool = false /* Metadata: 0x00AF8517 */) => default; // 0x000000018244DBD0-0x000000018244DED0
	// [XID] // 0x000000018977D680-0x000000018977D6A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8518 */, bool useObjectPool = false /* Metadata: 0x00AF851C */) => default; // 0x000000018244D060-0x000000018244D480
	[BlackList] // 0x0000000189784F20-0x0000000189784F60
	// [XID] // 0x0000000189784F20-0x0000000189784F60
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018244CB70-0x000000018244CE40
	// [XID] // 0x000000018978F3C0-0x000000018978F3E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018244E250-0x000000018244E640
	[BlackList] // 0x0000000189796B70-0x0000000189796BB0
	// [XID] // 0x0000000189796B70-0x0000000189796BB0
	public virtual void AutoAllocTypeFields() {} // 0x000000018244CEE0-0x000000018244CF80
	[BlackList] // 0x00000001897A1840-0x00000001897A1880
	// [XID] // 0x00000001897A1840-0x00000001897A1880
	public virtual void AutoRecycleTypeFields() {} // 0x000000018244CF80-0x000000018244D060
	[BlackList] // 0x00000001897ABF60-0x00000001897ABFA0
	// [XID] // 0x00000001897ABF60-0x00000001897ABFA0
	public virtual void ReturnToObjectPool() {} // 0x000000018244E8E0-0x000000018244E980
	[BlackList] // 0x00000001897B70B0-0x00000001897B70F0
	// [XID] // 0x00000001897B70B0-0x00000001897B70F0
	public virtual void OnPoolAllocated() {} // 0x000000018244E840-0x000000018244E8E0
	[BlackList] // 0x00000001897C1C70-0x00000001897C1CB0
	// [XID] // 0x00000001897C1C70-0x00000001897C1CB0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018244E7A0-0x000000018244E840
}

