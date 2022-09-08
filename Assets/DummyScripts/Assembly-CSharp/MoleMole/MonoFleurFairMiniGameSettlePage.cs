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
	public class MonoFleurFairMiniGameSettlePage : MonoUIProxy // TypeDefIndex: 30386
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _balloonTrans; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _fallTrans; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _musicTrans; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordText_1; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordText_2; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordText_3; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordText_4; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordNumText_1; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordNumText_2; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordNumText_3; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recordNumText_4; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _record3Trans; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _record4Trans; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _score; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _score_pre; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _newTrans; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _avatarTrans; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _avatarIcon; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarDesc; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarScore; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFleurFairMiniGameRewardBtn _avatarRewardBtn; // 0xF8
	
		// Properties
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x0000000189A61570-0x0000000189A61590 */ get => default; } // 0x0000000184ADE4D0-0x0000000184ADE580 
		public UnityEngine.UI.Text desc { /* [XID] */ /* 0x0000000189A69430-0x0000000189A69450 */ get => default; } // 0x0000000184ADE2C0-0x0000000184ADE370 
		public UnityEngine.UI.Text score { /* [XID] */ /* 0x0000000189A707E0-0x0000000189A70800 */ get => default; } // 0x0000000184ADE420-0x0000000184ADE4D0 
		public UnityEngine.UI.Text scorePre { /* [XID] */ /* 0x0000000189A780B0-0x0000000189A780D0 */ get => default; } // 0x0000000184ADE370-0x0000000184ADE420 
		public Transform avatarTrans { /* [XID] */ /* 0x0000000189A7F6A0-0x0000000189A7F6C0 */ get => default; } // 0x0000000184ADE210-0x0000000184ADE2C0 
		public Image avatarIcon { /* [XID] */ /* 0x0000000189A873A0-0x0000000189A873C0 */ get => default; } // 0x0000000184ADE000-0x0000000184ADE0B0 
		public UnityEngine.UI.Text avatarDesc { /* [XID] */ /* 0x0000000189A8EBE0-0x0000000189A8EC00 */ get => default; } // 0x0000000184ADDF50-0x0000000184ADE000 
		public UnityEngine.UI.Text avatarScore { /* [XID] */ /* 0x0000000189A961F0-0x0000000189A96210 */ get => default; } // 0x0000000184ADE160-0x0000000184ADE210 
		public MonoFleurFairMiniGameRewardBtn avatarRewardBtn { /* [XID] */ /* 0x0000000189A9D740-0x0000000189A9D760 */ get => default; } // 0x0000000184ADE0B0-0x0000000184ADE160 
		public MonoUIContainer BtnAgain { /* [XID] */ /* 0x0000000189AA4FF0-0x0000000189AA5010 */ get => default; } // 0x0000000184ADDD10-0x0000000184ADDDD0 
		public MonoUIContainer BtnQuit { /* [XID] */ /* 0x0000000189AAC7B0-0x0000000189AAC7D0 */ get => default; } // 0x0000000184ADDDD0-0x0000000184ADDE90 
		public MonoUIContainer BtnReceive { /* [XID] */ /* 0x0000000189AB3FF0-0x0000000189AB4010 */ get => default; } // 0x0000000184ADDE90-0x0000000184ADDF50 
	
		// Constructors
		public MonoFleurFairMiniGameSettlePage() {} // 0x0000000184ADDC10-0x0000000184ADDD10
	
		// Methods
		// [XID] // 0x0000000189ABBD50-0x0000000189ABBD70
		public void ShowMiniGame(EFleurFairMiniGame miniGame) {} // 0x0000000184ADDAC0-0x0000000184ADDC10
		// [XID] // 0x0000000189AC3520-0x0000000189AC3540
		public void SetNewTag(bool isNew) {} // 0x0000000184ADD9E0-0x0000000184ADDAC0
		// [XID] // 0x0000000189ACABF0-0x0000000189ACAC10
		public UnityEngine.UI.Text GetRecordText(int index) => default; // 0x0000000184ADD900-0x0000000184ADD9E0
		// [XID] // 0x0000000189AD2620-0x0000000189AD2640
		public UnityEngine.UI.Text GetRecordNumText(int index) => default; // 0x0000000184ADD810-0x0000000184ADD900
	}
}
