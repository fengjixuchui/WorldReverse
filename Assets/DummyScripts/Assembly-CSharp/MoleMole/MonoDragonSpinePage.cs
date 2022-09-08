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
	public class MonoDragonSpinePage : MonoUIProxy // TypeDefIndex: 31200
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _progressContainer; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _albedoView; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _chaptersRoot; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _chapterTab1Root; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _chapterTab2Root; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _chapter4View; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _enterTime; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _backMainTime; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _showBanner; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _bannerBtn; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _albedoScrollDesc; // 0xA0
	
		// Properties
		public ScrollRect albedoScrollDesc { /* [XID] */ /* 0x00000001899CDF20-0x00000001899CDF40 */ get => default; } // 0x0000000183F42E40-0x0000000183F42EF0 
		public string timeDesc { /* [XID] */ /* 0x00000001899D5670-0x00000001899D5690 */ set {} } // 0x0000000183F43380-0x0000000183F43450
		public Transform coinRoot { /* [XID] */ /* 0x00000001899DCA10-0x00000001899DCA30 */ get => default; } // 0x0000000183F43190-0x0000000183F43230 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x00000001899E4690-0x00000001899E46B0 */ get => default; } // 0x0000000183F42840-0x0000000183F42900 
		public MonoUIContainer BtnWeaponInfo { /* [XID] */ /* 0x00000001899EB980-0x00000001899EB9A0 */ get => default; } // 0x0000000183F42CC0-0x0000000183F42D80 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x00000001899F3470-0x00000001899F3490 */ get => default; } // 0x0000000183F42490-0x0000000183F42550 
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x00000001899FAE30-0x00000001899FAE50 */ get => default; } // 0x0000000183F42B40-0x0000000183F42C00 
		public MonoUIContainer BtnCourse { /* [XID] */ /* 0x0000000189A02080-0x0000000189A020A0 */ get => default; } // 0x0000000183F426C0-0x0000000183F42780 
		public MonoUIContainer BtnShop { /* [XID] */ /* 0x0000000189A09870-0x0000000189A09890 */ get => default; } // 0x0000000183F42C00-0x0000000183F42CC0 
		public MonoUIContainer BtnWeapon { /* [XID] */ /* 0x0000000189A10FD0-0x0000000189A10FF0 */ get => default; } // 0x0000000183F42D80-0x0000000183F42E40 
		public MonoUIContainer progressContainer { /* [XID] */ /* 0x0000000189A18380-0x0000000189A183A0 */ get => default; } // 0x0000000183F432E0-0x0000000183F43380 
		public Transform chapterMainView { /* [XID] */ /* 0x0000000189A1FA30-0x0000000189A1FA50 */ get => default; } // 0x0000000183F43050-0x0000000183F430F0 
		public Transform chapterView { /* [XID] */ /* 0x0000000189A26DF0-0x0000000189A26E10 */ get => default; } // 0x0000000183F430F0-0x0000000183F43190 
		public Transform chapter4View { /* [XID] */ /* 0x0000000189A2E630-0x0000000189A2E650 */ get => default; } // 0x0000000183F42FA0-0x0000000183F43050 
		public float enterTime { /* [XID] */ /* 0x0000000189A35F80-0x0000000189A35FA0 */ get => default; } // 0x0000000183F43230-0x0000000183F432E0 
		public float backMainTime { /* [XID] */ /* 0x0000000189A3D580-0x0000000189A3D5A0 */ get => default; } // 0x0000000183F42EF0-0x0000000183F42FA0 
		public MonoUIContainer Albedo_BtnGoto { /* [XID] */ /* 0x0000000189A44C50-0x0000000189A44C70 */ get => default; } // 0x0000000183F423D0-0x0000000183F42490 
		public MonoUIContainer BtnFetch { /* [XID] */ /* 0x0000000189A4C4A0-0x0000000189A4C4C0 */ get => default; } // 0x0000000183F42780-0x0000000183F42840 
		public MonoUIContainer BtnChallenge { /* [XID] */ /* 0x0000000189A53C00-0x0000000189A53C20 */ get => default; } // 0x0000000183F42600-0x0000000183F426C0 
		public MonoUIContainer BtnItemDetail { /* [XID] */ /* 0x0000000189A5B650-0x0000000189A5B670 */ get => default; } // 0x0000000183F42900-0x0000000183F429C0 
		public MonoUIContainer BtnPrev { /* [XID] */ /* 0x0000000189A62CA0-0x0000000189A62CC0 */ get => default; } // 0x0000000183F42A80-0x0000000183F42B40 
		public MonoUIContainer BtnNext { /* [XID] */ /* 0x0000000189A6A850-0x0000000189A6A870 */ get => default; } // 0x0000000183F429C0-0x0000000183F42A80 
		public Button BtnBanner { /* [XID] */ /* 0x0000000189A71EE0-0x0000000189A71F00 */ get => default; } // 0x0000000183F42550-0x0000000183F42600 
	
		// Constructors
		public MonoDragonSpinePage() {} // 0x0000000183F42310-0x0000000183F423D0
	
		// Methods
		// [XID] // 0x0000000189A79B40-0x0000000189A79B60
		public void ShowAlbedo() {} // 0x0000000183F41E90-0x0000000183F41FA0
		// [XID] // 0x0000000189A80FE0-0x0000000189A81000
		public void ShowAllChapters() {} // 0x0000000183F41FA0-0x0000000183F42150
		// [XID] // 0x0000000189A88A20-0x0000000189A88A40
		public void ShowChapter(int index, bool isSwitch) {} // 0x0000000183F42150-0x0000000183F42310
		// [XID] // 0x0000000189A901F0-0x0000000189A90210
		private void ResetTrigger(string trigger) {} // 0x0000000183F41CF0-0x0000000183F41DB0
		// [XID] // 0x0000000189A979E0-0x0000000189A97A00
		public void SetBannerVisible(bool bVis) {} // 0x0000000183F41DB0-0x0000000183F41E90
	}
}
