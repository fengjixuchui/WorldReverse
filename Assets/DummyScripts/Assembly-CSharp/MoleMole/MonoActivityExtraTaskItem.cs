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
	public class MonoActivityExtraTaskItem : MonoBehaviour // TypeDefIndex: 29696
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockTips; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _questList; // 0x30
	
		// Properties
		public MonoSimpleReusableList questList { /* [XID] */ /* 0x00000001896E2150-0x00000001896E2170 */ get => default; } // 0x0000000186314790-0x0000000186314830 
		public string title { /* [XID] */ /* 0x00000001896E9670-0x00000001896E9690 */ set {} } // 0x0000000186314920-0x00000001863149F0
		public string unlockTips { /* [XID] */ /* 0x00000001896F08B0-0x00000001896F08D0 */ set {} } // 0x00000001863149F0-0x0000000186314AC0
		public bool showLockIcon { /* [XID] */ /* 0x00000001896F80C0-0x00000001896F80E0 */ set {} } // 0x0000000186314830-0x0000000186314920
	
		// Constructors
		public MonoActivityExtraTaskItem() {} // 0x0000000186314710-0x0000000186314790
	}
}
