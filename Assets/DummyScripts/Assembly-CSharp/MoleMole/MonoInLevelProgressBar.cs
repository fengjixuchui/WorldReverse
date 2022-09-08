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
	public class MonoInLevelProgressBar : MonoBehaviour // TypeDefIndex: 31227
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public SmoothMask progressFill; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _info; // 0x30
		private bool _valid; // 0x38
		private MonoDungeonCountDown countDown; // 0x40
		public Color colorNormal; // 0x48
		public Color colorTerminate; // 0x58
	
		// Properties
		public MonoDungeonCountDown CountDown { /* [XID] */ /* 0x000000018992D420-0x000000018992D440 */ get => default; } // 0x0000000183D73710-0x0000000183D73860 
		public string title { /* [XID] */ /* 0x0000000189934970-0x0000000189934990 */ set {} } // 0x0000000183D73A80-0x0000000183D73B50
		public string info { /* [XID] */ /* 0x000000018993C440-0x000000018993C460 */ set {} } // 0x0000000183D73860-0x0000000183D73930
		public float progressRatio { /* [XID] */ /* 0x0000000189943A90-0x0000000189943AB0 */ set {} } // 0x0000000183D73930-0x0000000183D73A80
		public bool valid { /* [XID] */ /* 0x000000018994B010-0x000000018994B030 */ set {} } // 0x0000000183D73B50-0x0000000183D73C50
	
		// Constructors
		public MonoInLevelProgressBar() {} // 0x0000000183D73690-0x0000000183D73710
	
		// Methods
		// [XID] // 0x00000001899529B0-0x00000001899529D0
		private void OnEnable() {} // 0x0000000183D73480-0x0000000183D73570
		// [XID] // 0x0000000189959F50-0x0000000189959F70
		public void TriggerAddEffect() {} // 0x0000000183D73570-0x0000000183D73690
	}
}
