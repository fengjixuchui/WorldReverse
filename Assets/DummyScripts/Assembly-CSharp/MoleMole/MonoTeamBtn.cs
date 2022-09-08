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
	// [RequireComponent] // 0x00000001896AA030-0x00000001896AA080
	public class MonoTeamBtn : MonoSpriteProxy // TypeDefIndex: 31087
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _qteButton; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBattleBtn _energySkillButton; // 0x38
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _avatarIcon; // 0x40
		[SerializeField] // 0x00000001896E0830-0x00000001896E0870
		// [Tooltip] // 0x00000001896E0830-0x00000001896E0870
		private UnityEngine.Material _deadMaterial; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameText; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private SmoothMask _hpBar; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoColorExchange _hpColor; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoColorExchange _hpBgColor; // 0x68
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _voiceButton; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _changeAvatarCD; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _changeAvatarCDMask; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _trialInfo; // 0x88
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _talentCD; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _talentCDMask; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _talentCDMaskImage; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _talentCDBgImage; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _talentCDEffectTrans; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _talentCDBgColor; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _talentCDFillColor; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _talentCDReadyBgColor; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _talentCDReadyFillColor; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _talentCDEffect; // 0xF8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoPrefabPlugin _prefabPlugin; // 0x100
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		public Transform avatarLevelUpTrans; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject avatarLevelUpGameObject; // 0x110
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		public Transform fetterUpTrans; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject fetterUpGameObject; // 0x120
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _pcKeyGrp; // 0x128
		public MonoInLevelBuffInfo inlevelBuffInfo; // 0x130
		private ulong _guid; // 0x138
		private bool _showChangeAvatarCDText; // 0x140
		private LCAvatarCombat _lcCombat; // 0x148
		private GameObject _talentCDEffectIns; // 0x150
		private AvatarDataItem _avatarData; // 0x158
		public UIUtil.LevelUpItemQueue teamLevelUpItemQueue; // 0x160
		public bool needTickBuff; // 0x168
		private Action<EvtEntityReadyPost> _onEntityReadyPost; // 0x170
		private float _currHPRatio; // 0x178
		private Animation _restoreHP; // 0x180
		private MonoUIEffect _restoreHPEffect; // 0x188
	
		// Properties
		public bool showChangeAvatarCDText { /* [XID] */ /* 0x00000001897B5090-0x00000001897B50B0 */ set {} } // 0x0000000183B5E7E0-0x0000000183B5E890
		public ulong guid { /* [XID] */ /* 0x00000001897BCCC0-0x00000001897BCCE0 */ get => default; } // 0x0000000183B5E490-0x0000000183B5E540 
		public string title { /* [XID] */ /* 0x00000001898769A0-0x00000001898769C0 */ set {} } // 0x0000000183B5EA50-0x0000000183B5EB20
		public Sprite iconSprite { /* [XID] */ /* 0x000000018987E4C0-0x000000018987E4E0 */ set {} } // 0x0000000183B5E720-0x0000000183B5E7E0
		public UnityEngine.Material iconMaterial { /* [XID] */ /* 0x0000000189885870-0x0000000189885890 */ set {} } // 0x0000000183B5E650-0x0000000183B5E720
		public Button actionButton { /* [XID] */ /* 0x00000001898B1BD0-0x00000001898B1BF0 */ get => default; } // 0x0000000183B5E3F0-0x0000000183B5E490 
		public bool showRestoreHPGrp { /* [XID] */ /* 0x00000001898C0C10-0x00000001898C0C30 */ set {} } // 0x0000000183B5E970-0x0000000183B5EA50
		public bool showPCKey { /* [XID] */ /* 0x00000001898CFEC0-0x00000001898CFEE0 */ set {} } // 0x0000000183B5E890-0x0000000183B5E970
		public string PCKey { /* [XID] */ /* 0x00000001898D7470-0x00000001898D7490 */ set {} } // 0x0000000183B5E540-0x0000000183B5E650
		public MonoControlElement PS4KeyIcon { /* [XID] */ /* 0x00000001898DF1E0-0x00000001898DF200 */ get => default; } // 0x0000000183B5E2E0-0x0000000183B5E3F0 
	
		// Constructors
		public MonoTeamBtn() {} // 0x0000000183B5E170-0x0000000183B5E2E0
	
		// Methods
		// [XID] // 0x00000001897C4040-0x00000001897C4060
		public void SetupView(ulong guid) {} // 0x0000000183B5D370-0x0000000183B5D510
		// [XID] // 0x00000001897CB900-0x00000001897CB920
		private void OnEntityReadyPost(EvtEntityReadyPost evt) {} // 0x0000000183B5C230-0x0000000183B5C390
		// [XID] // 0x00000001897D31F0-0x00000001897D3210
		private void InitLCCombat() {} // 0x0000000183B5A8B0-0x0000000183B5ACA0
		// [XID] // 0x00000001897DAC70-0x00000001897DAC90
		private void InitSkillInfo() {} // 0x0000000183B5C390-0x0000000183B5C820
		// [XID] // 0x00000001897E2360-0x00000001897E2380
		public void Update() {} // 0x0000000183B5E0B0-0x0000000183B5E170
		// [XID] // 0x00000001897E9AD0-0x00000001897E9AF0
		private void UpdateTalentBtn() {} // 0x0000000183B5B680-0x0000000183B5B8F0
		// [XID] // 0x00000001897F1790-0x00000001897F17B0
		private void ShowTalentEffect() {} // 0x0000000183B5B520-0x0000000183B5B680
		// [XID] // 0x00000001897F8E60-0x00000001897F8E80
		public void RefreshSkillButton() {} // 0x0000000183B5CD70-0x0000000183B5D130
		// [XID] // 0x0000000189800470-0x0000000189800490
		private void RefreshOnFadeIn() {} // 0x0000000183B5ACA0-0x0000000183B5AF20
		// [XID] // 0x0000000189807AF0-0x0000000189807B10
		private void ClearOnFadeOut() {} // 0x0000000183B5BF30-0x0000000183B5C010
		// [XID] // 0x000000018980F3F0-0x000000018980F410
		private void InitValue() {} // 0x0000000183B5BD80-0x0000000183B5BE30
		// [XID] // 0x0000000189816A80-0x0000000189816AA0
		public void UpdateValue(uint refreshMask = 65535 /* Metadata: 0x00B11E8A */) {} // 0x0000000183B5DFF0-0x0000000183B5E0B0
		// [XID] // 0x000000018981E300-0x000000018981E320
		public void UpdateBuff(bool init, uint entityID = 0 /* Metadata: 0x00B11E8E */) {} // 0x0000000183B5D7A0-0x0000000183B5DAC0
		// [XID] // 0x00000001898257E0-0x0000000189825800
		public void SetSpeech(bool enable) {} // 0x0000000183B5D130-0x0000000183B5D200
		// [XID] // 0x000000018982CFA0-0x000000018982CFC0
		private void InitHP() {} // 0x0000000183B5C820-0x0000000183B5CAC0
		// [XID] // 0x0000000189834780-0x00000001898347A0
		private void UpdateHP() {} // 0x0000000183B5C010-0x0000000183B5C230
		// [XID] // 0x000000018983BDD0-0x000000018983BDF0
		public void UpdateLifeState() {} // 0x0000000183B5DF20-0x0000000183B5DFF0
		// [XID] // 0x0000000189843420-0x0000000189843440
		protected override void OnDestroy() {} // 0x0000000183B5CAC0-0x0000000183B5CBF0
		// [XID] // 0x000000018984A940-0x000000018984A960
		private void OnDisable() {} // 0x0000000183B5CBF0-0x0000000183B5CC90
		// [XID] // 0x0000000189851D40-0x0000000189851D60
		private void UpdateQTE() {} // 0x0000000183B5B8F0-0x0000000183B5BBF0
		// [XID] // 0x00000001898595C0-0x00000001898595E0
		public void UpdateChangeAvatarState() {} // 0x0000000183B5DAC0-0x0000000183B5DF20
		// [XID] // 0x0000000189860700-0x0000000189860720
		public bool IsEnergySkillButtonActive() => default; // 0x0000000183B5BE30-0x0000000183B5BF30
		// [XID] // 0x0000000189867E10-0x0000000189867E30
		public void OnEnergyFull(bool full) {} // 0x0000000183B5CC90-0x0000000183B5CD70
		// [XID] // 0x000000018986F370-0x000000018986F390
		public uint GetAvatarEntityId() => default; // 0x0000000183B5BBF0-0x0000000183B5BD80
		// [XID] // 0x000000018988CB60-0x000000018988CB80
		public void FadeIn() {} // 0x0000000183B5B0E0-0x0000000183B5B240
		// [XID] // 0x0000000189894230-0x0000000189894250
		public void FadeOut() {} // 0x0000000183B5B3A0-0x0000000183B5B520
		// [XID] // 0x000000018989B7A0-0x000000018989B7C0
		public void FadeInEnd() {} // 0x0000000183B5AF80-0x0000000183B5B0E0
		// [XID] // 0x00000001898A2CD0-0x00000001898A2CF0
		public void FadeOutEnd() {} // 0x0000000183B5B240-0x0000000183B5B3A0
		// [XID] // 0x00000001898AA1F0-0x00000001898AA210
		public void SetupAnimator(bool current) {} // 0x0000000183B5D200-0x0000000183B5D370
		// [XID] // 0x00000001898B97F0-0x00000001898B9810
		public void TryCreateRestoreHP() {} // 0x0000000183B5D650-0x0000000183B5D7A0
		// [XID] // 0x00000001898C8470-0x00000001898C8490
		public void TriggerRestoreHPEffect() {} // 0x0000000183B5D510-0x0000000183B5D650
	}
}
