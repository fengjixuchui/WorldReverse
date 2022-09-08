/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class InLevelBaseLoadingDialogContext : BaseLoadingContext // TypeDefIndex: 29357
{
	// Fields
	public Action PerformFinishHandler; // 0x180
	public Action ProgressFinishHandler; // 0x188
	public Action LoadFinishHandler; // 0x190
	public Action ClearHandler; // 0x198
	protected Color _backColor; // 0x1A0
	protected bool _startDark; // 0x1B0
	protected bool _startLightup; // 0x1B1

	// Constructors
	protected InLevelBaseLoadingDialogContext() {} // 0x0000000182237370-0x0000000182237410

	// Methods
	// [XID] // 0x0000000189A9D880-0x0000000189A9D8A0
	protected void UpdateDark(Image bgImg) {} // 0x0000000182237110-0x0000000182237290
	// [XID] // 0x0000000189AA5170-0x0000000189AA5190
	protected void UpdateLightup(Image bgImg) {} // 0x0000000182236EC0-0x0000000182237050
	// [XID] // 0x0000000189AAC8F0-0x0000000189AAC910
	public override void SetupView() {} // 0x0000000182237290-0x0000000182237370
	// [XID] // 0x0000000189AB41B0-0x0000000189AB41D0
	protected virtual void ClearAll() {} // 0x0000000182236C00-0x0000000182236CB0
	// [XID] // 0x0000000189ABBEF0-0x0000000189ABBF10
	public override void ClearView() {} // 0x0000000182236CB0-0x0000000182236DA0
	// [XID] // 0x0000000189AC3680-0x0000000189AC36A0
	public override void OnDisconnect() {} // 0x0000000182237050-0x0000000182237110
}

