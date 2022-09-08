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
	public class MonoInLevelGameInfo : MonoSpriteProxy // TypeDefIndex: 29744
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private SmoothMask _expBar; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _prefabPlugin; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _expText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _lvText; // 0x38
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private SmoothMask _hpBar; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _hpTransitionBar; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoColorExchange _hpColor; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoColorExchange _hpBgColor; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _hpLabel; // 0x60
		// [Range] // 0x0000000189B3DEB0-0x0000000189B3DF00
		[SerializeField] // 0x0000000189B3DEB0-0x0000000189B3DF00
		[Space] // 0x0000000189B3DEB0-0x0000000189B3DF00
		private float _hpWarningThreshold; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _hpWarning; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoInLevelBuffInfo _buffInfo; // 0x78
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _climateBarObj; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _climateSmoothMask; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _climateAnimator; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Transform avatarLevelUpTransform; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject avatarLevelUpGameObject; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform avatarFetterUpTransform; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject avatarFetterUpGameObject; // 0xB0
		private float _maxExp; // 0xB8
		private float _currentExp; // 0xBC
		private int _lv; // 0xC0
		// [Header] // 0x0000000189B97500-0x0000000189B97560
		[ReadOnly] // 0x0000000189B97500-0x0000000189B97560
		[SerializeField] // 0x0000000189B97500-0x0000000189B97560
		private float _tempStamina; // 0xC4
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private float _tempStaminaTarget; // 0xC8
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		private float _tempStaminaChangeSpeed; // 0xCC
		[ReadOnly] // 0x0000000189BBAA80-0x0000000189BBAAC0
		[SerializeField] // 0x0000000189BBAA80-0x0000000189BBAAC0
		[Space] // 0x0000000189BBAA80-0x0000000189BBAAC0
		private float _currStamina; // 0xD0
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		private float _staminaTarget1; // 0xD4
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private float _staminaTarget2; // 0xD8
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private float _maxStamina; // 0xDC
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private float _staminaChangeSpeed; // 0xE0
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private bool _turnAround; // 0xE4
		private const float STAMINA_STEP = 100f; // Metadata: 0x00B0FD67
		private const float SP_MAX_UPDATE_DELAY = 0.4f; // Metadata: 0x00B0FD6B
		private const float SP_MAX_TURN_AROUNT_DELAY = 0.2f; // Metadata: 0x00B0FD6F
		private uint _avatarID; // 0xE8
		[ReadOnly] // 0x0000000189602210-0x0000000189602250
		[SerializeField] // 0x0000000189602210-0x0000000189602250
		[Space] // 0x0000000189602210-0x0000000189602250
		private float _currFlightEnergy; // 0xEC
		private MonoBaseStamina _staminaInfo; // 0xF0
		private MonoChargeBar _chargeBar; // 0xF8
		private MonoComplexStaminaBar _flightActivityChargeBar; // 0x100
		private const string GLIDING_ENERGY_KEY = "AVATAR_GLIDING_ENERGY"; // Metadata: 0x00B0FD73
		private bool _flightChallengeStarted; // 0x108
		private bool _flightBarInited; // 0x109
		private UIUtil.LevelUpItemQueue _avatarLevelUpItemQueue; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _climateLerpTime; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _climateActiveEff; // 0x120
		protected float _lastClimateRatio; // 0x128
		protected float _targetClimateRatio; // 0x12C
		protected float _curClimateRatio; // 0x130
		protected float _climateLerpTimer; // 0x134
		protected bool _instantClimateLerp; // 0x138
		protected JsonClimateType _lastClimateType; // 0x13C
		public static readonly float MaxFlightStamina; // 0x00
		public static readonly float FullFlightStamina; // 0x04
	
		// Properties
		private bool staminaStable { /* [XID] */ /* 0x000000018964B830-0x000000018964B850 */ get => default; } // 0x0000000183D59A80-0x0000000183D59B50 
		private bool tempStaminaStable { /* [XID] */ /* 0x0000000189652FC0-0x0000000189652FE0 */ get => default; } // 0x0000000183D599C0-0x0000000183D59A80 
		public StaminaType staminaType { /* [XID] */ /* 0x00000001896BB970-0x00000001896BB990 */ set {} } // 0x0000000183D5CFF0-0x0000000183D5D220
		private MonoChargeBar chargeBar { /* [XID] */ /* 0x00000001896C2E30-0x00000001896C2E50 */ get => default; } // 0x0000000183D59B50-0x0000000183D59CA0 
		private MonoComplexStaminaBar flightChargeBar { /* [XID] */ /* 0x000000018970D240-0x000000018970D260 */ get => default; } // 0x0000000183D59460-0x0000000183D59590 
	
		// Constructors
		public MonoInLevelGameInfo() {} // 0x0000000183D5CE60-0x0000000183D5CFF0
		static MonoInLevelGameInfo() {} // 0x0000000183D5CDF0-0x0000000183D5CE60
	
		// Methods
		// [XID] // 0x000000018962D7E0-0x000000018962D800
		public void Setup() {} // 0x0000000183D5C850-0x0000000183D5C940
		// [XID] // 0x0000000189635320-0x0000000189635340
		public void OnDestory() {} // 0x0000000183D5B8D0-0x0000000183D5B990
		// [XID] // 0x000000018963CA00-0x000000018963CA20
		private void OnEnable() {} // 0x0000000183D5BA30-0x0000000183D5BC70
		// [XID] // 0x0000000189644080-0x00000001896440A0
		private void OnDisable() {} // 0x0000000183D5B990-0x0000000183D5BA30
		// [XID] // 0x000000018965A6A0-0x000000018965A6C0
		private void Update() {} // 0x0000000183D5CA30-0x0000000183D5CDF0
		// [XID] // 0x0000000189661CD0-0x0000000189661CF0
		public void OnAvatarChange() {} // 0x0000000183D5B350-0x0000000183D5B4B0
		// [XID] // 0x00000001896698B0-0x00000001896698D0
		public void OnAvatarLevelUp(uint oldLevel, uint newLevel) {} // 0x0000000183D5B6C0-0x0000000183D5B8D0
		// [XID] // 0x00000001896713E0-0x0000000189671400
		public void OnAvatarFetterUp(uint oldLevel, uint newLevel) {} // 0x0000000183D5B4B0-0x0000000183D5B6C0
		// [XID] // 0x0000000189678C80-0x0000000189678CA0
		public bool RefreshValue(uint refreshMask) => default; // 0x0000000183D5BF30-0x0000000183D5C0E0
		// [XID] // 0x0000000189680390-0x00000001896803B0
		public void RefreshBuff(uint runtimeID) {} // 0x0000000183D5BE70-0x0000000183D5BF30
		// [XID] // 0x0000000189687EB0-0x0000000189687ED0
		private void RefreshHP() {} // 0x0000000183D5AD60-0x0000000183D5B350
		// [XID] // 0x000000018968F910-0x000000018968F930
		private void InitStamina() {} // 0x0000000183D5AA60-0x0000000183D5AD60
		// [XID] // 0x0000000189697310-0x0000000189697330
		private void RefreshStamina() {} // 0x0000000183D59590-0x0000000183D59970
		// [XID] // 0x000000018969E860-0x000000018969E880
		private void UpdateStaminaTarget(float newTarget) {} // 0x0000000183D59CA0-0x0000000183D59E90
		// [XID] // 0x00000001896A5850-0x00000001896A5870
		private void RefreshExp() {} // 0x0000000183D5A910-0x0000000183D5AA60
		// [XID] // 0x00000001896AD0D0-0x00000001896AD0F0
		private void RefreshPlayerLevelExp() {} // 0x0000000183D59E90-0x0000000183D5A110
		// [XID] // 0x00000001896B4700-0x00000001896B4720
		private void TickStaminaValue() {} // 0x0000000183D59300-0x0000000183D59460
		// [XID] // 0x00000001896CA2C0-0x00000001896CA2E0
		public void SetChargeBarValue(float value, bool isAdd, bool isRestart) {} // 0x0000000183D5C0E0-0x0000000183D5C200
		// [XID] // 0x00000001896D1970-0x00000001896D1990
		public void SuppressClimteEffectFlash() {} // 0x0000000183D5C940-0x0000000183D5CA30
		// [XID] // 0x00000001896D9180-0x00000001896D91A0
		protected void AutoFetchClimateData() {} // 0x0000000183D5A160-0x0000000183D5A2D0
		// [XID] // 0x00000001896E0950-0x00000001896E0970
		public void SetClimateType(JsonClimateType climateType) {} // 0x0000000183D5C310-0x0000000183D5C420
		// [XID] // 0x00000001896E7C00-0x00000001896E7C20
		public void SetClimbateBar(float ratio) {} // 0x0000000183D5C420-0x0000000183D5C5C0
		// [XID] // 0x00000001896EF2F0-0x00000001896EF310
		protected void UpdateClimateBarLerp() {} // 0x0000000183D5A2D0-0x0000000183D5A440
		// [XID] // 0x00000001896F6C80-0x00000001896F6CA0
		protected void SetClimateSmoothMaskValue(float ratio) {} // 0x0000000183D5BC70-0x0000000183D5BE70
		// [XID] // 0x00000001896FE5F0-0x00000001896FE610
		public void SetClimateBarWarning(int warningState) {} // 0x0000000183D5C200-0x0000000183D5C310
		// [XID] // 0x0000000189705700-0x0000000189705720
		public void MarkClimateMeterChangeInstant() {} // 0x0000000183D5A760-0x0000000183D5A800
		// [XID] // 0x00000001897146E0-0x0000000189714700
		public void SetFlightChallengeState(bool isStart) {} // 0x0000000183D5C790-0x0000000183D5C850
		// [XID] // 0x000000018971C0F0-0x000000018971C110
		public void SetFlightChallengeBarVisible(bool show) {} // 0x0000000183D5C6A0-0x0000000183D5C790
		// [XID] // 0x0000000189723540-0x0000000189723560
		public void SetFlightChallengeBarValue(float value) {} // 0x0000000183D5C5C0-0x0000000183D5C6A0
		// [XID] // 0x000000018972ACC0-0x000000018972ACE0
		private void InitFlightChargeBar() {} // 0x0000000183D5A800-0x0000000183D5A910
		// [XID] // 0x00000001897323B0-0x00000001897323D0
		private void TickFlightChargeBar() {} // 0x0000000183D5A440-0x0000000183D5A760
	}
}
