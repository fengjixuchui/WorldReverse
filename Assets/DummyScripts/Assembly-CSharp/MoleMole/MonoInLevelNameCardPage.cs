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
	public class MonoInLevelNameCardPage : MonoUIProxy // TypeDefIndex: 29750
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		// [Header] // 0x00000001896F8080-0x00000001896F80C0
		[SerializeField] // 0x00000001896F8080-0x00000001896F80C0
		private GameObject _imgL; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgR; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _nameCardPic; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _playerIcon; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerName; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameCardName; // 0x70
		// [Header] // 0x0000000189729400-0x0000000189729440
		[SerializeField] // 0x0000000189729400-0x0000000189729440
		private MonoGridScroller _nameCardScroller; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollerJoypadController _nameCardScrollerController; // 0x80
		// [Header] // 0x000000018973CD30-0x000000018973CD70
		[SerializeField] // 0x000000018973CD30-0x000000018973CD70
		private MonoPrefabPlugin _profilePrefab; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectDetail; // 0x90
	
		// Properties
		public bool showDefaultNameCard { /* [XID] */ /* 0x00000001897503F0-0x0000000189750410 */ set {} } // 0x0000000183D6D0A0-0x0000000183D6D1C0
		public Image nameCardPic { /* [XID] */ /* 0x0000000189757990-0x00000001897579B0 */ get => default; } // 0x0000000183D6C950-0x0000000183D6C9F0 
		public Image playerIcon { /* [XID] */ /* 0x000000018975F3B0-0x000000018975F3D0 */ get => default; } // 0x0000000183D6CB40-0x0000000183D6CBE0 
		public string playerName { /* [XID] */ /* 0x00000001897668A0-0x00000001897668C0 */ set {} } // 0x0000000183D6CFD0-0x0000000183D6D0A0
		public string nameCardName { /* [XID] */ /* 0x000000018976DE70-0x000000018976DE90 */ set {} } // 0x0000000183D6CF00-0x0000000183D6CFD0
		public MonoPrefabPlugin profilePrefab { /* [XID] */ /* 0x00000001897755B0-0x00000001897755D0 */ get => default; } // 0x0000000183D6CBE0-0x0000000183D6CC90 
		public MonoGridScroller nameCardSrcoller { /* [XID] */ /* 0x000000018977CE30-0x000000018977CE50 */ get => default; } // 0x0000000183D6CAA0-0x0000000183D6CB40 
		public MonoScrollerJoypadController nameCardSrcollerController { /* [XID] */ /* 0x0000000189784870-0x0000000189784890 */ get => default; } // 0x0000000183D6C9F0-0x0000000183D6CAA0 
		public MonoUIContainer returnBtn { /* [XID] */ /* 0x000000018978BE60-0x000000018978BE80 */ get => default; } // 0x0000000183D6CC90-0x0000000183D6CD50 
		public MonoUIContainer useBtn { /* [XID] */ /* 0x0000000189793290-0x00000001897932B0 */ get => default; } // 0x0000000183D6CD50-0x0000000183D6CE10 
		public bool detailSelected { /* [XID] */ /* 0x000000018979B520-0x000000018979B540 */ set {} } // 0x0000000183D6CE10-0x0000000183D6CF00
	
		// Constructors
		public MonoInLevelNameCardPage() {} // 0x0000000183D6C8B0-0x0000000183D6C950
	}
}
