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

public class ReentryChecker // TypeDefIndex: 26642
{
	// Fields
	private IFrameSingletonTask _task; // 0x10
	private int _taskCollectFrame; // 0x18
	private int _lastCollectFrame; // 0x1C
	public bool _isExecuting; // 0x20
	private int _lastScheduledFrame; // 0x24
	private int _lastFlushFrame; // 0x28
	private List<string> _errorMsgs; // 0x30

	// Nested types
	private struct HistoryInfo // TypeDefIndex: 26643
	{
		// Fields
		public string info; // 0x00
		public string stackTrace; // 0x08

		// Constructors
		public HistoryInfo(string inInfo) {
			info = default;
			stackTrace = default;
		} // 0x0000000182855F80-0x0000000182856030
	}

	// Constructors
	public ReentryChecker() {} // Dummy constructor
	public ReentryChecker(IFrameSingletonTask inTask) {} // 0x0000000182845140-0x00000001828451E0

	// Methods
	// [XID] // 0x00000001899693D0-0x00000001899693F0
	public override string ToString() => default; // 0x0000000182844DA0-0x0000000182845140
	// [XID] // 0x0000000189970F50-0x0000000189970F70
	private void OnAlert(string errorMsg) {} // 0x00000001828444F0-0x00000001828446A0
	// [XID] // 0x0000000189978880-0x00000001899788A0
	private string OnHistory(string behaviour, Queue<HistoryInfo> history, int maxCount) => default; // 0x00000001828446A0-0x0000000182844CC0
	// [XID] // 0x000000018997F8F0-0x000000018997F910
	public void OnCollect() {} // 0x0000000182844150-0x0000000182844230
	// [XID] // 0x00000001899872E0-0x0000000189987300
	public void OnExecute() {} // 0x0000000182844CC0-0x0000000182844DA0
	// [XID] // 0x000000018998EDB0-0x000000018998EDD0
	public void OnFlush() {} // 0x0000000182844230-0x00000001828444F0
}

