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
	public class MonoMPInvitationListDialog : MonoUIProxy // TypeDefIndex: 31124
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _titleLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _hintLabel; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoReusableList _invitationList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x58
	
		// Properties
		public Button closeButton { /* [XID] */ /* 0x000000018963DE20-0x000000018963DE40 */ get => default; } // 0x0000000182F07800-0x0000000182F078C0 
		public MonoReusableList invitationList { /* [XID] */ /* 0x00000001896457D0-0x00000001896457F0 */ get => default; } // 0x0000000182F078C0-0x0000000182F07960 
		public string title { /* [XID] */ /* 0x000000018964CF50-0x000000018964CF70 */ set {} } // 0x0000000182F07A30-0x0000000182F07B00
		public string hint { /* [XID] */ /* 0x00000001896546E0-0x0000000189654700 */ set {} } // 0x0000000182F07960-0x0000000182F07A30
	
		// Constructors
		public MonoMPInvitationListDialog() {} // 0x0000000182F07780-0x0000000182F07800
	}
}
