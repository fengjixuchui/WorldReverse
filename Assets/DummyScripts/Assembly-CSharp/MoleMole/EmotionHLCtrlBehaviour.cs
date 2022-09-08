/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class EmotionHLCtrlBehaviour : PlayableBehaviour // TypeDefIndex: 26163
	{
		// Fields
		[NonSerialized]
		private EmotionHLCtrlBehaviour _meta; // 0x10
		public bool enableEmotion; // 0x18
		public string emotionName; // 0x20
		public float emotionTransitionTime; // 0x28
		public float emotionExitTime; // 0x2C
		public bool enableEyeCtrl; // 0x30
		public Vector3 eyeTargetOffset; // 0x34
		public float eyeTransitionTime; // 0x40
		public float eyeExitTime; // 0x44
		public bool enableBlink; // 0x48
		public bool disableEmotionMouth; // 0x49
	
		// Constructors
		public EmotionHLCtrlBehaviour() {} // 0x000000018149D2F0-0x000000018149D370
	
		// Methods
		// [XID] // 0x0000000189943F90-0x0000000189943FB0
		public void RegisterMeta(EmotionHLCtrlBehaviour template) {} // 0x000000018149D240-0x000000018149D2F0
		// [XID] // 0x000000018994B540-0x000000018994B560
		public void UpdateEyeTargetOffset(Vector3 offset) {} // 0x000000018149D150-0x000000018149D240
	}
}
