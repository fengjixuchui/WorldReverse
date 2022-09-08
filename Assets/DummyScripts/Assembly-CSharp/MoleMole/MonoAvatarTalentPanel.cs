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
	public class MonoAvatarTalentPanel : MonoBehaviour // TypeDefIndex: 30452
	{
		// Fields
		private const string SMALL_TALENT_ICON_PATH = "ART/UI/Menus/Widget/CharacterPage/Btn_SmallTalent"; // Metadata: 0x00B110C1
		private const string BAG_ITEM_SLOT_PATH = "ART/UI/Menus/Widget/BagItemSlot"; // Metadata: 0x00B110F6
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _talentUpgradeCondition; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _talentName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _talentType; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _talentDesc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PreTalentStruct _preTalent; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _preTalentRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _talentBackBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _talentIconRoot; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noTalentTip; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _itemNeedRoot1; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _itemNeedRoot2; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemOrText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _upgradeNeedText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockedRoot; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockedTip; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _maxTip; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxTipText; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpActionPS4; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _talentList; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGroup; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _talentScrollRect; // 0xC0
		private MonoAvatarTalentIcon _talentDetailIcon; // 0xC8
		private GameObject _bagItemPrefab; // 0xD0
		private MonoBagProxySlot _itemNeedSlot1; // 0xD8
		private MonoBagProxySlot _itemNeedSlot2; // 0xE0
	
		// Properties
		public GameObject talentUpgradeCondition { /* [XID] */ /* 0x0000000189A71FE0-0x0000000189A72000 */ get => default; } // 0x00000001842325B0-0x0000000184232650 
		public UnityEngine.UI.Text talentName { /* [XID] */ /* 0x0000000189A79C40-0x0000000189A79C60 */ get => default; } // 0x00000001842323C0-0x0000000184232460 
		public UnityEngine.UI.Text talentType { /* [XID] */ /* 0x0000000189A810C0-0x0000000189A810E0 */ get => default; } // 0x0000000184232510-0x00000001842325B0 
		public UnityEngine.UI.Text talentDesc { /* [XID] */ /* 0x0000000189A88B20-0x0000000189A88B40 */ get => default; } // 0x0000000184232080-0x0000000184232120 
		public Button talentBackBtn { /* [XID] */ /* 0x0000000189A902D0-0x0000000189A902F0 */ get => default; } // 0x0000000184231FE0-0x0000000184232080 
		public PreTalentStruct preTalent { /* [XID] */ /* 0x0000000189A97AC0-0x0000000189A97AE0 */ get => default; } // 0x0000000184231F10-0x0000000184231FE0 
		public GameObject preTalentRoot { /* [XID] */ /* 0x0000000189A9EE90-0x0000000189A9EEB0 */ get => default; } // 0x0000000184231E70-0x0000000184231F10 
		public GameObject noTalentTip { /* [XID] */ /* 0x0000000189AA67D0-0x0000000189AA67F0 */ get => default; } // 0x0000000184231DD0-0x0000000184231E70 
		public UnityEngine.UI.Text upgradeNeedText { /* [XID] */ /* 0x0000000189AADE40-0x0000000189AADE60 */ get => default; } // 0x0000000184232650-0x0000000184232700 
		public GameObject lockedRoot { /* [XID] */ /* 0x0000000189AB57D0-0x0000000189AB57F0 */ get => default; } // 0x0000000184231B10-0x0000000184231BC0 
		public UnityEngine.UI.Text lockedTip { /* [XID] */ /* 0x0000000189ABD1B0-0x0000000189ABD1D0 */ get => default; } // 0x0000000184231BC0-0x0000000184231C70 
		public GameObject maxTip { /* [XID] */ /* 0x0000000189AC4C40-0x0000000189AC4C60 */ get => default; } // 0x0000000184231D20-0x0000000184231DD0 
		public UnityEngine.UI.Text maxTipText { /* [XID] */ /* 0x0000000189ACC2C0-0x0000000189ACC2E0 */ get => default; } // 0x0000000184231C70-0x0000000184231D20 
		public MonoSimpleReusableList talentList { /* [XID] */ /* 0x0000000189AD3DA0-0x0000000189AD3DC0 */ get => default; } // 0x0000000184232310-0x00000001842323C0 
		public Transform itemNeedRoot1 { /* [XID] */ /* 0x0000000189ADB8A0-0x0000000189ADB8C0 */ get => default; } // 0x0000000184231570-0x0000000184231610 
		public Transform itemNeedRoot2 { /* [XID] */ /* 0x0000000189AE3180-0x0000000189AE31A0 */ get => default; } // 0x0000000184231610-0x00000001842316B0 
		public GameObject itemOrText { /* [XID] */ /* 0x0000000189AEAB50-0x0000000189AEAB70 */ get => default; } // 0x0000000184231A70-0x0000000184231B10 
		public RectTransform grpActionPS4 { /* [XID] */ /* 0x0000000189AF2420-0x0000000189AF2440 */ get => default; } // 0x00000001842314C0-0x0000000184231570 
		public CanvasGroup canvasGroup { /* [XID] */ /* 0x0000000189AF9DC0-0x0000000189AF9DE0 */ get => default; } // 0x0000000184231410-0x00000001842314C0 
		public ScrollRect talentScrollRect { /* [XID] */ /* 0x0000000189B012F0-0x0000000189B01310 */ get => default; } // 0x0000000184232460-0x0000000184232510 
		public MonoAvatarTalentIcon talentDetailIcon { /* [XID] */ /* 0x0000000189B08840-0x0000000189B08860 */ get => default; } // 0x0000000184232120-0x0000000184232310 
		public GameObject bagItemPrefab { /* [XID] */ /* 0x0000000189B101E0-0x0000000189B10200 */ get => default; } // 0x00000001842312F0-0x0000000184231410 
		public MonoBagProxySlot itemNeedSlot1 { /* [XID] */ /* 0x0000000189B17300-0x0000000189B17320 */ get => default; } // 0x00000001842316B0-0x0000000184231890 
		public MonoBagProxySlot itemNeedSlot2 { /* [XID] */ /* 0x0000000189B1ECA0-0x0000000189B1ECC0 */ get => default; } // 0x0000000184231890-0x0000000184231A70 
	
		// Constructors
		public MonoAvatarTalentPanel() {} // 0x0000000184231200-0x00000001842312F0
	
		// Methods
		// [XID] // 0x0000000189B264F0-0x0000000189B26510
		private void OnDestroy() {} // 0x0000000184231070-0x0000000184231200
	}
}
