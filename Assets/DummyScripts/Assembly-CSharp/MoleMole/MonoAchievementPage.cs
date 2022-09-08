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
	public class MonoAchievementPage : MonoBehaviour // TypeDefIndex: 30672
	{
		// Fields
		private const float HAS_GOAL_REWARD_POS_Y = 142f; // Metadata: 0x00B11430
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _noGoalRewardScrollerPosY; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _insidePageTab; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _overviewTab; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCount; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _insidePageListScroller; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _insidePageDetailScroller; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _overviewScroller; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _detailRewardItemList; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtRewardLabel; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtRewardProgress; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtRewardDesc; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtRewardDate; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _rewardProgress; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardProgressGO; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchGoalBtn; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _markPointGO; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _fetchHintGO; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeGO; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _inProgressGO; // 0xC0
		private bool _showGoalRewardProgress; // 0xC8
		private AchievementIconType _goalRewardType; // 0xCC
		private Animator _rewardAnimator; // 0xD0
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x00000001899DB5A0-0x00000001899DB5C0 */ get => default; } // 0x0000000184C63C30-0x0000000184C63CD0 
		public GameObject insidePageTab { /* [XID] */ /* 0x00000001899E2CA0-0x00000001899E2CC0 */ get => default; } // 0x0000000184C647D0-0x0000000184C64870 
		public GameObject overviewTab { /* [XID] */ /* 0x00000001899EA3D0-0x00000001899EA3F0 */ get => default; } // 0x0000000184C64910-0x0000000184C649B0 
		public UnityEngine.UI.Text txtCount { /* [XID] */ /* 0x00000001899F1DA0-0x00000001899F1DC0 */ get => default; } // 0x0000000184C64A60-0x0000000184C64B00 
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x00000001899F95E0-0x00000001899F9600 */ get => default; } // 0x0000000184C64DA0-0x0000000184C64E40 
		public MonoGridScroller insidePageListScroller { /* [XID] */ /* 0x0000000189A00900-0x0000000189A00920 */ get => default; } // 0x0000000184C64730-0x0000000184C647D0 
		public MonoGridScroller insidePageDetailScroller { /* [XID] */ /* 0x0000000189A081E0-0x0000000189A08200 */ get => default; } // 0x0000000184C64690-0x0000000184C64730 
		public MonoGridScroller overviewScroller { /* [XID] */ /* 0x0000000189A0F5F0-0x0000000189A0F610 */ get => default; } // 0x0000000184C64870-0x0000000184C64910 
		public MonoSimpleReusableList detailRewardItemList { /* [XID] */ /* 0x0000000189A16C80-0x0000000189A16CA0 */ get => default; } // 0x0000000184C64270-0x0000000184C64310 
		public UnityEngine.UI.Text txtRewardLabel { /* [XID] */ /* 0x0000000189A1E2E0-0x0000000189A1E300 */ get => default; } // 0x0000000184C64C60-0x0000000184C64D00 
		public UnityEngine.UI.Text txtRewardProgress { /* [XID] */ /* 0x0000000189A259E0-0x0000000189A25A00 */ get => default; } // 0x0000000184C64D00-0x0000000184C64DA0 
		public UnityEngine.UI.Text txtRewardDesc { /* [XID] */ /* 0x0000000189A2CE00-0x0000000189A2CE20 */ get => default; } // 0x0000000184C64BB0-0x0000000184C64C60 
		public UnityEngine.UI.Text txtRewardDate { /* [XID] */ /* 0x0000000189A347D0-0x0000000189A347F0 */ get => default; } // 0x0000000184C64B00-0x0000000184C64BB0 
		public float rewardProgress { /* [XID] */ /* 0x0000000189A3BBF0-0x0000000189A3BC10 */ set {} } // 0x0000000184C651E0-0x0000000184C652B0
		public Button fetchGoalBtn { /* [XID] */ /* 0x0000000189A43880-0x0000000189A438A0 */ get => default; } // 0x0000000184C644F0-0x0000000184C645F0 
		public Button fetchBtn { /* [XID] */ /* 0x0000000189A4ACD0-0x0000000189A4ACF0 */ get => default; } // 0x0000000184C64310-0x0000000184C644F0 
		public Button closeBtn { /* [XID] */ /* 0x0000000189A523B0-0x0000000189A523D0 */ get => default; } // 0x0000000184C63EB0-0x0000000184C64090 
		public Button backBtn { /* [XID] */ /* 0x0000000189A59CE0-0x0000000189A59D00 */ get => default; } // 0x0000000184C63CD0-0x0000000184C63EB0 
		public Button detailBtn { /* [XID] */ /* 0x0000000189A614A0-0x0000000189A614C0 */ get => default; } // 0x0000000184C64090-0x0000000184C64270 
		public Button OKBtn { /* [XID] */ /* 0x0000000189A693D0-0x0000000189A693F0 */ get => default; } // 0x0000000184C63A50-0x0000000184C63C30 
		public bool showGoalRewardProgress { /* [XID] */ /* 0x0000000189A70760-0x0000000189A70780 */ get => default; /* [XID] */ /* 0x0000000189A78030-0x0000000189A78050 */ set {} } // 0x0000000184C649B0-0x0000000184C64A60 0x0000000184C652B0-0x0000000184C65450
		public AchievementIconType goalRewardIconType { /* [XID] */ /* 0x0000000189A7F5E0-0x0000000189A7F600 */ get => default; /* [XID] */ /* 0x0000000189A87320-0x0000000189A87340 */ set {} } // 0x0000000184C645F0-0x0000000184C64690 0x0000000184C64E40-0x0000000184C65000
		public bool isGoalRewardSelected { /* [XID] */ /* 0x0000000189A8EB60-0x0000000189A8EB80 */ set {} } // 0x0000000184C65000-0x0000000184C651E0
	
		// Constructors
		public MonoAchievementPage() {} // 0x0000000184C63960-0x0000000184C63A50
	}
}
