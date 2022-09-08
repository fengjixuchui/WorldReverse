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
	public abstract class MonoBaseSkillBtn : MonoActionBtn // TypeDefIndex: 31102
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected SmoothMask _progressFill; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _addEffect; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIEffect _maxEffect; // 0x68
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected MonoPrefabPlugin _prefabPlugin; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _energyEffectPlugin; // 0x78
		[ReadOnly] // 0x0000000189BBAA80-0x0000000189BBAAC0
		[SerializeField] // 0x0000000189BBAA80-0x0000000189BBAAC0
		[Space] // 0x0000000189BBAA80-0x0000000189BBAAC0
		protected uint _skillID; // 0x80
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		protected ElementType _elementType; // 0x84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected SkillIconType _iconType; // 0x88
		protected GameObject _lightObj; // 0x90
		protected float lastCd; // 0x98
		protected SimpleText _cdText; // 0xA0
		protected SmoothMask _cdMask; // 0xA8
		protected CanvasGroup _cdGroup; // 0xB0
		protected GameObject _bg; // 0xB8
		protected GameObject _progress; // 0xC0
		protected List<Image> _points; // 0xC8
		protected MonoSkillPointPanel _skillPointPanel; // 0xD0
		protected BaseEntity _baseEntity; // 0xD8
		protected int _maxChargeCount; // 0xE0
		protected bool _showCDText; // 0xE4
		protected bool _isInSkill; // 0xE5
		protected bool _canUseBtn; // 0xE6
		protected int _lastChargeCount; // 0xE8
		protected bool _isGlobalValueEnergySkill; // 0xEC
		protected string _globalValueKey; // 0xF0
		private bool _energyFull; // 0xF8
		private Transform _energyEffect; // 0x100
		protected Transform _energyFullHaloGrp; // 0x108
		private static MonoAudioEvent2D.Event _maxEnergyAudio; // 0x00
		private ParticleSystem _cdIncreaseEffect; // 0x110
		private ParticleSystem _cdDecreaseEffect; // 0x118
		protected bool _isEnergySkill; // 0x120
		private Image _progressFullHalo; // 0x128
		private Image _progressFullHaloBlur; // 0x130
		private ParticleSystem _cdEndEffect; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabContainerPlugin _effectContainer; // 0x140
	
		// Properties
		public bool showCDText { get; /* [XID] */ /* 0x00000001896CB9D0-0x00000001896CB9F0 */ set; } // 0x00000001848FA1E0-0x00000001848FA330
		public bool energyFull { /* [XID] */ /* 0x00000001896E1FF0-0x00000001896E2010 */ get; /* [XID] */ /* 0x00000001896DA890-0x00000001896DA8B0 */ set; } // 0x00000001848F99A0-0x00000001848F9A50 0x00000001848F9B00-0x00000001848F9EE0
		public ElementType elementType { get; /* [XID] */ /* 0x000000018971D640-0x000000018971D660 */ set; } // 0x00000001848F9A50-0x00000001848F9B00
		public bool showProgress { get; /* [XID] */ /* 0x0000000189724A10-0x0000000189724A30 */ set; } // 0x00000001848FA330-0x00000001848FA420
		public Color progressFillColor { get; /* [XID] */ /* 0x0000000189742A10-0x0000000189742A30 */ set; } // 0x00000001848F9EE0-0x00000001848FA1E0
	
		// Constructors
		protected MonoBaseSkillBtn() {} // 0x00000001848F9850-0x00000001848F99A0
		static MonoBaseSkillBtn() {} // 0x00000001848F97D0-0x00000001848F9850
	
		// Methods
		// [XID] // 0x00000001896D2CF0-0x00000001896D2D10
		private void Awake() {} // 0x00000001848F7A10-0x00000001848F80B0
		// [XID] // 0x00000001896E94E0-0x00000001896E9500
		public void ClearEnergyEffect() {} // 0x00000001848F80B0-0x00000001848F8180
		// [XID] // 0x00000001896F0780-0x00000001896F07A0
		protected void UpdateMaxCharge(int num) {} // 0x00000001848F85A0-0x00000001848F8930
		// [XID] // 0x00000001896F7F20-0x00000001896F7F40
		public void Clear() {} // 0x00000001848F8180-0x00000001848F82B0
		// [XID] // 0x00000001896FF920-0x00000001896FF940
		public void PlayAddEffect() {} // 0x00000001848F9000-0x00000001848F9130
		// [XID] // 0x0000000189706ED0-0x0000000189706EF0
		public void PlayCDChangedEffect(bool isAddCD) {} // 0x00000001848F9130-0x00000001848F93C0
		// [XID] // 0x000000018970E7D0-0x000000018970E7F0
		private void PlayCDInstanceEffect(Transform trans) {} // 0x00000001848F8930-0x00000001848F8A90
		// [XID] // 0x0000000189715C00-0x0000000189715C20
		private void PlayCDDecreaseEffect(Transform trans) {} // 0x00000001848F8440-0x00000001848F85A0
		// [XID] // 0x000000018972C260-0x000000018972C280
		public void InitEnergyProgress(float value) {} // 0x00000001848F8A90-0x00000001848F8DC0
		// [XID] // 0x0000000189733920-0x0000000189733940
		public void UpdateEnergyProgress(float value) {} // 0x00000001848F95D0-0x00000001848F97D0
		// [XID] // 0x000000018973B060-0x000000018973B080
		protected virtual bool IsGlobalValueEnergyFull(float value) => default; // 0x00000001848F8DC0-0x00000001848F8E80
		// [XID] // 0x000000018974A6E0-0x000000018974A700
		public void CreateCDEndEffect() {} // 0x00000001848F82B0-0x00000001848F8440
		// [XID] // 0x00000001897517F0-0x0000000189751810
		public void PlayCDEndEffect() {} // 0x00000001848F93C0-0x00000001848F94C0
		// [XID] // 0x0000000189758DB0-0x0000000189758DD0
		public void PlayUIEffect(string name) {} // 0x00000001848F94C0-0x00000001848F95D0
		// [XID] // 0x0000000189760A90-0x0000000189760AB0
		private void PlayEffect(Transform trans) {} // 0x00000001848F8E80-0x00000001848F9000
	}
}
