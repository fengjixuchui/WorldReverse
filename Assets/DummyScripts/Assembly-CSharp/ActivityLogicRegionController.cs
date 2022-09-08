/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ActivityLogicRegionController // TypeDefIndex: 20651
{
	// Fields
	private Dictionary<uint, Dictionary<uint, ActivityRegion>> _searchs; // 0x10
	private Dictionary<uint, bool> _searchFirstIn; // 0x18
	private ActivityRegionSearchImplementBase _eventSender; // 0x20

	// Constructors
	public ActivityLogicRegionController() {} // Dummy constructor
	public ActivityLogicRegionController(ActivityRegionSearchQueryType type) {} // 0x0000000181BFD5B0-0x0000000181BFD7D0

	// Methods
	// [XID] // 0x000000018980C6D0-0x000000018980C6F0
	public ActivityRegion GetRegionById(uint _regionId) => default; // 0x0000000181BFC700-0x0000000181BFCA30
	// [XID] // 0x0000000189813E60-0x0000000189813E80
	public ActivitySearchArea GetSearchAreaById(uint _areaId) => default; // 0x0000000181BF9F30-0x0000000181BFA340
	// [XID] // 0x000000018981B9A0-0x000000018981B9C0
	public ActivityRegion GetRegion(uint searchId, uint regionId) => default; // 0x0000000181BFCA30-0x0000000181BFCBA0
	// [XID] // 0x0000000189822F30-0x0000000189822F50
	public bool HasSearchEntered(uint searchId) => default; // 0x0000000181BFC600-0x0000000181BFC700
	// [XID] // 0x000000018982A8B0-0x000000018982A8D0
	public Dictionary<uint, ActivityRegion> GetActivityLogicRegion(uint _searchId) => default; // 0x0000000181BFCF00-0x0000000181BFCFF0
	// [XID] // 0x0000000189831CC0-0x0000000189831CE0
	public bool IsPositionInRegion(Vector3 currentTeamPos, ActivityRegion targetRegion) => default; // 0x0000000181BFB120-0x0000000181BFB3B0
	// [XID] // 0x0000000189839320-0x0000000189839340
	public bool IsSearchActive(uint searchId) => default; // 0x0000000181BFB950-0x0000000181BFBCB0
	// [XID] // 0x0000000189840910-0x0000000189840930
	public void RefreshAllFromProto(RepeatedMessageField<RegionSearchInfo> regionSearchInfoList) {} // 0x0000000181BFBCB0-0x0000000181BFC600
	// [XID] // 0x0000000189847E60-0x0000000189847E80
	private void RefreshOneSearchRegionFromProto_Exist(uint searchId, Dictionary<uint, ActivityRegion> dict, RepeatedMessageField<RegionSearch> regionSearch) {} // 0x0000000181BFA5B0-0x0000000181BFB120
	// [XID] // 0x000000018984F5E0-0x000000018984F600
	private void RefreshOneSearchRegionFromProto_NotExist(uint searchId, Dictionary<uint, ActivityRegion> dict, RepeatedMessageField<RegionSearch> regionSearch) {} // 0x0000000181BFD200-0x0000000181BFD5B0
	// [XID] // 0x00000001898567C0-0x00000001898567E0
	public void UpdateAllRegion(Vector3 currentTeamPos, bool forceTriggerInOutChangeCallBack = false /* Metadata: 0x00AFDF67 */) {} // 0x0000000181BFCBA0-0x0000000181BFCF00
	// [XID] // 0x000000018985DA70-0x000000018985DA90
	private void UpdateSingleRegion(ActivityRegion region, Vector3 currentTeamPos, bool forceTriggerInOutChangeCallBack = false /* Metadata: 0x00AFDF68 */) {} // 0x0000000181BFCFF0-0x0000000181BFD200
	// [XID] // 0x0000000189865510-0x0000000189865530
	private void UpdateSingleArea(ActivitySearchArea area, Vector3 currentTeamPos, bool forceTriggerInOutChangeCallBack = false /* Metadata: 0x00AFDF69 */) {} // 0x0000000181BFA340-0x0000000181BFA5B0
	// [XID] // 0x000000018986C950-0x000000018986C970
	public ActivityRegion FindPositionInWhichRegion(Vector3 pos) => default; // 0x0000000181BFB3B0-0x0000000181BFB950
	// [XID] // 0x0000000189873E00-0x0000000189873E20
	public bool IsPositionInAnyActiveArea(Vector3 pos) => default; // 0x0000000181BF99B0-0x0000000181BF9F30
}

