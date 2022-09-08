/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MTRManager : GlobalManager, INotifyInterface // TypeDefIndex: 21189
{
	// Fields
	private const bool _defaultIsOpen = false; // Metadata: 0x00AFF082
	private const int _defaultMaxTTL = 32; // Metadata: 0x00AFF083
	private const int _defaultTimeOut = 5000; // Metadata: 0x00AFF087
	private const int _defaultTraceCount = 5; // Metadata: 0x00AFF08B
	private const int _defaultAbortTimeOutCount = 3; // Metadata: 0x00AFF08F
	private const int _defaultAutoTraceInterval = 3600; // Metadata: 0x00AFF093
	private const int _defaultTraceCDEachReason = 600; // Metadata: 0x00AFF097
	private bool _isOpen; // 0x10
	private int _maxTTL; // 0x14
	private int _timeOut; // 0x18
	private int _traceCount; // 0x1C
	private int _abortTimeOutCount; // 0x20
	private int _autoTraceInterval; // 0x24
	private int _traceCDEachReason; // 0x28
	private bool _paramInited; // 0x2C
	private bool _initByServer; // 0x2D
	private bool _isDNSAnylzing; // 0x2E
	private string _curDNSAnylzingUrl; // 0x30
	private MTRReason _curDNSAnylzingReason; // 0x38
	private float _lastAutoTraceTime; // 0x3C
	private MtrManagerTask _mtrMgrTask; // 0x40
	private bool _isAutoTracing; // 0x48
	private float[] _reasonLastTraceTime; // 0x50
	private IMTRClient _client; // 0x58

	// Constructors
	public MTRManager() {} // 0x000000018365FE70-0x000000018365FF50

	// Methods
	// [XID] // 0x0000000189B1AA60-0x0000000189B1AA80
	public override void Init() {} // 0x000000018365EDB0-0x000000018365EF50
	// [XID] // 0x0000000189B22050-0x0000000189B22070
	private void RegistNofity() {} // 0x000000018365FC90-0x000000018365FD70
	// [XID] // 0x0000000189B29600-0x0000000189B29620
	private void UnregistNotify() {} // 0x000000018365FAA0-0x000000018365FB80
	// [XID] // 0x0000000189B30B90-0x0000000189B30BB0
	private void LoadLocalParamData() {} // 0x000000018365DFA0-0x000000018365E190
	// [XID] // 0x0000000189B38230-0x0000000189B38250
	private void SaveLocalParamData() {} // 0x000000018365DA00-0x000000018365DBF0
	// [XID] // 0x0000000189B3FC80-0x0000000189B3FCA0
	public bool OnNotify(Notify ntf) => default; // 0x000000018365FB80-0x000000018365FC90
	// [XID] // 0x0000000189B47470-0x0000000189B47490
	public static void BeginServerInit() {} // 0x000000018365E330-0x000000018365E3F0
	// [XID] // 0x0000000189B4ECB0-0x0000000189B4ECD0
	public static void EndServerInit() {} // 0x000000018365D8F0-0x000000018365DA00
	// [XID] // 0x0000000189B565E0-0x0000000189B56600
	public void InitParams(bool? isOpen, int? maxTTL, int? timeOut, int? traceCount, int? abortTimeOutCount, int? autoTraceInterval, int? traceCDEachReason) {} // 0x000000018365EFD0-0x000000018365F240
	// [XID] // 0x0000000189B5DD60-0x0000000189B5DD80
	public override void ClearOnLevelDestroy() {} // 0x000000018365DE10-0x000000018365DEB0
	// [XID] // 0x0000000189B65300-0x0000000189B65320
	public override void ReloadRes() {} // 0x000000018365FDD0-0x000000018365FE70
	// [XID] // 0x0000000189B6C960-0x0000000189B6C980
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF081 */) {} // 0x000000018365DCB0-0x000000018365DD70
	// [XID] // 0x0000000189B74040-0x0000000189B74060
	public override void Destroy() {} // 0x000000018365DEB0-0x000000018365DFA0
	// [XID] // 0x0000000189B7B630-0x0000000189B7B650
	public bool IsValid() => default; // 0x000000018365D840-0x000000018365D8F0
	// [XID] // 0x0000000189B83020-0x0000000189B83040
	public bool IsWorking() => default; // 0x000000018365DBF0-0x000000018365DCB0
	// [XID] // 0x0000000189B8A570-0x0000000189B8A590
	public void StartMonitorByUrl(string url, MTRReason reason) {} // 0x000000018365E520-0x000000018365E790
	// [XID] // 0x0000000189B91B60-0x0000000189B91B80
	private void OnGetHostAddressEnd(IAsyncResult result) {} // 0x000000018365F980-0x000000018365FAA0
	// [XID] // 0x0000000189B99000-0x0000000189B99020
	private bool IsCanStartMonitor(MTRReason reason) => default; // 0x000000018365F240-0x000000018365F3C0
	// [XID] // 0x0000000189BA0350-0x0000000189BA0370
	public void StartMonitor(string ip, IPAddress ipAddress, MTRReason reason) {} // 0x000000018365F500-0x000000018365F7E0
	// [XID] // 0x0000000189BA7BB0-0x0000000189BA7BD0
	private void OnMonitorEnd(MTRData report) {} // 0x000000018365F3C0-0x000000018365F500
	// [XID] // 0x0000000189BAEFE0-0x0000000189BAF000
	public override void ClearOnDisconnect() {} // 0x000000018365DD70-0x000000018365DE10
	// [XID] // 0x0000000189BB6650-0x0000000189BB6670
	public void StopMonitor() {} // 0x000000018365E930-0x000000018365E9E0
	// [XID] // 0x0000000189BBDD20-0x0000000189BBDD40
	public void StartGameServerMonitor(MTRReason reason) {} // 0x000000018365E3F0-0x000000018365E520
	// [XID] // 0x0000000189BC59C0-0x0000000189BC59E0
	public void WorkThreadInit() {} // 0x000000018365E190-0x000000018365E330
	// [XID] // 0x0000000189BCD480-0x0000000189BCD4A0
	public void WorkThreadCollect() {} // 0x000000018365E9E0-0x000000018365EC10
	// [XID] // 0x0000000189BD49B0-0x0000000189BD49D0
	public void WorkThreadExecute() {} // 0x000000018365EC10-0x000000018365EDB0
	// [XID] // 0x0000000189BDC460-0x0000000189BDC480
	public void WorkThreadFlush() {} // 0x000000018365E790-0x000000018365E930
	// [XID] // 0x00000001895E8D30-0x00000001895E8D50
	public void WorkThreadDestroy() {} // 0x000000018365F7E0-0x000000018365F980
}

