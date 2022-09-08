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
	public class MonoDungeonExpendDialog : MonoUIProxy // TypeDefIndex: 30534
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoPrefabPlugin _prefabPlugin; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _freeClickButton; // 0x50
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _titleLabel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descriptionLabel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subDescriptionLabel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _hintText; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _costItemImage; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costItemCountText; // 0x80
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _noticeText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _completeText; // 0x90
	
		// Properties
		public Button freeClickButton { /* [XID] */ /* 0x0000000189B040F0-0x0000000189B04110 */ get => default; } // 0x0000000184690FD0-0x0000000184691070 
		public Button confirmButton { /* [XID] */ /* 0x0000000189B0B970-0x0000000189B0B990 */ get => default; } // 0x0000000184690F10-0x0000000184690FD0 
		public Button cancelButton { /* [XID] */ /* 0x0000000189B12E60-0x0000000189B12E80 */ get => default; } // 0x0000000184690E50-0x0000000184690F10 
		public string title { /* [XID] */ /* 0x0000000189B1A570-0x0000000189B1A590 */ set {} } // 0x0000000184691800-0x00000001846918D0
		public string description { /* [XID] */ /* 0x0000000189B21A70-0x0000000189B21A90 */ set {} } // 0x00000001846914C0-0x0000000184691590
		public string subDescription { /* [XID] */ /* 0x0000000189B291E0-0x0000000189B29200 */ set {} } // 0x0000000184691730-0x0000000184691800
		public string hint { /* [XID] */ /* 0x0000000189B30570-0x0000000189B30590 */ set {} } // 0x0000000184691590-0x0000000184691660
		public Sprite costItemSprite { /* [XID] */ /* 0x0000000189B37E90-0x0000000189B37EB0 */ set {} } // 0x0000000184691400-0x00000001846914C0
		public string costItemCountString { /* [XID] */ /* 0x0000000189B3F860-0x0000000189B3F880 */ set {} } // 0x0000000184691330-0x0000000184691400
		public string completeText { /* [XID] */ /* 0x0000000189B47120-0x0000000189B47140 */ set {} } // 0x0000000184691260-0x0000000184691330
		public MonoBagProxySlot itemSlot { /* [XID] */ /* 0x0000000189B4E860-0x0000000189B4E880 */ get => default; } // 0x0000000184691070-0x0000000184691150 
		public string noticeText { /* [XID] */ /* 0x0000000189B73BF0-0x0000000189B73C10 */ set {} } // 0x0000000184691660-0x0000000184691730
		public bool showingComplete { /* [XID] */ /* 0x0000000189B7B240-0x0000000189B7B260 */ get => default; } // 0x0000000184691150-0x0000000184691260 
	
		// Constructors
		public MonoDungeonExpendDialog() {} // 0x0000000184690DB0-0x0000000184690E50
	
		// Methods
		// [XID] // 0x0000000189B56080-0x0000000189B560A0
		public void TriggerLoading() {} // 0x0000000184690C80-0x0000000184690DB0
		// [XID] // 0x0000000189B5D980-0x0000000189B5D9A0
		public void TriggerComplete() {} // 0x0000000184690AC0-0x0000000184690BA0
		// [XID] // 0x0000000189B64EC0-0x0000000189B64EE0
		public void TriggerFail() {} // 0x0000000184690BA0-0x0000000184690C80
		// [XID] // 0x0000000189B6C4C0-0x0000000189B6C4E0
		public void SetAvailable(bool value) {} // 0x00000001846909C0-0x0000000184690AC0
	}
}
