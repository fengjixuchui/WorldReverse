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
	public class MonoActivityMistTrialQuestRow : MonoUIProxy // TypeDefIndex: 30348
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtRowTitle; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtProgress; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardReusableList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeGO; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _inProgressGO; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtn; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnBG; // 0x78
	
		// Properties
		public UnityEngine.UI.Text txtRowTitle { /* [XID] */ /* 0x0000000189A58380-0x0000000189A583A0 */ get => default; } // 0x0000000186321330-0x00000001863213D0 
		public UnityEngine.UI.Text txtProgress { /* [XID] */ /* 0x0000000189A5FE40-0x0000000189A5FE60 */ get => default; } // 0x0000000186321290-0x0000000186321330 
		public MonoSimpleReusableList rewardReusableList { /* [XID] */ /* 0x0000000189A67B00-0x0000000189A67B20 */ get => default; } // 0x00000001863211F0-0x0000000186321290 
		public GameObject completeGO { /* [XID] */ /* 0x0000000189A6EF10-0x0000000189A6EF30 */ get => default; } // 0x0000000186321010-0x00000001863210B0 
		public GameObject inProgressGO { /* [XID] */ /* 0x0000000189A76750-0x0000000189A76770 */ get => default; } // 0x0000000186321150-0x00000001863211F0 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189A7E060-0x0000000189A7E080 */ get => default; } // 0x00000001863210B0-0x0000000186321150 
		public GameObject btnGrp { /* [XID] */ /* 0x0000000189A859A0-0x0000000189A859C0 */ get => default; } // 0x0000000186320F70-0x0000000186321010 
		public GameObject btnBG { /* [XID] */ /* 0x0000000189A8D2A0-0x0000000189A8D2C0 */ get => default; } // 0x0000000186320ED0-0x0000000186320F70 
	
		// Nested types
		public enum State // TypeDefIndex: 30349
		{
			InProgress = 0,
			ReadyToClaim = 1,
			Complete = 2,
			InDungeon = 3
		}
	
		// Constructors
		public MonoActivityMistTrialQuestRow() {} // 0x0000000186320E40-0x0000000186320ED0
	
		// Methods
		// [XID] // 0x0000000189A947C0-0x0000000189A947E0
		public void SetState(State state) {} // 0x0000000186320CB0-0x0000000186320E40
	}
}
