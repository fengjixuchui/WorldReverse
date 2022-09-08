/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugAIInfoDialogContext : BaseDialogContext // TypeDefIndex: 28588
{
	// Fields
	private StringBuilder stringBuilderHelper; // 0x178
	private GameObject _aiSelfPanel; // 0x180
	private GameObject _aiSelfPanelNextPageBtn; // 0x188
	private GameObject _aiSelfPanelShowPathBtn; // 0x190
	private UnityEngine.UI.Text _aiSelfPanelText; // 0x198
	private const int _aiSelfPanelPageCount = 2; // Metadata: 0x00B0D95C
	private int _aiSelfPanelPageIndex; // 0x1A0
	private bool _aiSelfPanelShowPath; // 0x1A4
	private GameObject _aiTargetPanel; // 0x1A8
	private UnityEngine.UI.Text _aiTargetPanelText; // 0x1B0
	private GameObject _avatarInfoPanel; // 0x1B8
	private UnityEngine.UI.Text _avatarInfoPanelText; // 0x1C0
	private GameObject _closeInfoPanel; // 0x1C8
	private BaseEntity _curSelected; // 0x1D0
	private AIKnowledge _curKnowledge; // 0x1D8
	private AIDecision _curDecision; // 0x1E0
	private AILocomotionHandler _curLoco; // 0x1E8
	private AIDebugKnowledge _curDebug; // 0x1F0
	private string _name; // 0x1F8
	private AvatarEntity _localAvatar; // 0x200
	private float _nextThreatPanelUpdateTick; // 0x208
	private GameObject _threatPanel; // 0x210
	private Transform _threatBarGroupTrans; // 0x218
	private GameObject _threatBarBase; // 0x220
	private float _threatBarBGHeight; // 0x228
	private float _threatBarBGWidth; // 0x22C
	private List<ThreatUnit> _threatList; // 0x230
	private ThreatUnit _mainThreatUnit; // 0x238
	private Color MAIN_THREAT_COLOR; // 0x260
	private Color OTHER_THREAT_COLOR; // 0x270
	private static readonly Color ENABLE_COLOR; // 0x00
	private static readonly Color DISABLE_COLOR; // 0x10

	// Nested types
	private struct ThreatUnit // TypeDefIndex: 28589
	{
		// Fields
		public GameObject threatBar; // 0x00
		public uint threatID; // 0x08
		public string threatName; // 0x10
		public float threatValue; // 0x18
		public float threatAUXScore; // 0x1C
		public ThreatAddReason addReson; // 0x20
	}

	// Constructors
	public InLevelDebugAIInfoDialogContext() {} // 0x0000000181C9BF80-0x0000000181C9C1D0
	static InLevelDebugAIInfoDialogContext() {} // 0x0000000181C9BE80-0x0000000181C9BF80

	// Methods
	// [XID] // 0x0000000189892DB0-0x0000000189892DD0
	public override void SetupView() {} // 0x0000000181C9B640-0x0000000181C9BD20
	// [XID] // 0x000000018989A430-0x000000018989A450
	public override void ClearView() {} // 0x0000000181C962E0-0x0000000181C96530
	// [XID] // 0x00000001898A1650-0x00000001898A1670
	private void InitEvents() {} // 0x0000000181C98010-0x0000000181C98320
	// [XID] // 0x00000001898A8F00-0x00000001898A8F20
	public override void UpdateView() {} // 0x0000000181C9BD20-0x0000000181C9BE80
	// [XID] // 0x00000001898B0840-0x00000001898B0860
	public void OpenInfoPanel() {} // 0x0000000181C98AA0-0x0000000181C98D50
	// [XID] // 0x00000001898B7E90-0x00000001898B7EB0
	public void OpenThreatPanel() {} // 0x0000000181C98520-0x0000000181C98620
	// [XID] // 0x00000001898BF520-0x00000001898BF540
	private void OnAIInfoNextPage() {} // 0x0000000181C97F50-0x0000000181C98010
	// [XID] // 0x00000001898C6E20-0x00000001898C6E40
	private void OnAIShowPath() {} // 0x0000000181C95FD0-0x0000000181C96170
	// [XID] // 0x00000001898CE3C0-0x00000001898CE3E0
	private void ShowPath() {} // 0x0000000181C96F00-0x0000000181C970D0
	// [XID] // 0x00000001898D5E10-0x00000001898D5E30
	private void HidePath() {} // 0x0000000181C98380-0x0000000181C98520
	// [XID] // 0x00000001898DDB40-0x00000001898DDB60
	private void OnCloseInfoPanel() {} // 0x0000000181C987A0-0x0000000181C98AA0
	// [XID] // 0x00000001898E5430-0x00000001898E5450
	private void OnCloseThreatPanel() {} // 0x0000000181C96E00-0x0000000181C96F00
	// [XID] // 0x00000001898ECB80-0x00000001898ECBA0
	private void CheckDestroyEntireDialog() {} // 0x0000000181C96170-0x0000000181C962E0
	// [XID] // 0x00000001898F4570-0x00000001898F4590
	public void Reset() {} // 0x0000000181C96D10-0x0000000181C96E00
	// [XID] // 0x00000001898FBD40-0x00000001898FBD60
	public void SetCurrentTarget(BaseEntity newTarget) {} // 0x0000000181C98620-0x0000000181C987A0
	// [XID] // 0x0000000189903770-0x0000000189903790
	public bool IsSelectedAIValid() => default; // 0x0000000181C95ED0-0x0000000181C95FD0
	// [XID] // 0x000000018990AC40-0x000000018990AC60
	private void UpdateAIInfoPanel() {} // 0x0000000181C98D50-0x0000000181C9B4C0
	// [XID] // 0x00000001899129D0-0x00000001899129F0
	private void UpdateAvatarInfoPanel() {} // 0x0000000181C96530-0x0000000181C96D10
	// [XID] // 0x000000018991A260-0x000000018991A280
	private void UpdateThreatPanel() {} // 0x0000000181C970D0-0x0000000181C974A0
	// [XID] // 0x0000000189921A80-0x0000000189921AA0
	private ThreatUnit CreateThreatUnit(ThreatInfo threatInfo, int index) => default; // 0x0000000181C974A0-0x0000000181C97E90
	// [XID] // 0x0000000189929180-0x00000001899291A0
	private void ClearThreatList() {} // 0x0000000181C9B4C0-0x0000000181C9B640
}

