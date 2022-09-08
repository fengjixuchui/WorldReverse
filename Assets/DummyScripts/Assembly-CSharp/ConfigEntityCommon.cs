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
public class ConfigEntityCommon : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17707
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEffectAttachShape _effectAttachShape; // 0x10
	private SimpleSafeFloat massRawNum; // 0x18
	private SimpleSafeFloat heightRawNum; // 0x1C
	private SimpleSafeFloat modelHeightRawNum; // 0x20
	private SimpleSafeFloat viewSizeRawNum; // 0x24
	private SimpleSafeFloat shadowViewSizeRatioRawNum; // 0x28
	private SimpleSafeFloat overrideCullBoundsRadiusRawNum; // 0x2C
	private bool _affectedByWorld; // 0x30
	private bool _checkInSurface; // 0x31
	private SimpleSafeFloat scaleRawNum; // 0x34
	private SimpleSafeFloat disableTickDistanceRawNum; // 0x38
	private SimpleSafeFloat forcePauseTickDistanceRawNum; // 0x3C
	private bool _shouldPauseAnimatorBeforeReady; // 0x40
	private bool _canTriggerElementReactionText; // 0x41
	private bool _useGrassDisplacement; // 0x42
	private bool _muteElementStickUI; // 0x43
	private bool _hasAfterImage; // 0x44
	private bool _useDynamicBoneMultiParams; // 0x45
	private bool _enableCrashDamage; // 0x46
	private bool _clearAnimatorOnSetLightDeactive; // 0x47
	private bool _clearAIOnSetLightDeactive; // 0x48
	private bool _useFinalIK; // 0x49

	// Properties
	public ConfigEffectAttachShape effectAttachShape { /* [XID] */ /* 0x0000000189B83520-0x0000000189B83540 */ get => default; /* [XID] */ /* 0x0000000189B8A9B0-0x0000000189B8A9D0 */ private set {} } // 0x0000000185144BF0-0x0000000185144C90 0x0000000185143C60-0x0000000185143D10
	public float mass { /* [XID] */ /* 0x0000000189B12C80-0x0000000189B12CA0 */ get => default; /* [XID] */ /* 0x0000000189B99380-0x0000000189B993A0 */ private set {} } // 0x0000000185141F20-0x0000000185142000 0x0000000185143AA0-0x0000000185143B80
	public float height { /* [XID] */ /* 0x0000000189BA08D0-0x0000000189BA08F0 */ get => default; /* [XID] */ /* 0x0000000189BA8010-0x0000000189BA8030 */ private set {} } // 0x0000000185145FD0-0x00000001851460B0 0x0000000185144B10-0x0000000185144BF0
	public float modelHeight { /* [XID] */ /* 0x0000000189BAF480-0x0000000189BAF4A0 */ get => default; /* [XID] */ /* 0x0000000189BB6B30-0x0000000189BB6B50 */ private set {} } // 0x0000000185144C90-0x0000000185144D70 0x0000000185145010-0x00000001851450F0
	public float viewSize { /* [XID] */ /* 0x0000000189BBE190-0x0000000189BBE1B0 */ get => default; /* [XID] */ /* 0x0000000189BC5E60-0x0000000189BC5E80 */ private set {} } // 0x0000000185142660-0x0000000185142740 0x00000001851424D0-0x00000001851425B0
	public float shadowViewSizeRatio { /* [XID] */ /* 0x0000000189BCD8E0-0x0000000189BCD900 */ get => default; /* [XID] */ /* 0x0000000189BD4D70-0x0000000189BD4D90 */ private set {} } // 0x0000000185144A30-0x0000000185144B10 0x0000000185143D10-0x0000000185143DF0
	public float overrideCullBoundsRadius { /* [XID] */ /* 0x0000000189BDC900-0x0000000189BDC920 */ get => default; /* [XID] */ /* 0x00000001895E91D0-0x00000001895E91F0 */ private set {} } // 0x0000000185144950-0x0000000185144A30 0x00000001851460B0-0x0000000185146190
	public bool affectedByWorld { /* [XID] */ /* 0x00000001895F0980-0x00000001895F09A0 */ get => default; /* [XID] */ /* 0x00000001895F8310-0x00000001895F8330 */ private set {} } // 0x0000000185144EC0-0x0000000185144F60 0x0000000185143350-0x0000000185143400
	public bool checkInSurface { /* [XID] */ /* 0x0000000189BDBD40-0x0000000189BDBD60 */ get => default; /* [XID] */ /* 0x0000000189607080-0x00000001896070A0 */ private set {} } // 0x0000000185145F30-0x0000000185145FD0 0x0000000185144E10-0x0000000185144EC0
	public float scale { /* [XID] */ /* 0x000000018960EB00-0x000000018960EB20 */ get => default; /* [XID] */ /* 0x00000001896160C0-0x00000001896160E0 */ private set {} } // 0x0000000185143B80-0x0000000185143C60 0x0000000185146600-0x00000001851466E0
	public float disableTickDistance { /* [XID] */ /* 0x000000018961D8F0-0x000000018961D910 */ get => default; /* [XID] */ /* 0x0000000189624D10-0x0000000189624D30 */ private set {} } // 0x0000000185144130-0x0000000185144210 0x0000000185141E40-0x0000000185141F20
	public float forcePauseTickDistance { /* [XID] */ /* 0x000000018962C4F0-0x000000018962C510 */ get => default; /* [XID] */ /* 0x0000000189634110-0x0000000189634130 */ private set {} } // 0x0000000185143560-0x0000000185143640 0x00000001851439C0-0x0000000185143AA0
	public bool shouldPauseAnimatorBeforeReady { /* [XID] */ /* 0x0000000189B03D70-0x0000000189B03D90 */ get => default; /* [XID] */ /* 0x00000001896430E0-0x0000000189643100 */ private set {} } // 0x0000000185142380-0x0000000185142420 0x0000000185144800-0x00000001851448B0
	public bool canTriggerElementReactionText { /* [XID] */ /* 0x000000018964A760-0x000000018964A780 */ get => default; /* [XID] */ /* 0x0000000189651FA0-0x0000000189651FC0 */ private set {} } // 0x00000001851451A0-0x0000000185145240 0x00000001851450F0-0x00000001851451A0
	public bool useGrassDisplacement { /* [XID] */ /* 0x00000001897F70B0-0x00000001897F70D0 */ get => default; /* [XID] */ /* 0x0000000189660DF0-0x0000000189660E10 */ private set {} } // 0x0000000185143FF0-0x0000000185144090 0x00000001851434B0-0x0000000185143560
	public bool muteElementStickUI { /* [XID] */ /* 0x0000000189668740-0x0000000189668760 */ get => default; /* [XID] */ /* 0x00000001896702D0-0x00000001896702F0 */ private set {} } // 0x00000001851448B0-0x0000000185144950 0x0000000185143F40-0x0000000185143FF0
	public bool hasAfterImage { /* [XID] */ /* 0x0000000189677B30-0x0000000189677B50 */ get => default; /* [XID] */ /* 0x000000018967F0E0-0x000000018967F100 */ private set {} } // 0x00000001851466E0-0x0000000185146780 0x00000001851425B0-0x0000000185142660
	public bool useDynamicBoneMultiParams { /* [XID] */ /* 0x00000001896869F0-0x0000000189686A10 */ get => default; /* [XID] */ /* 0x000000018968E850-0x000000018968E870 */ private set {} } // 0x0000000185144D70-0x0000000185144E10 0x0000000185143E90-0x0000000185143F40
	public bool enableCrashDamage { /* [XID] */ /* 0x00000001896BCAC0-0x00000001896BCAE0 */ get => default; /* [XID] */ /* 0x000000018969D930-0x000000018969D950 */ private set {} } // 0x00000001851443C0-0x0000000185144460 0x0000000185144F60-0x0000000185145010
	public bool clearAnimatorOnSetLightDeactive { /* [XID] */ /* 0x00000001896A4960-0x00000001896A4980 */ get => default; /* [XID] */ /* 0x00000001896AC0F0-0x00000001896AC110 */ private set {} } // 0x0000000185144460-0x0000000185144500 0x0000000185143400-0x00000001851434B0
	public bool clearAIOnSetLightDeactive { /* [XID] */ /* 0x00000001896B33B0-0x00000001896B33D0 */ get => default; /* [XID] */ /* 0x00000001896BABB0-0x00000001896BABD0 */ private set {} } // 0x0000000185143DF0-0x0000000185143E90 0x0000000185142420-0x00000001851424D0
	public bool useFinalIK { /* [XID] */ /* 0x00000001896C1B80-0x00000001896C1BA0 */ get => default; /* [XID] */ /* 0x00000001896C9210-0x00000001896C9230 */ private set {} } // 0x0000000185144090-0x0000000185144130 0x00000001851422D0-0x0000000185142380

	// Constructors
	public ConfigEntityCommon() {} // 0x0000000185146820-0x0000000185146970

	// Methods
	// [XID] // 0x00000001896D0B60-0x00000001896D0B80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185146190-0x00000001851464C0
	// [XID] // 0x00000001896D80B0-0x00000001896D80D0
	public void InitEmpty() {} // 0x0000000185144210-0x00000001851443C0
	[BlackList] // 0x00000001896DFA20-0x00000001896DFA60
	// [XID] // 0x00000001896DFA20-0x00000001896DFA60
	public bool FromJson(JSONNode node) => default; // 0x0000000185143640-0x00000001851439C0
	// [XID] // 0x00000001896E9E80-0x00000001896E9EA0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185140850-0x0000000185141B70
	// [XID] // 0x00000001896F0F20-0x00000001896F0F40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF787B */, bool useObjectPool = false /* Metadata: 0x00AF787F */) => default; // 0x0000000185144500-0x0000000185144800
	// [XID] // 0x00000001896F87C0-0x00000001896F87E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7880 */, bool useObjectPool = false /* Metadata: 0x00AF7884 */) => default; // 0x0000000185142740-0x0000000185143350
	[BlackList] // 0x00000001897000E0-0x0000000189700120
	// [XID] // 0x00000001897000E0-0x0000000189700120
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185141B70-0x0000000185141E40
	// [XID] // 0x000000018970A820-0x000000018970A840
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185145240-0x0000000185145F30
	[BlackList] // 0x0000000189712370-0x00000001897123B0
	// [XID] // 0x0000000189712370-0x00000001897123B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185142000-0x00000001851420A0
	[BlackList] // 0x000000018971C780-0x000000018971C7C0
	// [XID] // 0x000000018971C780-0x000000018971C7C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851420A0-0x00000001851422D0
	[BlackList] // 0x0000000189726E20-0x0000000189726E60
	// [XID] // 0x0000000189726E20-0x0000000189726E60
	public virtual void ReturnToObjectPool() {} // 0x0000000185146780-0x0000000185146820
	[BlackList] // 0x0000000189731320-0x0000000189731360
	// [XID] // 0x0000000189731320-0x0000000189731360
	public virtual void OnPoolAllocated() {} // 0x0000000185146560-0x0000000185146600
	[BlackList] // 0x000000018973BBE0-0x000000018973BC20
	// [XID] // 0x000000018973BBE0-0x000000018973BC20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851464C0-0x0000000185146560
}

