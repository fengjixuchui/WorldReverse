/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoSpeechBubble : MonoBehaviour // TypeDefIndex: 31080
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _content; // 0x20
		// [Range] // 0x0000000189667CC0-0x0000000189667D40
		[SerializeField] // 0x0000000189667CC0-0x0000000189667D40
		[Space] // 0x0000000189667CC0-0x0000000189667D40
		// [Tooltip] // 0x0000000189667CC0-0x0000000189667D40
		private float _hideDistance; // 0x28
		// [MinMax] // 0x000000018967A100-0x000000018967A170
		[SerializeField] // 0x000000018967A100-0x000000018967A170
		// [Tooltip] // 0x000000018967A100-0x000000018967A170
		private Vector2 _normalScaleRange; // 0x2C
		// [Range] // 0x00000001896893B0-0x0000000189689410
		[SerializeField] // 0x00000001896893B0-0x0000000189689410
		// [Tooltip] // 0x00000001896893B0-0x0000000189689410
		private float _nearTransitionDistance; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _markYOffset; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _markNameYOffset; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _markNameTitleYOffset; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _nameYOffset; // 0x44
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _nameTitleYOffset; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _yOffset; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _posChangeTimeS; // 0x50
		public float _posOffsetScale; // 0x54
		private Vector3 _fromPosOffset; // 0x58
		private Vector3 _toPosOffset; // 0x64
		public Vector3 _realPosOffset; // 0x70
		private float _curOffsetChangeTime; // 0x7C
		[ReadOnly] // 0x0000000189602210-0x0000000189602250
		[SerializeField] // 0x0000000189602210-0x0000000189602250
		[Space] // 0x0000000189602210-0x0000000189602250
		private bool _valid; // 0x80
		private float _fadeOutEndTime; // 0x84
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private bool _hide; // 0x88
	
		// Properties
		public float markYOffset { /* [XID] */ /* 0x00000001896E3620-0x00000001896E3640 */ get => default; } // 0x0000000184FFAE10-0x0000000184FFAEC0 
		public float markNameYOffset { /* [XID] */ /* 0x00000001896EAA40-0x00000001896EAA60 */ get => default; } // 0x0000000184FFAD60-0x0000000184FFAE10 
		public float markNameTitleYOffset { /* [XID] */ /* 0x00000001896F1D40-0x00000001896F1D60 */ get => default; } // 0x0000000184FFACB0-0x0000000184FFAD60 
		public float nameYOffset { /* [XID] */ /* 0x00000001896F9790-0x00000001896F97B0 */ get => default; } // 0x0000000184FFAF70-0x0000000184FFB020 
		public float nameTitleYOffset { /* [XID] */ /* 0x0000000189700FA0-0x0000000189700FC0 */ get => default; } // 0x0000000184FFAEC0-0x0000000184FFAF70 
		public float yOffset { /* [XID] */ /* 0x00000001897086E0-0x0000000189708700 */ get => default; } // 0x0000000184FFB230-0x0000000184FFB2E0 
		public float posOffsetScale { /* [XID] */ /* 0x0000000189710050-0x0000000189710070 */ get => default; /* [XID] */ /* 0x00000001897173D0-0x00000001897173F0 */ set {} } // 0x0000000184FFB180-0x0000000184FFB230 0x0000000184FFB410-0x0000000184FFB4D0
		private bool valid { /* [XID] */ /* 0x0000000189744170-0x0000000189744190 */ get => default; /* [XID] */ /* 0x0000000189937470-0x0000000189937490 */ set {} } // 0x0000000184FF9AB0-0x0000000184FF9B60 0x0000000184FF9B60-0x0000000184FF9E30
		public bool fadingOut { /* [XID] */ /* 0x0000000189753130-0x0000000189753150 */ get => default; } // 0x0000000184FFAB50-0x0000000184FFAC00 
		public bool hide { /* [XID] */ /* 0x00000001897621A0-0x00000001897621C0 */ set {} } // 0x0000000184FFB2E0-0x0000000184FFB410
		public float hideDistance { /* [XID] */ /* 0x0000000189769710-0x0000000189769730 */ get => default; } // 0x0000000184FFAC00-0x0000000184FFACB0 
		public Vector2 normalScaleRange { /* [XID] */ /* 0x0000000189770D10-0x0000000189770D30 */ get => default; } // 0x0000000184FFB0D0-0x0000000184FFB180 
		public float nearTransitionDistance { /* [XID] */ /* 0x00000001897786A0-0x00000001897786C0 */ get => default; } // 0x0000000184FFB020-0x0000000184FFB0D0 
	
		// Constructors
		public MonoSpeechBubble() {} // 0x0000000184FFAA50-0x0000000184FFAB50
	
		// Methods
		// [XID] // 0x000000018971EE50-0x000000018971EE70
		public void ResetToOriginalPos() {} // 0x0000000184FFA390-0x0000000184FFA4A0
		// [XID] // 0x00000001897263F0-0x0000000189726410
		public void SetOffset(Vector3 offset, bool isAnime) {} // 0x0000000184FFA4A0-0x0000000184FFA670
		// [XID] // 0x000000018972D9F0-0x000000018972DA10
		public void UpdateContextByCfg(ConfigDialogScheme dialogConfig) {} // 0x0000000184FFA670-0x0000000184FFA850
		// [XID] // 0x0000000189735170-0x0000000189735190
		private void UpdatePosition() {} // 0x0000000184FFA020-0x0000000184FFA240
		// [XID] // 0x0000000189745730-0x0000000189745750
		public void Clear() {} // 0x0000000184FF9A10-0x0000000184FF9AB0
		// [XID] // 0x0000000189928A90-0x0000000189928AB0
		private void CheckAnimator() {} // 0x0000000184FF9E30-0x0000000184FFA020
		// [XID] // 0x000000018977FC00-0x000000018977FC20
		public void RefreshOnEnable() {} // 0x0000000184FFA240-0x0000000184FFA390
		// [XID] // 0x00000001897874E0-0x0000000189787500
		private void Update() {} // 0x0000000184FFA850-0x0000000184FFAA50
	}
}
