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

public class StatModule // TypeDefIndex: 27868
{
	// Fields
	private static StatModule _instance; // 0x00
	private IEnumerator _frameStateAnalyzer; // 0x10
	public const int statusDataBatchCount = 60; // Metadata: 0x00B0D0B7
	private StatusCollector _statusCollector; // 0x18
	private WaitForSeconds _collectInterval; // 0x20

	// Properties
	public static StatModule instance { /* [XID] */ /* 0x0000000189AA9690-0x0000000189AA96B0 */ get => default; } // 0x00000001843C45A0-0x00000001843C4680 

	// Nested types
	private class StatusCollector // TypeDefIndex: 27869
	{
		// Fields
		public static float toRecordLevelLoadedTime; // 0x00
		public static float toRecordFpsTime; // 0x04
		public static int targetMemoryRecordTime; // 0x08
		private TimerReceiver _startCollectTimer; // 0x10
		private TimerReceiver _collectStatusTimer; // 0x18

		// Constructors
		public StatusCollector() {} // Dummy constructor
		public StatusCollector(int batchDataCount) {} // 0x00000001843DEBB0-0x00000001843DEC10
		static StatusCollector() {} // 0x00000001843DEB40-0x00000001843DEBB0

		// Methods
		// [XID] // 0x0000000189AD28E0-0x0000000189AD2900
		private bool StartLoopCollect() => default; // 0x00000001843DE830-0x00000001843DEA00
		// [XID] // 0x0000000189ADA330-0x0000000189ADA350
		private void ConditionalSendStatToServer() {} // 0x00000001843DEAA0-0x00000001843DEB40
		// [XID] // 0x0000000189AE1BF0-0x0000000189AE1C10
		private bool LoopCollect() => default; // 0x00000001843DEA00-0x00000001843DEAA0
		// [XID] // 0x0000000189AE9400-0x0000000189AE9420
		public void ConditionalStartCollect() {} // 0x00000001843DE5C0-0x00000001843DE740
		// [XID] // 0x0000000189AF11D0-0x0000000189AF11F0
		public void Clear(bool isFlush) {} // 0x00000001843DE740-0x00000001843DE830
	}

	// Constructors
	public StatModule() {} // 0x00000001843C4C80-0x00000001843C4D80

	// Methods
	// [XID] // 0x0000000189A9ADB0-0x0000000189A9ADD0
	public static int GetUTCNow() => default; // 0x00000001843C4450-0x00000001843C45A0
	// [XID] // 0x0000000189AA2170-0x0000000189AA2190
	public static string AppendTimeStampCSV(string inCSVContent, bool bNeedPrefixComma, bool bNeedSuffixComma) => default; // 0x00000001843C4AE0-0x00000001843C4C80
	[DebuggerHidden] // 0x0000000189AB14F0-0x0000000189AB1530
	// [XID] // 0x0000000189AB14F0-0x0000000189AB1530
	private IEnumerator OnAnalyzePlayerFrameStatus() => default; // 0x00000001843C49D0-0x00000001843C4AE0
	// [XID] // 0x0000000189ABC090-0x0000000189ABC0B0
	private void ClearFrameState() {} // 0x00000001843C4680-0x00000001843C4730
	// [XID] // 0x0000000189AC3880-0x0000000189AC38A0
	public void OnPlayerLogin() {} // 0x00000001843C4730-0x00000001843C4890
	// [XID] // 0x0000000189ACAE90-0x0000000189ACAEB0
	private void Shutdown() {} // 0x00000001843C4890-0x00000001843C49D0
}

