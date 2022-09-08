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
	public class MonoCoopChapterRow : MonoBehaviour // TypeDefIndex: 30138
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _chapterTitle; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _chapterDes; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _chapterTip; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _keyIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockKeyNum; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardNormalImg; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardHaveImg; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardAllGetImg; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockImg; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _isOngoing; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _needKey; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _rewardBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noticeRP; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTxt; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _chapterCondTips; // 0x98
		private bool _isShowRewardButton; // 0xA0
	
		// Properties
		public UnityEngine.UI.Text chapterTitle { /* [XID] */ /* 0x00000001898F8D20-0x00000001898F8D40 */ get => default; } // 0x0000000183F320A0-0x0000000183F32140 
		public UnityEngine.UI.Text chapterDes { /* [XID] */ /* 0x00000001899006C0-0x00000001899006E0 */ get => default; } // 0x0000000183F31F60-0x0000000183F32000 
		public UnityEngine.UI.Text chapterTip { /* [XID] */ /* 0x0000000189907E10-0x0000000189907E30 */ get => default; } // 0x0000000183F32000-0x0000000183F320A0 
		public Image keyIcon { /* [XID] */ /* 0x000000018990F5B0-0x000000018990F5D0 */ get => default; } // 0x0000000183F32340-0x0000000183F323E0 
		public UnityEngine.UI.Text unlockKeyNum { /* [XID] */ /* 0x0000000189917030-0x0000000189917050 */ get => default; } // 0x0000000183F32670-0x0000000183F32710 
		public GameObject lockImg { /* [XID] */ /* 0x000000018991E730-0x000000018991E750 */ get => default; } // 0x0000000183F323E0-0x0000000183F32480 
		public GameObject isOngoing { /* [XID] */ /* 0x0000000189925F90-0x0000000189925FB0 */ get => default; } // 0x0000000183F321F0-0x0000000183F32290 
		public GameObject needKey { /* [XID] */ /* 0x000000018992D580-0x000000018992D5A0 */ get => default; } // 0x0000000183F32480-0x0000000183F32520 
		public Button actionBtn { /* [XID] */ /* 0x0000000189934AD0-0x0000000189934AF0 */ get => default; } // 0x0000000183F31E10-0x0000000183F31EB0 
		public Button rewardBtn { /* [XID] */ /* 0x000000018993C5A0-0x000000018993C5C0 */ get => default; } // 0x0000000183F325D0-0x0000000183F32670 
		public GameObject noticeRP { /* [XID] */ /* 0x0000000189943C10-0x0000000189943C30 */ get => default; } // 0x0000000183F32520-0x0000000183F325D0 
		public GameObject grpTxt { /* [XID] */ /* 0x000000018994B110-0x000000018994B130 */ get => default; } // 0x0000000183F32140-0x0000000183F321F0 
		public UnityEngine.UI.Text chapterCondTips { /* [XID] */ /* 0x0000000189952B40-0x0000000189952B60 */ get => default; } // 0x0000000183F31EB0-0x0000000183F31F60 
		public bool isShowRewardButton { /* [XID] */ /* 0x000000018995A070-0x000000018995A090 */ get => default; } // 0x0000000183F32290-0x0000000183F32340 
		public bool isSelected { /* [XID] */ /* 0x0000000189969150-0x0000000189969170 */ set {} } // 0x0000000183F32710-0x0000000183F328E0
	
		// Constructors
		public MonoCoopChapterRow() {} // 0x0000000183F31D50-0x0000000183F31E10
	
		// Methods
		// [XID] // 0x0000000189961A80-0x0000000189961AA0
		public void RefreshRewardState(CoopChapterRewardState state) {} // 0x0000000183F31B00-0x0000000183F31D50
	}
}
