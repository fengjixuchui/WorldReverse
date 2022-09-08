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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonEndDialog : BaseDialogContext // TypeDefIndex: 28930
{
	// Fields
	private uint _reviveCountUsed; // 0x178
	private uint _reviveCountMax; // 0x17C
	private long _autoQuitLimit; // 0x180
	private bool _autoQuitEnabled; // 0x188
	private uint _dungeonId; // 0x18C
	private ExitType _exitType; // 0x190
	private MonoDungeonEndDialog _dialogMono; // 0x198
	private DungeonEndContextData _contextData; // 0x1A0
	private bool _isSuccess; // 0x1A8
	private string _title; // 0x1B0
	private bool _hasRecommendContent; // 0x1B8
	private bool _hasFactorContent; // 0x1B9
	private bool _hasFailTips; // 0x1BA
	private bool _hasTrialSucc; // 0x1BB
	private Dictionary<uint, StrengthenPointData> _pointDataDic; // 0x1C0
	private List<DungeonLevelEntityConfig> _configList; // 0x1C8
	private List<string> _failTipsList; // 0x1D0
	private List<string> _recommendList; // 0x1D8
	private bool _isChallenge; // 0x1E0
	private string _subTitle; // 0x1E8
	private string _subName; // 0x1F0
	private uint _score; // 0x1F8
	private uint _highestScore; // 0x1FC
	private string _secondsBeforeAutoQuitStr; // 0x200
	private bool _showTimeChallengeHint; // 0x208
	private string _overrideScoreIconName; // 0x210
	private const float BASIC_VALUE = 0.15f; // Metadata: 0x00B0E890

	// Nested types
	private enum ExitType // TypeDefIndex: 28931
	{
		None = 0,
		Die = 1,
		Failed = 2,
		ExitNoRestart = 3,
		ExitWithRestart = 4
	}

	// Constructors
	public DungeonEndDialog() {} // Dummy constructor
	public DungeonEndDialog(bool isSuccess, string title) {} // 0x00000001816908C0-0x0000000181690B30
	public DungeonEndDialog(DungeonChallengeFinishNotify ntf) {} // 0x0000000181690B30-0x0000000181691000
	public DungeonEndDialog(DungeonPlayerDieNotify ntf) {} // 0x000000018168FD60-0x0000000181690380
	public DungeonEndDialog(DungeonSettleNotify ntf, bool canRestart = false /* Metadata: 0x00B0E88E */) {} // 0x0000000181690380-0x00000001816908C0
	public DungeonEndDialog(EffigyChallengeResultNotify ntf) {} // 0x0000000181691000-0x00000001816913E0
	public DungeonEndDialog(ChannellerSlabLoopDungeonResultInfo info, bool isCancel = false /* Metadata: 0x00B0E88F */) {} // 0x00000001816913E0-0x0000000181691810

	// Methods
	// [XID] // 0x000000018994FA50-0x000000018994FA70
	private void InitBaseSetting() {} // 0x000000018168E7C0-0x000000018168E9A0
	// [XID] // 0x0000000189957090-0x00000001899570B0
	private void InitMistTrialEnd(bool isSuccess, ulong closeTime) {} // 0x000000018168C110-0x000000018168C250
	// [XID] // 0x000000018995EBE0-0x000000018995EC00
	public override void ClearView() {} // 0x000000018168C030-0x000000018168C110
	// [XID] // 0x00000001899662A0-0x00000001899662C0
	public override void UpdateView() {} // 0x000000018168FBD0-0x000000018168FD60
	// [XID] // 0x000000018996D740-0x000000018996D760
	public override void SetupView() {} // 0x000000018168F380-0x000000018168FBD0
	// [XID] // 0x00000001899752E0-0x0000000189975300
	private void SetButtons() {} // 0x000000018168C250-0x000000018168CCF0
	// [XID] // 0x000000018997C4A0-0x000000018997C4C0
	private void SetFailTips() {} // 0x000000018168D8C0-0x000000018168DB60
	// [XID] // 0x00000001899841C0-0x00000001899841E0
	private void OnFactorTipsScrollerInit(Transform trans, int index) {} // 0x000000018168F1D0-0x000000018168F380
	// [XID] // 0x000000018998BD30-0x000000018998BD50
	private void SetFactorDesc() {} // 0x000000018168BA50-0x000000018168C030
	// [XID] // 0x0000000189993900-0x0000000189993920
	private void SetTrialSucc() {} // 0x000000018168DE60-0x000000018168E090
	// [XID] // 0x000000018999B1E0-0x000000018999B200
	private void SetRecommendContent() {} // 0x000000018168CF30-0x000000018168D450
	// [XID] // 0x00000001899A29E0-0x00000001899A2A00
	private void OnFactorListScrollerInit(Transform trans, int index) {} // 0x000000018168CCF0-0x000000018168CEA0
	// [XID] // 0x00000001899AA2E0-0x00000001899AA300
	private void OnRecommendListScrollerInit(Transform trans, int index) {} // 0x000000018168E090-0x000000018168E460
	// [XID] // 0x00000001899B1D30-0x00000001899B1D50
	protected override void BindViewCallbacks() {} // 0x000000018168B580-0x000000018168BA50
	// [XID] // 0x00000001899B9070-0x00000001899B9090
	private void RequestClose() {} // 0x000000018168EFC0-0x000000018168F0C0
	// [XID] // 0x00000001899C0930-0x00000001899C0950
	private void RequestQuit() {} // 0x000000018168EDF0-0x000000018168EFC0
	// [XID] // 0x00000001899C8180-0x00000001899C81A0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018168D4B0-0x000000018168D800
	// [XID] // 0x00000001899CFB00-0x00000001899CFB20
	private void ScrollScroller(float delta) {} // 0x000000018168B3F0-0x000000018168B580
	// [XID] // 0x00000001899D6F10-0x00000001899D6F30
	private void RequestRevive() {} // 0x000000018168E570-0x000000018168E7C0
	// [XID] // 0x00000001899DE4A0-0x00000001899DE4C0
	private void RequestRestart() {} // 0x000000018168DB60-0x000000018168DE60
	// [XID] // 0x00000001899E6140-0x00000001899E6160
	private void RequestMistTrialRestart() {} // 0x000000018168E9A0-0x000000018168ED90
	// [XID] // 0x00000001899ED530-0x00000001899ED550
	private void RequestTowerRestart() {} // 0x000000018168E460-0x000000018168E570
	[DebuggerHidden] // 0x00000001899F50A0-0x00000001899F50E0
	// [XID] // 0x00000001899F50A0-0x00000001899F50E0
	private IEnumerator LateSetAniBoolTrue() => default; // 0x000000018168F0C0-0x000000018168F1D0
}

