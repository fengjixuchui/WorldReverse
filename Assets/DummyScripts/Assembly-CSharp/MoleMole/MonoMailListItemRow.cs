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
	public class MonoMailListItemRow : MonoSpriteProxy // TypeDefIndex: 30824
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _sender; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _date; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _newTip; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _notGetTip; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _importantTip; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selected; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _marked; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _readImg; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unreadImg; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _markStar; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _bgCanvas; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _titleCanvas; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _DetailCanvas; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _itemIconCanvas; // 0xA0
	
		// Properties
		public bool selected { /* [XID] */ /* 0x00000001897666D0-0x00000001897666F0 */ set {} } // 0x000000018428E930-0x000000018428EA20
		public bool marked { /* [XID] */ /* 0x000000018976DD50-0x000000018976DD70 */ set {} } // 0x000000018428E840-0x000000018428E930
		public bool markStar { /* [XID] */ /* 0x0000000189775460-0x0000000189775480 */ set {} } // 0x000000018428E750-0x000000018428E840
		public Button actionBtn { /* [XID] */ /* 0x000000018977CCD0-0x000000018977CCF0 */ get => default; } // 0x000000018428E5C0-0x000000018428E660 
		public bool isNew { /* [XID] */ /* 0x0000000189784730-0x0000000189784750 */ set {} } // 0x000000018428E660-0x000000018428E750
	
		// Constructors
		public MonoMailListItemRow() {} // 0x000000018428E500-0x000000018428E5C0
	
		// Methods
		// [XID] // 0x000000018978BD00-0x000000018978BD20
		public void SetMailItemView(MailDataItem mailData) {} // 0x000000018428DFC0-0x000000018428E400
		// [XID] // 0x00000001897931B0-0x00000001897931D0
		public void SetMailRemainTime(MailDataItem mailData) {} // 0x000000018428E400-0x000000018428E500
		// [XID] // 0x000000018979B480-0x000000018979B4A0
		private string MailSendTimeToString(uint sendTime) => default; // 0x000000018428DD90-0x000000018428DFC0
		// [XID] // 0x00000001897A2940-0x00000001897A2960
		private string MailTimeToString(uint sendTime, uint expireTime) => default; // 0x000000018428DB90-0x000000018428DD90
		// [XID] // 0x00000001897A9E20-0x00000001897A9E40
		private void SetMailCanvasStyle(bool isGot) {} // 0x000000018428D9E0-0x000000018428DB90
	}
}
