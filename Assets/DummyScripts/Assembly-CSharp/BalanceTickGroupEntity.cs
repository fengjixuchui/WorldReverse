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

public sealed class BalanceTickGroupEntity : BalanceTickGroup // TypeDefIndex: 21298
{
	// Fields
	private BoundsOccluder _boundsOccluder; // 0x40
	private double _lastGlobalTime; // 0x48

	// Constructors
	public BalanceTickGroupEntity() {} // 0x000000018282A8C0-0x000000018282A990

	// Methods
	// [XID] // 0x000000018999FA90-0x000000018999FAB0
	protected override void OnPreAddProxy(BalanceTickObjectProxy inProxy) {} // 0x000000018282A6C0-0x000000018282A7D0
	// [XID] // 0x00000001899A77A0-0x00000001899A77C0
	public void QueueComponentToggleTickableEvent() {} // 0x000000018282A620-0x000000018282A6C0
	// [XID] // 0x00000001899AEFB0-0x00000001899AEFD0
	public override void UpdateComputeThread(float inGlobalTime, float deltaTime) {} // 0x000000018282A7D0-0x000000018282A8C0
	// [XID] // 0x00000001899B6370-0x00000001899B6390
	public void RefreshMainCameraMatrixUnityThread(Camera InCamera) {} // 0x000000018282A4E0-0x000000018282A5A0
	// [XID] // 0x00000001899BDF70-0x00000001899BDF90
	public void Refresh(double inGlobalTime) {} // 0x000000018282A200-0x000000018282A2B0
	// [XID] // 0x00000001899C56F0-0x00000001899C5710
	public void OnTickLODChange(BalanceTickObjectProxy inProxy, int fromLOD, int toLOD) {} // 0x000000018282A340-0x000000018282A4E0
}

