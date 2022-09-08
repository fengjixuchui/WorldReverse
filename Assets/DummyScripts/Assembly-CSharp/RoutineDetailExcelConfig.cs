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
using Newtonsoft.Json;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class RoutineDetailExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14913
{
	// Fields
	private Vector3? _centerPositionCustom; // 0x10
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 routineIdRawNum; // 0x20
	protected GeneralRoutineType _routineType; // 0x24
	protected SimpleSafeUInt32 groupIdRawNum; // 0x28
	protected SimpleSafeUInt32 tagRawNum; // 0x2C
	protected bool _is_backup; // 0x30
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x34
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected RoutineFinishContent _finishContent; // 0x38
	protected LogicType _condComb; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected RoutineCondContent[] _condVec; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected RoutineActionContent[] _actionVec; // 0x50
	protected uint _nameTextMapHash; // 0x58
	protected uint _descTextMapHash; // 0x5C
	protected uint _goalTextMapHash; // 0x60
	protected string _centerPosition; // 0x68
	protected SimpleSafeUInt32 radarRadiusRawNum; // 0x70
	protected SimpleSafeUInt32 enterDistanceRawNum; // 0x74
	protected SimpleSafeUInt32 exitDistanceRawNum; // 0x78

	// Properties
	public uint routineId { /* [XID] */ /* 0x0000000189673620-0x0000000189673640 */ get => default; /* [XID] */ /* 0x000000018967AEC0-0x000000018967AEE0 */ protected set {} } // 0x0000000183D960B0-0x0000000183D96180 0x0000000183D97AA0-0x0000000183D97B80
	public GeneralRoutineType routineType { /* [XID] */ /* 0x0000000189682710-0x0000000189682730 */ get => default; /* [XID] */ /* 0x000000018968A2B0-0x000000018968A2D0 */ protected set {} } // 0x0000000183D963A0-0x0000000183D96440 0x0000000183D965C0-0x0000000183D96670
	public uint groupId { /* [XID] */ /* 0x0000000189692030-0x0000000189692050 */ get => default; /* [XID] */ /* 0x00000001896994C0-0x00000001896994E0 */ protected set {} } // 0x0000000183D97E80-0x0000000183D97F50 0x0000000183D981F0-0x0000000183D982D0
	public uint tag { /* [XID] */ /* 0x00000001896A0930-0x00000001896A0950 */ get => default; /* [XID] */ /* 0x00000001896A7F00-0x00000001896A7F20 */ protected set {} } // 0x0000000183D97D00-0x0000000183D97DD0 0x0000000183D94700-0x0000000183D947E0
	public bool is_backup { /* [XID] */ /* 0x00000001896AF2F0-0x00000001896AF310 */ get => default; /* [XID] */ /* 0x00000001896B6860-0x00000001896B6880 */ protected set {} } // 0x0000000183D97A00-0x0000000183D97AA0 0x0000000183D96250-0x0000000183D96300
	public uint rewardId { /* [XID] */ /* 0x00000001896BDB60-0x00000001896BDB80 */ get => default; /* [XID] */ /* 0x00000001896C53D0-0x00000001896C53F0 */ protected set {} } // 0x0000000183D97680-0x0000000183D97750 0x0000000183D94200-0x0000000183D942E0
	public RoutineFinishContent finishContent { /* [XID] */ /* 0x00000001896CC970-0x00000001896CC990 */ get => default; /* [XID] */ /* 0x00000001896D3C40-0x00000001896D3C60 */ protected set {} } // 0x0000000183D94660-0x0000000183D94700 0x0000000183D942E0-0x0000000183D94390
	public LogicType condComb { /* [XID] */ /* 0x00000001896DB5A0-0x00000001896DB5C0 */ get => default; /* [XID] */ /* 0x00000001896E2D80-0x00000001896E2DA0 */ protected set {} } // 0x0000000183D98640-0x0000000183D986E0 0x0000000183D97800-0x0000000183D978B0
	public RoutineCondContent[] condVec { /* [XID] */ /* 0x00000001896EA3C0-0x00000001896EA3E0 */ get => default; /* [XID] */ /* 0x00000001896F13E0-0x00000001896F1400 */ protected set {} } // 0x0000000183D945C0-0x0000000183D94660 0x0000000183D97750-0x0000000183D97800
	public RoutineActionContent[] actionVec { /* [XID] */ /* 0x00000001896F8D20-0x00000001896F8D40 */ get => default; /* [XID] */ /* 0x0000000189700540-0x0000000189700560 */ protected set {} } // 0x0000000183D96300-0x0000000183D963A0 0x0000000183D97DD0-0x0000000183D97E80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189707D70-0x0000000189707D90 */ get => default; /* [XID] */ /* 0x000000018970F880-0x000000018970F8A0 */ protected set {} } // 0x0000000183D947E0-0x0000000183D94880 0x0000000183D97950-0x0000000183D97A00
	public string name { /* [XID] */ /* 0x0000000189716AE0-0x0000000189716B00 */ get => default; } // 0x0000000183D98A50-0x0000000183D98BD0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018971E4E0-0x000000018971E500 */ get => default; /* [XID] */ /* 0x0000000189725B40-0x0000000189725B60 */ protected set {} } // 0x0000000183D978B0-0x0000000183D97950 0x0000000183D94880-0x0000000183D94930
	public string desc { /* [XID] */ /* 0x000000018972D100-0x000000018972D120 */ get => default; } // 0x0000000183D96440-0x0000000183D965C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint goalTextMapHash { /* [XID] */ /* 0x00000001897348B0-0x00000001897348D0 */ get => default; /* [XID] */ /* 0x000000018973C240-0x000000018973C260 */ protected set {} } // 0x0000000183D968C0-0x0000000183D96960 0x0000000183D98820-0x0000000183D988D0
	public string goal { /* [XID] */ /* 0x00000001897439D0-0x00000001897439F0 */ get => default; } // 0x0000000183D988D0-0x0000000183D98A50 
	public string centerPosition { /* [XID] */ /* 0x000000018974B500-0x000000018974B520 */ get => default; /* [XID] */ /* 0x0000000189752710-0x0000000189752730 */ protected set {} } // 0x0000000183D97C60-0x0000000183D97D00 0x0000000183D96810-0x0000000183D968C0
	public uint radarRadius { /* [XID] */ /* 0x0000000189759D40-0x0000000189759D60 */ get => default; /* [XID] */ /* 0x0000000189761950-0x0000000189761970 */ protected set {} } // 0x0000000183D96180-0x0000000183D96250 0x0000000183D97F50-0x0000000183D98030
	public uint enterDistance { /* [XID] */ /* 0x0000000189768D80-0x0000000189768DA0 */ get => default; /* [XID] */ /* 0x0000000189770450-0x0000000189770470 */ protected set {} } // 0x0000000183D96740-0x0000000183D96810 0x0000000183D97B80-0x0000000183D97C60
	public uint exitDistance { /* [XID] */ /* 0x0000000189777AF0-0x0000000189777B10 */ get => default; /* [XID] */ /* 0x000000018977F1E0-0x000000018977F200 */ protected set {} } // 0x0000000183D96670-0x0000000183D96740 0x0000000183D98BD0-0x0000000183D98CB0

	// Constructors
	public RoutineDetailExcelConfig() {} // 0x0000000183D98D50-0x0000000183D98DD0

	// Methods
	// [XID] // 0x000000018965CD00-0x000000018965CD20
	public Vector3 GetCenterPosition() => default; // 0x0000000183D982D0-0x0000000183D98640
	// [XID] // 0x0000000189664200-0x0000000189664220
	public RoutineTypeExcelConfig GetRoutineTypeExcelConfig() => default; // 0x0000000183D95FE0-0x0000000183D960B0
	// [XID] // 0x000000018966B940-0x000000018966B960
	public string GetGoalProgressString() => default; // 0x0000000183D98030-0x0000000183D981F0
	// [IDTag] // 0x0000000189786BE0-0x0000000189786C20
	// [XID] // 0x0000000189786BE0-0x0000000189786C20
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183D95400-0x0000000183D95FE0
	// [IDTag] // 0x0000000189791190-0x00000001897911D0
	// [XID] // 0x0000000189791190-0x00000001897911D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183D94930-0x0000000183D95400
	// [XID] // 0x000000018979C1D0-0x000000018979C1F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9BA */, bool useObjectPool = false /* Metadata: 0x00AEF9BE */) => default; // 0x0000000183D96960-0x0000000183D97680
	[BlackList] // 0x00000001897A36E0-0x00000001897A3720
	// [XID] // 0x00000001897A36E0-0x00000001897A3720
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D94390-0x0000000183D94430
	[BlackList] // 0x00000001897ADDD0-0x00000001897ADE10
	// [XID] // 0x00000001897ADDD0-0x00000001897ADE10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D94430-0x0000000183D945C0
	[BlackList] // 0x00000001897B8B60-0x00000001897B8BA0
	// [XID] // 0x00000001897B8B60-0x00000001897B8BA0
	public virtual void ReturnToObjectPool() {} // 0x0000000183D98CB0-0x0000000183D98D50
	[BlackList] // 0x00000001897C3A70-0x00000001897C3AB0
	// [XID] // 0x00000001897C3A70-0x00000001897C3AB0
	public virtual void OnPoolAllocated() {} // 0x0000000183D98780-0x0000000183D98820
	[BlackList] // 0x00000001897CE3C0-0x00000001897CE400
	// [XID] // 0x00000001897CE3C0-0x00000001897CE400
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D986E0-0x0000000183D98780
}

