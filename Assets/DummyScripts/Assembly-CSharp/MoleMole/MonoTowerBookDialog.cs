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
	public class MonoTowerBookDialog : MonoUIProxy // TypeDefIndex: 30591
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _totalScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _layerRoomText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _avatarIconRoot; // 0x60
		private MonoAvatarIcon[] _avatarIcon; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _towerDataList; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _detailScrollRect; // 0x80
	
		// Properties
		public MonoGridScroller totalScroller { /* [XID] */ /* 0x0000000189B11990-0x0000000189B119B0 */ get => default; } // 0x0000000184882AF0-0x0000000184882B90 
		public ScrollRect detailScrollRect { /* [XID] */ /* 0x0000000189B18CE0-0x0000000189B18D00 */ get => default; } // 0x0000000184882860-0x0000000184882910 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189B203B0-0x0000000189B203D0 */ get => default; } // 0x0000000184882A50-0x0000000184882AF0 
		public UnityEngine.UI.Text timeText { /* [XID] */ /* 0x0000000189B279D0-0x0000000189B279F0 */ get => default; } // 0x00000001848829B0-0x0000000184882A50 
		public UnityEngine.UI.Text layerRoomText { /* [XID] */ /* 0x0000000189B2ED10-0x0000000189B2ED30 */ get => default; } // 0x0000000184882910-0x00000001848829B0 
		public Transform[] avatarIconRoot { /* [XID] */ /* 0x0000000189B36590-0x0000000189B365B0 */ get => default; } // 0x00000001848826B0-0x0000000184882750 
		public MonoReusableList towerDataList { /* [XID] */ /* 0x0000000189B3DD90-0x0000000189B3DDB0 */ get => default; } // 0x0000000184882B90-0x0000000184882C30 
		public MonoUIContainer closeButton { /* [XID] */ /* 0x0000000189B45B10-0x0000000189B45B30 */ get => default; } // 0x0000000184882750-0x0000000184882860 
		public bool showOKButton { /* [XID] */ /* 0x0000000189B4CFB0-0x0000000189B4CFD0 */ set {} } // 0x0000000184882D00-0x0000000184882DD0
		public bool showDetailButton { /* [XID] */ /* 0x0000000189B546D0-0x0000000189B546F0 */ set {} } // 0x0000000184882C30-0x0000000184882D00
	
		// Constructors
		public MonoTowerBookDialog() {} // 0x00000001848825D0-0x00000001848826B0
	
		// Methods
		// [XID] // 0x0000000189B5C2A0-0x0000000189B5C2C0
		public MonoAvatarIcon GetAvatarIcon(int index) => default; // 0x00000001848822A0-0x00000001848825D0
	}
}
