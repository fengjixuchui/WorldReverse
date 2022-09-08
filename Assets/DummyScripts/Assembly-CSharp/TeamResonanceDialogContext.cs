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

public sealed class TeamResonanceDialogContext : BaseDialogContext // TypeDefIndex: 28976
{
	// Fields
	private MonoTeamResonanceDialog _dialogMono; // 0x178
	private List<TeamResonanceExcelConfig> _resonanceList; // 0x180
	private Dictionary<int, int> _teamElemDic; // 0x188
	private List<TeamElemStruct> _tempElemTypeList; // 0x190
	private bool _tempActiveFlag; // 0x198
	private List<ulong> _teamList; // 0x1A0
	private uint _totalBreakLevel; // 0x1A8
	private bool _ignoreBreakLevelCheck; // 0x1AC
	private bool _inSameScene; // 0x1AD
	private bool _ignoreSameSceneCheck; // 0x1AE
	private bool _isInTower; // 0x1AF

	// Nested types
	public struct TeamElemStruct // TypeDefIndex: 28977
	{
		// Fields
		public int elemType; // 0x00
		public bool active; // 0x04
	}

	// Constructors
	public TeamResonanceDialogContext() {} // Dummy constructor
	public TeamResonanceDialogContext(List<ulong> teamList, bool isInTower = false /* Metadata: 0x00B0E8E3 */, bool ignoreBreakLevelCheck = false /* Metadata: 0x00B0E8E4 */, bool ignoreSameSceneCheck = false /* Metadata: 0x00B0E8E5 */) {} // 0x0000000182F54EA0-0x0000000182F55000

	// Methods
	// [XID] // 0x000000018962F150-0x000000018962F170
	public override void SetupView() {} // 0x0000000182F54D90-0x0000000182F54EA0
	// [XID] // 0x0000000189636B10-0x0000000189636B30
	protected override void BindViewCallbacks() {} // 0x0000000182F53230-0x0000000182F53350
	// [XID] // 0x000000018963E040-0x000000018963E060
	private void RefreshResonanceList() {} // 0x0000000182F54840-0x0000000182F54A80
	// [XID] // 0x00000001896459D0-0x00000001896459F0
	private void RefreshTeamElementDic() {} // 0x0000000182F53820-0x0000000182F53AA0
	// [XID] // 0x000000018964D1E0-0x000000018964D200
	private void RefreshElementView() {} // 0x0000000182F53350-0x0000000182F53660
	// [XID] // 0x0000000189654980-0x00000001896549A0
	private void SetElementItemActive(MonoCommonUIItem item, bool active) {} // 0x0000000182F54350-0x0000000182F544D0
	// [XID] // 0x000000018965C070-0x000000018965C090
	private void RefreshResonanceView() {} // 0x0000000182F53660-0x0000000182F53790
	// [XID] // 0x0000000189663730-0x0000000189663750
	private void RefreshResonanceItem(Transform trans, int index) {} // 0x0000000182F52940-0x0000000182F52F20
	// [XID] // 0x000000018966B070-0x000000018966B090
	private TeamElemStruct GetTeamElemStruct(ElementType elemType, int i) => default; // 0x0000000182F54C70-0x0000000182F54D90
	// [XID] // 0x0000000189672C70-0x0000000189672C90
	private void RefreshResonanceItemIconList(Transform trans, int index) {} // 0x0000000182F544D0-0x0000000182F54840
	// [XID] // 0x000000018967A370-0x000000018967A390
	private uint GetTeamTotalBreakLevel() => default; // 0x0000000182F54030-0x0000000182F541F0
	// [XID] // 0x0000000189681BC0-0x0000000189681BE0
	private void CheckTeamInSameScene() {} // 0x0000000182F53060-0x0000000182F53230
	// [XID] // 0x0000000189689650-0x0000000189689670
	private bool GetResonanceActive(TeamResonanceExcelConfig config) => default; // 0x0000000182F53AA0-0x0000000182F53FD0
	// [XID] // 0x0000000189691290-0x00000001896912B0
	private int CompareResonance(TeamResonanceExcelConfig xData, TeamResonanceExcelConfig yData) => default; // 0x0000000182F52F20-0x0000000182F53060
	// [XID] // 0x0000000189698A40-0x0000000189698A60
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182F541F0-0x0000000182F54350
	// [XID] // 0x000000018969FE90-0x000000018969FEB0
	private void ScrollResonanceList(float delta) {} // 0x0000000182F54A80-0x0000000182F54C10
}

