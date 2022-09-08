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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class AIPoseControlKnowledge : IAutoAllocRecycle // TypeDefIndex: 19965
{
	// Fields
	// [PooledField] // 0x0000000189831DC0-0x0000000189831DE0
	public Dictionary<int, List<AIPoseControlInfo>> poseControlInfos; // 0x10
	private ConfigAIPoseControl config; // 0x20

	// Properties
	public int lastPoseID { /* [XID] */ /* 0x0000000189ADA5A0-0x0000000189ADA5E0 */ get; /* [XID] */ /* 0x0000000189AE50E0-0x0000000189AE5120 */ private set; } // 0x0000000182654DD0-0x0000000182654E30 0x0000000182655580-0x00000001826555E0

	// Constructors
	public AIPoseControlKnowledge() {} // 0x00000001826558A0-0x0000000182655900

	// Methods
	[BlackList] // 0x0000000189ABA960-0x0000000189ABA9A0
	// [XID] // 0x0000000189ABA960-0x0000000189ABA9A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182654C00-0x0000000182654CD0
	[BlackList] // 0x0000000189AC5370-0x0000000189AC53B0
	// [XID] // 0x0000000189AC5370-0x0000000189AC53B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182654CD0-0x0000000182654DD0
	[BlackList] // 0x0000000189ACF870-0x0000000189ACF8B0
	// [XID] // 0x0000000189ACF870-0x0000000189ACF8B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182655800-0x00000001826558A0
	// [XID] // 0x0000000189AEFC60-0x0000000189AEFC80
	public void ReInitByConfigID(BaseEntity.ReInitReason reason, ConfigAIPoseControl configPoseControl, float currentTime) {} // 0x00000001826555E0-0x00000001826556C0
	// [XID] // 0x0000000189AF71E0-0x0000000189AF7200
	public void InitPoseControl(ConfigAIPoseControl poseControlSetting, float currentTime) {} // 0x0000000182654E30-0x0000000182655130
	// [XID] // 0x0000000189AE4720-0x0000000189AE4740
	public void OnPoseChanged(int toPose, float currentTime) {} // 0x0000000182655390-0x0000000182655580
	[BlackList] // 0x0000000189B060A0-0x0000000189B060E0
	// [XID] // 0x0000000189B060A0-0x0000000189B060E0
	public virtual void OnPoolAllocated() {} // 0x0000000182655760-0x0000000182655800
	[BlackList] // 0x0000000189B108F0-0x0000000189B10930
	// [XID] // 0x0000000189B108F0-0x0000000189B10930
	public virtual void OnBeforePoolRecycled() {} // 0x00000001826556C0-0x0000000182655760
	// [XID] // 0x0000000189B1ABC0-0x0000000189B1ABE0
	private void RecycleInfos() {} // 0x0000000182655130-0x0000000182655390
}

