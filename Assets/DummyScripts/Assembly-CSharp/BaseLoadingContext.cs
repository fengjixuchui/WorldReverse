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

public abstract class BaseLoadingContext : BaseDialogContext // TypeDefIndex: 29998
{
	// Fields
	protected bool asyncLoad; // 0x178

	// Constructors
	protected BaseLoadingContext() {} // 0x00000001836D2C90-0x00000001836D2D00

	// Methods
	protected abstract void ShowProgress(float progress);
	// [XID] // 0x0000000189B72740-0x0000000189B72760
	public override bool OnNotify(Notify ntf) => default; // 0x00000001836D26D0-0x00000001836D2870
	// [XID] // 0x0000000189B79C90-0x0000000189B79CB0
	protected void ResumeGameLevelLoadFinished() {} // 0x00000001836D24D0-0x00000001836D2640
	// [XID] // 0x0000000189B813C0-0x0000000189B813E0
	public override void SetActive(bool active) {} // 0x00000001836D2B70-0x00000001836D2C90
	// [XID] // 0x0000000189B88B70-0x0000000189B88B90
	protected override void PostSetupView() {} // 0x00000001836D2870-0x00000001836D2970
	// [XID] // 0x0000000189B90020-0x0000000189B90040
	protected override void ReleaseView() {} // 0x00000001836D2970-0x00000001836D2B70
}

