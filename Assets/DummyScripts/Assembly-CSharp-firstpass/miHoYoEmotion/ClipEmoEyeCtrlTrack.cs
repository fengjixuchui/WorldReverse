/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public class ClipEmoEyeCtrlTrack : EmoTrack // TypeDefIndex: 8465
	{
		// Fields
		private ClipShapeManager _clipManager; // 0x50
		private EyeKey _eyeKey; // 0x58
		private GameObject _eyeStar; // 0x60
		private SkinnedMeshRenderer _smr; // 0x68
		private List<SequenceClipBakeData.EyeCtrlData> _currList; // 0x70
		private SequenceClipBakeData.EyeCtrlData _lastData; // 0x78
		private SequenceClipBakeData.EyeCtrlData _currData; // 0x80
		private int _currIndex; // 0x88
		private bool _isPlayAtTime; // 0x8C
		private float _currTime; // 0x90
		private bool _isPlaying; // 0x94
	
		// Constructors
		public ClipEmoEyeCtrlTrack() {} // 0x00000001873203B0-0x00000001873204A0
	
		// Methods
		// [XID] // 0x0000000189662D10-0x0000000189662D30
		public override void Init(ElementManager manager) {} // 0x000000018731FDB0-0x000000018731FF80
		// [XID] // 0x00000001899048E0-0x0000000189904900
		public void AddEyeCtrlList(List<SequenceClipBakeData.EyeCtrlData> eyeCtrlData, bool playAtTime = false /* Metadata: 0x00ADF7EA */, bool forceReset = true /* Metadata: 0x00ADF7EB */) {} // 0x000000018731F7E0-0x000000018731F930
		// [XID] // 0x0000000189672550-0x0000000189672570
		public override void Update(float deltaTime) {} // 0x00000001873200E0-0x00000001873203B0
		// [XID] // 0x000000018966A8F0-0x000000018966A910
		private void FindSMR() {} // 0x000000018731FC60-0x000000018731FDB0
		// [XID] // 0x00000001896814E0-0x0000000189681500
		public override void Apply() {} // 0x000000018731F930-0x000000018731FC60
	}
}
