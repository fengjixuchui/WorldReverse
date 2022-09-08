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

public sealed class HomeWorldPositionPageContext : BasePageContext // TypeDefIndex: 30260
{
	// Fields
	private MonoHomeWorldPositionPage _pageMono; // 0x190
	private bool _enableClick; // 0x198
	private bool _lastEnableState; // 0x199
	private bool _isTimerOn; // 0x19A
	private float _timer; // 0x19C
	private List<ModulePositionData> _moduleDataLists; // 0x1A0
	private List<uint> _unLockList; // 0x1A8
	private uint _canChooseNum; // 0x1B0
	private uint _haveChosenNum; // 0x1B4
	private bool _freeChooseMode; // 0x1B8
	private uint _currentChooseModule; // 0x1BC
	private float _chooseBtnTimer; // 0x1C0
	private Coroutine _previewCloseCoroutine; // 0x1C8

	// Properties
	private bool EnableClick { /* [XID] */ /* 0x0000000189918580-0x00000001899185A0 */ get => default; /* [XID] */ /* 0x000000018991FD80-0x000000018991FDA0 */ set {} } // 0x0000000183FECBD0-0x0000000183FECC80 0x0000000183FEA4B0-0x0000000183FEA560

	// Nested types
	private struct ModulePositionData // TypeDefIndex: 30261
	{
		// Fields
		public uint id; // 0x00
		public bool isFree; // 0x04
		public string imageAddr; // 0x08
		public string name; // 0x10
	}

	// Constructors
	public HomeWorldPositionPageContext() {} // 0x0000000183FEE610-0x0000000183FEE730

	// Methods
	// [XID] // 0x0000000189927620-0x0000000189927640
	public override void SetupView() {} // 0x0000000183FEE300-0x0000000183FEE4F0
	// [XID] // 0x000000018992ED80-0x000000018992EDA0
	public override void ClearView() {} // 0x0000000183FEABC0-0x0000000183FEAC70
	// [XID] // 0x00000001899361B0-0x00000001899361D0
	protected override void BindViewCallbacks() {} // 0x0000000183FEA800-0x0000000183FEAAB0
	// [XID] // 0x000000018993DBD0-0x000000018993DBF0
	protected override void OnEnable() {} // 0x0000000183FEDFA0-0x0000000183FEE060
	// [XID] // 0x0000000189945360-0x0000000189945380
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183FEE060-0x0000000183FEE180
	// [XID] // 0x000000018994C820-0x000000018994C840
	protected override void BindRedPoints() {} // 0x0000000183FEA760-0x0000000183FEA800
	// [XID] // 0x0000000189953F20-0x0000000189953F40
	public override void UpdateView() {} // 0x0000000183FEE4F0-0x0000000183FEE610
	// [XID] // 0x000000018995B780-0x000000018995B7A0
	private void ResetData() {} // 0x0000000183FEC760-0x0000000183FEC830
	// [XID] // 0x00000001899633A0-0x00000001899633C0
	private void RefreshData() {} // 0x0000000183FEB0A0-0x0000000183FEB5B0
	// [XID] // 0x000000018996A700-0x000000018996A720
	private void RefreshView() {} // 0x0000000183FEBE90-0x0000000183FEC310
	// [XID] // 0x0000000189972440-0x0000000189972460
	private void ScrollerItemRefresh(Transform trans, int index) {} // 0x0000000183FEB5B0-0x0000000183FEBB20
	// [XID] // 0x0000000189979C20-0x0000000189979C40
	private void OnModuleClicked(int index) {} // 0x0000000183FEC530-0x0000000183FEC760
	// [XID] // 0x0000000189981430-0x0000000189981450
	private void CheckBtnClicked(int index) {} // 0x0000000183FED090-0x0000000183FED180
	// [XID] // 0x0000000189988C40-0x0000000189988C60
	private void OkBtnClicked(int index) {} // 0x0000000183FEDBB0-0x0000000183FEDFA0
	// [XID] // 0x0000000189990400-0x0000000189990420
	private void OnModuleChosen(uint moduleId) {} // 0x0000000183FED410-0x0000000183FEDAC0
	// [XID] // 0x0000000189997FD0-0x0000000189997FF0
	private void OpenPreview(int index) {} // 0x0000000183FEC830-0x0000000183FECBD0
	// [XID] // 0x000000018999F6B0-0x000000018999F6D0
	private void PrevBtnClicked() {} // 0x0000000183FEE180-0x0000000183FEE300
	// [XID] // 0x00000001899A7230-0x00000001899A7250
	private void NextBtnClicked() {} // 0x0000000183FEA560-0x0000000183FEA700
	// [XID] // 0x00000001899AEB60-0x00000001899AEB80
	private void BackBtnClicked() {} // 0x0000000183FEACD0-0x0000000183FEAF20
	// [XID] // 0x00000001899B5EE0-0x00000001899B5F00
	private void RefreshButtonState(int index) {} // 0x0000000183FECC80-0x0000000183FED090
	// [XID] // 0x00000001899BDBE0-0x00000001899BDC00
	private void TryClosePage() {} // 0x0000000183FEAAB0-0x0000000183FEABC0
	// [XID] // 0x00000001899C5360-0x00000001899C5380
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183FEBB80-0x0000000183FEBE90
}

