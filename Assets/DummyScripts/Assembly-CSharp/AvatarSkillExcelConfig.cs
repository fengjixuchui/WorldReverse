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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AvatarSkillExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15224
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected string _abilityName; // 0x18
	protected uint _descTextMapHash; // 0x20
	protected string _skillIcon; // 0x28
	protected bool _isRanged; // 0x30
	protected SimpleSafeFloat cdTimeRawNum; // 0x34
	protected bool _ignoreCDMinusRatio; // 0x38
	protected SimpleSafeFloat costStaminaRawNum; // 0x3C
	protected ElementType _costElemType; // 0x40
	protected SimpleSafeFloat costElemValRawNum; // 0x44
	protected SimpleSafeInt32 maxChargeNumRawNum; // 0x48
	protected SimpleSafeInt32 triggerIDRawNum; // 0x4C
	protected string _lockShape; // 0x50
	protected SimpleSafeFloat[] _lockWeightParams; // 0x58
	protected bool _isAttackCameraLock; // 0x60
	protected SkillDrag _dragType; // 0x64
	protected bool _showIconArrow; // 0x68
	protected MonitorType _needMonitor; // 0x6C
	protected bool _defaultLocked; // 0x70
	protected string _buffIcon; // 0x78
	protected SimpleSafeUInt32 proudSkillGroupIdRawNum; // 0x80
	protected string _globalValueKey; // 0x88
	protected SimpleSafeFloat energyMinRawNum; // 0x90
	protected bool _forceCanDoSkill; // 0x94
	protected SimpleSafeUInt32 cdSlotRawNum; // 0x98
	protected bool _needStore; // 0x9C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BD52F0-0x0000000189BD5310 */ get => default; /* [XID] */ /* 0x0000000189BDCE60-0x0000000189BDCE80 */ protected set {} } // 0x0000000184D2DFC0-0x0000000184D2E090 0x0000000184D2BFF0-0x0000000184D2C0D0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001895E9730-0x00000001895E9750 */ get => default; /* [XID] */ /* 0x00000001895F0F00-0x00000001895F0F20 */ protected set {} } // 0x0000000184D28C70-0x0000000184D28D10 0x0000000184D2DAB0-0x0000000184D2DB60
	public string name { /* [XID] */ /* 0x00000001895F8950-0x00000001895F8970 */ get => default; } // 0x0000000184D2E2F0-0x0000000184D2E470 
	public string abilityName { /* [XID] */ /* 0x00000001895FFDB0-0x00000001895FFDD0 */ get => default; /* [XID] */ /* 0x00000001896074A0-0x00000001896074C0 */ protected set {} } // 0x0000000184D2D6D0-0x0000000184D2D770 0x0000000184D2DCF0-0x0000000184D2DDA0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018960EF00-0x000000018960EF20 */ get => default; /* [XID] */ /* 0x0000000189616540-0x0000000189616560 */ protected set {} } // 0x0000000184D2D970-0x0000000184D2DA10 0x0000000184D29200-0x0000000184D292B0
	public string desc { /* [XID] */ /* 0x000000018961DDB0-0x000000018961DDD0 */ get => default; } // 0x0000000184D2B9D0-0x0000000184D2BB50 
	public string skillIcon { /* [XID] */ /* 0x00000001896251D0-0x00000001896251F0 */ get => default; /* [XID] */ /* 0x000000018962C9F0-0x000000018962CA10 */ protected set {} } // 0x0000000184D2BEB0-0x0000000184D2BF50 0x0000000184D28D10-0x0000000184D28DC0
	public bool isRanged { /* [XID] */ /* 0x0000000189634770-0x0000000189634790 */ get => default; /* [XID] */ /* 0x000000018963BEA0-0x000000018963BEC0 */ protected set {} } // 0x0000000184D2B930-0x0000000184D2B9D0 0x0000000184D2B6F0-0x0000000184D2B7A0
	public float cdTime { /* [XID] */ /* 0x0000000189643560-0x0000000189643580 */ get => default; /* [XID] */ /* 0x000000018964ABA0-0x000000018964ABC0 */ protected set {} } // 0x0000000184D2C180-0x0000000184D2C260 0x0000000184D2E090-0x0000000184D2E170
	public bool ignoreCDMinusRatio { /* [XID] */ /* 0x0000000189652360-0x0000000189652380 */ get => default; /* [XID] */ /* 0x0000000189659A90-0x0000000189659AB0 */ protected set {} } // 0x0000000184D2D820-0x0000000184D2D8C0 0x0000000184D292B0-0x0000000184D29360
	public float costStamina { /* [XID] */ /* 0x00000001896611D0-0x00000001896611F0 */ get => default; /* [XID] */ /* 0x0000000189668C60-0x0000000189668C80 */ protected set {} } // 0x0000000184D2BB50-0x0000000184D2BC30 0x0000000184D2DDA0-0x0000000184D2DE80
	public ElementType costElemType { /* [XID] */ /* 0x00000001897EAFF0-0x00000001897EB010 */ get => default; /* [XID] */ /* 0x0000000189677FF0-0x0000000189678010 */ protected set {} } // 0x0000000184D2E170-0x0000000184D2E210 0x0000000184D28710-0x0000000184D287C0
	public float costElemVal { /* [XID] */ /* 0x000000018967F6C0-0x000000018967F6E0 */ get => default; /* [XID] */ /* 0x0000000189686F70-0x0000000189686F90 */ protected set {} } // 0x0000000184D2B560-0x0000000184D2B640 0x0000000184D284B0-0x0000000184D28590
	public int maxChargeNum { /* [XID] */ /* 0x00000001896CB4D0-0x00000001896CB4F0 */ get => default; /* [XID] */ /* 0x00000001896966F0-0x0000000189696710 */ protected set {} } // 0x0000000184D28FA0-0x0000000184D29070 0x0000000184D2DC10-0x0000000184D2DCF0
	public int triggerID { /* [XID] */ /* 0x000000018969DD90-0x000000018969DDB0 */ get => default; /* [XID] */ /* 0x00000001896A4D40-0x00000001896A4D60 */ protected set {} } // 0x0000000184D2BC30-0x0000000184D2BD00 0x0000000184D2E210-0x0000000184D2E2F0
	public string lockShape { /* [XID] */ /* 0x00000001896AC5F0-0x00000001896AC610 */ get => default; /* [XID] */ /* 0x00000001896B3830-0x00000001896B3850 */ protected set {} } // 0x0000000184D2BF50-0x0000000184D2BFF0 0x0000000184D2C260-0x0000000184D2C310
	public SimpleSafeFloat[] lockWeightParams { /* [XID] */ /* 0x00000001896BAF30-0x00000001896BAF50 */ get => default; /* [XID] */ /* 0x00000001896C20E0-0x00000001896C2100 */ protected set {} } // 0x0000000184D28DC0-0x0000000184D28E60 0x0000000184D2D8C0-0x0000000184D2D970
	public bool isAttackCameraLock { /* [XID] */ /* 0x00000001896C96F0-0x00000001896C9710 */ get => default; /* [XID] */ /* 0x00000001896D0E40-0x00000001896D0E60 */ protected set {} } // 0x0000000184D28670-0x0000000184D28710 0x0000000184D29070-0x0000000184D29120
	public SkillDrag dragType { /* [XID] */ /* 0x00000001896D8550-0x00000001896D8570 */ get => default; /* [XID] */ /* 0x00000001896DFF80-0x00000001896DFFA0 */ protected set {} } // 0x0000000184D2B410-0x0000000184D2B4B0 0x0000000184D2B640-0x0000000184D2B6F0
	public bool showIconArrow { /* [XID] */ /* 0x00000001896E71A0-0x00000001896E71C0 */ get => default; /* [XID] */ /* 0x00000001896EE810-0x00000001896EE830 */ protected set {} } // 0x0000000184D2DA10-0x0000000184D2DAB0 0x0000000184D28B10-0x0000000184D28BC0
	public MonitorType needMonitor { /* [XID] */ /* 0x00000001896F60A0-0x00000001896F60C0 */ get => default; /* [XID] */ /* 0x00000001896FD8D0-0x00000001896FD8F0 */ protected set {} } // 0x0000000184D28E60-0x0000000184D28F00 0x0000000184D2DB60-0x0000000184D2DC10
	public bool defaultLocked { /* [XID] */ /* 0x0000000189704D70-0x0000000189704D90 */ get => default; /* [XID] */ /* 0x000000018970C470-0x000000018970C490 */ protected set {} } // 0x0000000184D2B2A0-0x0000000184D2B340 0x0000000184D28400-0x0000000184D284B0
	public string buffIcon { /* [XID] */ /* 0x0000000189713DE0-0x0000000189713E00 */ get => default; /* [XID] */ /* 0x000000018971B660-0x000000018971B680 */ protected set {} } // 0x0000000184D28F00-0x0000000184D28FA0 0x0000000184D2B4B0-0x0000000184D2B560
	public uint proudSkillGroupId { /* [XID] */ /* 0x00000001897228A0-0x00000001897228C0 */ get => default; /* [XID] */ /* 0x000000018972A000-0x000000018972A020 */ protected set {} } // 0x0000000184D2BDE0-0x0000000184D2BEB0 0x0000000184D28590-0x0000000184D28670
	public string globalValueKey { /* [XID] */ /* 0x000000018996BB40-0x000000018996BB60 */ get => default; /* [XID] */ /* 0x0000000189738EF0-0x0000000189738F10 */ protected set {} } // 0x0000000184D2C0D0-0x0000000184D2C180 0x0000000184D28BC0-0x0000000184D28C70
	public float energyMin { /* [XID] */ /* 0x0000000189740CC0-0x0000000189740CE0 */ get => default; /* [XID] */ /* 0x0000000189748200-0x0000000189748220 */ protected set {} } // 0x0000000184D2B850-0x0000000184D2B930 0x0000000184D2BD00-0x0000000184D2BDE0
	public bool forceCanDoSkill { /* [XID] */ /* 0x000000018974FA90-0x000000018974FAB0 */ get => default; /* [XID] */ /* 0x0000000189757060-0x0000000189757080 */ protected set {} } // 0x0000000184D2D770-0x0000000184D2D820 0x0000000184D2B7A0-0x0000000184D2B850
	public uint cdSlot { /* [XID] */ /* 0x0000000189790030-0x0000000189790050 */ get => default; /* [XID] */ /* 0x0000000189765CD0-0x0000000189765CF0 */ protected set {} } // 0x0000000184D2B340-0x0000000184D2B410 0x0000000184D29120-0x0000000184D29200
	public bool needStore { /* [XID] */ /* 0x000000018976D4C0-0x000000018976D4E0 */ get => default; /* [XID] */ /* 0x0000000189774890-0x00000001897748B0 */ protected set {} } // 0x0000000184D2B1F0-0x0000000184D2B2A0 0x0000000184D28A60-0x0000000184D28B10

	// Constructors
	public AvatarSkillExcelConfig() {} // 0x0000000184D2E510-0x0000000184D2E570

	// Methods
	// [IDTag] // 0x000000018977C2A0-0x000000018977C2E0
	// [XID] // 0x000000018977C2A0-0x000000018977C2E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184D29360-0x0000000184D2A290
	// [IDTag] // 0x0000000189786AC0-0x0000000189786B00
	// [XID] // 0x0000000189786AC0-0x0000000189786B00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184D2A290-0x0000000184D2B1F0
	// [XID] // 0x0000000189791010-0x0000000189791030
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0449 */, bool useObjectPool = false /* Metadata: 0x00AF044D */) => default; // 0x0000000184D2C310-0x0000000184D2D6D0
	[BlackList] // 0x00000001897988A0-0x00000001897988E0
	// [XID] // 0x00000001897988A0-0x00000001897988E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D287C0-0x0000000184D28860
	[BlackList] // 0x00000001897A3660-0x00000001897A36A0
	// [XID] // 0x00000001897A3660-0x00000001897A36A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D28860-0x0000000184D28A60
	[BlackList] // 0x00000001897ADCD0-0x00000001897ADD10
	// [XID] // 0x00000001897ADCD0-0x00000001897ADD10
	public virtual void ReturnToObjectPool() {} // 0x0000000184D2E470-0x0000000184D2E510
	[BlackList] // 0x00000001897B8AA0-0x00000001897B8AE0
	// [XID] // 0x00000001897B8AA0-0x00000001897B8AE0
	public virtual void OnPoolAllocated() {} // 0x0000000184D2DF20-0x0000000184D2DFC0
	[BlackList] // 0x00000001897C3970-0x00000001897C39B0
	// [XID] // 0x00000001897C3970-0x00000001897C39B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D2DE80-0x0000000184D2DF20
}

