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

public sealed class HomeworldNPCDialogContext : BaseDialogContext // TypeDefIndex: 28948
{
	// Fields
	private MonoHomeworldNPCDialog _dialogMono; // 0x178
	private MonoHomeworldEnvironmentSetting _envSetting; // 0x180
	private List<HomeworldNPCExcelData> _avaliableNPCData; // 0x188
	private int _slotIndex; // 0x190

	// Constructors
	public HomeworldNPCDialogContext() {} // Dummy constructor
	public HomeworldNPCDialogContext(MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001839B74E0-0x00000001839B7620

	// Methods
	// [XID] // 0x0000000189708900-0x0000000189708920
	public override void SetupView() {} // 0x00000001839B72B0-0x00000001839B74E0
	// [XID] // 0x00000001897101F0-0x0000000189710210
	protected override void BindViewCallbacks() {} // 0x00000001839B6700-0x00000001839B6940
	// [XID] // 0x0000000189717610-0x0000000189717630
	private void SetupNPCSlots() {} // 0x00000001839B6DB0-0x00000001839B6E80
	// [XID] // 0x000000018971F0B0-0x000000018971F0D0
	private void OnSlotNPCButtonReady(Transform btnTrans, int index) {} // 0x00000001839B6C90-0x00000001839B6DB0
	// [XID] // 0x00000001897266D0-0x00000001897266F0
	private void OnNPCButtonClicked(int index) {} // 0x00000001839B6EE0-0x00000001839B6FA0
	// [XID] // 0x000000018972DBF0-0x000000018972DC10
	private void SetupAvailableNPCPanel() {} // 0x00000001839B6530-0x00000001839B6700
	// [XID] // 0x00000001897353B0-0x00000001897353D0
	private void CloseAvliableNPCPanel() {} // 0x00000001839B6FA0-0x00000001839B70A0
	// [XID] // 0x000000018973CE10-0x000000018973CE30
	private void OnAvailableNPCButtonReady(Transform btnTrans, int index) {} // 0x00000001839B6940-0x00000001839B6C90
	// [XID] // 0x00000001897443D0-0x00000001897443F0
	private void OnAvaliableNPCButtonClicked(int index) {} // 0x00000001839B7100-0x00000001839B72B0
}

