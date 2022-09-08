/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class DebugReplayer : MonoBehaviour // TypeDefIndex: 31817
	{
		// Fields
		private ReplaySession curReplaySession; // 0x18
		public IReplayDebugDraw replayDD; // 0x20
	
		// Properties
		public int currentFrame { /* [XID] */ /* 0x000000018973E740-0x000000018973E760 */ get => default; /* [XID] */ /* 0x0000000189745A20-0x0000000189745A40 */ set {} } // 0x0000000184D81410-0x0000000184D814C0 0x0000000184D815A0-0x0000000184D81670
		public int totalFrames { /* [XID] */ /* 0x000000018974D4E0-0x000000018974D500 */ get => default; } // 0x0000000184D814C0-0x0000000184D815A0 
	
		// Nested types
		private class ReplaySession // TypeDefIndex: 31818
		{
			// Fields
			public RecordData data; // 0x10
			public int currentFrameId; // 0x18
	
			// Constructors
			public ReplaySession() {} // 0x0000000184D9A810-0x0000000184D9A870
		}
	
		// Constructors
		public DebugReplayer() {} // 0x0000000184D813B0-0x0000000184D81410
	
		// Methods
		// [XID] // 0x0000000189718E10-0x0000000189718E30
		public void BeginReplay(RecordData data) {} // 0x0000000184D80950-0x0000000184D80A90
		// [XID] // 0x00000001897205B0-0x00000001897205D0
		public void EndReplay() {} // 0x0000000184D80A90-0x0000000184D80B80
		// [XID] // 0x0000000189727BE0-0x0000000189727C00
		private void Update() {} // 0x0000000184D80FC0-0x0000000184D813B0
		// [XID] // 0x000000018972F190-0x000000018972F1B0
		public void NextFrame() {} // 0x0000000184D80E60-0x0000000184D80F10
		// [XID] // 0x0000000189736BA0-0x0000000189736BC0
		public void PrevFrame() {} // 0x0000000184D80F10-0x0000000184D80FC0
		// [XID] // 0x0000000189754B90-0x0000000189754BB0
		private void StepToFrame(int frameID) {} // 0x0000000184D80B80-0x0000000184D80E60
	}
}
