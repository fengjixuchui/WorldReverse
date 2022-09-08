/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class WaitingRspWidgetContext : BaseWidgetContext // TypeDefIndex: 28991
{
	// Fields
	private const float DEFAULT_TIMEOUT_DELAY = 60f; // Metadata: 0x00B0E906
	private float _timeOutDuration; // 0x168
	private bool _waitingByManager; // 0x16C
	private Dictionary<ushort, List<Action<Packet>>> _rspCallBackDic; // 0x170
	private GeneralDialogContext _curGeneralDialog; // 0x178

	// Constructors
	public WaitingRspWidgetContext() {} // 0x000000018352DA60-0x000000018352DBA0

	// Methods
	// [XID] // 0x00000001898E6EE0-0x00000001898E6F00
	public override void Init() {} // 0x000000018352D1C0-0x000000018352D2F0
	// [XID] // 0x00000001898EE6B0-0x00000001898EE6D0
	public void ResetDelayDuration(float? tarDuration = default) {} // 0x000000018352D6D0-0x000000018352D7D0
	// [XID] // 0x00000001898F5E40-0x00000001898F5E60
	public void AddWaitingByManager() {} // 0x000000018352D430-0x000000018352D4D0
	// [XID] // 0x00000001898FD680-0x00000001898FD6A0
	public void RemoveWaitingByManager() {} // 0x000000018352D0B0-0x000000018352D160
	// [XID] // 0x0000000189904F40-0x0000000189904F60
	public void AddWaitingRsp(ushort rspId, Action<Packet> onRspCallback = null) {} // 0x000000018352CF30-0x000000018352D0B0
	// [XID] // 0x000000018990C740-0x000000018990C760
	protected override void RegisterHandlePacket() {} // 0x000000018352D7D0-0x000000018352D870
	// [XID] // 0x0000000189913FF0-0x0000000189914010
	public override bool OnPacket(Packet packet) => default; // 0x000000018352D4D0-0x000000018352D6D0
	// [XID] // 0x000000018991BA40-0x000000018991BA60
	public override void UpdateView() {} // 0x000000018352D870-0x000000018352DA60
	// [XID] // 0x0000000189922FC0-0x0000000189922FE0
	private static void ReconnectImpl(bool check) {} // 0x000000018352D350-0x000000018352D430
	// [XID] // 0x000000018992A7B0-0x000000018992A7D0
	private void CheckCanClose() {} // 0x000000018352CD60-0x000000018352CE40
	// [XID] // 0x0000000189931DD0-0x0000000189931DF0
	public override void CloseWidget() {} // 0x000000018352CE40-0x000000018352CF30
}

