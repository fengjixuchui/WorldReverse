/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MTRClient_Win : IMTRClient // TypeDefIndex: 21180
{
	// Fields
	private ThreadWorkContext _curContext; // 0x10
	private Action<MTRData> _curWorkCallBack; // 0x18
	private bool _isWorking; // 0x20
	private WantStartParams _wantStartParams; // 0x28
	private static string _sendData; // 0x00
	private static int _replaySize; // 0x08

	// Nested types
	private class ThreadWorkContext // TypeDefIndex: 21181
	{
		// Fields
		public bool forceInterrupt; // 0x10
		public bool isFinished; // 0x11
		public bool isInterrupt; // 0x12
		public int tarAddress; // 0x14
		public MTRData resultReport; // 0x18
		public byte maxTTL; // 0x20
		public int timeOut; // 0x24
		public int maxTryCount; // 0x28
		public int abortTimeOutCount; // 0x2C
		public byte realTTL; // 0x30
		public IntPtr fileHandle; // 0x38
		public List<SingleTTLWorkContext> singleTTLContext; // 0x40
		private bool _isWorking; // 0x48

		// Properties
		public bool isWorking { /* [XID] */ /* 0x0000000189AB8A00-0x0000000189AB8A20 */ get => default; } // 0x00000001845C5810-0x00000001845C58B0 

		// Constructors
		public ThreadWorkContext() {} // 0x00000001845C58B0-0x00000001845C5960

		// Methods
		// [XID] // 0x0000000189AC0630-0x0000000189AC0650
		public void Start(string url, IPAddress address, byte maxTTL, int timeOut, int maxTryCount, int abortTimeOutCount, MTRReason reason) {} // 0x00000001845C5560-0x00000001845C5810
		// [XID] // 0x0000000189AC7FD0-0x0000000189AC7FF0
		public void Stop() {} // 0x00000001845C5390-0x00000001845C5560
	}

	private class SingleTTLWorkContext // TypeDefIndex: 21182
	{
		// Fields
		public MTRWinNative.ICMP_OPTIONS option; // 0x10
		public MTRWinNative.ICMP_ECHO_REPLY replay; // 0x20
		public IntPtr waitHandle; // 0x48
		public bool waitError; // 0x50
		public int curTimeOutCount; // 0x54
		public int curTotalCount; // 0x58
		public bool isReleased; // 0x5C

		// Constructors
		public SingleTTLWorkContext() {} // 0x00000001845C5B70-0x00000001845C5BD0

		// Methods
		// [XID] // 0x0000000189ACF670-0x0000000189ACF690
		public void Init(byte ttl) {} // 0x00000001845C5960-0x00000001845C5AA0
		// [XID] // 0x0000000189AD7420-0x0000000189AD7440
		public void Release() {} // 0x00000001845C5AA0-0x00000001845C5B70
	}

	private struct WantStartParams // TypeDefIndex: 21183
	{
		// Fields
		public string url; // 0x00
		public IPAddress address; // 0x08
		public byte maxTTL; // 0x10
		public int timeOut; // 0x14
		public int maxTryCount; // 0x18
		public int abortTimeOutCount; // 0x1C
		public MTRReason reason; // 0x20
		public Action<MTRData> callBack; // 0x28

		// Methods
		// [XID] // 0x0000000189ADEF10-0x0000000189ADEF30
		public void Init(string url, IPAddress address, byte maxTTL, int timeOut, int maxTryCount, int abortTimeOutCount, MTRReason reason, Action<MTRData> callBack) {} // 0x00000001845C52B0-0x00000001845C5360
		// [XID] // 0x0000000189AE67E0-0x0000000189AE6800
		public void Clear() {} // 0x00000001845C5360-0x00000001845C5390
	}

	// Constructors
	public MTRClient_Win() {} // 0x00000001845B7B50-0x00000001845B7C00
	static MTRClient_Win() {} // 0x00000001845B7A40-0x00000001845B7B50

	// Methods
	// [XID] // 0x0000000189A66310-0x0000000189A66330
	public bool CheckIsValid() => default; // 0x00000001845B6AE0-0x00000001845B6C80
	// [XID] // 0x0000000189A6DA60-0x0000000189A6DA80
	public bool Start(string url, IPAddress address, byte maxTTL, int timeOut, int maxTryCount, int abortTimeOutCount, MTRReason reason, Action<MTRData> callBack) => default; // 0x00000001845B6E00-0x00000001845B6FA0
	// [XID] // 0x0000000189A751B0-0x0000000189A751D0
	public void Stop() {} // 0x00000001845B6C80-0x00000001845B6D60
	// [XID] // 0x0000000189A7CE10-0x0000000189A7CE30
	public bool IsWorking() => default; // 0x00000001845B6D60-0x00000001845B6E00
	// [XID] // 0x0000000189A846E0-0x0000000189A84700
	public string GetReport() => default; // 0x00000001845B7800-0x00000001845B78D0
	// [XID] // 0x0000000189A8C020-0x0000000189A8C040
	private void TryInterruptWorkImpl() {} // 0x00000001845B7980-0x00000001845B7A40
	// [XID] // 0x0000000189A934D0-0x0000000189A934F0
	public void WorkThreadCollect() {} // 0x00000001845B7190-0x00000001845B72F0
	// [XID] // 0x0000000189A9AFE0-0x0000000189A9B000
	public void WorkThreadExecute() {} // 0x00000001845B72F0-0x00000001845B7800
	// [XID] // 0x0000000189AA2350-0x0000000189AA2370
	public void WorkThreadFlush() {} // 0x00000001845B7040-0x00000001845B7190
	// [XID] // 0x0000000189AA98C0-0x0000000189AA98E0
	public void WorkThreadInit() {} // 0x00000001845B6FA0-0x00000001845B7040
	// [XID] // 0x0000000189AB1680-0x0000000189AB16A0
	public void WorkThreadDestroy() {} // 0x00000001845B78D0-0x00000001845B7980
}

