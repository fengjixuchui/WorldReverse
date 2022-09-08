/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelNamePageContext : BasePageContext // TypeDefIndex: 29917
{
	// Fields
	private MonoInLevelNamePage _pageMono; // 0x190
	public Action namePageCallback; // 0x198
	public Action nameFinPageCallback; // 0x1A0
	private uint selectedConfigId; // 0x1A8
	private bool isMale; // 0x1AC
	private MonoPS4IMEProxy _proxy; // 0x1B0
	private bool _passCheck; // 0x1B8

	// Nested types
	private enum InvalidCharState // TypeDefIndex: 29918
	{
		Valid = 0,
		Space = 1
	}

	// Constructors
	public InLevelNamePageContext() {} // Dummy constructor
	public InLevelNamePageContext(uint id, bool isMale) {} // 0x00000001835BC250-0x00000001835BC350

	// Methods
	// [XID] // 0x0000000189A6D6D0-0x0000000189A6D6F0
	public override void SetupView() {} // 0x00000001835BBD60-0x00000001835BC120
	// [XID] // 0x0000000189A74DF0-0x0000000189A74E10
	public override void ClearView() {} // 0x00000001835BAD70-0x00000001835BAE40
	// [XID] // 0x0000000189A7CA40-0x0000000189A7CA60
	public override bool OnNotify(Notify ntf) => default; // 0x00000001835BBC30-0x00000001835BBD60
	// [XID] // 0x0000000189A84360-0x0000000189A84380
	public override void UpdateView() {} // 0x00000001835BC120-0x00000001835BC250
	// [XID] // 0x0000000189A8BC90-0x0000000189A8BCB0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001835BB460-0x00000001835BB570
	// [XID] // 0x0000000189A93220-0x0000000189A93240
	private void OpenInputDialog() {} // 0x00000001835BB5D0-0x00000001835BB7F0
	// [XID] // 0x0000000189A9AC80-0x0000000189A9ACA0
	private InvalidCharState HasInvalidChar(string accountName) => default; // 0x00000001835BB1C0-0x00000001835BB2D0
	// [XID] // 0x0000000189AA1F90-0x0000000189AA1FB0
	private void OnOK() {} // 0x00000001835BB850-0x00000001835BB9F0
	// [XID] // 0x0000000189AA9430-0x0000000189AA9450
	public float FadeOutDuration() => default; // 0x00000001835BBA80-0x00000001835BBB90
	// [XID] // 0x0000000189AB1390-0x0000000189AB13B0
	protected override void FadeOut() {} // 0x00000001835BB120-0x00000001835BB1C0
	// [XID] // 0x0000000189AB8600-0x0000000189AB8620
	public override void ClosePage() {} // 0x00000001835BA1A0-0x00000001835BA3B0
	// [XID] // 0x0000000189AC02E0-0x0000000189AC0300
	private void FinalClosePage() {} // 0x00000001835BAEA0-0x00000001835BB030
	// [XID] // 0x0000000189AC7CE0-0x0000000189AC7D00
	public override void OnDisconnect() {} // 0x00000001835BBB90-0x00000001835BBC30
	// [XID] // 0x0000000189ACF220-0x0000000189ACF240
	private void CheckNameString(string name) {} // 0x00000001835BB390-0x00000001835BB460
	// [XID] // 0x0000000189AD70F0-0x0000000189AD7110
	private bool CheckNameStringValid(string name) => default; // 0x00000001835BA3B0-0x00000001835BAD70
}

