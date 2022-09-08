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

public sealed class ActivityRegionSearchManager : InLevelManager, INotifyInterface // TypeDefIndex: 20739
{
	// Fields
	private BaseEntity _teamEntity; // 0x10
	private const float ACTIVITY_REGION_CHECK_GAP = 0.4f; // Metadata: 0x00AFE223
	private float _nextActivityRegionCheckTime; // 0x18
	private ActivityLogicRegionController _activityLogicRegionController_Self; // 0x20
	private ActivityLogicRegionController _activityLogicRegionController_Other; // 0x28

	// Properties
	private Vector3? localAvatarPosition { /* [XID] */ /* 0x00000001898874A0-0x00000001898874C0 */ get => default; } // 0x00000001835E8DD0-0x00000001835E8F50 
	private ActivityLogicRegionController activityLogicRegionController_Self { /* [XID] */ /* 0x000000018988E620-0x000000018988E640 */ get => default; } // 0x00000001835E9220-0x00000001835E92F0 
	private ActivityLogicRegionController activityLogicRegionController_Other { /* [XID] */ /* 0x0000000189895C40-0x0000000189895C60 */ get => default; } // 0x00000001835E9CA0-0x00000001835E9D70 

	// Constructors
	public ActivityRegionSearchManager() {} // 0x00000001835EA460-0x00000001835EA4E0

	// Methods
	// [XID] // 0x000000018989D280-0x000000018989D2A0
	private ActivityLogicRegionController GetController(ActivityRegionSearchQueryType type) => default; // 0x00000001835E8F50-0x00000001835E9060
	// [XID] // 0x00000001898A4C00-0x00000001898A4C20
	public override void Init() {} // 0x00000001835E9730-0x00000001835E9AC0
	// [XID] // 0x00000001898AC0E0-0x00000001898AC100
	public override void Destroy() {} // 0x00000001835E92F0-0x00000001835E93E0
	// [XID] // 0x00000001898B3800-0x00000001898B3820
	public override void Tick() {} // 0x00000001835EA230-0x00000001835EA460
	// [XID] // 0x00000001898BB5D0-0x00000001898BB5F0
	public override void ClearOnDisconnect() {} // 0x00000001835E9180-0x00000001835E9220
	// [XID] // 0x00000001898C2860-0x00000001898C2880
	public bool OnNotify(Notify ntf) => default; // 0x00000001835E9F60-0x00000001835EA070
	// [XID] // 0x00000001898CA2C0-0x00000001898CA2E0
	public ActivityRegion GetActivityRegionById(uint regionId, ActivityRegionSearchQueryType type) => default; // 0x00000001835E9AC0-0x00000001835E9BB0
	// [XID] // 0x00000001898D19F0-0x00000001898D1A10
	public ActivitySearchArea GetActivityRegionAreaById(uint areaId, ActivityRegionSearchQueryType type) => default; // 0x00000001835E9640-0x00000001835E9730
	// [XID] // 0x00000001898D9230-0x00000001898D9250
	public bool IsSearchActive(uint searchId, ActivityRegionSearchQueryType type) => default; // 0x00000001835E9550-0x00000001835E9640
	// [XID] // 0x00000001898E0E90-0x00000001898E0EB0
	public bool IsPositionInAnyActiveArea(Vector3 pos, ActivityRegionSearchQueryType type) => default; // 0x00000001835E8CC0-0x00000001835E8DD0
	// [XID] // 0x00000001898E8980-0x00000001898E89A0
	public ActivityRegion FindPositionInWhichRegion(Vector3 pos, ActivityRegionSearchQueryType type) => default; // 0x00000001835E9440-0x00000001835E9550
	// [XID] // 0x00000001898F0080-0x00000001898F00A0
	public List<ActivityRegion> GetActivityRegionList(uint searchId, ActivityRegionSearchQueryType type) => default; // 0x00000001835E9060-0x00000001835E9180
	// [XID] // 0x00000001898F79B0-0x00000001898F79D0
	public Dictionary<uint, ActivityRegion> GetActivityRegionDict(uint searchId, ActivityRegionSearchQueryType type) => default; // 0x00000001835E9BB0-0x00000001835E9CA0
	// [XID] // 0x00000001898FF010-0x00000001898FF030
	public void UpdateRegionInfoFromProto(uint uid, RepeatedMessageField<RegionSearchInfo> regionSearchInfoList) {} // 0x00000001835EA0D0-0x00000001835EA230
	// [XID] // 0x0000000189906790-0x00000001899067B0
	private void UpdateRegion() {} // 0x00000001835E9D70-0x00000001835E9F60
}

