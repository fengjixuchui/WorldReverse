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
	public class MonoBagPageCookSelectRow : MonoSpriteProxy // TypeDefIndex: 30698
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _anim; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _iconList; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectGo; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mark; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x50
		private List<BagItemSlot> _itemList; // 0x58
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001895F91F0-0x00000001895F9210 */ get => default; } // 0x00000001848E6B80-0x00000001848E6C20 
		public bool selected { /* [XID] */ /* 0x0000000189600820-0x0000000189600840 */ set {} } // 0x00000001848E6EF0-0x00000001848E6FE0
		public bool highlighted { /* [XID] */ /* 0x0000000189608140-0x0000000189608160 */ set {} } // 0x00000001848E6E00-0x00000001848E6EF0
		public MonoSimpleReusableList iconList { /* [XID] */ /* 0x000000018960FAC0-0x000000018960FAE0 */ get => default; } // 0x00000001848E6CC0-0x00000001848E6D60 
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x0000000189616D30-0x0000000189616D50 */ get => default; } // 0x00000001848E6D60-0x00000001848E6E00 
		public UnityEngine.UI.Text desc { /* [XID] */ /* 0x000000018961E8E0-0x000000018961E900 */ get => default; } // 0x00000001848E6C20-0x00000001848E6CC0 
	
		// Constructors
		public MonoBagPageCookSelectRow() {} // 0x00000001848E6AD0-0x00000001848E6B80
	
		// Methods
		// [XID] // 0x0000000189625D00-0x0000000189625D20
		public void Setup(uint materialID, bool isCurrent) {} // 0x00000001848E67D0-0x00000001848E6AD0
		// [XID] // 0x000000018962D620-0x000000018962D640
		private void RefreshItem(Transform trans, int index) {} // 0x00000001848E6490-0x00000001848E6610
		// [XID] // 0x00000001896351E0-0x0000000189635200
		public void SetChosenState(bool isChosen) {} // 0x00000001848E6700-0x00000001848E67D0
		// [XID] // 0x000000018963C860-0x000000018963C880
		private void ClearAnimTrigger() {} // 0x00000001848E6610-0x00000001848E6700
	}
}
