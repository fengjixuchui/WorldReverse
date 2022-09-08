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
	public class MonoActivityMistTrialDungeonEntry : MonoUIProxy, INavSelectable // TypeDefIndex: 30346
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockMask; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtLock; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selected; // 0x68
		private State _state; // 0x70
		private uint _openTime; // 0x74
		private ActivityMistTrialLevelDataExcelConfig _levelConfig; // 0x78
	
		// Properties
		public Button actionBtn { /* [XID] */ /* 0x000000018999B0E0-0x000000018999B100 */ get => default; } // 0x0000000186320710-0x00000001863207B0 
		public GameObject lockMask { /* [XID] */ /* 0x00000001899A2900-0x00000001899A2920 */ get => default; } // 0x00000001863208F0-0x0000000186320990 
		public Image icon { /* [XID] */ /* 0x00000001899AA220-0x00000001899AA240 */ get => default; } // 0x00000001863207B0-0x0000000186320850 
		public UnityEngine.UI.Text txtLock { /* [XID] */ /* 0x00000001899B1C10-0x00000001899B1C30 */ get => default; } // 0x0000000186320B70-0x0000000186320C10 
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x00000001899B8F80-0x00000001899B8FA0 */ get => default; } // 0x0000000186320C10-0x0000000186320CB0 
		public GameObject selected { /* [XID] */ /* 0x00000001899C0870-0x00000001899C0890 */ get => default; } // 0x0000000186320A30-0x0000000186320AD0 
		public State state { /* [XID] */ /* 0x00000001899C80C0-0x00000001899C80E0 */ get => default; } // 0x0000000186320AD0-0x0000000186320B70 
		public uint openTime { /* [XID] */ /* 0x00000001899CFA40-0x00000001899CFA60 */ get => default; /* [XID] */ /* 0x00000001899D6DD0-0x00000001899D6DF0 */ private set {} } // 0x0000000186320990-0x0000000186320A30 0x00000001863201D0-0x0000000186320280
		public ActivityMistTrialLevelDataExcelConfig levelConfig { /* [XID] */ /* 0x00000001899DE420-0x00000001899DE440 */ get => default; } // 0x0000000186320850-0x00000001863208F0 
	
		// Nested types
		public enum State // TypeDefIndex: 30347
		{
			Invalid = 0,
			Closed = 1,
			Opened = 2
		}
	
		// Constructors
		public MonoActivityMistTrialDungeonEntry() {} // 0x0000000186320680-0x0000000186320710
	
		// Methods
		// [XID] // 0x00000001899E60C0-0x00000001899E60E0
		public void SetupPanel(ActivityMistTrialLevelDataExcelConfig levelConfig) {} // 0x0000000186320520-0x00000001863205E0
		// [XID] // 0x00000001899ED490-0x00000001899ED4B0
		private void Refresh() {} // 0x000000018631FDF0-0x000000018631FEA0
		// [XID] // 0x00000001899F5000-0x00000001899F5020
		private void RefreshTitleAndIcon() {} // 0x0000000186320280-0x0000000186320400
		// [XID] // 0x00000001899FC570-0x00000001899FC590
		private void CheckOpen() {} // 0x000000018631FEA0-0x0000000186320110
		// [XID] // 0x0000000189A03B40-0x0000000189A03B60
		public void Update() {} // 0x00000001863205E0-0x0000000186320680
		// [XID] // 0x0000000189A0B090-0x0000000189A0B0B0
		public void SetNavSelected(bool active) {} // 0x0000000186320400-0x0000000186320520
	}
}
