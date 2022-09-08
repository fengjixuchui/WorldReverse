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

public sealed class MPLoadingDialogContext : BaseLoadingDialogContext // TypeDefIndex: 30003
{
	// Fields
	private MonoLoadingCanvas _dialogMono; // 0x198
	private string _text; // 0x1A0
	public bool enableLoading; // 0x1A8
	public bool loadingStarted; // 0x1A9

	// Properties
	public string text { /* [XID] */ /* 0x000000018971D770-0x000000018971D790 */ set {} } // 0x0000000183FB9E90-0x0000000183FB9FD0

	// Constructors
	public MPLoadingDialogContext() {} // 0x0000000183FBA9D0-0x0000000183FBAB10

	// Methods
	// [XID] // 0x0000000189724B30-0x0000000189724B50
	public override void SetupView() {} // 0x0000000183FBA5D0-0x0000000183FBA920
	// [XID] // 0x000000018972C360-0x000000018972C380
	public void StartLoading(bool force = false /* Metadata: 0x00B106C5 */) {} // 0x0000000183FB9AD0-0x0000000183FB9BD0
	// [XID] // 0x0000000189733A20-0x0000000189733A40
	public override void ClearView() {} // 0x0000000183FB9A10-0x0000000183FB9AD0
	// [XID] // 0x000000018973B1A0-0x000000018973B1C0
	public override void UpdateView() {} // 0x0000000183FBA920-0x0000000183FBA9D0
	// [XID] // 0x0000000189742B50-0x0000000189742B70
	public override void CloseDialog() {} // 0x0000000183FB9C70-0x0000000183FB9E90
	// [XID] // 0x000000018974A830-0x000000018974A850
	protected override void ShowProgress(float progress) {} // 0x0000000183FBA1D0-0x0000000183FBA3D0
	// [XID] // 0x0000000189751910-0x0000000189751930
	private void UpdateLightup() {} // 0x0000000183FBA3D0-0x0000000183FBA570
}

