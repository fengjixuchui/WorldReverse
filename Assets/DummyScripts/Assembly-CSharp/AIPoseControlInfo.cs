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
public class AIPoseControlInfo : IAutoAllocRecycle // TypeDefIndex: 19964
{
	// Fields
	private const float WAIT_TIME = 1f; // Metadata: 0x00AFD15E
	public ConfigAIPoseControlItem config; // 0x10
	public float nextAvailableUseTick; // 0x18

	// Constructors
	public AIPoseControlInfo() {} // 0x0000000183CB3730-0x0000000183CB37A0

	// Methods
	[BlackList] // 0x0000000189A4E3B0-0x0000000189A4E3F0
	// [XID] // 0x0000000189A4E3B0-0x0000000189A4E3F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183CB3070-0x0000000183CB3110
	[BlackList] // 0x0000000189A58A20-0x0000000189A58A60
	// [XID] // 0x0000000189A58A20-0x0000000189A58A60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183CB3110-0x0000000183CB31B0
	[BlackList] // 0x0000000189A63570-0x0000000189A635B0
	// [XID] // 0x0000000189A63570-0x0000000189A635B0
	public virtual void ReturnToObjectPool() {} // 0x0000000183CB3690-0x0000000183CB3730
	[BlackList] // 0x0000000189A6DCE0-0x0000000189A6DD20
	// [XID] // 0x0000000189A6DCE0-0x0000000189A6DD20
	public virtual void OnPoolAllocated() {} // 0x0000000183CB35F0-0x0000000183CB3690
	[BlackList] // 0x0000000189A78740-0x0000000189A78780
	// [XID] // 0x0000000189A78740-0x0000000189A78780
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183CB3550-0x0000000183CB35F0
	// [XID] // 0x0000000189A82F40-0x0000000189A82F60
	public void ReInitByConfigID(BaseEntity.ReInitReason reason, ConfigAIPoseControlItem configPoseControl, float currentTime) {} // 0x0000000183CB3470-0x0000000183CB3550
	// [XID] // 0x0000000189A8A800-0x0000000189A8A820
	public void InitPoseControl(ConfigAIPoseControlItem poseControlSetting, float currentTime) {} // 0x0000000183CB32E0-0x0000000183CB33B0
	// [XID] // 0x0000000189BABA10-0x0000000189BABA30
	public void ReInitNextAvailableUseTick(float currentTime) {} // 0x0000000183CB31B0-0x0000000183CB32E0
	// [XID] // 0x0000000189A99AA0-0x0000000189A99AC0
	public void ReInitNextAvailableUseTickWhenStateCantUseSkill(float currentTime) {} // 0x0000000183CB33B0-0x0000000183CB3470
}

