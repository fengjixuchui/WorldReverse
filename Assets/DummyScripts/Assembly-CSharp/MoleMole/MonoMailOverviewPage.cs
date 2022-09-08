/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMailOverviewPage : MonoUIProxy // TypeDefIndex: 31009
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _mailScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _mutiSelectToggle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMailDetail _mailDetailPanel; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mailListPanel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noMailTip; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCostLabel _mailNumLabel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoRegionJoypadController _joypadController; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x78
	
		// Properties
		public MonoGridScroller mailScroller { /* [XID] */ /* 0x0000000189A5CE50-0x0000000189A5CE70 */ get => default; } // 0x000000018428F3C0-0x000000018428F460 
		public MonoUIContainer mutiSelectToggle { /* [XID] */ /* 0x0000000189A646D0-0x0000000189A646F0 */ get => default; } // 0x000000018428F460-0x000000018428F500 
		public MonoUIContainer btnFetchAll { /* [XID] */ /* 0x0000000189A6BF70-0x0000000189A6BF90 */ get => default; } // 0x000000018428EBA0-0x000000018428EC90 
		public MonoUIContainer btnDeleteRead { /* [XID] */ /* 0x0000000189A73640-0x0000000189A73660 */ get => default; } // 0x000000018428EAB0-0x000000018428EBA0 
		public MonoUIContainer btnReturn { /* [XID] */ /* 0x0000000189A7B200-0x0000000189A7B220 */ get => default; } // 0x000000018428EF60-0x000000018428F050 
		public MonoUIContainer btnTip { /* [XID] */ /* 0x0000000189A82900-0x0000000189A82920 */ get => default; } // 0x000000018428F050-0x000000018428F140 
		public MonoMailDetail mailDetailPanel { /* [XID] */ /* 0x0000000189A8A310-0x0000000189A8A330 */ get => default; } // 0x000000018428F1E0-0x000000018428F280 
		public GameObject mailListPanel { /* [XID] */ /* 0x0000000189A91A90-0x0000000189A91AB0 */ get => default; } // 0x000000018428F280-0x000000018428F320 
		public GameObject noMailTip { /* [XID] */ /* 0x0000000189A99530-0x0000000189A99550 */ get => default; } // 0x000000018428F500-0x000000018428F5A0 
		public MonoCostLabel mailNumLabel { /* [XID] */ /* 0x0000000189AA0670-0x0000000189AA0690 */ get => default; } // 0x000000018428F320-0x000000018428F3C0 
		public Transform btnPSOK { /* [XID] */ /* 0x0000000189AA7C10-0x0000000189AA7C30 */ get => default; } // 0x000000018428EE70-0x000000018428EF60 
		public Transform btnPSExit { /* [XID] */ /* 0x0000000189AAF6C0-0x0000000189AAF6E0 */ get => default; } // 0x000000018428EC90-0x000000018428ED80 
		public Transform btnPSItemDetail { /* [XID] */ /* 0x0000000189AB6F10-0x0000000189AB6F30 */ get => default; } // 0x000000018428ED80-0x000000018428EE70 
		public MonoRegionJoypadController joypadControlller { /* [XID] */ /* 0x0000000189ABE960-0x0000000189ABE980 */ get => default; } // 0x000000018428F140-0x000000018428F1E0 
	
		// Constructors
		public MonoMailOverviewPage() {} // 0x000000018428EA20-0x000000018428EAB0
	}
}
