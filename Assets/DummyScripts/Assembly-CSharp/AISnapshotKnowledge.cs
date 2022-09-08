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
public class AISnapshotKnowledge : IAutoAllocRecycle // TypeDefIndex: 19977
{
	// Fields
	private bool currentSkillValid; // 0x10
	private uint currentSkillID; // 0x14
	private bool currentSkillSelected; // 0x18
	private bool currentSkillTryDoSkill; // 0x19
	private bool currentSkillSuccess; // 0x1A
	private bool currentSkillFailed; // 0x1B
	private Queue<AISnapshotSkillCycle> currentSkillCycles; // 0x20
	private Dictionary<uint, int> whoIHit; // 0x28
	private float movedDistance; // 0x30
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public TacticRecordInfo tacticRecord; // 0x38
	public int lastAnimationState; // 0x40
	public float lastAnimationStateChangeTime; // 0x44

	// Constructors
	public AISnapshotKnowledge() {} // 0x00000001813530F0-0x0000000181353150

	// Methods
	[BlackList] // 0x00000001898DC3B0-0x00000001898DC3F0
	// [XID] // 0x00000001898DC3B0-0x00000001898DC3F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181351B80-0x0000000181351C50
	[BlackList] // 0x00000001898E7250-0x00000001898E7290
	// [XID] // 0x00000001898E7250-0x00000001898E7290
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181351C50-0x0000000181351D30
	[BlackList] // 0x00000001898F1AD0-0x00000001898F1B10
	// [XID] // 0x00000001898F1AD0-0x00000001898F1B10
	public virtual void ReturnToObjectPool() {} // 0x0000000181353050-0x00000001813530F0
	[BlackList] // 0x00000001898FC130-0x00000001898FC170
	// [XID] // 0x00000001898FC130-0x00000001898FC170
	public virtual void OnPoolAllocated() {} // 0x0000000181352E50-0x0000000181352F10
	[BlackList] // 0x00000001899068D0-0x0000000189906910
	// [XID] // 0x00000001899068D0-0x0000000189906910
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181352D60-0x0000000181352E50
	// [XID] // 0x00000001897B2DE0-0x00000001897B2E00
	public void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x0000000181352BA0-0x0000000181352CA0
	// [IDTag] // 0x0000000189918BF0-0x0000000189918C30
	// [XID] // 0x0000000189918BF0-0x0000000189918C30
	public void CollectSnapshotData(AISnapshotInfo snapshotCollection, float now, AIKnowledge aiKnowledge, LCAIBeta lcai) {} // 0x0000000181352390-0x00000001813528E0
	// [IDTag] // 0x0000000189923400-0x0000000189923440
	// [XID] // 0x0000000189923400-0x0000000189923440
	public void CollectSnapshotData(AISnapshotInfoJson snapshotCollection, float now, AIKnowledge aiKnowledge, LCAIBeta lcai) {} // 0x0000000181351E80-0x0000000181352390
	// [XID] // 0x0000000189AAF440-0x0000000189AAF460
	public void RecordMove(float distance) {} // 0x0000000181352A00-0x0000000181352AF0
	// [XID] // 0x0000000189685C90-0x0000000189685CB0
	public void RecordHitAvatar(uint victimID) {} // 0x00000001813528E0-0x0000000181352A00
	// [XID] // 0x000000018993CB30-0x000000018993CB50
	public void RecordSkillStart(uint skillID) {} // 0x0000000181352CA0-0x0000000181352D60
	// [XID] // 0x00000001898AEBB0-0x00000001898AEBD0
	public void RecordTryDoSkill() {} // 0x0000000181351DE0-0x0000000181351E80
	// [XID] // 0x000000018994B740-0x000000018994B760
	public void RecordSkillSuccess() {} // 0x0000000181351D30-0x0000000181351DE0
	// [XID] // 0x0000000189893E00-0x0000000189893E20
	public void RecordSkillFail() {} // 0x0000000181352AF0-0x0000000181352BA0
	// [XID] // 0x000000018995A5F0-0x000000018995A610
	private void InternalSaveSkill() {} // 0x0000000181352F10-0x0000000181353050
}

