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
public class LevelGadget : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18490
{
	// Fields
	private SimpleSafeUInt32 groupIdRawNum; // 0x10
	private SimpleSafeUInt32 mapInstIdRawNum; // 0x14
	private string _followMove_AttachPoint; // 0x18
	private SimpleSafeUInt32 followMove_targetInstanceIdRawNum; // 0x20
	private bool _gadgetMisc_UnlockShowCutScene; // 0x24
	private ChestShowMoment _gadgetMisc_ChestShowMoment; // 0x28
	private ChestShowUIRemind _gadgetMisc_ChestShowUIRemind; // 0x2C
	private ChestShowCutsceneType _gadgetMisc_ChestShowCtsType; // 0x30
	private bool _billboard_HasUIBar; // 0x34
	private SimpleSafeFloat billboard_ShowUIBarDisRawNum; // 0x38
	private SimpleSafeFloat billboard_HideUIBarDisRawNum; // 0x3C
	private bool _billboard_UIBarNeedEnterCombat; // 0x40
	private HpBarStyle _billboard_HpBarStyle; // 0x44
	private TargetIndicatorType _targetIndicator_Type; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTemplateData _ui_Indicator; // 0x50
	private SimpleSafeUInt32 targetIndicator_TaskIDRawNum; // 0x58

	// Properties
	public uint groupId { /* [XID] */ /* 0x00000001897CC0D0-0x00000001897CC0F0 */ get => default; /* [XID] */ /* 0x00000001897D3A00-0x00000001897D3A20 */ private set {} } // 0x000000018515AFC0-0x000000018515B090 0x000000018515B210-0x000000018515B2F0
	public uint mapInstId { /* [XID] */ /* 0x00000001897DB490-0x00000001897DB4B0 */ get => default; /* [XID] */ /* 0x00000001897E2B60-0x00000001897E2B80 */ private set {} } // 0x000000018515A1A0-0x000000018515A270 0x0000000185159BC0-0x0000000185159CA0
	public string followMove_AttachPoint { /* [XID] */ /* 0x00000001897EA300-0x00000001897EA320 */ get => default; /* [XID] */ /* 0x00000001897F1FB0-0x00000001897F1FD0 */ private set {} } // 0x000000018515C220-0x000000018515C2C0 0x0000000185158EB0-0x0000000185158F60
	public uint followMove_targetInstanceId { /* [XID] */ /* 0x00000001897F9840-0x00000001897F9860 */ get => default; /* [XID] */ /* 0x0000000189800D60-0x0000000189800D80 */ private set {} } // 0x000000018515AB70-0x000000018515AC40 0x000000018515ACF0-0x000000018515ADD0
	public bool gadgetMisc_UnlockShowCutScene { /* [XID] */ /* 0x00000001898082C0-0x00000001898082E0 */ get => default; /* [XID] */ /* 0x000000018980FCD0-0x000000018980FCF0 */ private set {} } // 0x000000018515B090-0x000000018515B130 0x000000018515A580-0x000000018515A630
	public ChestShowMoment gadgetMisc_ChestShowMoment { /* [XID] */ /* 0x0000000189817360-0x0000000189817380 */ get => default; /* [XID] */ /* 0x000000018981ECC0-0x000000018981ECE0 */ private set {} } // 0x000000018515A320-0x000000018515A3C0 0x000000018515AC40-0x000000018515ACF0
	public ChestShowUIRemind gadgetMisc_ChestShowUIRemind { /* [XID] */ /* 0x00000001898261B0-0x00000001898261D0 */ get => default; /* [XID] */ /* 0x000000018982D760-0x000000018982D780 */ private set {} } // 0x0000000185158F60-0x0000000185159000 0x000000018515C2C0-0x000000018515C370
	public ChestShowCutsceneType gadgetMisc_ChestShowCtsType { /* [XID] */ /* 0x0000000189834F10-0x0000000189834F30 */ get => default; /* [XID] */ /* 0x000000018983C6B0-0x000000018983C6D0 */ private set {} } // 0x00000001851586D0-0x0000000185158770 0x000000018515A7C0-0x000000018515A870
	public bool billboard_HasUIBar { /* [XID] */ /* 0x0000000189843D20-0x0000000189843D40 */ get => default; /* [XID] */ /* 0x000000018984B1F0-0x000000018984B210 */ private set {} } // 0x0000000185158D60-0x0000000185158E00 0x00000001851590E0-0x0000000185159190
	public float billboard_ShowUIBarDis { /* [XID] */ /* 0x0000000189852460-0x0000000189852480 */ get => default; /* [XID] */ /* 0x0000000189859DB0-0x0000000189859DD0 */ private set {} } // 0x000000018515A3C0-0x000000018515A4A0 0x0000000185159000-0x00000001851590E0
	public float billboard_HideUIBarDis { /* [XID] */ /* 0x0000000189860E70-0x0000000189860E90 */ get => default; /* [XID] */ /* 0x00000001898686F0-0x0000000189868710 */ private set {} } // 0x0000000185159CA0-0x0000000185159D80 0x000000018515A4A0-0x000000018515A580
	public bool billboard_UIBarNeedEnterCombat { /* [XID] */ /* 0x000000018986FB40-0x000000018986FB60 */ get => default; /* [XID] */ /* 0x0000000189877210-0x0000000189877230 */ private set {} } // 0x0000000185158A40-0x0000000185158AE0 0x000000018515A270-0x000000018515A320
	public HpBarStyle billboard_HpBarStyle { /* [XID] */ /* 0x000000018987EBA0-0x000000018987EBC0 */ get => default; /* [XID] */ /* 0x0000000189886080-0x00000001898860A0 */ private set {} } // 0x000000018515AF20-0x000000018515AFC0 0x0000000185158E00-0x0000000185158EB0
	public TargetIndicatorType targetIndicator_Type { /* [XID] */ /* 0x000000018988D320-0x000000018988D340 */ get => default; /* [XID] */ /* 0x00000001898949D0-0x00000001898949F0 */ private set {} } // 0x000000018515ADD0-0x000000018515AE70 0x000000018515C370-0x000000018515C420
	public ConfigTemplateData ui_Indicator { /* [XID] */ /* 0x000000018989BEA0-0x000000018989BEC0 */ get => default; /* [XID] */ /* 0x00000001898A3540-0x00000001898A3560 */ private set {} } // 0x000000018515A100-0x000000018515A1A0 0x000000018515AE70-0x000000018515AF20
	public uint targetIndicator_TaskID { /* [XID] */ /* 0x00000001898AA940-0x00000001898AA960 */ get => default; /* [XID] */ /* 0x00000001898B22F0-0x00000001898B2310 */ private set {} } // 0x000000018515BD90-0x000000018515BE60 0x000000018515B130-0x000000018515B210

