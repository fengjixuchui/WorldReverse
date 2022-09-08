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

public sealed class MonsterModule : CharacterModule // TypeDefIndex: 21591
{
	// Fields
	private Dictionary<uint, Vector3> _monsterPositions; // 0x18

	// Constructors
	private MonsterModule() {} // 0x0000000182E41FD0-0x0000000182E42060

	// Methods
	// [XID] // 0x00000001897D84A0-0x00000001897D84C0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000182E3D050-0x0000000182E3D120
	// [XID] // 0x00000001897DF590-0x00000001897DF5B0
	public override bool OnPacket(Packet pkt) => default; // 0x0000000182E3CEB0-0x0000000182E3CFA0
	// [XID] // 0x00000001897E6DB0-0x00000001897E6DD0
	public void OnMonsterSummonTagNotify(MonsterSummonTagNotify notify) {} // 0x0000000182E3E110-0x0000000182E3E2E0
	// [XID] // 0x00000001897EEA80-0x00000001897EEAA0
	public void UpdateMonsterPropsByID(uint entityId, MapField<uint, PropValue> propMap) {} // 0x0000000182E3D7D0-0x0000000182E3D8C0
	// [XID] // 0x0000000189667A70-0x0000000189667A90
	public void UpdateMonsterFightPropsByID(uint entityId, MapField<uint, float> propMap, bool doClear = false /* Metadata: 0x00AFF9B3 */) {} // 0x0000000182E3CDA0-0x0000000182E3CEB0
	// [XID] // 0x000000018974A1D0-0x000000018974A1F0
	public MonsterDataItem GetMonsterDataByID(uint entityId) => default; // 0x0000000182E41000-0x0000000182E41110
	// [XID] // 0x0000000189805050-0x0000000189805070
	public override void EntityAppear(SceneEntityInfo entity, VisionType type, uint infoParam) {} // 0x0000000182E41300-0x0000000182E41FD0
	// [XID] // 0x000000018980C570-0x000000018980C590
	private Vector3 GetMonsterPos(SceneMonsterInfo info, Vector serverPos) => default; // 0x0000000182E3D8C0-0x0000000182E3DD80
	// [XID] // 0x0000000189813D00-0x0000000189813D20
	public static void CheckMonsterAffix(string from, uint runtimeId, uint configId, IList<uint> affixList) {} // 0x0000000182E3C710-0x0000000182E3CD20
	// [XID] // 0x000000018981B880-0x000000018981B8A0
	private BaseEntity MonsterAppear(SceneEntityInfo entity, VisionType type, BaseEntity baseEntity = null) => default; // 0x0000000182E3E4F0-0x0000000182E40F60
	// [XID] // 0x0000000189822E10-0x0000000189822E30
	public override void EntityDisappear(uint entityId, VisionType type) {} // 0x0000000182E41110-0x0000000182E41300
	// [XID] // 0x000000018982A790-0x000000018982A7B0
	private void HandleMonsterDie(uint entityId, VisionType type) {} // 0x0000000182E3DD80-0x0000000182E3DF00
	// [XID] // 0x0000000189831B40-0x0000000189831B60
	private void HandleMonsterPickUp(uint entityId, VisionType type) {} // 0x0000000182E3D120-0x0000000182E3D2E0
	// [XID] // 0x00000001898391C0-0x00000001898391E0
	private void HandleMonsterMissing(uint entityId, VisionType type) {} // 0x0000000182E3E2E0-0x0000000182E3E4F0
	// [XID] // 0x0000000189840830-0x0000000189840850
	private void HandleMonsterRemove(uint entityId, VisionType type) {} // 0x0000000182E3D2E0-0x0000000182E3D450
	// [XID] // 0x0000000189847D60-0x0000000189847D80
	public void MarkMonsterInMinimap(MarkEntityInMinMapNotify ntf) {} // 0x0000000182E3D450-0x0000000182E3D650
	// [XID] // 0x000000018984F520-0x000000018984F540
	public void UnmarkMonsterInMinimap(UnmarkEntityInMinMapNotify ntf) {} // 0x0000000182E3DF80-0x0000000182E3E110
	// [XID] // 0x00000001898566C0-0x00000001898566E0
	public bool TryGetMonsterPosition(uint entityID, out Vector3 position) {
		position = default;
		return default;
	} // 0x0000000182E3D650-0x0000000182E3D730
	// [XID] // 0x000000018985D9B0-0x000000018985D9D0
	public override void ClearOnLevelDestroy() {} // 0x0000000182E3CFA0-0x0000000182E3D050
	// [XID] // 0x0000000189865360-0x0000000189865380
	public override void ClearOnDisconnect() {} // 0x0000000182E40F60-0x0000000182E41000
}

