/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMusicGameButton : MonoActionBtn // TypeDefIndex: 31108
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<RectTransform> _scaleTrans; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _successEff; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _missEff; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _buttonCanvas; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _enterSuccReginCanvas; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _enterCanvasChangeTime; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _startAlpha; // 0x84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _alphaScale; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _effectAnimator; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _colorStart; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _colorEnd; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _lightColorStart; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _lightColorEnd; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _colorCurve; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _effectTime; // 0xE0
		private float _startScale; // 0xE4
		private float _endScale; // 0xE8
		private uint _scaleTime; // 0xEC
		private float _deltScale; // 0xF0
		private float _deltAlphaScale; // 0xF4
		private float _deltColor; // 0xF8
		private MUSIC_BUTTON_STATE _buttonState; // 0xFC
		public Action<int> onSuccessCallback; // 0x100
		public Action<int> onFailCallback; // 0x108
		private FleurFairMusicGameMainPage _pageContent; // 0x110
		private MusicGameBasicConfig _musicConfig; // 0x118
		private SimpleObjectPool<MusicDataClass> _musicDataPool; // 0x120
		private List<CanvasGroup> _scaleTransCanvas; // 0x128
		private List<Image> _scaleTransImage; // 0x130
		private List<Image> _scaleTransImageLight; // 0x138
		private Queue<MusicDataClass> musicDataQueue; // 0x140
		private int scaleTransIndex; // 0x148
		private float _effectStayTime; // 0x14C
		private MUSIC_BUTTON_STATE _lastButtonState; // 0x150
	
		// Constructors
		public MonoMusicGameButton() {} // 0x0000000183710170-0x0000000183710310
	
		// Methods
		// [XID] // 0x00000001899A7130-0x00000001899A7150
		public void Reset() {} // 0x000000018370F590-0x000000018370F7E0
		// [XID] // 0x00000001899AEA60-0x00000001899AEA80
		public void SetContent(FleurFairMusicGameMainPage page) {} // 0x000000018370F7E0-0x000000018370FEC0
		// [XID] // 0x00000001899B5DE0-0x00000001899B5E00
		public void OnStart(int musicIndex, uint keyTime) {} // 0x000000018370E4E0-0x000000018370E9E0
		// [XID] // 0x00000001899BDB00-0x00000001899BDB20
		public void Success(int index) {} // 0x000000018370FF70-0x0000000183710170
		// [XID] // 0x00000001899C5200-0x00000001899C5220
		public void Fail(int index) {} // 0x000000018370DEE0-0x000000018370E0E0
		// [XID] // 0x00000001899CC8D0-0x00000001899CC8F0
		public void SimulateClick() {} // 0x000000018370FEC0-0x000000018370FF70
		// [XID] // 0x00000001899D3FD0-0x00000001899D3FF0
		protected override void HandlePointDown() {} // 0x000000018370E0E0-0x000000018370E320
		// [XID] // 0x00000001899DB540-0x00000001899DB560
		public void OnUpdate(float deltTime) {} // 0x000000018370E9E0-0x000000018370F530
		// [XID] // 0x00000001899E2C20-0x00000001899E2C40
		protected override void OnDestroy() {} // 0x000000018370E320-0x000000018370E4E0
	}
}
