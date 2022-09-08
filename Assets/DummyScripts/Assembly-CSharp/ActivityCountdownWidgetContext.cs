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

public sealed class ActivityCountdownWidgetContext : BaseWidgetContext // TypeDefIndex: 29373
{
	// Fields
	private MonoActivityCountdownWidget _widgetMono; // 0x168
	private ulong _endTime; // 0x170
	private uint _endTimeStamp; // 0x178
	private float _countDownTime; // 0x17C
	private int _countDownSecond; // 0x180
	private uint _prevTickTime; // 0x184
	private bool _finish; // 0x188
	private float _defaultCountdown; // 0x18C

	// Constructors
	public ActivityCountdownWidgetContext() {} // Dummy constructor
	public ActivityCountdownWidgetContext(ulong endTime, float defaultCountdown) {} // 0x00000001831A09C0-0x00000001831A0AB0

	// Methods
	// [XID] // 0x00000001899007C0-0x00000001899007E0
	public override void SetupView() {} // 0x00000001831A07A0-0x00000001831A08D0
	// [XID] // 0x0000000189907F10-0x0000000189907F30
	public override void UpdateView() {} // 0x00000001831A08D0-0x00000001831A09C0
	// [XID] // 0x000000018990F700-0x000000018990F720
	public override void ClearView() {} // 0x000000018319FD30-0x000000018319FDD0
	// [XID] // 0x00000001899170D0-0x00000001899170F0
	private void InitPrepareTime(uint endTime) {} // 0x000000018319FF90-0x00000001831A0070
	// [XID] // 0x000000018991E7F0-0x000000018991E810
	private void InitPrepareCountdown(float seconds) {} // 0x00000001831A0610-0x00000001831A06F0
	// [XID] // 0x0000000189926090-0x00000001899260B0
	public void SetTime(uint endTimeStamp, float defaultCountdown) {} // 0x00000001831A0070-0x00000001831A0140
	// [XID] // 0x000000018992D760-0x000000018992D780
	public void SetCountdown(float seconds) {} // 0x00000001831A0140-0x00000001831A0200
	// [XID] // 0x0000000189934C10-0x0000000189934C30
	public void TickTime() {} // 0x000000018319FDD0-0x000000018319FF90
	// [XID] // 0x000000018993C6E0-0x000000018993C700
	public void TickCountdown() {} // 0x00000001831A0260-0x00000001831A0440
	// [XID] // 0x0000000189943D10-0x0000000189943D30
	public void SetTimeText(uint spanSeconds) {} // 0x00000001831A0500-0x00000001831A0610
	// [XID] // 0x000000018994B230-0x000000018994B250
	public bool IsCountDown() => default; // 0x00000001831A06F0-0x00000001831A07A0
}

