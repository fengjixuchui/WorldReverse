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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BargainDialogContext : BaseDialogContext // TypeDefIndex: 28839
{
	// Fields
	private MonoBargainDialog _pageMono; // 0x178
	private BargainExcelConfig _bargainConfig; // 0x180
	private BargainInstData _bargainInstData; // 0x188
	private uint _bargainID; // 0x190
	private const float BARGAIN_OFFER_WAIT = 5f; // Metadata: 0x00B0E786
	private bool _canCloseDialog; // 0x194
	private bool _priceOfferSent; // 0x195
	private LCBaseInter _bargainInter; // 0x198
	private uint _bargainMin; // 0x1A0
	private uint _bargainMax; // 0x1A4
	private const int INPUT_STATE_BARGAIN = 0; // Metadata: 0x00B0E78A
	private const int INPUT_STATE_INPUT = 1; // Metadata: 0x00B0E78E

	// Constructors
	public BargainDialogContext() {} // Dummy constructor
	public BargainDialogContext(uint bargainID, LCBaseInter bargainInter) {} // 0x0000000181AAB740-0x0000000181AAB860

	// Methods
	// [XID] // 0x0000000189830180-0x00000001898301A0
	public override void SetupView() {} // 0x0000000181AAAB10-0x0000000181AAB740
	// [XID] // 0x0000000189837920-0x0000000189837940
	private void HandleQuantityWdigetValueChange(MonoQuantityWidget widget) {} // 0x0000000181AA9CA0-0x0000000181AA9EA0
	// [XID] // 0x000000018983F010-0x000000018983F030
	private void HandleInputFieldValueChange(string value) {} // 0x0000000181AAA5E0-0x0000000181AAAAB0
	// [XID] // 0x0000000189846690-0x00000001898466B0
	private void SendBargainExpectPrice() {} // 0x0000000181AA9890-0x0000000181AA9AB0
	[DebuggerHidden] // 0x000000018984DC20-0x000000018984DC60
	// [XID] // 0x000000018984DC20-0x000000018984DC60
	private IEnumerator DelayCloseDialog() => default; // 0x0000000181AA9780-0x0000000181AA9890
	// [XID] // 0x0000000189857E20-0x0000000189857E40
	private void BargainOfferComplete() {} // 0x0000000181AA9B60-0x0000000181AA9C10
	// [XID] // 0x000000018985EF30-0x000000018985EF50
	public override void CloseDialog() {} // 0x0000000181AA9AB0-0x0000000181AA9B60
	// [XID] // 0x00000001898666F0-0x0000000189866710
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181AA9F00-0x0000000181AAA5E0
}

