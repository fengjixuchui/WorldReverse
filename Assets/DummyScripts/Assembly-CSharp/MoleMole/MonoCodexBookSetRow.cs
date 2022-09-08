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
	public class MonoCodexBookSetRow : MonoBehaviour, INavSelectable // TypeDefIndex: 30489
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _allCollectedMark; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _bookSelectContent; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _navSelectMark; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockMark; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unlockedMark; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Toggle _foldToggle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconImage; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconQualityBGImage; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconQualityShadowImage; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _starQuality; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _lockButton; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _qualityAnimator; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redpointMark; // 0x88
		private bool _isLocked; // 0x90
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189622E20-0x0000000189622E40 */ get => default; } // 0x0000000184BA0890-0x0000000184BA0930 
		public GameObject allCollectedMark { /* [XID] */ /* 0x000000018962A630-0x000000018962A650 */ get => default; } // 0x0000000184BA0210-0x0000000184BA02B0 
		public MonoSimpleReusableList bookSelectContent { /* [XID] */ /* 0x0000000189631DB0-0x0000000189631DD0 */ get => default; } // 0x0000000184BA02B0-0x0000000184BA0350 
		public Toggle foldToggle { /* [XID] */ /* 0x0000000189639930-0x0000000189639950 */ get => default; } // 0x0000000184BA0350-0x0000000184BA03F0 
		public Image iconImage { /* [XID] */ /* 0x0000000189640DC0-0x0000000189640DE0 */ get => default; } // 0x0000000184BA03F0-0x0000000184BA0490 
		public Image iconQualityBGImage { /* [XID] */ /* 0x00000001896486D0-0x00000001896486F0 */ get => default; } // 0x0000000184BA0490-0x0000000184BA0530 
		public Image iconQualityShadowImage { /* [XID] */ /* 0x000000018964FDE0-0x000000018964FE00 */ get => default; } // 0x0000000184BA0530-0x0000000184BA05D0 
		public Transform starQuality { /* [XID] */ /* 0x0000000189657680-0x00000001896576A0 */ get => default; } // 0x0000000184BA07F0-0x0000000184BA0890 
		public Button lockButton { /* [XID] */ /* 0x000000018965ECC0-0x000000018965ECE0 */ get => default; } // 0x0000000184BA0750-0x0000000184BA07F0 
		public bool isFold { /* [XID] */ /* 0x0000000189666360-0x0000000189666380 */ get => default; } // 0x0000000184BA05D0-0x0000000184BA06A0 
		public bool isClickSelected { /* [XID] */ /* 0x0000000189675900-0x0000000189675920 */ set {} } // 0x0000000184BA0930-0x0000000184BA0A40
		public bool isLocked { /* [XID] */ /* 0x0000000189684900-0x0000000189684920 */ get => default; /* [XID] */ /* 0x000000018967D230-0x000000018967D250 */ set {} } // 0x0000000184BA06A0-0x0000000184BA0750 0x0000000184BA0A40-0x0000000184BA0B60
	
		// Constructors
		public MonoCodexBookSetRow() {} // 0x0000000184BA0160-0x0000000184BA0210
	
		// Methods
		// [XID] // 0x000000018966DB60-0x000000018966DB80
		public void SetNavSelected(bool selected) {} // 0x0000000184B9FE30-0x0000000184B9FF20
		// [XID] // 0x000000018968C4F0-0x000000018968C510
		public void SetQuality(uint rank) {} // 0x0000000184B9FF20-0x0000000184BA0070
		// [XID] // 0x0000000189693F40-0x0000000189693F60
		public void SetRedPoint(bool show) {} // 0x0000000184BA0070-0x0000000184BA0160
	}
}
