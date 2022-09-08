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
	public class MonoInLevelGachaShowPage : MonoUIProxy // TypeDefIndex: 29742
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected UnityEngine.UI.Text _txtItemName; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected GameObject _ownedGroup; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoStarRate _rankStar; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _scrollTrans; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _addScrollTrans; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _slotPrefab; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarLabelTxt; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarDescTxt; // 0x80
		public Image[] colorImages; // 0x88
	
		// Properties
		public GameObject ownedGroup { /* [XID] */ /* 0x0000000189AA94B0-0x0000000189AA94D0 */ get => default; } // 0x000000018470FA70-0x000000018470FB10 
		public Transform addScrollTrans { /* [XID] */ /* 0x0000000189AB13D0-0x0000000189AB13F0 */ get => default; } // 0x000000018470F440-0x000000018470F4E0 
		public Transform scrollTrans { /* [XID] */ /* 0x0000000189AB8660-0x0000000189AB8680 */ get => default; } // 0x000000018470FB10-0x000000018470FBB0 
		public GameObject slotPrefab { /* [XID] */ /* 0x0000000189AC0370-0x0000000189AC0390 */ get => default; } // 0x000000018470FBB0-0x000000018470FC50 
		public Button onceTimeBtn { /* [XID] */ /* 0x0000000189AC7D40-0x0000000189AC7D60 */ get => default; } // 0x000000018470F950-0x000000018470FA70 
		public Button okBtn { /* [XID] */ /* 0x0000000189ACF280-0x0000000189ACF2A0 */ get => default; } // 0x000000018470F830-0x000000018470F950 
		public Button btnNext { /* [XID] */ /* 0x0000000189AD7150-0x0000000189AD7170 */ get => default; } // 0x000000018470F4E0-0x000000018470F600 
		public Button closeBtn { /* [XID] */ /* 0x0000000189ADEB10-0x0000000189ADEB30 */ get => default; } // 0x000000018470F600-0x000000018470F720 
		public RectTransform materialsContainer { /* [XID] */ /* 0x0000000189AE6500-0x0000000189AE6520 */ get => default; } // 0x000000018470F720-0x000000018470F830 
	
		// Constructors
		public MonoInLevelGachaShowPage() {} // 0x000000018470F3B0-0x000000018470F440
	
		// Methods
		// [XID] // 0x0000000189AEDCD0-0x0000000189AEDCF0
		public void Refresh(BagItem bagItem, bool isAvatar) {} // 0x000000018470F090-0x000000018470F3B0
	}
}
