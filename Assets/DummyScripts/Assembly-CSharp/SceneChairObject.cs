/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x000000018987FF20-0x000000018987FF60
[RecycleType] // 0x000000018987FF20-0x000000018987FF60
public sealed class SceneChairObject : BaseScenePropObject, IAutoAllocRecycle, IChair // TypeDefIndex: 20233
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private SceneChairConfig _config; // 0x30
	private Vector3[] _sitPositions; // 0x38
	private Quaternion[] _sitRotations; // 0x40
	private Vector3?[] _lastRefreshChairPositions; // 0x48
	private SceneChairConfig.SitDirection?[] _lastRefreshChairDirections; // 0x50
	private uint[] _occupiedEntityIDs; // 0x58
	private bool _applyDynamicSitdownCheck; // 0x60
	private bool _dynamicCheckFinished; // 0x61
	private List<DynamicSitPointDirectionConfig> _dynamicSitdownPointConfigs; // 0x68
	private int _dynamicSitdownPointCheckLayer; // 0x70
	private Collider[] _overlapColliders; // 0x78
	private Vector3 _dynamicSitdownPointCheckCenter; // 0x80
	private Vector3 _dynamicSitdownPointCheckSize; // 0x8C

	// Properties
	public SceneChairConfig config { /* [XID] */ /* 0x0000000189926480-0x00000001899264A0 */ get => default; /* [XID] */ /* 0x000000018992DB30-0x000000018992DB50 */ set {} } // 0x00000001836CA0C0-0x00000001836CA250 0x00000001836C5D20-0x00000001836C5DD0

	// Constructors
	public SceneChairObject() {} // 0x00000001836CA9F0-0x00000001836CAB20

	// Methods
	[BlackList] // 0x0000000189906890-0x00000001899068D0
	// [XID] // 0x0000000189906890-0x00000001899068D0
	public override void AutoAllocTypeFields() {} // 0x00000001836C5B80-0x00000001836C5C20
	[BlackList] // 0x0000000189911010-0x0000000189911050
	// [XID] // 0x0000000189911010-0x0000000189911050
	public override void AutoRecycleTypeFields() {} // 0x00000001836C5C20-0x00000001836C5D20
	[BlackList] // 0x000000018991BD40-0x000000018991BD80
	// [XID] // 0x000000018991BD40-0x000000018991BD80
	public override void ReturnToObjectPool() {} // 0x00000001836CA950-0x00000001836CA9F0
	// [XID] // 0x0000000189934FD0-0x0000000189934FF0
	public override void InitSceneProp(string name, GameObject obj, ScenePropType type, string effectPattern = null) {} // 0x00000001836C88E0-0x00000001836C8B30
	// [XID] // 0x000000018993CB10-0x000000018993CB30
	public override void ReleaseSceneProp() {} // 0x00000001836C9D90-0x00000001836C9EB0
	// [XID] // 0x0000000189944180-0x00000001899441A0
	public Vector3 ComputeSitPosition(int index, SceneChairConfig.SitDirection enterDirection, BaseEntity entity = null) => default; // 0x00000001836CA250-0x00000001836CA4B0
	// [XID] // 0x000000018994B720-0x000000018994B740
	public Vector3 ComputeSitDownPosition(int index, SceneChairConfig.SitDirection enterDirection, BaseEntity entity = null) => default; // 0x00000001836C7E70-0x00000001836C8210
	// [XID] // 0x0000000189953010-0x0000000189953030
	public Vector3 GetSitPositionSimple(int index, BaseEntity entity = null) => default; // 0x00000001836CA5B0-0x00000001836CA950
	// [XID] // 0x000000018995A590-0x000000018995A5B0
	public Quaternion GetChairRotation(BaseEntity entity = null) => default; // 0x00000001836C8E30-0x00000001836C8F40
	// [XID] // 0x0000000189962090-0x00000001899620B0
	public Quaternion ComputeSitRotation(int index, SceneChairConfig.SitDirection enterDirection) => default; // 0x00000001836C92C0-0x00000001836C93F0
	// [XID] // 0x00000001899695C0-0x00000001899695E0
	private void RefreshSitPositionRotation(int index, SceneChairConfig.SitDirection enterDirection) {} // 0x00000001836C75E0-0x00000001836C7E70
	// [XID] // 0x0000000189971240-0x0000000189971260
	public SceneChairConfig.SitDownPoint GetSitDownPosition(int index) => default; // 0x00000001836C8D40-0x00000001836C8E30
	// [XID] // 0x0000000189978BB0-0x0000000189978BD0
	public int GetSitUpPerformID() => default; // 0x00000001836C9EB0-0x00000001836C9F80
	// [XID] // 0x000000018997FC50-0x000000018997FC70
	public int GetSitDownPerformID() => default; // 0x00000001836C93F0-0x00000001836C94C0
	// [XID] // 0x0000000189987570-0x0000000189987590
	public SceneChairConfig.SitDirection GetStandDirection(int index, float angle) => default; // 0x00000001836C8210-0x00000001836C8520
	// [XID] // 0x000000018998F180-0x000000018998F1A0
	public SceneChairConfig.SitDownData GetNearestSitDownPoint(Vector3 position, SceneChairConfig.SitDirection? direction, bool ignoreInteeDistance, bool ignoreOccupied = true /* Metadata: 0x00AFD416 */) => default; // 0x00000001836C5FE0-0x00000001836C6790
	// [XID] // 0x0000000189996B60-0x0000000189996B80
	public SceneChairConfig.SitDownData GetSitDownDataByID(Vector3 position, long id) => default; // 0x00000001836C9730-0x00000001836C9D30
	// [XID] // 0x000000018999E750-0x000000018999E770
	public bool IsSittable(Vector3 position, SceneChairConfig.SitDownData sitData) => default; // 0x00000001836C5DD0-0x00000001836C5FE0
	// [XID] // 0x00000001899A60F0-0x00000001899A6110
	public void FreeFromEntity(int index, uint entityID) {} // 0x00000001836C8B30-0x00000001836C8C80
	// [XID] // 0x00000001899AD720-0x00000001899AD740
	public void OccupiedByEntity(int index, uint entityID) {} // 0x00000001836C8FE0-0x00000001836C9130
	// [XID] // 0x00000001899B4FA0-0x00000001899B4FC0
	private int GetSlotIndex(int sitPointIndex) => default; // 0x00000001836C9F80-0x00000001836CA0C0
	// [XID] // 0x00000001899BC6F0-0x00000001899BC710
	public void CheckOccupied() {} // 0x00000001836C70B0-0x00000001836C7150
	// [XID] // 0x00000001899C4060-0x00000001899C4080
	public bool IsFree(int index) => default; // 0x00000001836C9130-0x00000001836C92C0
	// [XID] // 0x00000001899CB830-0x00000001899CB850
	public bool IsOccupiedByEntity(int index, uint entityID) => default; // 0x00000001836C6A00-0x00000001836C6B50
	// [XID] // 0x00000001899D2CD0-0x00000001899D2CF0
	public Transform GetTransform() => default; // 0x00000001836CA4B0-0x00000001836CA5B0
	// [XID] // 0x00000001899DA260-0x00000001899DA280
	private VCBasePerform GetEntityVCBasePerform(uint entityID) => default; // 0x00000001836C8520-0x00000001836C8670
	// [XID] // 0x00000001899E1DC0-0x00000001899E1DE0
	private void InitDynamicSitPoint() {} // 0x00000001836C94C0-0x00000001836C9730
	// [XID] // 0x00000001899E91B0-0x00000001899E91D0
	public void VerifyDynamicSitdownPoint() {} // 0x00000001836C6B50-0x00000001836C70B0
	// [XID] // 0x00000001899F0A30-0x00000001899F0A50
	private bool VerifySitdownPointEntryDynamic(int sitdownPointIndex, SceneChairConfig.SitDirection direction) => default; // 0x00000001836C71B0-0x00000001836C75E0
	// [XID] // 0x00000001899F8170-0x00000001899F8190
	public bool IsSitdownPointDynamicValid(int sitdownPointIndex) => default; // 0x00000001836C8670-0x00000001836C88E0
	// [XID] // 0x00000001899FF800-0x00000001899FF820
	private bool IsSitdownPointDirectionDynamicValid(int sitdownPointIndex, SceneChairConfig.SitDirection direction) => default; // 0x00000001836C6790-0x00000001836C6A00
}

