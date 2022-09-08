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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTransitionWhite : MonoBehaviour // TypeDefIndex: 19848
	{
		// Fields
		private const float TimeOut = 5f; // Metadata: 0x00AFCF4B
		private FadeOutCallBack _CallBack; // 0x18
		private float _transitTimePrev; // 0x20
		private float _transitTimePost; // 0x24
		private float _whiteScreenTime; // 0x28
		private string _result; // 0x30
		private bool _isEndlessLevel; // 0x38
		private int _endCgId; // 0x3C
		private string _levelEndPoint; // 0x40
		private bool _isFadeOut; // 0x48
		private float _time; // 0x4C
		private bool _isPlaying; // 0x50
		private Action _cbfOnWhite; // 0x58
		private bool _onWhiteScreenCallbackCalled; // 0x60
		private CanvasGroup _CanvasGroup; // 0x68
		private float _fadeInDuration; // 0x70
		private float _fadeInTime; // 0x74
		private float _fadeOutDuration; // 0x78
		private float _fadeOutTime; // 0x7C
		private bool _waitFadeOut; // 0x80
		private const float _waitFadeOutTime = 5f; // Metadata: 0x00AFCF4F
		private float _currentWaitFadeOutTime; // 0x84
	
		// Nested types
		public delegate void FadeOutCallBack(string result, bool isEndlessLevel = false /* Metadata: 0x00AFCF53 */, int endCgId = 0 /* Metadata: 0x00AFCF54 */, string levelEndPoint = "Born" /* Metadata: 0x00AFCF58 */); // TypeDefIndex: 19849; 0x000000018487E4B0-0x000000018487E810
	
		// Constructors
		private MonoTransitionWhite() {} // 0x0000000184889870-0x0000000184889930
	
		// Methods
		// [XID] // 0x0000000189702F50-0x0000000189702F70
		private void OnDisable() {} // 0x0000000184889330-0x00000001848893D0
		// [XID] // 0x000000018970A620-0x000000018970A640
		public void FadeIn(float duration = 1f /* Metadata: 0x00AFCF2A */, FadeOutCallBack callBack = null, string result = null, bool isEndlessLevel = false /* Metadata: 0x00AFCF2E */, int endCgId = 0 /* Metadata: 0x00AFCF2F */, string levelEndPoint = "Born" /* Metadata: 0x00AFCF33 */) {} // 0x0000000184888F20-0x00000001848890F0
		// [XID] // 0x0000000189712090-0x00000001897120B0
		public void FadeOut(float duration = 1f /* Metadata: 0x00AFCF3B */) {} // 0x00000001848890F0-0x0000000184889220
		[DebuggerHidden] // 0x00000001897196B0-0x00000001897196F0
		// [XID] // 0x00000001897196B0-0x00000001897196F0
		private IEnumerator StartFadeIn() => default; // 0x0000000184889220-0x0000000184889330
		[DebuggerHidden] // 0x00000001897239F0-0x0000000189723A30
		// [XID] // 0x00000001897239F0-0x0000000189723A30
		private IEnumerator StartFadeOut() => default; // 0x0000000184888E10-0x0000000184888F20
		// [XID] // 0x000000018972E0F0-0x000000018972E110
		public void Setup(float tTransitTimePrev, float tTransitTimePost = 1f /* Metadata: 0x00AFCF3F */, float tTransitTimePower = 1f /* Metadata: 0x00AFCF43 */, float whiteScreenTime = 0f /* Metadata: 0x00AFCF47 */) {} // 0x0000000184889580-0x00000001848896A0
		// [XID] // 0x00000001897357B0-0x00000001897357D0
		public void SetCallBack(Action tCbfOnWhite = null) {} // 0x00000001848894D0-0x0000000184889580
		// [XID] // 0x000000018973D330-0x000000018973D350
		public void Play() {} // 0x00000001848893D0-0x00000001848894D0
		// [XID] // 0x00000001897447B0-0x00000001897447D0
		private void Update() {} // 0x00000001848896A0-0x0000000184889870
		// [XID] // 0x000000018974C4D0-0x000000018974C4F0
		private void UpdateAlpha() {} // 0x0000000184888B60-0x0000000184888E10
	}
}
