/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cinemachine;
using IFix.Core;
using UnityEngine.Playables;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine.Timeline
{
	public sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 6867
	{
		// Fields
		private CinemachineBrain mBrain; // 0x10
		private int mBrainOverrideId; // 0x18
		private bool mPlaying; // 0x1C
		private float mLastOverrideFrame; // 0x20
	
		// Constructors
		public CinemachineMixer() {} // 0x00000001866960C0-0x0000000186696130
	
		// Methods
		// [XID] // 0x00000001899C3750-0x00000001899C3770
		public override void OnGraphStop(Playable playable) {} // 0x0000000186695810-0x0000000186695920
		// [XID] // 0x00000001899CABE0-0x00000001899CAC00
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000186695A20-0x0000000186695EB0
		// [XID] // 0x00000001899D22B0-0x00000001899D22D0
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000186695920-0x0000000186695A20
	}
}
