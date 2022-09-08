/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class CountSelectDialogContext : BaseDialogContext // TypeDefIndex: 28903
{
	// Fields
	private MonoCountSelectDialog _dialogMono; // 0x178
	private string _title; // 0x180
	private uint _maxCount; // 0x188
	private uint _minCount; // 0x18C
	private uint _selectCount; // 0x190
	private Action<uint> _callback; // 0x198

	// Properties
	public string title { /* [XID] */ /* 0x0000000189AAC9D0-0x0000000189AAC9F0 */ set {} } // 0x00000001816ADA40-0x00000001816ADAF0
	public uint maxCount { /* [XID] */ /* 0x0000000189AB42B0-0x0000000189AB42D0 */ set {} } // 0x00000001816ADAF0-0x00000001816ADBA0
	public Action<uint> callback { /* [XID] */ /* 0x0000000189ABBFB0-0x0000000189ABBFD0 */ set {} } // 0x00000001816AD900-0x00000001816AD9B0

	// Constructors
	public CountSelectDialogContext() {} // 0x00000001816AE680-0x00000001816AE750

	// Methods
	// [XID] // 0x0000000189AC3780-0x0000000189AC37A0
	public override void SetupView() {} // 0x00000001816AE350-0x00000001816AE680
	// [XID] // 0x0000000189ACADB0-0x0000000189ACADD0
	protected override void BindViewCallbacks() {} // 0x00000001816ACE80-0x00000001816AD190
	// [XID] // 0x0000000189AD2840-0x0000000189AD2860
	private void SetLongPress() {} // 0x00000001816AD280-0x00000001816AD570
	// [XID] // 0x0000000189ADA270-0x0000000189ADA290
	private void Cancel() {} // 0x00000001816AD740-0x00000001816AD810
	// [XID] // 0x0000000189AE1B50-0x0000000189AE1B70
	private void Confirm() {} // 0x00000001816ACDB0-0x00000001816ACE80
	// [XID] // 0x0000000189AE9340-0x0000000189AE9360
	private void OnSliderValueChanged(float value) {} // 0x00000001816AE1F0-0x00000001816AE350
	// [XID] // 0x0000000189AF10F0-0x0000000189AF1110
	private void OnInputFieldEndEdit(string text) {} // 0x00000001816AD570-0x00000001816AD740
	// [XID] // 0x0000000189AF8610-0x0000000189AF8630
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001816ADC00-0x00000001816AE190
	// [XID] // 0x0000000189AFFCA0-0x0000000189AFFCC0
	private void IncreaseCount() {} // 0x00000001816AD190-0x00000001816AD280
	// [XID] // 0x0000000189B07250-0x0000000189B07270
	private void DecreaseCount() {} // 0x00000001816AD810-0x00000001816AD900
}

