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
	public class MonoFleurFairMiniGameSettlePlayerListRow : MonoBehaviour // TypeDefIndex: 30387
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _iconBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _selfTag; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _ps4ID; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemText_1; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemText_2; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemText_3; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rank1; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rank2; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rank3; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rank4; // 0x78
		public bool IsSelf; // 0x80
		private bool _hightlighted; // 0x81
	
		// Properties
		public Sprite icon { /* [XID] */ /* 0x0000000189B3DE10-0x0000000189B3DE30 */ set {} } // 0x0000000184ADEF20-0x0000000184ADEFE0
		public UnityEngine.UI.Text itemText_1 { /* [XID] */ /* 0x0000000189B45B70-0x0000000189B45B90 */ get => default; } // 0x0000000184ADEA60-0x0000000184ADEB00 
		public UnityEngine.UI.Text itemText_2 { /* [XID] */ /* 0x0000000189B4D010-0x0000000189B4D030 */ get => default; } // 0x0000000184ADEB00-0x0000000184ADEBA0 
		public UnityEngine.UI.Text itemText_3 { /* [XID] */ /* 0x0000000189B54790-0x0000000189B547B0 */ get => default; } // 0x0000000184ADEBA0-0x0000000184ADEC40 
		public MonoUIContainer ps4ID { /* [XID] */ /* 0x0000000189B5C340-0x0000000189B5C360 */ get => default; } // 0x0000000184ADECE0-0x0000000184ADED80 
		public Button iconBtn { /* [XID] */ /* 0x0000000189B63920-0x0000000189B63940 */ get => default; } // 0x0000000184ADE9C0-0x0000000184ADEA60 
		public UnityEngine.UI.Text nameLabel { /* [XID] */ /* 0x0000000189B6B100-0x0000000189B6B120 */ get => default; } // 0x0000000184ADEC40-0x0000000184ADECE0 
		public bool highlight { /* [XID] */ /* 0x0000000189B88B30-0x0000000189B88B50 */ get => default; /* [XID] */ /* 0x0000000189B90000-0x0000000189B90020 */ set {} } // 0x0000000184ADE910-0x0000000184ADE9C0 0x0000000184ADED80-0x0000000184ADEF20
	
		// Constructors
		public MonoFleurFairMiniGameSettlePlayerListRow() {} // 0x0000000184ADE890-0x0000000184ADE910
	
		// Methods
		// [XID] // 0x0000000189B72700-0x0000000189B72720
		public void SetRank(int rank) {} // 0x0000000184ADE580-0x0000000184ADE6B0
		// [XID] // 0x0000000189B79C50-0x0000000189B79C70
		public void SetSelectedState(bool selected) {} // 0x0000000184ADE6B0-0x0000000184ADE7B0
		// [XID] // 0x0000000189B81380-0x0000000189B813A0
		public void SetSelfTag(bool isSelf) {} // 0x0000000184ADE7B0-0x0000000184ADE890
	}
}
