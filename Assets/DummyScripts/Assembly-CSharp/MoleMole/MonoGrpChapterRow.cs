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
	public class MonoGrpChapterRow : MonoBehaviour // TypeDefIndex: 31290
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtChapterType; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtChapterTitle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtChapterNum; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtChapterTips; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tipsGO; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgChapterIcon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgChapterTypeIcon; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockCover; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgUV; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgUV2; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noticeContainer; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtChapterImgName; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgChapterBg; // 0x80
		private bool _isSelected; // 0x88
		private bool _isLocked; // 0x89
		private Animator _animator; // 0x90
	
		// Properties
		public UnityEngine.UI.Text txtChapterType { /* [XID] */ /* 0x00000001898EE2B0-0x00000001898EE2D0 */ get => default; } // 0x00000001840804C0-0x0000000184080560 
		public UnityEngine.UI.Text txtChapterTitle { /* [XID] */ /* 0x00000001898F5AE0-0x00000001898F5B00 */ get => default; } // 0x0000000184080420-0x00000001840804C0 
		public UnityEngine.UI.Text txtChapterNum { /* [XID] */ /* 0x00000001898FD2A0-0x00000001898FD2C0 */ get => default; } // 0x00000001840802E0-0x0000000184080380 
		public UnityEngine.UI.Text txtChapterTips { /* [XID] */ /* 0x0000000189904B40-0x0000000189904B60 */ get => default; } // 0x0000000184080380-0x0000000184080420 
		public Image imgChapterIcon { /* [XID] */ /* 0x000000018990C3A0-0x000000018990C3C0 */ get => default; } // 0x000000018407FE60-0x000000018407FF00 
		public Image imgChapterTypeIcon { /* [XID] */ /* 0x0000000189913BF0-0x0000000189913C10 */ get => default; } // 0x000000018407FF00-0x000000018407FFA0 
		public Button actionBtn { /* [XID] */ /* 0x000000018991B5D0-0x000000018991B5F0 */ get => default; } // 0x000000018407FD10-0x000000018407FDB0 
		public GameObject tipsGO { /* [XID] */ /* 0x0000000189922BC0-0x0000000189922BE0 */ get => default; } // 0x00000001840801A0-0x0000000184080240 
		public GameObject noticeContainer { /* [XID] */ /* 0x000000018992A4D0-0x000000018992A4F0 */ get => default; } // 0x0000000184080100-0x00000001840801A0 
		public UnityEngine.UI.Text txtChapterImgName { /* [XID] */ /* 0x0000000189931A40-0x0000000189931A60 */ get => default; } // 0x0000000184080240-0x00000001840802E0 
		public Image imgChapterBg { /* [XID] */ /* 0x00000001899394C0-0x00000001899394E0 */ get => default; } // 0x000000018407FDB0-0x000000018407FE60 
		public bool isSelected { /* [XID] */ /* 0x00000001899407B0-0x00000001899407D0 */ get => default; /* [XID] */ /* 0x0000000189948050-0x0000000189948070 */ set {} } // 0x0000000184080050-0x0000000184080100 0x00000001840807A0-0x0000000184080970
		public bool isLocked { /* [XID] */ /* 0x000000018994F810-0x000000018994F830 */ get => default; /* [XID] */ /* 0x0000000189956DB0-0x0000000189956DD0 */ set {} } // 0x000000018407FFA0-0x0000000184080050 0x0000000184080670-0x00000001840807A0
		public bool isLockAnimationActive { /* [XID] */ /* 0x0000000189966000-0x0000000189966020 */ set {} } // 0x0000000184080560-0x0000000184080670
	
		// Constructors
		public MonoGrpChapterRow() {} // 0x000000018407FC60-0x000000018407FD10
	
		// Methods
		// [XID] // 0x000000018995E900-0x000000018995E920
		public void PlayerUnlockAnimation() {} // 0x000000018407FB10-0x000000018407FC60
	}
}
