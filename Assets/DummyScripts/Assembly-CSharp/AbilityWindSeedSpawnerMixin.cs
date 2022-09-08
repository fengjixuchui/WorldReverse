/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityWindSeedSpawnerMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14601
{
	// Fields
	private const int MAX_RANDOM_NUM = 20; // Metadata: 0x00AEB949
	private const float DISTANCE_CHECK_INTERVAL = 1f; // Metadata: 0x00AEB94D
	private const float REFRESH_CHECK_INTERVAL = 0.5f; // Metadata: 0x00AEB951
	private const float HEIGHT_ABOVE_GROUND = 0.2f; // Metadata: 0x00AEB955
	private const float GRASS_OFFSET_TIMES = 2f; // Metadata: 0x00AEB959
	private WindSeedSpawnerMixin _spawnerConfig; // 0x70
	private float _lastDistanceCheckTime; // 0x78
	private float _lastRefreshTime; // 0x7C
	private float _refreshMeter; // 0x80
	private Vector3 _lastAvatarPosition; // 0x84
	private List<MiHoYoGrassInfo> _avaliableGrass; // 0x90
	private List<MiHoYoGrassInfo> _spawnCandidateGrass; // 0x98
	private List<Vector3> _restrictionSeedPos; // 0xA0
	private LCAbility _teamAbility; // 0xA8
	private static Vector3[] _tileCheckTopLeft; // 0x00
	private static Vector3[] _tileCheckTopRight; // 0x08
	private static Vector3[] _tileCheckBotLeft; // 0x10
	private static Vector3[] _tileCheckBotRight; // 0x18
	private static Vector3[][] _grassCheckOffsets; // 0x20

	// Constructors
	public AbilityWindSeedSpawnerMixin() {} // 0x0000000182E37F90-0x0000000182E38070
	static AbilityWindSeedSpawnerMixin() {} // 0x0000000182E37900-0x0000000182E37F90

	// Methods
	// [XID] // 0x0000000189634A20-0x0000000189634A40
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182E34D60-0x0000000182E34F20
	// [XID] // 0x000000018963C180-0x000000018963C1A0
	public override void Clear() {} // 0x0000000182E35120-0x0000000182E351E0
	// [XID] // 0x0000000189643820-0x0000000189643840
	protected override void AddEventListener() {} // 0x0000000182E347C0-0x0000000182E349D0
	// [XID] // 0x000000018964ADA0-0x000000018964ADC0
	protected override void RemoveEventListener() {} // 0x0000000182E362A0-0x0000000182E364B0
	// [XID] // 0x0000000189652620-0x0000000189652640
	public override void OnAdded(bool syncToServer) {} // 0x0000000182E33230-0x0000000182E33440
	// [XID] // 0x0000000189659DD0-0x0000000189659DF0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182E34CB0-0x0000000182E34D60
	// [XID] // 0x0000000189661480-0x00000001896614A0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182E35850-0x0000000182E35930
	// [XID] // 0x0000000189669050-0x0000000189669070
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000182E366E0-0x0000000182E36990
	// [XID] // 0x0000000189670A00-0x0000000189670A20
	public override void Tick(float inDeltaTime) {} // 0x0000000182E376D0-0x0000000182E37900
	// [XID] // 0x0000000189678270-0x0000000189678290
	private void UpdateRefreshMeter() {} // 0x0000000182E36EF0-0x0000000182E375B0
	// [XID] // 0x000000018967FB70-0x000000018967FB90
	private void ClearRefreshMeter() {} // 0x0000000182E34B90-0x0000000182E34C30
	// [XID] // 0x0000000189687220-0x0000000189687240
	private int GetWindBulletNum() => default; // 0x0000000182E33440-0x0000000182E336E0
	// [XID] // 0x000000018968EFD0-0x000000018968EFF0
	private ulong GetLocalPlayerID() => default; // 0x0000000182E36BB0-0x0000000182E36CE0
	// [XID] // 0x0000000189696A90-0x0000000189696AB0
	public void OnSeverWindSeedNotify(EvtWindSeedNotify notify) {} // 0x0000000182E36DA0-0x0000000182E36EF0
	// [XID] // 0x000000018969DFE0-0x000000018969E000
	public void OnWindSeedDebugNotify(EvtWindSeedDebugNotify notify) {} // 0x0000000182E343E0-0x0000000182E347C0
	// [XID] // 0x00000001896A5010-0x00000001896A5030
	private void AttemptToSendSpawnPositions(uint spawmNum = 1 /* Metadata: 0x00AEB945 */) {} // 0x0000000182E35990-0x0000000182E362A0
	// [XID] // 0x00000001896AC960-0x00000001896AC980
	private void SelectAvailableGrassToSpawn(List<MiHoYoGrassInfo> grassInfos) {} // 0x0000000182E336E0-0x0000000182E341C0
	// [XID] // 0x00000001896B3BF0-0x00000001896B3C10
	private void ResetAbilityMixinData(AbilityMixinWindSeedSpawner abilityMessage) {} // 0x0000000182E369F0-0x0000000182E36BB0
	// [XID] // 0x00000001896BB2C0-0x00000001896BB2E0
	private void SendRefreshSignalInvoke() {} // 0x0000000182E35550-0x0000000182E356C0
	// [XID] // 0x00000001896C2480-0x00000001896C24A0
	private void SendSpawnWindSeedAtPositionInvoke(List<Vector3> positions) {} // 0x0000000182E351E0-0x0000000182E35550
	// [XID] // 0x00000001896C9A10-0x00000001896C9A30
	private void SendConsumeWindSeedInvoke(uint seedID) {} // 0x0000000182E356C0-0x0000000182E35850
	// [XID] // 0x00000001896D1240-0x00000001896D1260
	private void ReceiveGainWindBullet(ulong playerID) {} // 0x0000000182E36510-0x0000000182E366E0
	// [XID] // 0x00000001896D8920-0x00000001896D8940
	private void FireSpawnWindFieldEvent() {} // 0x0000000182E34A30-0x0000000182E34B90
	[DebuggerHidden] // 0x00000001896E0150-0x00000001896E0190
	// [XID] // 0x00000001896E0150-0x00000001896E0190
	private IEnumerator FireGainWindBulletEvent() => default; // 0x0000000182E34FA0-0x0000000182E350B0
	[BlackList] // 0x00000001896EA540-0x00000001896EA580
	// [XID] // 0x00000001896EA540-0x00000001896EA580
	public override void AutoAllocTypeFields() {} // 0x0000000182E34250-0x0000000182E342F0
	[BlackList] // 0x00000001896F4BA0-0x00000001896F4BE0
	// [XID] // 0x00000001896F4BA0-0x00000001896F4BE0
	public override void AutoRecycleTypeFields() {} // 0x0000000182E342F0-0x0000000182E343E0
	[BlackList] // 0x00000001896FF3B0-0x00000001896FF3F0
	// [XID] // 0x00000001896FF3B0-0x00000001896FF3F0
	public override void ReturnToObjectPool() {} // 0x0000000182E37630-0x0000000182E376D0
}

