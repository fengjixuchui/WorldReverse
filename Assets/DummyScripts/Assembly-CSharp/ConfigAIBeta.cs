/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAIBeta : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17515
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeInt32 friendlinessRawNum; // 0x14
	private DecisionArchetype _decisionArchetype; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIMove _moveSetting; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIPrecombatSetting _precombat; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICombatSetting _aiCombat; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBuddySetting _buddySetting; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISensing _sensing; // 0x40
	private Dictionary<string, NeuronName[]> _neurons; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIThreatSetting _threat; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIOrderSetting _order; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIDefendArea _defendArea; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFlySetting _fly; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIPoseControl _poseControl; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIUISetting _ui; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIProfilingSetting _profiling; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAINetworkSetting _network; // 0x88
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAISkillGroupCD[] _skillGroupCDConfigs; // 0x90
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISkillSetting _skillSetting; // 0x98
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAISkill> _skills; // 0xA0
	private SimpleSafeFloat skillGCDRawNum; // 0xA8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIReturnToBornPosSetting _returnToBornTactic; // 0xB0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIWanderSetting _wanderTactic; // 0xB8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFollowScriptedPathSetting _followScriptedPathTactic; // 0xC0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFollowServerRouteSetting _followServerRouteTactic; // 0xC8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIInvestigateSetting _investigateTactic; // 0xD0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIReactActionPointSetting _reactActionPointTactic; // 0xD8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIPatrolFollowSetting _patrolFollowTactic; // 0xE0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICombatFollowMoveSetting _combatFollowMoveTactic; // 0xE8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIMeleeChargeSetting _meleeChargeTactic; // 0xF0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFacingMoveSetting _facingMoveTactic; // 0xF8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISurroundSetting _surroundTactic; // 0x100
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFindBackSetting _findBackTactic; // 0x108
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICombatFixedMoveSetting _combatFixedMoveTactic; // 0x110
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICrabMoveSetting _crabMoveTactic; // 0x118
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFleeSetting _fleeTactic; // 0x120
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISpacialChaseSetting _spacialChaseTactic; // 0x128
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISpacialProbeSetting _spacialProbeTactic; // 0x130
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISpacialAdjustSetting _spacialAdjustTactic; // 0x138
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBirdCirclingSetting _birdCirclingTactic; // 0x140
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIScriptedMoveToSetting _scriptedMoveToTactic; // 0x148
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAILandingSetting _landingTactic; // 0x150
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIExtractionSetting _extractionTactic; // 0x158
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBrownianMotionSetting _brownianMotionTactic; // 0x160
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIMixinSetting _mixin; // 0x168
	public static Action<ConfigAIBeta, bool> postProcessData; // 0x00
	public static Action<ConfigAIBeta> postInitEmpty; // 0x08
	[BlackList] // 0x0000000189A3C630-0x0000000189A3C680
	[JsonIgnore] // 0x0000000189A3C630-0x0000000189A3C680
	// [PooledField] // 0x0000000189A3C630-0x0000000189A3C680
	public HashSet<string> caredTargetGlobalValueNames; // 0x170
	private static Dictionary<byte, HashSet<uint>> _skillEliteSets; // 0x10

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189A58E20-0x0000000189A58E40 */ get => default; /* [XID] */ /* 0x0000000189A60760-0x0000000189A60780 */ private set {} } // 0x0000000184537090-0x0000000184537130 0x00000001845395D0-0x0000000184539680
	public int friendliness { /* [XID] */ /* 0x0000000189A685D0-0x0000000189A685F0 */ get => default; /* [XID] */ /* 0x0000000189A6F900-0x0000000189A6F920 */ private set {} } // 0x0000000184539C00-0x0000000184539CD0 0x000000018453D020-0x000000018453D100
	public DecisionArchetype decisionArchetype { /* [XID] */ /* 0x0000000189AFB1A0-0x0000000189AFB1C0 */ get => default; /* [XID] */ /* 0x0000000189A7EB00-0x0000000189A7EB20 */ private set {} } // 0x0000000184539ED0-0x0000000184539F70 0x00000001845363B0-0x0000000184536460
	public ConfigAIMove moveSetting { /* [XID] */ /* 0x0000000189A86310-0x0000000189A86330 */ get => default; /* [XID] */ /* 0x0000000189A8DD10-0x0000000189A8DD30 */ private set {} } // 0x00000001845337B0-0x0000000184533850 0x0000000184533450-0x0000000184533500
	public ConfigAIPrecombatSetting precombat { /* [XID] */ /* 0x0000000189A952F0-0x0000000189A95310 */ get => default; /* [XID] */ /* 0x0000000189A9CAB0-0x0000000189A9CAD0 */ private set {} } // 0x00000001845331B0-0x0000000184533250 0x0000000184536670-0x0000000184536720
	public ConfigAICombatSetting aiCombat { /* [XID] */ /* 0x0000000189AA42A0-0x0000000189AA42C0 */ get => default; /* [XID] */ /* 0x0000000189AAB7B0-0x0000000189AAB7D0 */ private set {} } // 0x0000000184539480-0x0000000184539520 0x0000000184538210-0x00000001845382C0
	public ConfigAIBuddySetting buddySetting { /* [XID] */ /* 0x000000018985E830-0x000000018985E850 */ get => default; /* [XID] */ /* 0x0000000189ABAD70-0x0000000189ABAD90 */ private set {} } // 0x00000001845379D0-0x0000000184537A70 0x000000018453D100-0x000000018453D1B0
	public ConfigAISensing sensing { /* [XID] */ /* 0x000000018979C7E0-0x000000018979C800 */ get => default; /* [XID] */ /* 0x0000000189AC9D00-0x0000000189AC9D20 */ private set {} } // 0x0000000184533250-0x00000001845332F0 0x0000000184537710-0x00000001845377C0
	public Dictionary<string, NeuronName[]> neurons { /* [XID] */ /* 0x000000018980D640-0x000000018980D660 */ get => default; /* [XID] */ /* 0x0000000189AD92D0-0x0000000189AD92F0 */ private set {} } // 0x0000000184533850-0x00000001845338F0 0x0000000184536460-0x0000000184536510
	public ConfigAIThreatSetting threat { /* [XID] */ /* 0x00000001898CDE60-0x00000001898CDE80 */ get => default; /* [XID] */ /* 0x0000000189AE8250-0x0000000189AE8270 */ private set {} } // 0x0000000184536880-0x0000000184536920 0x00000001845371E0-0x0000000184537290
	public ConfigAIOrderSetting order { /* [XID] */ /* 0x00000001897AB000-0x00000001897AB020 */ get => default; /* [XID] */ /* 0x0000000189AF75C0-0x0000000189AF75E0 */ private set {} } // 0x0000000184533710-0x00000001845337B0 0x0000000184537870-0x0000000184537920
	public ConfigAIDefendArea defendArea { /* [XID] */ /* 0x00000001898BEE40-0x00000001898BEE60 */ get => default; /* [XID] */ /* 0x0000000189B06440-0x0000000189B06460 */ private set {} } // 0x00000001845339A0-0x0000000184533A40 0x0000000184536A80-0x0000000184536B30
	public ConfigAIFlySetting fly { /* [XID] */ /* 0x00000001897D14E0-0x00000001897D1500 */ get => default; /* [XID] */ /* 0x0000000189B14FB0-0x0000000189B14FD0 */ private set {} } // 0x000000018453A020-0x000000018453A0C0 0x0000000184539E20-0x0000000184539ED0
	public ConfigAIPoseControl poseControl { /* [XID] */ /* 0x0000000189B1C990-0x0000000189B1C9B0 */ get => default; /* [XID] */ /* 0x0000000189B23EE0-0x0000000189B23F00 */ private set {} } // 0x0000000184539CD0-0x0000000184539D70 0x00000001845333A0-0x0000000184533450
	public ConfigAIUISetting ui { /* [XID] */ /* 0x0000000189B2B200-0x0000000189B2B220 */ get => default; /* [XID] */ /* 0x0000000189B32820-0x0000000189B32840 */ private set {} } // 0x0000000184536310-0x00000001845363B0 0x0000000184537130-0x00000001845371E0
	public ConfigAIProfilingSetting profiling { /* [XID] */ /* 0x0000000189B3C0F0-0x0000000189B3C110 */ get => default; /* [XID] */ /* 0x0000000189B41A50-0x0000000189B41A70 */ private set {} } // 0x0000000184536920-0x00000001845369D0 0x0000000184537340-0x00000001845373F0
	public ConfigAINetworkSetting network { /* [XID] */ /* 0x0000000189B49480-0x0000000189B494A0 */ get => default; /* [XID] */ /* 0x0000000189B50B00-0x0000000189B50B20 */ private set {} } // 0x0000000184539AA0-0x0000000184539B50 0x0000000184538160-0x0000000184538210
	public ConfigAISkillGroupCD[] skillGroupCDConfigs { /* [XID] */ /* 0x0000000189B58360-0x0000000189B58380 */ get => default; /* [XID] */ /* 0x0000000189B5FCC0-0x0000000189B5FCE0 */ private set {} } // 0x0000000184538900-0x00000001845389B0 0x0000000184531C20-0x0000000184531CD0
	public ConfigAISkillSetting skillSetting { /* [XID] */ /* 0x00000001898FB440-0x00000001898FB460 */ get => default; /* [XID] */ /* 0x0000000189B6E560-0x0000000189B6E580 */ private set {} } // 0x0000000184531AC0-0x0000000184531B70 0x00000001845373F0-0x00000001845374A0
	public Dictionary<string, ConfigAISkill> skills { /* [XID] */ /* 0x00000001899030F0-0x0000000189903110 */ get => default; /* [XID] */ /* 0x0000000189B7D2C0-0x0000000189B7D2E0 */ private set {} } // 0x0000000184537920-0x00000001845379D0 0x0000000184533100-0x00000001845331B0
	public float skillGCD { /* [XID] */ /* 0x0000000189B850B0-0x0000000189B850D0 */ get => default; /* [XID] */ /* 0x0000000189B8BEE0-0x0000000189B8BF00 */ private set {} } // 0x000000018453D1B0-0x000000018453D290 0x0000000184537630-0x0000000184537710
	public ConfigAIReturnToBornPosSetting returnToBornTactic { /* [XID] */ /* 0x000000018983A1E0-0x000000018983A200 */ get => default; /* [XID] */ /* 0x0000000189B9AC00-0x0000000189B9AC20 */ private set {} } // 0x0000000184539680-0x0000000184539730 0x00000001845387A0-0x0000000184538850
	public ConfigAIWanderSetting wanderTactic { /* [XID] */ /* 0x0000000189BA23D0-0x0000000189BA23F0 */ get => default; /* [XID] */ /* 0x0000000189BA9900-0x0000000189BA9920 */ private set {} } // 0x0000000184538370-0x0000000184538420 0x0000000184539520-0x00000001845395D0
	public ConfigAIFollowScriptedPathSetting followScriptedPathTactic { /* [XID] */ /* 0x0000000189BB10F0-0x0000000189BB1110 */ get => default; /* [XID] */ /* 0x0000000189BB8260-0x0000000189BB8280 */ private set {} } // 0x000000018453A170-0x000000018453A220 0x0000000184536510-0x00000001845365C0
	public ConfigAIFollowServerRouteSetting followServerRouteTactic { /* [XID] */ /* 0x0000000189BBF950-0x0000000189BBF970 */ get => default; /* [XID] */ /* 0x0000000189BC75A0-0x0000000189BC75C0 */ private set {} } // 0x0000000184539F70-0x000000018453A020 0x0000000184536B30-0x0000000184536BE0
	public ConfigAIInvestigateSetting investigateTactic { /* [XID] */ /* 0x0000000189857690-0x00000001898576B0 */ get => default; /* [XID] */ /* 0x0000000189BD6540-0x0000000189BD6560 */ private set {} } // 0x00000001845365C0-0x0000000184536670 0x00000001845377C0-0x0000000184537870
	public ConfigAIReactActionPointSetting reactActionPointTactic { /* [XID] */ /* 0x000000018985E850-0x000000018985E870 */ get => default; /* [XID] */ /* 0x00000001895EACB0-0x00000001895EACD0 */ private set {} } // 0x00000001845332F0-0x00000001845333A0 0x00000001845335B0-0x0000000184533660
	public ConfigAIPatrolFollowSetting patrolFollowTactic { /* [XID] */ /* 0x00000001895F2170-0x00000001895F2190 */ get => default; /* [XID] */ /* 0x00000001895F9AA0-0x00000001895F9AC0 */ private set {} } // 0x0000000184539890-0x0000000184539940 0x00000001845369D0-0x0000000184536A80
	public ConfigAICombatFollowMoveSetting combatFollowMoveTactic { /* [XID] */ /* 0x00000001898B0260-0x00000001898B0280 */ get => default; /* [XID] */ /* 0x0000000189608C50-0x0000000189608C70 */ private set {} } // 0x000000018453C310-0x000000018453C3C0 0x00000001845338F0-0x00000001845339A0
	public ConfigAIMeleeChargeSetting meleeChargeTactic { /* [XID] */ /* 0x0000000189610410-0x0000000189610430 */ get => default; /* [XID] */ /* 0x00000001896176F0-0x0000000189617710 */ private set {} } // 0x0000000184538850-0x0000000184538900 0x00000001845393D0-0x0000000184539480
	public ConfigAIFacingMoveSetting facingMoveTactic { /* [XID] */ /* 0x000000018961F2E0-0x000000018961F300 */ get => default; /* [XID] */ /* 0x00000001896266A0-0x00000001896266C0 */ private set {} } // 0x0000000184533A40-0x0000000184533AF0 0x000000018453C3C0-0x000000018453C470
	public ConfigAISurroundSetting surroundTactic { /* [XID] */ /* 0x0000000189874CB0-0x0000000189874CD0 */ get => default; /* [XID] */ /* 0x0000000189635C50-0x0000000189635C70 */ private set {} } // 0x000000018453CF70-0x000000018453D020 0x0000000184533500-0x00000001845335B0
	public ConfigAIFindBackSetting findBackTactic { /* [XID] */ /* 0x000000018963D350-0x000000018963D370 */ get => default; /* [XID] */ /* 0x0000000189644890-0x00000001896448B0 */ private set {} } // 0x00000001845397E0-0x0000000184539890 0x0000000184539D70-0x0000000184539E20
	public ConfigAICombatFixedMoveSetting combatFixedMoveTactic { /* [XID] */ /* 0x0000000189899EB0-0x0000000189899ED0 */ get => default; /* [XID] */ /* 0x0000000189653780-0x00000001896537A0 */ private set {} } // 0x0000000184533050-0x0000000184533100 0x0000000184538A60-0x0000000184538B10
	public ConfigAICrabMoveSetting crabMoveTactic { /* [XID] */ /* 0x0000000189892420-0x0000000189892440 */ get => default; /* [XID] */ /* 0x0000000189662540-0x0000000189662560 */ private set {} } // 0x00000001845374A0-0x0000000184537550 0x00000001845380B0-0x0000000184538160
	public ConfigAIFleeSetting fleeTactic { /* [XID] */ /* 0x000000018966A140-0x000000018966A160 */ get => default; /* [XID] */ /* 0x0000000189671DC0-0x0000000189671DE0 */ private set {} } // 0x0000000184531B70-0x0000000184531C20 0x0000000184536260-0x0000000184536310
	public ConfigAISpacialChaseSetting spacialChaseTactic { /* [XID] */ /* 0x0000000189883850-0x0000000189883870 */ get => default; /* [XID] */ /* 0x0000000189680C80-0x0000000189680CA0 */ private set {} } // 0x0000000184538000-0x00000001845380B0 0x000000018453CEC0-0x000000018453CF70
	public ConfigAISpacialProbeSetting spacialProbeTactic { /* [XID] */ /* 0x0000000189688720-0x0000000189688740 */ get => default; /* [XID] */ /* 0x0000000189690060-0x0000000189690080 */ private set {} } // 0x0000000184537A70-0x0000000184537B20 0x000000018453C260-0x000000018453C310
	public ConfigAISpacialAdjustSetting spacialAdjustTactic { /* [XID] */ /* 0x00000001896979E0-0x0000000189697A00 */ get => default; /* [XID] */ /* 0x000000018969EE10-0x000000018969EE30 */ private set {} } // 0x00000001845367D0-0x0000000184536880 0x00000001845399F0-0x0000000184539AA0
	public ConfigAIBirdCirclingSetting birdCirclingTactic { /* [XID] */ /* 0x00000001896A6190-0x00000001896A61B0 */ get => default; /* [XID] */ /* 0x00000001896AD670-0x00000001896AD690 */ private set {} } // 0x0000000184539940-0x00000001845399F0 0x0000000184539B50-0x0000000184539C00
	public ConfigAIScriptedMoveToSetting scriptedMoveToTactic { /* [XID] */ /* 0x00000001896B4DD0-0x00000001896B4DF0 */ get => default; /* [XID] */ /* 0x00000001896BC0E0-0x00000001896BC100 */ private set {} } // 0x00000001845389B0-0x0000000184538A60 0x0000000184539730-0x00000001845397E0
	public ConfigAILandingSetting landingTactic { /* [XID] */ /* 0x00000001898A10E0-0x00000001898A1100 */ get => default; /* [XID] */ /* 0x00000001896CAB30-0x00000001896CAB50 */ private set {} } // 0x000000018453A0C0-0x000000018453A170 0x0000000184533AF0-0x0000000184533BA0
	public ConfigAIExtractionSetting extractionTactic { /* [XID] */ /* 0x00000001896D2200-0x00000001896D2220 */ get => default; /* [XID] */ /* 0x00000001896D9B90-0x00000001896D9BB0 */ private set {} } // 0x0000000184536FE0-0x0000000184537090 0x0000000184533660-0x0000000184533710
	public ConfigAIBrownianMotionSetting brownianMotionTactic { /* [XID] */ /* 0x00000001896E1250-0x00000001896E1270 */ get => default; /* [XID] */ /* 0x00000001896E84C0-0x00000001896E84E0 */ private set {} } // 0x00000001845382C0-0x0000000184538370 0x0000000184538B10-0x0000000184538BC0
	public ConfigAIMixinSetting mixin { /* [XID] */ /* 0x0000000189823CC0-0x0000000189823CE0 */ get => default; /* [XID] */ /* 0x00000001896F7430-0x00000001896F7450 */ private set {} } // 0x0000000184536720-0x00000001845367D0 0x0000000184537290-0x0000000184537340

	// Constructors
	public ConfigAIBeta() {} // 0x000000018453D540-0x000000018453D610
	static ConfigAIBeta() {} // 0x000000018453D330-0x000000018453D540

	// Methods
	// [XID] // 0x0000000189700CC0-0x0000000189700CE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018453C470-0x000000018453CD10
	// [XID] // 0x0000000189705FE0-0x0000000189706000
	public void InitEmpty() {} // 0x0000000184537B20-0x0000000184538000
	[BlackList] // 0x000000018970D890-0x000000018970D8D0
	// [XID] // 0x000000018970D890-0x000000018970D8D0
	public bool FromJson(JSONNode node) => default; // 0x0000000184536BE0-0x0000000184536FE0
	// [XID] // 0x0000000189717EB0-0x0000000189717ED0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018452EB70-0x00000001845317F0
	// [XID] // 0x000000018971F850-0x000000018971F870
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF716B */, bool useObjectPool = false /* Metadata: 0x00AF716F */) => default; // 0x0000000184538420-0x00000001845387A0
	// [XID] // 0x0000000189726EA0-0x0000000189726EC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7170 */, bool useObjectPool = false /* Metadata: 0x00AF7174 */) => default; // 0x0000000184533BA0-0x0000000184536260
	[BlackList] // 0x000000018972E3B0-0x000000018972E3F0
	// [XID] // 0x000000018972E3B0-0x000000018972E3F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001845317F0-0x0000000184531AC0
	// [XID] // 0x0000000189738C10-0x0000000189738C30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018453A220-0x000000018453C260
	[BlackList] // 0x0000000189740A00-0x0000000189740A40
	// [XID] // 0x0000000189740A00-0x0000000189740A40
	public virtual void OnPoolAllocated() {} // 0x000000018453CE20-0x000000018453CEC0
	[BlackList] // 0x000000018974B240-0x000000018974B280
	// [XID] // 0x000000018974B240-0x000000018974B280
	public virtual void OnBeforePoolRecycled() {} // 0x000000018453CD10-0x000000018453CE20
	// [XID] // 0x0000000189755690-0x00000001897556B0
	private static void OnPostInitEmpty(ConfigAIBeta data) {} // 0x0000000184537550-0x0000000184537630
	// [XID] // 0x000000018975C8D0-0x000000018975C8F0
	private static void OnPostProcessDataCallback(ConfigAIBeta data, bool useObjectPool) {} // 0x0000000184538BC0-0x00000001845393D0
	[BlackList] // 0x00000001897640C0-0x0000000189764100
	// [XID] // 0x00000001897640C0-0x0000000189764100
	public virtual void AutoAllocTypeFields() {} // 0x0000000184531CD0-0x0000000184531D70
	[BlackList] // 0x000000018976E660-0x000000018976E6A0
	// [XID] // 0x000000018976E660-0x000000018976E6A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184531D70-0x0000000184533050
	[BlackList] // 0x0000000189779000-0x0000000189779040
	// [XID] // 0x0000000189779000-0x0000000189779040
	public virtual void ReturnToObjectPool() {} // 0x000000018453D290-0x000000018453D330
}