	// Constructors
	public LevelGadget() {} // 0x000000018515C4C0-0x000000018515C5D0

	// Methods
	// [XID] // 0x00000001898BA060-0x00000001898BA080
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018515BE60-0x000000018515C0E0
	// [XID] // 0x00000001898C13A0-0x00000001898C13C0
	public void InitEmpty() {} // 0x000000018515A630-0x000000018515A7C0
	[BlackList] // 0x00000001898C8D60-0x00000001898C8DA0
	// [XID] // 0x00000001898C8D60-0x00000001898C8DA0
	public bool FromJson(JSONNode node) => default; // 0x0000000185159D80-0x000000018515A100
	// [XID] // 0x00000001898D32D0-0x00000001898D32F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851577C0-0x00000001851586D0
	// [XID] // 0x00000001898DABC0-0x00000001898DABE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F31 */, bool useObjectPool = false /* Metadata: 0x00AF9F35 */) => default; // 0x000000018515A870-0x000000018515AB70
	// [XID] // 0x00000001898E2A40-0x00000001898E2A60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F36 */, bool useObjectPool = false /* Metadata: 0x00AF9F3A */) => default; // 0x0000000185159190-0x0000000185159BC0
	[BlackList] // 0x00000001898EA510-0x00000001898EA550
	// [XID] // 0x00000001898EA510-0x00000001898EA550
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185158770-0x0000000185158A40
	// [XID] // 0x00000001898F4AE0-0x00000001898F4B00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018515B2F0-0x000000018515BD90
	[BlackList] // 0x00000001898FC390-0x00000001898FC3D0
	// [XID] // 0x00000001898FC390-0x00000001898FC3D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185158AE0-0x0000000185158B80
	[BlackList] // 0x0000000189906AB0-0x0000000189906AF0
	// [XID] // 0x0000000189906AB0-0x0000000189906AF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185158B80-0x0000000185158D60
	[BlackList] // 0x0000000189911240-0x0000000189911280
	// [XID] // 0x0000000189911240-0x0000000189911280
	public virtual void ReturnToObjectPool() {} // 0x000000018515C420-0x000000018515C4C0
	[BlackList] // 0x000000018991BFE0-0x000000018991C020
	// [XID] // 0x000000018991BFE0-0x000000018991C020
	public virtual void OnPoolAllocated() {} // 0x000000018515C180-0x000000018515C220
	[BlackList] // 0x00000001899266C0-0x0000000189926700
	// [XID] // 0x00000001899266C0-0x0000000189926700
	public virtual void OnBeforePoolRecycled() {} // 0x000000018515C0E0-0x000000018515C180
}

