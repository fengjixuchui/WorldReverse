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
	public class MonoChannellerSlabWaveRow : MonoBehaviour, IJoypadSelect // TypeDefIndex: 30050
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _waveTitle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _waveDesc; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _foldTrans; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _openTrans; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _selectTrans; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UIDButton _actionBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _backBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _normalWave; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _oneOffDungeon; // 0x68
		private int _waitOneFrame; // 0x70
		private bool _toOpen; // 0x74
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _oneOffDungeonTitle; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _oneOffDungeonInProgress; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _oneOffDungeonFinish; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _gotoOneOffDungeonDialog; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _oneOffDungeonAtor; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _oneOffSelectTrans; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _dungeonLock; // 0xA8
	
		// Properties
		public UnityEngine.UI.Text waveTitle { /* [XID] */ /* 0x0000000189ABBDB0-0x0000000189ABBDD0 */ get => default; } // 0x000000018480F4B0-0x000000018480F550 
		public UnityEngine.UI.Text waveDesc { /* [XID] */ /* 0x0000000189AC3580-0x0000000189AC35A0 */ get => default; } // 0x000000018480F410-0x000000018480F4B0 
		public UIDButton actionBtn { /* [XID] */ /* 0x0000000189ACAC30-0x0000000189ACAC50 */ get => default; } // 0x000000018480F020-0x000000018480F0C0 
		public Button backBtn { /* [XID] */ /* 0x0000000189AD2680-0x0000000189AD26A0 */ get => default; } // 0x000000018480F0C0-0x000000018480F160 
		public Animator oneOffDungeonAtor { /* [XID] */ /* 0x0000000189B0E8B0-0x0000000189B0E8D0 */ get => default; } // 0x000000018480F210-0x000000018480F2C0 
		public UnityEngine.UI.Text oneOffDungeonTitle { /* [XID] */ /* 0x0000000189B15CA0-0x0000000189B15CC0 */ get => default; } // 0x000000018480F370-0x000000018480F410 
		public UnityEngine.UI.Text oneOffDungeonProgress { /* [XID] */ /* 0x0000000189B1D3B0-0x0000000189B1D3D0 */ get => default; } // 0x000000018480F2C0-0x000000018480F370 
		public Button gotoOneOffDungeonDialog { /* [XID] */ /* 0x0000000189B24C30-0x0000000189B24C50 */ get => default; } // 0x000000018480F160-0x000000018480F210 
	
		// Constructors
		public MonoChannellerSlabWaveRow() {} // 0x000000018480EF50-0x000000018480F020
	
		// Methods
		// [XID] // 0x0000000189ADA0D0-0x0000000189ADA0F0
		public void SetSelected(bool bSelected) {} // 0x000000018480E9D0-0x000000018480EAD0
		// [XID] // 0x0000000189AE19D0-0x0000000189AE19F0
		public void SetState(int state) {} // 0x000000018480EAD0-0x000000018480EBB0
		// [XID] // 0x0000000189AE9180-0x0000000189AE91A0
		public void SetAnimatorState(bool bShow) {} // 0x000000018480E690-0x000000018480E7A0
		// [XID] // 0x0000000189AF0F70-0x0000000189AF0F90
		public void SetOpenedState(bool isOpened) {} // 0x000000018480E8C0-0x000000018480E9D0
		// [XID] // 0x0000000189AF83F0-0x0000000189AF8410
		private void Update() {} // 0x000000018480ECB0-0x000000018480EF50
		// [XID] // 0x0000000189AFFB00-0x0000000189AFFB20
		public void ShowNormalWave(bool isNormal) {} // 0x000000018480EBB0-0x000000018480ECB0
		// [XID] // 0x0000000189B07070-0x0000000189B07090
		public void SetOneOffDungeonState(int state) {} // 0x000000018480E7A0-0x000000018480E8C0
	}
}
