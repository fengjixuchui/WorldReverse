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
	public class MonoAchievementSublistRow : MonoBehaviour // TypeDefIndex: 31143
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDate; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtProgress; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtComplete; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTotalNum; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _markPointBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _markPointGO; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _fetchHintGO; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeGO; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _inProgressGO; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeMask; // 0x88
		private AchievementIconType _iconType; // 0x90
		private Animator _animator; // 0x98
	
		// Properties
		public Image icon { /* [XID] */ /* 0x00000001899619C0-0x00000001899619E0 */ get => default; } // 0x0000000184C659C0-0x0000000184C65A60 
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x0000000189969070-0x0000000189969090 */ get => default; } // 0x0000000184C65E20-0x0000000184C65EC0 
		public UnityEngine.UI.Text txtDesc { /* [XID] */ /* 0x0000000189970AB0-0x0000000189970AD0 */ get => default; } // 0x0000000184C65CE0-0x0000000184C65D80 
		public UnityEngine.UI.Text txtDate { /* [XID] */ /* 0x00000001899784B0-0x00000001899784D0 */ get => default; } // 0x0000000184C65C40-0x0000000184C65CE0 
		public UnityEngine.UI.Text txtProgress { /* [XID] */ /* 0x000000018997F5B0-0x000000018997F5D0 */ get => default; } // 0x0000000184C65D80-0x0000000184C65E20 
		public UnityEngine.UI.Text txtComplete { /* [XID] */ /* 0x0000000189986F00-0x0000000189986F20 */ get => default; } // 0x0000000184C65BA0-0x0000000184C65C40 
		public UnityEngine.UI.Text txtTotalNum { /* [XID] */ /* 0x000000018998E9B0-0x000000018998E9D0 */ get => default; } // 0x0000000184C65EC0-0x0000000184C65F60 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x00000001899965F0-0x0000000189996610 */ get => default; } // 0x0000000184C65B00-0x0000000184C65BA0 
		public Button fetchBtn { /* [XID] */ /* 0x000000018999E050-0x000000018999E070 */ get => default; } // 0x0000000184C65820-0x0000000184C65920 
		public Button markPointBtn { /* [XID] */ /* 0x00000001899A5AB0-0x00000001899A5AD0 */ get => default; } // 0x0000000184C65A60-0x0000000184C65B00 
		public AchievementIconType iconType { /* [XID] */ /* 0x00000001899AD110-0x00000001899AD130 */ get => default; /* [XID] */ /* 0x00000001899B4970-0x00000001899B4990 */ set {} } // 0x0000000184C65920-0x0000000184C659C0 0x0000000184C65F60-0x0000000184C66160
		public bool isSelected { /* [XID] */ /* 0x00000001899BC040-0x00000001899BC060 */ set {} } // 0x0000000184C66160-0x0000000184C66330
	
		// Constructors
		public MonoAchievementSublistRow() {} // 0x0000000184C65760-0x0000000184C65820
	}
}
