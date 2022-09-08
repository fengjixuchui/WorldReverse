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
	public class MonoAvatarSkillPanel : MonoBehaviour // TypeDefIndex: 30446
	{
		// Fields
		private const string SKILL_ICON_PATH = "ART/UI/Menus/Widget/CharacterPage/Btn_SkillIcon"; // Metadata: 0x00B11003
		private const string SKILL_STATE_ROW_PATH = "ART/UI/Menus/Widget/CharacterPage/SkillStateRow"; // Metadata: 0x00B11036
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _skillScroller; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconRoot; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillTypeText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillNameText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillLevelText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _skillTab; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _introduceBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _attributeBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _introducePanel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _attributePanel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _extraLevelText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _baseDesc; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _addDescRoot; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _attributeScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _skillBackBtn; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTipText; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxTipText; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tipsRoot; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpActionPS4; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGroup; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _skillIntroduceScrollRect; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _skillAttributeScrollRect; // 0xC0
		private MonoAvatarSkillIcon _skillDetailIcon; // 0xC8
		private GameObject _skillStateRowPrefab; // 0xD0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<MonoSkillStateRow> skillAddDescList; // 0xD8
	
		// Properties
		public MonoGridScroller skillScroller { /* [XID] */ /* 0x000000018965ECE0-0x000000018965ED00 */ get => default; } // 0x0000000184229F10-0x0000000184229FB0 
		public UnityEngine.UI.Text skillTypeText { /* [XID] */ /* 0x0000000189666380-0x00000001896663A0 */ get => default; } // 0x000000018422A170-0x000000018422A210 
		public UnityEngine.UI.Text skillNameText { /* [XID] */ /* 0x000000018966DB80-0x000000018966DBA0 */ get => default; } // 0x0000000184229E70-0x0000000184229F10 
		public UnityEngine.UI.Text skillLevelText { /* [XID] */ /* 0x0000000189675920-0x0000000189675940 */ get => default; } // 0x0000000184229DD0-0x0000000184229E70 
		public GameObject skillTab { /* [XID] */ /* 0x000000018967D250-0x000000018967D270 */ get => default; } // 0x000000018422A0D0-0x000000018422A170 
		public MonoUIContainer introduceBtn { /* [XID] */ /* 0x0000000189684920-0x0000000189684940 */ get => default; } // 0x0000000184229730-0x00000001842297D0 
		public MonoUIContainer attributeBtn { /* [XID] */ /* 0x000000018968C510-0x000000018968C530 */ get => default; } // 0x00000001842292A0-0x0000000184229340 
		public GameObject introducePanel { /* [XID] */ /* 0x0000000189693F60-0x0000000189693F80 */ get => default; } // 0x00000001842297D0-0x0000000184229870 
		public GameObject attributePanel { /* [XID] */ /* 0x000000018969B4F0-0x000000018969B510 */ get => default; } // 0x0000000184229340-0x00000001842293E0 
		public UnityEngine.UI.Text extraLevelText { /* [XID] */ /* 0x00000001896A2C10-0x00000001896A2C30 */ get => default; } // 0x00000001842295E0-0x0000000184229680 
		public UnityEngine.UI.Text baseDesc { /* [XID] */ /* 0x00000001896AA100-0x00000001896AA120 */ get => default; } // 0x0000000184229490-0x0000000184229530 
		public Transform addDescRoot { /* [XID] */ /* 0x00000001896B0E70-0x00000001896B0E90 */ get => default; } // 0x0000000184229200-0x00000001842292A0 
		public MonoGridScroller attributeScroller { /* [XID] */ /* 0x00000001896B8A90-0x00000001896B8AB0 */ get => default; } // 0x00000001842293E0-0x0000000184229490 
		public Button skillBackBtn { /* [XID] */ /* 0x00000001896BFD10-0x00000001896BFD30 */ get => default; } // 0x0000000184229A80-0x0000000184229B30 
		public UnityEngine.UI.Text lockTipText { /* [XID] */ /* 0x00000001896C75F0-0x00000001896C7610 */ get => default; } // 0x0000000184229870-0x0000000184229920 
		public UnityEngine.UI.Text maxTipText { /* [XID] */ /* 0x00000001896CED50-0x00000001896CED70 */ get => default; } // 0x0000000184229920-0x00000001842299D0 
		public GameObject tipsRoot { /* [XID] */ /* 0x00000001896D6170-0x00000001896D6190 */ get => default; } // 0x000000018422A210-0x000000018422A2C0 
		public RectTransform grpActionPS4 { /* [XID] */ /* 0x00000001896DD790-0x00000001896DD7B0 */ get => default; } // 0x0000000184229680-0x0000000184229730 
		public CanvasGroup canvasGroup { /* [XID] */ /* 0x00000001896E4E00-0x00000001896E4E20 */ get => default; } // 0x0000000184229530-0x00000001842295E0 
		public ScrollRect skillIntroduceScrollRect { /* [XID] */ /* 0x00000001896EC300-0x00000001896EC320 */ get => default; } // 0x0000000184229D20-0x0000000184229DD0 
		public ScrollRect skillAttributeScrollRect { /* [XID] */ /* 0x00000001896F3AB0-0x00000001896F3AD0 */ get => default; } // 0x00000001842299D0-0x0000000184229A80 
		public MonoAvatarSkillIcon skillDetailIcon { /* [XID] */ /* 0x00000001896FB1C0-0x00000001896FB1E0 */ get => default; } // 0x0000000184229B30-0x0000000184229D20 
		public GameObject skillStateRowPrefab { /* [XID] */ /* 0x0000000189702940-0x0000000189702960 */ get => default; } // 0x0000000184229FB0-0x000000018422A0D0 
	
		// Constructors
		public MonoAvatarSkillPanel() {} // 0x00000001842290E0-0x0000000184229200
	
		// Methods
		// [XID] // 0x000000018970A0D0-0x000000018970A0F0
		public MonoSkillStateRow GetNewSkillStateRow() => default; // 0x0000000184228DF0-0x0000000184228F50
		// [XID] // 0x0000000189711B50-0x0000000189711B70
		private void OnDestroy() {} // 0x0000000184228F50-0x00000001842290E0
	}
}
