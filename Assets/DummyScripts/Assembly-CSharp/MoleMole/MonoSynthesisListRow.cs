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
	public class MonoSynthesisListRow : MonoSpriteProxy // TypeDefIndex: 30942
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _itemIcon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cornerIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _lockIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockRoot; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _newRoot; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _nameCanvas; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _descCanvas; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _starRoot; // 0x78
		private MonoStarRate _rankStar; // 0x80
		private GameObject _rankStarObj; // 0x88
	
		// Properties
		public Button actionBtn { /* [XID] */ /* 0x0000000189785B50-0x0000000189785B70 */ get => default; } // 0x000000018500C040-0x000000018500C0E0 
		public bool showNewIcon { /* [XID] */ /* 0x000000018978D270-0x000000018978D290 */ set {} } // 0x000000018500C440-0x000000018500C530
		public Transform starRoot { /* [XID] */ /* 0x0000000189794590-0x00000001897945B0 */ get => default; } // 0x000000018500C250-0x000000018500C2F0 
		public uint combineId { /* [XID] */ /* 0x000000018979CA40-0x000000018979CA80 */ get; /* [XID] */ /* 0x00000001897A6ED0-0x00000001897A6F10 */ private set; } // 0x000000018500C0E0-0x000000018500C140 0x000000018500B350-0x000000018500B3C0
		public bool isSelected { /* [XID] */ /* 0x00000001897B17D0-0x00000001897B17F0 */ get => default; } // 0x000000018500C140-0x000000018500C250 
		public bool canCombine { /* [XID] */ /* 0x00000001897B9240-0x00000001897B9260 */ set {} } // 0x000000018500C2F0-0x000000018500C440
	
		// Constructors
		public MonoSynthesisListRow() {} // 0x000000018500BF50-0x000000018500C040
	
		// Methods
		// [XID] // 0x00000001897C1320-0x00000001897C1340
		public void SetConvertListRow(uint resultItemId, string descStr) {} // 0x000000018500B520-0x000000018500B7E0
		// [XID] // 0x00000001897C8DA0-0x00000001897C8DC0
		public void SetSynthesisListRow(uint combineId) {} // 0x000000018500B7E0-0x000000018500BCD0
		// [XID] // 0x00000001897D03E0-0x00000001897D0400
		public void ShowStar(int value) {} // 0x000000018500BCD0-0x000000018500BF50
		// [XID] // 0x00000001897D80C0-0x00000001897D80E0
		protected override void OnDestroy() {} // 0x000000018500B3C0-0x000000018500B520
	}
}
