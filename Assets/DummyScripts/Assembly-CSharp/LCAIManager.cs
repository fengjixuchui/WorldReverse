/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAIManager : LCBase, INotifyInterface // TypeDefIndex: 11692
{
	// Fields
	private LevelEntity _levelEntity; // 0x130
	private float _time; // 0x138
	private AINetworkManager _networkManager; // 0x140
	private AIGroupManager _aiGroupManager; // 0x148
	private AIPatrolGroupManager _aiPatrolGroupManager; // 0x150
	private AIEventScheduler _eventScheduler; // 0x158
	private AIMeleeSlotManager _meleeSlotManager; // 0x160
	private AISkillPublicCDManager _skillPublicCDManager; // 0x168
	private Dictionary<uint, LCAIBeta> _aiUnits; // 0x170
	private List<LCAIBeta> _localAvatarAlertEnemies; // 0x178
	private List<LCAIBeta> _localAvatarAwareEnemies; // 0x180
	private BaseEntity _localAvatar; // 0x188
	private VCLocalInputController _avatarInputController; // 0x190
	private bool _localAvatarInCombat; // 0x198
	private bool _worldInCombat; // 0x199
	public Dictionary<uint, Dictionary<uint, IList<BaseEntity>>> _aiEnemyEntityTable; // 0x1A0
	private Dictionary<uint, List<BaseEntity>> _configIDEntityTable; // 0x1A8
	private List<BaseEntity> _inteeEntityList; // 0x1B0
	private bool _isInInteraction; // 0x1B8
	private AIBehaviorRecorder _behaviorRecorder; // 0x1C0
	private InGameDrawer ingameDrawer; // 0x1C8
	private LevelAiManagerTask _levelAiManagerTask; // 0x1D0
	private LevelAiManagerData _levelAiManagerData; // 0x1D8
	private float _nextTickCombatInfo; // 0x1E8
	private float _nextTickLevelInfo; // 0x1EC
	private float _nextTickMeleeSlotInfo; // 0x1F0
	private float _nextTickPathfollowAvoidance; // 0x1F4

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189688FA0-0x0000000189688FC0 */ get => default; } // 0x0000000181DFD940-0x0000000181DFD9E0 
	public Dictionary<uint, List<BaseEntity>> configIDEntityTable { /* [XID] */ /* 0x0000000189690AC0-0x0000000189690AE0 */ get => default; /* [XID] */ /* 0x0000000189698360-0x0000000189698380 */ set {} } // 0x0000000181DFB150-0x0000000181DFB200 0x0000000181DF8830-0x0000000181DF88E0

	// Constructors
	public LCAIManager() {} // Dummy constructor
	public LCAIManager(LevelEntity levelEntity) {} // 0x0000000181DFD6A0-0x0000000181DFD940
	static LCAIManager() {} // 0x0000000181DFD620-0x0000000181DFD6A0

	// Methods
	// [XID] // 0x000000018969F620-0x000000018969F640
	public override void Init() {} // 0x0000000181DFA9D0-0x0000000181DFAC60
	// [XID] // 0x00000001896A69A0-0x00000001896A69C0
	protected override void Tick(float inDeltaTime) {} // 0x0000000181DFD520-0x0000000181DFD620
	// [XID] // 0x00000001896AE070-0x00000001896AE090
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181DFBA40-0x0000000181DFBAF0
	// [XID] // 0x0000000189A20F80-0x0000000189A20FA0
	public override void Destroy() {} // 0x0000000181DF9000-0x0000000181DF93C0
	// [XID] // 0x00000001896BC9C0-0x00000001896BC9E0
	public void RefreshLocalPlayerCaches() {} // 0x0000000181DFC5F0-0x0000000181DFC6F0
	// [XID] // 0x00000001896C3F00-0x00000001896C3F20
	public void AddAI(LCAIBeta unit) {} // 0x0000000181DFA1A0-0x0000000181DFA5A0
	// [XID] // 0x00000001896CB390-0x00000001896CB3B0
	public void RemoveAI(LCAIBeta unit) {} // 0x0000000181DFB820-0x0000000181DFBA40
	// [XID] // 0x00000001896D2930-0x00000001896D2950
	public void ScheduleEventSync(BaseEvent e, AIEventScheduler.Category c) {} // 0x0000000181DFAF50-0x0000000181DFB030
	// [XID] // 0x00000001896DA400-0x00000001896DA420
	public bool CanUseSkill(string pCDName, BaseEntity targetEntity) => default; // 0x0000000181DFD380-0x0000000181DFD460
	// [XID] // 0x000000018990D940-0x000000018990D960
	public void SetSkillUsed(string pCDName) {} // 0x0000000181DFCE40-0x0000000181DFCF10
	// [XID] // 0x00000001896E8FB0-0x00000001896E8FD0
	public bool RequestMeleeSlot(uint attackerID, uint targetID, ref Vector3 slotPos) => default; // 0x0000000181DF8360-0x0000000181DF8460
	// [XID] // 0x0000000189685CB0-0x0000000189685CD0
	public Dictionary<uint, IList<BaseEntity>> GetEnemies(uint campID) => default; // 0x0000000181DF8E80-0x0000000181DF8F80
	// [XID] // 0x00000001896F7A90-0x00000001896F7AB0
	public VCLocalInputController GetCachedLocalAvatarInputController() => default; // 0x0000000181DF88E0-0x0000000181DF89A0
	// [XID] // 0x0000000189B1B9A0-0x0000000189B1B9C0
	public BaseEntity GetCachedLocalAvatar() => default; // 0x0000000181DFD460-0x0000000181DFD520
	// [XID] // 0x0000000189706900-0x0000000189706920
	public void TriggerLevelAbility(string abilityName, uint targetID) {} // 0x0000000181DF8C40-0x0000000181DF8D50
	// [XID] // 0x0000000189B38FF0-0x0000000189B39010
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000181DF9FA0-0x0000000181DFA0A0
	// [XID] // 0x0000000189715610-0x0000000189715630
	protected override bool ListenEvent(BaseEvent evt) => default; // 0x0000000181DFBAF0-0x0000000181DFBC60
	// [XID] // 0x0000000189B82780-0x0000000189B827A0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181DFA0A0-0x0000000181DFA1A0
	// [XID] // 0x0000000189B9FCC0-0x0000000189B9FCE0
	protected override bool OnEvent(BaseEvent evt) => default; // 0x0000000181DFCA80-0x0000000181DFCD50
	// [XID] // 0x00000001896A6B10-0x00000001896A6B30
	public bool OnNotify(Notify ntf) => default; // 0x0000000181DFCD50-0x0000000181DFCE40
	// [XID] // 0x00000001897333D0-0x00000001897333F0
	private void OnInteractionRealStart(Notify ntf) {} // 0x0000000181DFC880-0x0000000181DFCA80
	// [XID] // 0x00000001899EB5F0-0x00000001899EB610
	public void RegisterDiagnosingNote(uint runtimeID, string note) {} // 0x0000000181DFB030-0x0000000181DFB150
	// [XID] // 0x00000001897423E0-0x0000000189742400
	public void RecordBehaviorsOnFrameEnd() {} // 0x0000000181DF9530-0x0000000181DF9770
	// [XID] // 0x0000000189749FD0-0x0000000189749FF0
	public void ClearRecorderData() {} // 0x0000000181DF8780-0x0000000181DF8830
	// [XID] // 0x0000000189751350-0x0000000189751370
	public void DebugForceAllAILeaveCombat() {} // 0x0000000181DFCF10-0x0000000181DFD0E0
	// [XID] // 0x0000000189758790-0x00000001897587B0
	public Dictionary<uint, LCAIBeta> GetAllAI() => default; // 0x0000000181DFA740-0x0000000181DFA7F0
	// [XID] // 0x0000000189662EC0-0x0000000189662EE0
	public LCAIBeta GetAI(uint entityID) => default; // 0x0000000181DF93C0-0x0000000181DF94B0
	// [XID] // 0x0000000189767760-0x0000000189767780
	public bool IsLocalAvatarInCombat() => default; // 0x0000000181DFA5A0-0x0000000181DFA650
	// [IDTag] // 0x000000018976EE50-0x000000018976EE90
	// [XID] // 0x000000018976EE50-0x000000018976EE90
	public List<LCAIBeta> GetLocalAvatarAlertedEnemies() => default; // 0x0000000181DFD2D0-0x0000000181DFD380
	// [IDTag] // 0x00000001897798C0-0x0000000189779900
	// [XID] // 0x00000001897798C0-0x0000000189779900
	public void GetLocalAvatarAlertedEnemies(EntityType enemyType, ref List<BaseEntityHandle> alertedEnemies) {} // 0x0000000181DFD0E0-0x0000000181DFD2D0
	// [XID] // 0x000000018969F8A0-0x000000018969F8C0
	public void GetLocalAvatarEnemyInfoForCamera(BaseEntity centerEntity, float countNearbyRange, float heightNearbyRange, out int count, out float height) {
		count = default;
		height = default;
	} // 0x0000000181DF9770-0x0000000181DF9BE0
	// [XID] // 0x000000018978B870-0x000000018978B890
	public void GetLocalAvatarEnemyForStealth(BaseEntity centerEntity, float sneakRange, ref Dictionary<BaseEntity, float> result) {} // 0x0000000181DFBC60-0x0000000181DFC3F0
	// [XID] // 0x00000001896BF810-0x00000001896BF830
	public LCAIBeta GetLocalAvatarNearestAlertedEnemyForAudio(Vector3 avatarPosition) => default; // 0x0000000181DFAC60-0x0000000181DFAEF0
	// [XID] // 0x00000001896C7230-0x00000001896C7250
	public void SwitchLocalAvatarWalkingAI(bool enable) {} // 0x0000000181DFA7F0-0x0000000181DFA9D0
	// [XID] // 0x00000001896CE880-0x00000001896CE8A0
	public void SwitchLocalAvatarCombatAI(bool enable) {} // 0x0000000181DF89A0-0x0000000181DF8C40
	// [XID] // 0x00000001898F57B0-0x00000001898F57D0
	public void SetScriptedMoveTo(List<Vector3> pos) {} // 0x0000000181DF8D50-0x0000000181DF8E80
	// [XID] // 0x00000001898FCF00-0x00000001898FCF20
	public void AITOOL_DrawDefendArea(uint entityID) {} // 0x0000000181DF84C0-0x0000000181DF8610
	// [XID] // 0x000000018991B450-0x000000018991B470
	public void AITOOL_HideDefendArea() {} // 0x0000000181DF86D0-0x0000000181DF8780
	// [XID] // 0x00000001897C0E90-0x00000001897C0EB0
	private void CreateComputeThreadTask() {} // 0x0000000181DF9C60-0x0000000181DF9D20
	// [XID] // 0x00000001897C87F0-0x00000001897C8810
	private void DestroyComputeThreadTask() {} // 0x0000000181DFA650-0x0000000181DFA740
	// [XID] // 0x000000018992A180-0x000000018992A1A0
	public void UpdateComputeThread() {} // 0x0000000181DF8610-0x0000000181DF86D0
	// [XID] // 0x00000001897D7610-0x00000001897D7630
	private void UpdateCombatInfo() {} // 0x0000000181DFB200-0x0000000181DFB820
	// [XID] // 0x0000000189943630-0x0000000189943650
	private void UpdateLevelInfo() {} // 0x0000000181DF9D20-0x0000000181DF9FA0
	// [XID] // 0x00000001897E6550-0x00000001897E6570
	private void UpdateMeleeSlotInfo() {} // 0x0000000181DFC4E0-0x0000000181DFC5F0
	// [XID] // 0x00000001897EE0A0-0x00000001897EE0C0
	private void UpdatePathfollowDynamicAvoidance() {} // 0x0000000181DFC6F0-0x0000000181DFC880
}

