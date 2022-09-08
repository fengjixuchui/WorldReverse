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
	public class MonoTowerFloorItem : MonoBehaviour // TypeDefIndex: 30954
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _rewardAnim; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _floorText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _starCountText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _doubleTeamIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _rewardBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgImage; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _picNext; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _picLock; // 0x58
		private Animator _animator; // 0x60
	
		// Properties
		public UnityEngine.UI.Text floorText { /* [XID] */ /* 0x0000000189AC3420-0x0000000189AC3440 */ get => default; } // 0x0000000184883FE0-0x0000000184884080 
		public UnityEngine.UI.Text starCountText { /* [XID] */ /* 0x0000000189ACAB30-0x0000000189ACAB50 */ get => default; } // 0x00000001848841C0-0x0000000184884260 
		public Animator rewardAnim { /* [XID] */ /* 0x0000000189AD2570-0x0000000189AD2590 */ get => default; } // 0x0000000184884080-0x0000000184884120 
		public Button actionBtn { /* [XID] */ /* 0x0000000189ADA030-0x0000000189ADA050 */ get => default; } // 0x0000000184883DA0-0x0000000184883E40 
		public Button rewardBtn { /* [XID] */ /* 0x0000000189AE1930-0x0000000189AE1950 */ get => default; } // 0x0000000184884120-0x00000001848841C0 
		public Image bgImage { /* [XID] */ /* 0x0000000189AE90E0-0x0000000189AE9100 */ get => default; } // 0x0000000184883F40-0x0000000184883FE0 
		public bool isDoubleTeam { /* [XID] */ /* 0x0000000189AF0E90-0x0000000189AF0EB0 */ set {} } // 0x0000000184884260-0x0000000184884350
		public bool showPicNext { /* [XID] */ /* 0x0000000189AF8350-0x0000000189AF8370 */ set {} } // 0x00000001848845B0-0x0000000184884690
		public bool showPicLock { /* [XID] */ /* 0x0000000189AFFA20-0x0000000189AFFA40 */ set {} } // 0x00000001848844D0-0x00000001848845B0
		public Animator animator { /* [XID] */ /* 0x0000000189B06FD0-0x0000000189B06FF0 */ get => default; } // 0x0000000184883E40-0x0000000184883F40 
		public bool showNormalLayer { /* [XID] */ /* 0x0000000189B0E7D0-0x0000000189B0E7F0 */ set {} } // 0x0000000184884350-0x00000001848844D0
	
		// Constructors
		public MonoTowerFloorItem() {} // 0x0000000184883D10-0x0000000184883DA0
	}
}
