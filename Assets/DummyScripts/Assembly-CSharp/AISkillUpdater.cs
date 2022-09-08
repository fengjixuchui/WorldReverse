/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AISkillUpdater : BrainModuleBase // TypeDefIndex: 20438
{
	// Constructors
	public AISkillUpdater() {} // Dummy constructor
	public AISkillUpdater(AIKnowledge knowledge) {} // 0x0000000184B107E0-0x0000000184B10880

	// Methods
	// [XID] // 0x00000001898A1AA0-0x00000001898A1AC0
	protected override void UpdateMainThreadInternal(float deltaTime) {} // 0x0000000184B0EFD0-0x0000000184B0F280
	// [XID] // 0x00000001898A9330-0x00000001898A9350
	protected override void UpdateComputeThreadInternal(float deltaTime) {} // 0x0000000184B0E780-0x0000000184B0E830
	// [XID] // 0x00000001898B0B80-0x00000001898B0BA0
	public void UpdateSkillsAvailability() {} // 0x0000000184B0EC10-0x0000000184B0EF50
	// [XID] // 0x0000000189751500-0x0000000189751520
	public void OnPoseChanged(int toPose) {} // 0x0000000184B0FA40-0x0000000184B0FBF0
	// [XID] // 0x00000001898BF9C0-0x00000001898BF9E0
	private bool Validate(AISkillInfo skill, ConfigAISkillType type) => default; // 0x0000000184B0FE50-0x0000000184B10560
	// [XID] // 0x00000001898C7220-0x00000001898C7240
	private bool CheckSkillEliteSetActived(AISkillInfo skill) => default; // 0x0000000184B0EA90-0x0000000184B0EC10
	// [XID] // 0x00000001898CE7B0-0x00000001898CE7D0
	private bool CheckBaseCriteria(AISkillInfo skill) => default; // 0x0000000184B0F830-0x0000000184B0FA40
	// [XID] // 0x00000001898D6190-0x00000001898D61B0
	private bool CheckCooldown(AISkillInfo skill) => default; // 0x0000000184B0F3B0-0x0000000184B0F650
	// [XID] // 0x00000001898DDDE0-0x00000001898DDE00
	private bool CheckCommand(AISkillInfo skill) => default; // 0x0000000184B0F280-0x0000000184B0F3B0
	// [XID] // 0x00000001898E56E0-0x00000001898E5700
	private bool CheckCombatPreloaded() => default; // 0x0000000184B106F0-0x0000000184B107E0
	// [XID] // 0x00000001898ECF40-0x00000001898ECF60
	private bool CheckAvatarBuckets(AISkillInfo skill, BaseEntity entity) => default; // 0x0000000184B10560-0x0000000184B106F0
	// [XID] // 0x00000001898F47C0-0x00000001898F47E0
	private bool CheckGlobalValues(AISkillInfo skill, AISkillKnowledge skillKnowledge) => default; // 0x0000000184B0FBF0-0x0000000184B0FE50
	// [XID] // 0x00000001898FC0B0-0x00000001898FC0D0
	private bool UpdateCheckBuddySkill(AISkillInfo skill) => default; // 0x0000000184B0E6A0-0x0000000184B0E780
	// [XID] // 0x0000000189903B70-0x0000000189903B90
	public static void OnEnterCombat(AIKnowledge aiKnowledge) {} // 0x0000000184B0F650-0x0000000184B0F830
	// [XID] // 0x000000018990B070-0x000000018990B090
	public static void OnLeaveCombat(AIKnowledge aiKnowledge) {} // 0x0000000184B0E830-0x0000000184B0EA10
}

