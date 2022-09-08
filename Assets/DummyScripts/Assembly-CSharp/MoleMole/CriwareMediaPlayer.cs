/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using AOT;
using CriMana;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class CriwareMediaPlayer : MonoBehaviour // TypeDefIndex: 32000
	{
		// Fields
		protected const float MIN_ENVELOPE_RATIO = 1.25f; // Metadata: 0x00B13ADD
		protected const float MAX_ENVELOPE_RATIO = 2.4444444f; // Metadata: 0x00B13AE1
		protected AspectRatioFitter _parentAspectRatioFitter; // 0x20
		protected AspectRatioFitter _aspectRatioFitter; // 0x28
		private Image _image; // 0x30
		private UnityEngine.UI.Text _text; // 0x38
		private CriManaMovieControllerForUI _controllerForUI; // 0x40
		private CriWareInitializer _criwareInitializer; // 0x48
		private CriWareErrorHandler _criwareErrorHandler; // 0x50
		private VideoSubtitles _videoSubtitles; // 0x58
		private Player.Status _lastStatus; // 0x60
		private Action<string> _onStartPlay; // 0x68
		private Action<string> _onFinishPlay; // 0x70
		private Action<string> _onError; // 0x78
		private Action _onClose; // 0x80
		private string _videoRuntimePath; // 0x88
		private bool _useSubtitle; // 0x90
		private string _subtitleRuntimePath; // 0x98
		private string _stat; // 0xA0
		private int _audioTrack; // 0xA8
		private ulong _encryptKey; // 0xB0
		private Coroutine _statCoroutine; // 0xB8
		private const float DEFAULT_VOLUME_VALUE = 1f; // Metadata: 0x00B13AE5
	
		// Properties
		public VideoPluginInterface.VideoEventCallback eventCallback { /* [XID] */ /* 0x0000000189A156C0-0x0000000189A15700 */ private get; /* [XID] */ /* 0x0000000189A1F970-0x0000000189A1F9B0 */ set; } // 0x0000000186B5F0C0-0x0000000186B5F120 0x0000000186B610B0-0x0000000186B61110
		public string videoRuntimePath { /* [XID] */ /* 0x0000000189A29E50-0x0000000189A29E70 */ get => default; } // 0x0000000186B61000-0x0000000186B610B0 
		public Player.Status status { /* [XID] */ /* 0x0000000189A65E60-0x0000000189A65E80 */ get => default; } // 0x0000000186B60EF0-0x0000000186B61000 
		public Player.Status lastStatus { /* [XID] */ /* 0x0000000189A6D480-0x0000000189A6D4A0 */ get => default; /* [XID] */ /* 0x0000000189A74C40-0x0000000189A74C60 */ set {} } // 0x0000000186B60E50-0x0000000186B60EF0 0x0000000186B61110-0x0000000186B61310
	
		// Constructors
		public CriwareMediaPlayer() {} // 0x0000000186B60DF0-0x0000000186B60E50
	
		// Methods
		// [XID] // 0x0000000189A31360-0x0000000189A31380
		public void MediaPlayerImageSetup(Image image) {} // 0x0000000186B5FD50-0x0000000186B5FE00
		// [XID] // 0x0000000189A38EB0-0x0000000189A38ED0
		public void MediaPlayerTextSetup(UnityEngine.UI.Text text) {} // 0x0000000186B5FF90-0x0000000186B60040
		// [XID] // 0x0000000189A405E0-0x0000000189A40600
		public void MediaPlayerSetup(string videoRuntimePath, bool useSubtitle, string subtitleRuntimePath, int audioTrack, Action<string> onStartPlay, Action<string> onFinishPlay, Action<string> onError, Action onClose, ulong encryptKey = 0 /* Metadata: 0x00B13AD5 */) {} // 0x0000000186B5FE00-0x0000000186B5FF90
		// [XID] // 0x0000000189A47C90-0x0000000189A47CB0
		public void OnStartPlay() {} // 0x0000000186B60740-0x0000000186B60800
		// [XID] // 0x0000000189A4F470-0x0000000189A4F490
		public void OnFinishPlay() {} // 0x0000000186B60570-0x0000000186B60630
		// [XID] // 0x0000000189A56B30-0x0000000189A56B50
		public void OnError() {} // 0x0000000186B604B0-0x0000000186B60570
		// [XID] // 0x0000000189A5E690-0x0000000189A5E6B0
		public void OnClose() {} // 0x0000000186B60280-0x0000000186B60330
		// [XID] // 0x0000000189A7C860-0x0000000189A7C880
		private void OnGUI() {} // 0x0000000186B60630-0x0000000186B60740
		// [XID] // 0x0000000189A84130-0x0000000189A84150
		private void OnEnable() {} // 0x0000000186B603F0-0x0000000186B604B0
		// [XID] // 0x0000000189A8BA90-0x0000000189A8BAB0
		private void OnDisable() {} // 0x0000000186B60330-0x0000000186B603F0
		// [XID] // 0x0000000189A930A0-0x0000000189A930C0
		private void Update() {} // 0x0000000186B60BC0-0x0000000186B60DF0
		// [XID] // 0x0000000189A9AAB0-0x0000000189A9AAD0
		public void Stop() {} // 0x0000000186B60AF0-0x0000000186B60BC0
		// [XID] // 0x0000000189AA1DB0-0x0000000189AA1DD0
		public void Play() {} // 0x0000000186B60990-0x0000000186B60A40
		// [XID] // 0x0000000189AA92D0-0x0000000189AA92F0
		public void Skip() {} // 0x0000000186B60A40-0x0000000186B60AF0
		// [MonoPInvokeCallback] // 0x0000000189AB11D0-0x0000000189AB1230
		// [XID] // 0x0000000189AB11D0-0x0000000189AB1230
		private void OnErrorCallback(string errmsg) {} // 0x0000000186B5FA00-0x0000000186B5FAD0
		[DebuggerHidden] // 0x0000000189AC0160-0x0000000189AC01A0
		// [XID] // 0x0000000189AC0160-0x0000000189AC01A0
		private IEnumerator DoPlay() => default; // 0x0000000186B5FAD0-0x0000000186B5FBA0
		[DebuggerHidden] // 0x0000000189ACA9C0-0x0000000189ACAA00
		// [XID] // 0x0000000189ACA9C0-0x0000000189ACAA00
		private IEnumerator DoStop() => default; // 0x0000000186B601B0-0x0000000186B60280
		[DebuggerHidden] // 0x0000000189AD58B0-0x0000000189AD58F0
		// [XID] // 0x0000000189AD58B0-0x0000000189AD58F0
		private IEnumerator DoSkip() => default; // 0x0000000186B5EFF0-0x0000000186B5F0C0
		[DebuggerHidden] // 0x0000000189AE0280-0x0000000189AE02C0
		// [XID] // 0x0000000189AE0280-0x0000000189AE02C0
		private IEnumerator InitComponents() => default; // 0x0000000186B5F860-0x0000000186B5F930
		// [XID] // 0x0000000189AEA950-0x0000000189AEA970
		private void Clean() {} // 0x0000000186B60040-0x0000000186B601B0
		// [XID] // 0x0000000189AF2240-0x0000000189AF2260
		protected virtual void AdaptMovieImage(MovieInfo movieInfo) {} // 0x0000000186B5FBA0-0x0000000186B5FD50
		// [XID] // 0x0000000189AF9B60-0x0000000189AF9B80
		private float GetVolumeSettingValue() => default; // 0x0000000186B60800-0x0000000186B60990
		// [XID] // 0x0000000189B01050-0x0000000189B01070
		private void CuePointCallback(ref EventPoint eventPoint) {} // 0x0000000186B5F120-0x0000000186B5F680
		[DebuggerHidden] // 0x0000000189B08640-0x0000000189B08680
		// [XID] // 0x0000000189B08640-0x0000000189B08680
		private IEnumerator StartStat() => default; // 0x0000000186B5F930-0x0000000186B5FA00
		// [XID] // 0x0000000189B12D40-0x0000000189B12D60
		private string DataSize2String(uint sizeByte) => default; // 0x0000000186B5F680-0x0000000186B5F860
	}
}
