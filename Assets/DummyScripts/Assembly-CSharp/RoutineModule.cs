/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RoutineModule : BaseModule // TypeDefIndex: 21640
{
	// Fields
	private PlayerRoutineDataNotify _playerRoutineDataNotify; // 0x10
	private WorldAllRoutineTypeNotify _worldAllRoutineTypeNotify; // 0x18
	private List<RoutineDetailExcelConfig> _ongoingRoutineList; // 0x20
	private float _nextCheckTime; // 0x28
	private const float CHECK_GAP = 1f; // Metadata: 0x00AFFACA
	private HashSet<uint> _startedRoutineSet; // 0x40

	// Properties
	public RoutineDetailExcelConfig activeRoutine { /* [XID] */ /* 0x0000000189BA91C0-0x0000000189BA9200 */ get; /* [XID] */ /* 0x0000000189BB37B0-0x0000000189BB37F0 */ private set; } // 0x0000000182502190-0x00000001825021F0 0x0000000182504990-0x00000001825049F0
	public RoutineDetailExcelConfig prevFinishedRoutine { /* [XID] */ /* 0x0000000189BBDC60-0x0000000189BBDCA0 */ get; /* [XID] */ /* 0x0000000189BC89E0-0x0000000189BC8A20 */ private set; } // 0x00000001825044A0-0x0000000182504500 0x0000000182504930-0x0000000182504990

	// Constructors
	public RoutineModule() {} // 0x0000000182505930-0x0000000182505A10

	// Methods
	// [XID] // 0x0000000189B5F5C0-0x0000000189B5F5E0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001825029C0-0x0000000182502AD0
	// [XID] // 0x0000000189B66CE0-0x0000000189B66D00
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000182504F00-0x0000000182504FB0
	// [XID] // 0x0000000189B6E040-0x0000000189B6E060
	public bool TryGetOngoingRoutine(uint routineId, out RoutineDetailExcelConfig config) {
		config = default;
		return default;
	} // 0x0000000182503550-0x00000001825036E0
	// [XID] // 0x0000000189B757F0-0x0000000189B75810
	public RoutineTypeExcelConfig GetRoutineTypeExcelConfig(GeneralRoutineType routineType) => default; // 0x0000000182502BA0-0x0000000182502C70
	// [XID] // 0x0000000189B7CC90-0x0000000189B7CCB0
	public PlayerRoutineInfo GetPlayerRoutineInfo(uint routineType) => default; // 0x00000001825021F0-0x00000001825023D0
	// [XID] // 0x0000000189B84B30-0x0000000189B84B50
	public WorldRoutineTypeInfo GetWorldRoutineTypeInfo(uint routineType) => default; // 0x0000000182502450-0x0000000182502630
	// [XID] // 0x0000000189B8B8E0-0x0000000189B8B900
	private void UpdateRoutineInfo() {} // 0x0000000182502C70-0x0000000182503550
	// [XID] // 0x0000000189B93090-0x0000000189B930B0
	public void InitMarks() {} // 0x0000000182503AD0-0x0000000182503D80
	// [XID] // 0x0000000189B9A620-0x0000000189B9A640
	public RoutineDetailExcelConfig GetRoutineDetailExcelConfig(uint routineId) => default; // 0x0000000182502AD0-0x0000000182502BA0
	// [XID] // 0x0000000189BA1DF0-0x0000000189BA1E10
	public uint GetRoutineProgress(uint routineType, uint routineId) => default; // 0x00000001825036E0-0x0000000182503990
	// [XID] // 0x0000000189BD3110-0x0000000189BD3130
	public void CheckRoutine() {} // 0x0000000182503D80-0x00000001825041F0
	// [XID] // 0x0000000189BDA970-0x0000000189BDA990
	private void CancelActiveRoutine() {} // 0x0000000182502630-0x0000000182502760
	// [XID] // 0x00000001895E7370-0x00000001895E7390
	private void HandleRoutineStart(RoutineDetailExcelConfig routineData) {} // 0x0000000182505220-0x00000001825054E0
	// [XID] // 0x00000001895EEC80-0x00000001895EECA0
	private void HandleRoutineExitRegion(RoutineDetailExcelConfig routineData) {} // 0x0000000182505060-0x0000000182505220
	// [XID] // 0x00000001895F6640-0x00000001895F6660
	public override bool OnPacket(Packet packet) => default; // 0x0000000182502760-0x0000000182502920
	// [XID] // 0x00000001895FDA20-0x00000001895FDA40
	private void OnPlayerRoutineDataNotify(PlayerRoutineDataNotify notify) {} // 0x00000001825054E0-0x0000000182505930
	// [XID] // 0x0000000189605250-0x0000000189605270
	private void OnWorldAllRoutineTypeNotify(WorldAllRoutineTypeNotify notify) {} // 0x0000000182504500-0x00000001825045C0
	// [XID] // 0x000000018960CC80-0x000000018960CCA0
	private void OnWorldRoutineTypeRefreshNotify(WorldRoutineTypeRefreshNotify notify) {} // 0x00000001825045C0-0x0000000182504930
	// [XID] // 0x00000001896141D0-0x00000001896141F0
	private bool OnWorldRoutineChangeNotify(WorldRoutineChangeNotify notify) => default; // 0x00000001825049F0-0x0000000182504F00
	// [XID] // 0x000000018961BBF0-0x000000018961BC10
	private void OnWorldRoutineTypeCloseNotify(WorldRoutineTypeCloseNotify notify) {} // 0x0000000182504270-0x0000000182504440
	// [XID] // 0x0000000189623160-0x0000000189623180
	public override void ClearOnDisconnect() {} // 0x0000000182504FB0-0x0000000182505060
	// [XID] // 0x000000018962A960-0x000000018962A980
	public override void ClearOnLevelDestroy() {} // 0x0000000182502920-0x00000001825029C0
	// [XID] // 0x00000001896320E0-0x0000000189632100
	public override void ClearOnBackHome() {} // 0x0000000182503990-0x0000000182503A50
}

