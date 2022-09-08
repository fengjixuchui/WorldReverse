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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityMiniTomoPageContext : BasePageContext // TypeDefIndex: 30179
{
	// Fields
	private MonoActivityMiniTomoPage _pageMono; // 0x190
	private uint _activityId; // 0x198
	private ActivityInfo _activityInfo; // 0x1A0
	private FindHilichurlDetailInfo _activityDetail; // 0x1A8
	private ActivityModule _activityModule; // 0x1B0
	private RewardPreviewComponent _rewardPreviewComponent; // 0x1B8
	private int _selectedPointDayIndex; // 0x1C0
	private MonoActivityMiniTomoPoint _selectedPointMono; // 0x1C8
	public static readonly uint DICTIONARY_ID; // 0x00
	private const string POINT_REGION = "PointRegion"; // Metadata: 0x00B10885
	private const string HINT_REGION = "HintRegion"; // Metadata: 0x00B10894
	private bool _isFocusPoint; // 0x1D0

	// Constructors
	public ActivityMiniTomoPageContext(uint activityId) {} // 0x00000001812EDE10-0x00000001812EDF10
	public ActivityMiniTomoPageContext() {} // 0x00000001812EDF10-0x00000001812EE000
	static ActivityMiniTomoPageContext() {} // 0x00000001812EDDB0-0x00000001812EDE10

	// Methods
	// [XID] // 0x0000000189825990-0x00000001898259B0
	public override void SetupView() {} // 0x00000001812ED940-0x00000001812EDDB0
	// [XID] // 0x000000018982D140-0x000000018982D160
	public override void ClearView() {} // 0x00000001812EABB0-0x00000001812EACE0
	// [XID] // 0x00000001898348A0-0x00000001898348C0
	protected override void OnEnable() {} // 0x00000001812ED450-0x00000001812ED550
	// [XID] // 0x000000018983BF10-0x000000018983BF30
	private void Refresh() {} // 0x00000001812EA290-0x00000001812EA3A0
	// [XID] // 0x0000000189843540-0x0000000189843560
	private void RefreshPointInfo(int index) {} // 0x00000001812EB800-0x00000001812EB9A0
	// [XID] // 0x000000018984AA40-0x000000018984AA60
	private void SetupPointView(MonoActivityMiniTomoPoint mono, int index) {} // 0x00000001812EB9A0-0x00000001812EC1D0
	// [XID] // 0x0000000189851E20-0x0000000189851E40
	private void RefreshPointRP(MonoActivityMiniTomoPoint mono, int dayIndex) {} // 0x00000001812ECD90-0x00000001812ECF00
	// [XID] // 0x00000001898596E0-0x0000000189859700
	private void OnPointButtonClick(MonoActivityMiniTomoPoint mono, int index) {} // 0x00000001812EADD0-0x00000001812EAF50
	// [XID] // 0x0000000189860880-0x00000001898608A0
	private void ShowPointDetail(int dayIndex) {} // 0x00000001812EA400-0x00000001812EA530
	// [XID] // 0x0000000189867F70-0x0000000189867F90
	private void SetupAssignmentView(int dayIndex, int assignmentIndex) {} // 0x00000001812EAFB0-0x00000001812EB3B0
	// [XID] // 0x000000018986F4D0-0x000000018986F4F0
	private void HideHiliWeiView() {} // 0x00000001812ED290-0x00000001812ED450
	// [XID] // 0x0000000189876B20-0x0000000189876B40
	private void SetupHiliWeiView(int dayIndex) {} // 0x00000001812EC1D0-0x00000001812EC640
	// [XID] // 0x000000018987E620-0x000000018987E640
	protected override void BindViewCallbacks() {} // 0x00000001812EA8E0-0x00000001812EAB00
	// [XID] // 0x00000001898859D0-0x00000001898859F0
	private void OnBtnGotoQuestClick(uint questId) {} // 0x00000001812ECF80-0x00000001812ED200
	// [XID] // 0x000000018988CCE0-0x000000018988CD00
	private void OnBtnGotoMapClick() {} // 0x00000001812EB440-0x00000001812EB800
	// [XID] // 0x00000001898943D0-0x00000001898943F0
	private void OnBtnDictionaryClick() {} // 0x00000001812EC840-0x00000001812ECA20
	// [XID] // 0x000000018989B940-0x000000018989B960
	private void OnBtnDescriptionClick() {} // 0x00000001812ECC20-0x00000001812ECD30
	// [XID] // 0x00000001898A2E10-0x00000001898A2E30
	private void OnBtnGetClick() {} // 0x00000001812EACE0-0x00000001812EADD0
	// [XID] // 0x00000001898AA330-0x00000001898AA350
	protected override void BindRedPoints() {} // 0x00000001812EA750-0x00000001812EA8E0
	// [XID] // 0x00000001898B1D10-0x00000001898B1D30
	public override bool OnNotify(Notify ntf) => default; // 0x00000001812ED7C0-0x00000001812ED940
	// [XID] // 0x00000001898B9950-0x00000001898B9970
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001812ECA20-0x00000001812ECB20
	// [XID] // 0x00000001898C0D70-0x00000001898C0D90
	public override void OnNavRegionFocus(MonoJoypadNavRegionBase focusRegion) {} // 0x00000001812ED550-0x00000001812ED7C0
	// [XID] // 0x00000001898C8670-0x00000001898C8690
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001812EC6A0-0x00000001812EC7E0
	// [XID] // 0x00000001898D0040-0x00000001898D0060
	private void SelectedPoint(bool isRight) {} // 0x00000001812EA530-0x00000001812EA750
	// [XID] // 0x00000001898D7650-0x00000001898D7670
	private void FocusNavRegion(string regionName) {} // 0x00000001812ECB20-0x00000001812ECC20
}

