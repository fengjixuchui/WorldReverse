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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AISkillKnowledge : IAutoAllocRecycle // TypeDefIndex: 19976
{
	// Fields
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public List<AISkillContainer> skills; // 0x10
	// [PooledField] // 0x0000000189831DC0-0x0000000189831DE0
	public Dictionary<int, List<AISkillInfo>> needResetCDSkills; // 0x18
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillContainer skillsOnAware; // 0x20
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillContainer skillsOnAlert; // 0x28
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillContainer skillsOnNerve; // 0x30
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillContainer skillsCombat; // 0x38
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillContainer skillsFree; // 0x40
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillContainer skillsActionPoint; // 0x48
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillContainer skillsCombatBuddy; // 0x50
	// [PooledField] // 0x0000000189831DC0-0x0000000189831DE0
	public Dictionary<int, AISkillGroupCDInfo> skillGroupCDs; // 0x58
	// [PooledField] // 0x00000001898393C0-0x00000001898393E0
	public HashSet<string> caredTargetGlobalValueNames; // 0x60
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public Dictionary<string, float> caredTargetGlobalValues; // 0x68
	public float gcd; // 0x70
	public uint skillCount; // 0x74
	public float nextGCDTick; // 0x78
	public float cdMultiplier; // 0x7C
	public float lastCastSkillTick; // 0x80
	public byte currentSkillEliteSetID; // 0x84

	// Constructors
	public AISkillKnowledge() {} // 0x00000001830809D0-0x0000000183080A40

	// Methods
	[BlackList] // 0x0000000189847EE0-0x0000000189847F20
	// [XID] // 0x0000000189847EE0-0x0000000189847F20
	public virtual void AutoAllocTypeFields() {} // 0x000000018307E570-0x000000018307E6F0
	[BlackList] // 0x00000001898521D0-0x0000000189852210
	// [XID] // 0x00000001898521D0-0x0000000189852210
	public virtual void AutoRecycleTypeFields() {} // 0x000000018307E6F0-0x000000018307E8A0
	[BlackList] // 0x000000018985C810-0x000000018985C850
	// [XID] // 0x000000018985C810-0x000000018985C850
	public virtual void ReturnToObjectPool() {} // 0x0000000183080930-0x00000001830809D0
	[BlackList] // 0x0000000189866BD0-0x0000000189866C10
	// [XID] // 0x0000000189866BD0-0x0000000189866C10
	public virtual void OnPoolAllocated() {} // 0x00000001830807E0-0x0000000183080880
	[BlackList] // 0x0000000189870FE0-0x0000000189871020
	// [XID] // 0x0000000189870FE0-0x0000000189871020
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183080740-0x00000001830807E0
	// [XID] // 0x000000018987B940-0x000000018987B960
	public void ReInitByConfigID(BaseEntity.ReInitReason reason, ConfigAIBeta aiConfig, AIKnowledge aiKnowledge, LCAIBetaData aiCreationData) {} // 0x00000001830802D0-0x0000000183080740
	// [XID] // 0x0000000189882AD0-0x0000000189882AF0
	public void InitSkill(ConfigAIBeta aiConfig, AIKnowledge aiKnowledge, LCAIBetaData aiCreationData) {} // 0x000000018307F100-0x000000018307FCF0
	// [XID] // 0x0000000189AC6210-0x0000000189AC6230
	public bool CheckSkillGroupCD(int groupID, float aiKnowledgeTime) => default; // 0x00000001830801B0-0x00000001830802D0
	// [XID] // 0x00000001898916C0-0x00000001898916E0
	public void SetSkillGroupCD(int groupID, float aiKnowledgeTime) {} // 0x000000018307EC10-0x000000018307ED70
	// [XID] // 0x0000000189898FB0-0x0000000189898FD0
	public AISkillInfo GetSkill(uint skillID) => default; // 0x000000018307EA60-0x000000018307EC10
	// [XID] // 0x0000000189734E10-0x0000000189734E30
	public void SetGCD(float currentTime) {} // 0x000000018307ED70-0x000000018307EE30
	// [XID] // 0x00000001898A7990-0x00000001898A79B0
	public void SetSkillEliteSetID(byte id) {} // 0x0000000183080880-0x0000000183080930
	// [XID] // 0x00000001899CDC90-0x00000001899CDCB0
	public void SetAvailableNow(uint skillID, float currentTime) {} // 0x000000018307EE30-0x000000018307EFE0
	// [XID] // 0x0000000189A77BC0-0x0000000189A77BE0
	public void ReTriggerSkillInitialCD(uint skillID, float currentTime) {} // 0x000000018307E8A0-0x000000018307EA60
	// [XID] // 0x00000001898BE0E0-0x00000001898BE100
	internal void RecoverFromServer(AIKnowledge aiKnowledge, LCAIBetaData data) {} // 0x000000018307FCF0-0x00000001830801B0
	// [XID] // 0x00000001898C5950-0x00000001898C5970
	internal void Clear(AIKnowledge aiKnowledge) {} // 0x000000018307EFE0-0x000000018307F100
}

