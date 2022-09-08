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
	public class MonoNameCardItemTip : MonoBehaviour // TypeDefIndex: 30421
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameCardName; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _playerIcon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cardIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cardStory; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cardSource; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _tipsContainer; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tipLocked; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tipUsing; // 0x58
	
		// Properties
		public string nameCardName { /* [XID] */ /* 0x0000000189A34830-0x0000000189A34850 */ set {} } // 0x00000001837104E0-0x00000001837105B0
		public Image playerIcon { /* [XID] */ /* 0x0000000189A3BC50-0x0000000189A3BC70 */ get => default; } // 0x0000000183710440-0x00000001837104E0 
		public string playerName { /* [XID] */ /* 0x0000000189A438E0-0x0000000189A43900 */ set {} } // 0x0000000183710770-0x0000000183710840
		public Image nameCardPic { /* [XID] */ /* 0x0000000189A4AD10-0x0000000189A4AD30 */ get => default; } // 0x00000001837103A0-0x0000000183710440 
		public string nameCardStory { /* [XID] */ /* 0x0000000189A52430-0x0000000189A52450 */ set {} } // 0x0000000183710690-0x0000000183710770
		public string nameCardSource { /* [XID] */ /* 0x0000000189A59D60-0x0000000189A59D80 */ set {} } // 0x00000001837105B0-0x0000000183710690
		public bool showTips { /* [XID] */ /* 0x0000000189A61530-0x0000000189A61550 */ set {} } // 0x0000000183710930-0x0000000183710A20
		public bool showLockedTip { /* [XID] */ /* 0x0000000189A69410-0x0000000189A69430 */ set {} } // 0x0000000183710840-0x0000000183710930
		public bool showUsingTip { /* [XID] */ /* 0x0000000189A707C0-0x0000000189A707E0 */ set {} } // 0x0000000183710A20-0x0000000183710B10
	
		// Constructors
		public MonoNameCardItemTip() {} // 0x0000000183710310-0x00000001837103A0
	}
}
