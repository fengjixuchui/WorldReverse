/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BenchmarkRunnerInstanceBase : IBMCaseRunner, ISessionCase // TypeDefIndex: 27591
{
	// Fields
	private BenchmarkRunnerTemplate _brt; // 0x10
	private BenchmarkCase[] _cases; // 0x18
	private BenchmarkRunnerInstanceBase[] _runners; // 0x20
	private Coroutine _runningCases; // 0x28
	protected bool _needLog; // 0x30
	protected ConsoleCommandExecuter _cce; // 0x38

	// Properties
	public int sessionID { /* [XID] */ /* 0x0000000189B8E890-0x0000000189B8E8D0 */ get; /* [XID] */ /* 0x0000000189B98EA0-0x0000000189B98EE0 */ set; } // 0x00000001824193B0-0x0000000182419410 0x00000001824186C0-0x0000000182418720

	// Constructors
	protected BenchmarkRunnerInstanceBase() {} // 0x00000001824196B0-0x0000000182419730

	// Methods
	public static T CreateBMCaseFromJson<T>(string caseJsonFile)
		where T : BMCaseBase => default;
	// [XID] // 0x0000000189BA35B0-0x0000000189BA35D0
	public void ConstructCases(string brtPath, bool needLog, ConsoleCommandExecuter cce) {} // 0x0000000182418720-0x0000000182418820
	// [XID] // 0x0000000189BAA930-0x0000000189BAA950
	public void ConstructCasesBySingleCasePath(string brtPath, bool needLog, ConsoleCommandExecuter cce) {} // 0x0000000182418530-0x00000001824186C0
	// [XID] // 0x0000000189BB1EF0-0x0000000189BB1F10
	protected void InteralConstructCases(BenchmarkRunnerTemplate inBRT, bool needLog, ConsoleCommandExecuter cce) {} // 0x00000001824180D0-0x00000001824181D0
	protected void ConstructBMCases<T>(BenchmarkRunnerTemplate inBRT)
		where T : BenchmarkRunnerInstanceBase, new() {}
	protected abstract void ConstructBMCases(BenchmarkRunnerTemplate inBRT);
	// [XID] // 0x0000000189BB9350-0x0000000189BB9370
	public void EnableLog(bool bNeedLog) {} // 0x00000001824181D0-0x00000001824182E0
	// [XID] // 0x0000000189BC10E0-0x0000000189BC1100
	protected void LogWithTime(string caseContent) {} // 0x0000000182419510-0x00000001824196B0
	// [XID] // 0x0000000189BC88B0-0x0000000189BC88D0
	protected virtual void OnStartBMCaseSample(string caseName, int caseID) {} // 0x0000000182418BC0-0x0000000182418CC0
	// [XID] // 0x0000000189BD00D0-0x0000000189BD00F0
	protected virtual void OnEndBMCaseSample(string caseName, int caseID) {} // 0x0000000182419410-0x0000000182419510
	// [XID] // 0x0000000189BD7710-0x0000000189BD7730
	private void OnExecuteCommandSample(string command) {} // 0x0000000182418AA0-0x0000000182418BC0
	// [XID] // 0x0000000189BDF1D0-0x0000000189BDF1F0
	private void OnExecuteLuaShell(string command) {} // 0x0000000182418820-0x0000000182418960
	// [XID] // 0x00000001895EBE60-0x00000001895EBE80
	private void OnExecuteCommandObjectSample(string command, object obj) {} // 0x0000000182419040-0x0000000182419240
	[DebuggerHidden] // 0x00000001895F3240-0x00000001895F3280
	// [XID] // 0x00000001895F3240-0x00000001895F3280
	public IEnumerator Run(int startCaseID, Action<string, int> onStartBMCase, Action<string, int> onEndBMCase, Action<string> onExecuteCommand, Action<string, object> onExecuteCommandWithObject, Action<string> onExecuteLuaShell, float timeScale = 1f /* Metadata: 0x00B0CA5B */) => default; // 0x00000001824183A0-0x0000000182418530
	[DebuggerHidden] // 0x00000001895FD970-0x00000001895FD9B0
	// [XID] // 0x00000001895FD970-0x00000001895FD9B0
	private IEnumerator CaseTestStop2(WaitForSeconds wait, int i, int y) => default; // 0x0000000182418DE0-0x0000000182418F20
	[DebuggerHidden] // 0x00000001896084E0-0x0000000189608520
	// [XID] // 0x00000001896084E0-0x0000000189608520
	private IEnumerator CaseTestStop(WaitForSeconds wait, int i) => default; // 0x0000000182418960-0x0000000182418AA0
	[DebuggerHidden] // 0x0000000189612A30-0x0000000189612A70
	// [XID] // 0x0000000189612A30-0x0000000189612A70
	private IEnumerator RunCasesTestStop(float timeScale) => default; // 0x0000000182418CC0-0x0000000182418DE0
	[DebuggerHidden] // 0x000000018961D2C0-0x000000018961D300
	// [XID] // 0x000000018961D2C0-0x000000018961D300
	private IEnumerator RunCases(float timeScale) => default; // 0x0000000182418F20-0x0000000182419040
	// [XID] // 0x00000001896277D0-0x00000001896277F0
	protected void Dispose() {} // 0x0000000182419240-0x00000001824193B0
	// [XID] // 0x000000018962F2B0-0x000000018962F2D0
	protected virtual void OnCaseFinished() {} // 0x00000001824182E0-0x00000001824183A0
	// [XID] // 0x0000000189636C70-0x0000000189636C90
	public void RunEntry(float timeScale) {} // 0x0000000182417F20-0x00000001824180D0
	// [XID] // 0x000000018963E1A0-0x000000018963E1C0
	public void Stop() {} // 0x0000000182417D90-0x0000000182417F20
	public static T CreateBMInstance<T>(string[] args, ConsoleCommandExecuter inExecuter)
		where T : BenchmarkRunnerInstanceBase, new() => default;
	public static T CreateBMInstanceBySingleCasePath<T>(string[] args, ConsoleCommandExecuter inExecuter)
		where T : BenchmarkRunnerInstanceBase, new() => default;
}

