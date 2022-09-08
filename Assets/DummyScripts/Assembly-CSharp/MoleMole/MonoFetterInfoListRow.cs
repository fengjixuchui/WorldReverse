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
	public class MonoFetterInfoListRow : MonoBehaviour // TypeDefIndex: 30471
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _playIcon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockedIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnAnimator; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGroup; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _new; // 0x48
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x000000018994C800-0x000000018994C820 */ get => default; } // 0x0000000185630820-0x00000001856308C0 
		public GameObject redPointNew { /* [XID] */ /* 0x0000000189953F00-0x0000000189953F20 */ get => default; } // 0x0000000185630960-0x0000000185630A00 
		public GameObject btnPlayAnimator { /* [XID] */ /* 0x000000018995B760-0x000000018995B780 */ get => default; } // 0x00000001856308C0-0x0000000185630960 
	
		// Constructors
		public MonoFetterInfoListRow() {} // 0x00000001856307A0-0x0000000185630820
	
		// Methods
		// [XID] // 0x0000000189963360-0x0000000189963380
		public void Refresh(AvatarDataItem avatarItem, Fetter.Data data, HashSet<uint> redPointCheckSet) {} // 0x00000001856304E0-0x00000001856307A0
	}
}
