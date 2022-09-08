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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AISkillInfo : IAutoAllocRecycle // TypeDefIndex: 19975
{
	// Fields
	public ConfigAISkill config; // 0x10
	public float nextAvailableUseTick; // 0x18
	public BaseEntity buddyChoice; // 0x20

	// Constructors
	public AISkillInfo() {} // 0x0000000181BAA520-0x0000000181BAA590

	// Methods
	[BlackList] // 0x0000000189775B00-0x0000000189775B40
	// [XID] // 0x0000000189775B00-0x0000000189775B40
	public virtual void AutoAllocTypeFields() {} // 0x0000000181BA96D0-0x0000000181BA9770
	[BlackList] // 0x0000000189780220-0x0000000189780260
	// [XID] // 0x0000000189780220-0x0000000189780260
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181BA9770-0x0000000181BA9820
	[BlackList] // 0x000000018978A9C0-0x000000018978AA00
	// [XID] // 0x000000018978A9C0-0x000000018978AA00
	public virtual void ReturnToObjectPool() {} // 0x0000000181BAA480-0x0000000181BAA520
	[BlackList] // 0x0000000189794EA0-0x0000000189794EE0
	// [XID] // 0x0000000189794EA0-0x0000000189794EE0
	public virtual void OnPoolAllocated() {} // 0x0000000181BAA3E0-0x0000000181BAA480
	[BlackList] // 0x00000001897A00B0-0x00000001897A00F0
	// [XID] // 0x00000001897A00B0-0x00000001897A00F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181BAA340-0x0000000181BAA3E0
	// [XID] // 0x0000000189912030-0x0000000189912050
	public void InitSkill(ConfigAISkill skillConfig, float? serverSkillCoolingTimeLeft, float currentTime) {} // 0x0000000181BA9D50-0x0000000181BA9F10
	// [XID] // 0x0000000189662EE0-0x0000000189662F00
	public void TriggerCD(float currentTime, float multiplier = 1f /* Metadata: 0x00AFD166 */) {} // 0x0000000181BA9F10-0x0000000181BAA090
	// [XID] // 0x00000001897B98F0-0x00000001897B9910
	public void TriggerPublicCD(LCAIManager aiManager) {} // 0x0000000181BA9820-0x0000000181BA9980
	// [XID] // 0x0000000189A01B60-0x0000000189A01B80
	public void SetAvailableNow(float currentTime) {} // 0x0000000181BA9AF0-0x0000000181BA9BA0
	// [XID] // 0x00000001897C9320-0x00000001897C9340
	public void ReTriggerInitialCD(float currentTime, float multiplier = 1f /* Metadata: 0x00AFD16A */) {} // 0x0000000181BAA090-0x0000000181BAA220
	// [XID] // 0x00000001897D0950-0x00000001897D0970
	public bool CheckNerve(AIKnowledge knowledge) => default; // 0x0000000181BA9BA0-0x0000000181BA9D50
	// [XID] // 0x00000001897D8700-0x00000001897D8720
	public bool CheckPose(int currentPose) => default; // 0x0000000181BA9980-0x0000000181BA9AF0
	// [XID] // 0x00000001897DF7D0-0x00000001897DF7F0
	internal bool CheckFlagSelfOnTemplateCollider(bool isOnTempCollider) => default; // 0x0000000181BAA220-0x0000000181BAA340
}

