/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtSceneRouteChange : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20158
{
	// Fields
	public RepeatedMessageField<SceneRouteChangeInfo> RouteList; // 0x30
	public uint SceneTime; // 0x38

	// Constructors
	public EvtSceneRouteChange() {} // 0x000000018108D5A0-0x000000018108D600

	// Methods
	[BlackList] // 0x000000018980B110-0x000000018980B150
	// [XID] // 0x000000018980B110-0x000000018980B150
	public override void AutoAllocTypeFields() {} // 0x000000018108CF80-0x000000018108D020
	[BlackList] // 0x00000001898158D0-0x0000000189815910
	// [XID] // 0x00000001898158D0-0x0000000189815910
	public override void AutoRecycleTypeFields() {} // 0x000000018108D020-0x000000018108D0D0
	[BlackList] // 0x0000000189820430-0x0000000189820470
	// [XID] // 0x0000000189820430-0x0000000189820470
	public override void ReturnToObjectPool() {} // 0x000000018108D450-0x000000018108D4F0
	// [XID] // 0x000000018982A8F0-0x000000018982A910
	public void Init(SceneRouteChangeNotify notify) {} // 0x000000018108D1A0-0x000000018108D280
	// [XID] // 0x0000000189831D60-0x0000000189831D80
	public override string ToString() => default; // 0x000000018108D4F0-0x000000018108D5A0
	// [XID] // 0x00000001898393A0-0x00000001898393C0
	public override void Clear() {} // 0x000000018108D280-0x000000018108D330
}

