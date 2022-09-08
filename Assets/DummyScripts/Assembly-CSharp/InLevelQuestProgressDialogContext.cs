/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelQuestProgressDialogContext : BaseDialogContext // TypeDefIndex: 29590
{
	// Fields
	private MonoDungeonChallenge _monoDungeonChallenge; // 0x178
	private QuestExcelConfigProxy _questConfig; // 0x180
	private uint _questProgress; // 0x198
	private bool _newHint; // 0x19C
	private bool _isShow; // 0x19D
	private Coroutine _coroutine; // 0x1A0

	// Constructors
	public InLevelQuestProgressDialogContext() {} // 0x000000018303F1D0-0x000000018303F2A0

	// Methods
	// [XID] // 0x0000000189951520-0x0000000189951540
	public void AddHint(ref QuestExcelConfigProxy cfg, uint progress) {} // 0x000000018303E790-0x000000018303E870
	// [XID] // 0x0000000189958B30-0x0000000189958B50
	public override void SetupView() {} // 0x000000018303ED60-0x000000018303EE20
	// [XID] // 0x0000000189960170-0x0000000189960190
	public override void UpdateView() {} // 0x000000018303EE20-0x000000018303F1D0
	// [XID] // 0x0000000189967BF0-0x0000000189967C10
	public override void ClearView() {} // 0x000000018303EA00-0x000000018303EB00
	// [XID] // 0x000000018996EDF0-0x000000018996EE10
	private void ShowProgressHint(bool show) {} // 0x000000018303E8F0-0x000000018303EA00
	// [XID] // 0x00000001899769F0-0x0000000189976A10
	private void FadeOutAnimation() {} // 0x000000018303EC20-0x000000018303ED60
}

