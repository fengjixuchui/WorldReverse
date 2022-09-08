/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class SliceFrameWatch // TypeDefIndex: 10625
	{
		// Fields
		private long _lastTickstamp; // 0x18
		private long _tickElapsed; // 0x20
		private double _millisecondsElapsed; // 0x28
		public double lastLoadTime; // 0x30
		private int _lastClearFrame; // 0x38
		private bool _infinityMode; // 0x48
	
		// Properties
		public bool bStarted { /* [XID] */ /* 0x0000000189AD04E0-0x0000000189AD0520 */ get; /* [XID] */ /* 0x0000000189ADB270-0x0000000189ADB2B0 */ private set; } // 0x00000001868A8FC0-0x00000001868A9020 0x00000001868A91E0-0x00000001868A9240
		public bool bDisabled { /* [XID] */ /* 0x00000001898DDD00-0x00000001898DDD20 */ get => default; /* [XID] */ /* 0x0000000189AFF270-0x0000000189AFF290 */ set {} } // 0x00000001868A8F20-0x00000001868A8FC0 0x00000001868A9120-0x00000001868A91E0
		public long tickThreshold { /* [XID] */ /* 0x0000000189B30190-0x0000000189B301D0 */ get; /* [XID] */ /* 0x0000000189B3AAA0-0x0000000189B3AAE0 */ private set; } // 0x00000001868A90C0-0x00000001868A9120 0x00000001868A92F0-0x00000001868A9350
		public bool infinityMode { /* [XID] */ /* 0x0000000189B5BE00-0x0000000189B5BE20 */ get => default; /* [XID] */ /* 0x0000000189B54240-0x0000000189B54260 */ set {} } // 0x00000001868A9020-0x00000001868A90C0 0x00000001868A9240-0x00000001868A92F0
	
		// Nested types
		public struct ScopeTickWatch : IDisposable // TypeDefIndex: 10626
		{
			// Fields
			private SliceFrameWatch _watch; // 0x00
			private bool _isTickSuccess; // 0x08
	
			// Constructors
			public ScopeTickWatch(SliceFrameWatch inWatch) {
				_watch = default;
				_isTickSuccess = default;
			} // 0x00000001868A0FD0-0x00000001868A10D0
	
			// Methods
			// [XID] // 0x0000000189A7C2C0-0x0000000189A7C2E0
			public bool IsTickSuccess() => default; // 0x00000001868A0F30-0x00000001868A0FD0
			// [XID] // 0x0000000189A9A680-0x0000000189A9A6A0
			public void Dispose() {} // 0x00000001868A0E80-0x00000001868A0F30
		}
	
		public struct ScopeLessTickWatch : IDisposable // TypeDefIndex: 10627
		{
			// Fields
			private ScopeTickWatchConsumer _sharedWatch; // 0x00
			public SliceFrameWatch thresholdWatch; // 0x08
	
			// Constructors
			public ScopeLessTickWatch(SliceFrameWatch inInternalSFW, SliceFrameWatch inSharedSFW) {
				_sharedWatch = default;
				thresholdWatch = default;
			} // 0x00000001868A08C0-0x00000001868A0990
	
			// Methods
			// [XID] // 0x0000000189A83C80-0x0000000189A83CA0
			public void Dispose() {} // 0x00000001868A0790-0x00000001868A08C0
		}
	
		public struct ScopeMoreTickWatch : IDisposable // TypeDefIndex: 10628
		{
			// Fields
			private ScopeTickWatchConsumer _sharedWatch; // 0x00
			public SliceFrameWatch thresholdWatch; // 0x08
	
			// Constructors
			public ScopeMoreTickWatch(SliceFrameWatch inInternalSFW, SliceFrameWatch inSharedSFW) {
				_sharedWatch = default;
				thresholdWatch = default;
			} // 0x00000001868A0AC0-0x00000001868A0BA0
	
			// Methods
			// [XID] // 0x00000001898E6B80-0x00000001898E6BA0
			public void Dispose() {} // 0x00000001868A0990-0x00000001868A0AC0
		}
	
		// Constructors
		public SliceFrameWatch() {} // 0x00000001868A8D80-0x00000001868A8E80
		public SliceFrameWatch(float inMS) {} // 0x00000001868A8E80-0x00000001868A8F20
	
		// Methods
		// [XID] // 0x000000018970FC70-0x000000018970FC90
		public double Elapsed() => default; // 0x00000001868A7EE0-0x00000001868A7F90
		// [XID] // 0x0000000189AED470-0x0000000189AED490
		private void RefreshTickstamp() {} // 0x00000001868A86C0-0x00000001868A8780
		// [XID] // 0x0000000189AF4EA0-0x0000000189AF4EC0
		public void Debug() {} // 0x00000001868A7BF0-0x00000001868A7EE0
		// [XID] // 0x00000001897DAA20-0x00000001897DAA40
		private void RefreshElapsedTick() {} // 0x00000001868A85D0-0x00000001868A86C0
		// [XID] // 0x0000000189B03CD0-0x0000000189B03CF0
		public void Reset() {} // 0x00000001868A8830-0x00000001868A8920
		// [XID] // 0x0000000189A565C0-0x0000000189A565E0
		public void ResetOnceAFrame() {} // 0x00000001868A8780-0x00000001868A8830
		// [XID] // 0x0000000189A5E1D0-0x0000000189A5E1F0
		public void Start() {} // 0x00000001868A8B20-0x00000001868A8C50
		// [XID] // 0x00000001897CB5A0-0x00000001897CB5C0
		public void Stop() {} // 0x00000001868A8C50-0x00000001868A8D80
		// [XID] // 0x00000001899CAB00-0x00000001899CAB20
		public void SetMillisecondThreshold(float inMS) {} // 0x00000001868A8920-0x00000001868A8A40
		// [XID] // 0x0000000189B4CB70-0x0000000189B4CB90
		public void SetTickThreshold(long tickThreshold) {} // 0x00000001868A8A40-0x00000001868A8B20
		// [XID] // 0x0000000189B63200-0x0000000189B63220
		public bool HasExceedSliceFrameThreshold(bool bRefreshElapsedTime = false /* Metadata: 0x00AE7DDE */) => default; // 0x00000001868A84C0-0x00000001868A85D0
		// [XID] // 0x00000001898ECE60-0x00000001898ECE80
		public static SliceFrameWatch GetLessRemainingTickWatch(SliceFrameWatch w1, SliceFrameWatch w2) => default; // 0x00000001868A8070-0x00000001868A8220
		// [XID] // 0x0000000189B72300-0x0000000189B72320
		public static SliceFrameWatch GetMoreRemainingTickWatch(SliceFrameWatch w1, SliceFrameWatch w2) => default; // 0x00000001868A8220-0x00000001868A8330
		// [XID] // 0x0000000189B79730-0x0000000189B79750
		public long GetRemainingSliceFrameTick() => default; // 0x00000001868A8330-0x00000001868A8420
		// [XID] // 0x00000001897F8A40-0x00000001897F8A60
		public long GetTickElapsed() => default; // 0x00000001868A8420-0x00000001868A84C0
		// [XID] // 0x0000000189B88680-0x0000000189B886A0
		public bool Begin() => default; // 0x00000001868A7B30-0x00000001868A7BF0
		// [XID] // 0x0000000189A1CB80-0x0000000189A1CBA0
		public bool End() => default; // 0x00000001868A7F90-0x00000001868A8070
	}
}
