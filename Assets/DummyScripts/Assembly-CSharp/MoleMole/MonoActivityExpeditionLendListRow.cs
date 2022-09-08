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
	public class MonoActivityExpeditionLendListRow : MonoUIProxy // TypeDefIndex: 30336
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _avatarIcon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtAvatarName; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDate; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _PS4ID; // 0x60
	
		// Properties
		public MonoUIContainer PS4ID { /* [XID] */ /* 0x0000000189B57860-0x0000000189B57880 */ get => default; } // 0x0000000186313AF0-0x0000000186313B90 
	
		// Constructors
		public MonoActivityExpeditionLendListRow() {} // 0x0000000186313A70-0x0000000186313AF0
	
		// Methods
		// [XID] // 0x0000000189B5F1D0-0x0000000189B5F1F0
		public void RefreshIconAndText(uint avatarId, string targetName, uint lendDate) {} // 0x0000000186313780-0x0000000186313A70
	}
}
