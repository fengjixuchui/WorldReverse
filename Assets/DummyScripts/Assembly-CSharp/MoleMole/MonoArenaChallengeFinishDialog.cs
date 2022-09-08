/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoArenaChallengeFinishDialog : MonoUIProxy // TypeDefIndex: 30101
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _monoSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _quitGo; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _againGO; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtQuitTime; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitleSucc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitleFail; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtSubTitleSucc; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtSubTitleFail; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCond1Succ; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCond1Fail; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCond2Succ; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCond2Fail; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCond3Succ; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCond3Fail; // 0xA8
		private List<UnityEngine.UI.Text> _txtCondSuccList; // 0xB0
		private List<UnityEngine.UI.Text> _txtCondFailList; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTipsSucc; // 0xC0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animCond1Succ; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animCond1Fail; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animCond2Succ; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animCond2Fail; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animCond3Succ; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animCond3Fail; // 0xF0
		private List<Animator> _animCondSuccList; // 0xF8
		private List<Animator> _animCondFailList; // 0x100
	
		// Properties
		public MonoElementSwitch monoSwitch { /* [XID] */ /* 0x0000000189A3D700-0x0000000189A3D720 */ get => default; } // 0x0000000184C90970-0x0000000184C90A10 
		public GameObject quitGo { /* [XID] */ /* 0x0000000189A44E00-0x0000000189A44E20 */ get => default; } // 0x0000000184C90A10-0x0000000184C90AB0 
		public GameObject againGO { /* [XID] */ /* 0x0000000189A4C600-0x0000000189A4C620 */ get => default; } // 0x0000000184C90250-0x0000000184C902F0 
		public UnityEngine.UI.Text txtQuitTime { /* [XID] */ /* 0x0000000189A53DA0-0x0000000189A53DC0 */ get => default; } // 0x0000000184C91170-0x0000000184C91210 
		public UnityEngine.UI.Text txtTitleSucc { /* [XID] */ /* 0x0000000189A5B7D0-0x0000000189A5B7F0 */ get => default; } // 0x0000000184C914A0-0x0000000184C91540 
		public UnityEngine.UI.Text txtTitleFail { /* [XID] */ /* 0x0000000189A62EC0-0x0000000189A62EE0 */ get => default; } // 0x0000000184C91400-0x0000000184C914A0 
		public UnityEngine.UI.Text txtSubTitleSucc { /* [XID] */ /* 0x0000000189A6A9E0-0x0000000189A6AA00 */ get => default; } // 0x0000000184C912B0-0x0000000184C91350 
		public UnityEngine.UI.Text txtSubTitleFail { /* [XID] */ /* 0x0000000189A720C0-0x0000000189A720E0 */ get => default; } // 0x0000000184C91210-0x0000000184C912B0 
		public UnityEngine.UI.Text txtCond1Succ { /* [XID] */ /* 0x0000000189A79D20-0x0000000189A79D40 */ get => default; } // 0x0000000184C90B60-0x0000000184C90C10 
		public UnityEngine.UI.Text txtCond1Fail { /* [XID] */ /* 0x0000000189A811C0-0x0000000189A811E0 */ get => default; } // 0x0000000184C90AB0-0x0000000184C90B60 
		public UnityEngine.UI.Text txtCond2Succ { /* [XID] */ /* 0x0000000189A88BE0-0x0000000189A88C00 */ get => default; } // 0x0000000184C90CC0-0x0000000184C90D70 
		public UnityEngine.UI.Text txtCond2Fail { /* [XID] */ /* 0x0000000189A90390-0x0000000189A903B0 */ get => default; } // 0x0000000184C90C10-0x0000000184C90CC0 
		public UnityEngine.UI.Text txtCond3Succ { /* [XID] */ /* 0x0000000189A97B80-0x0000000189A97BA0 */ get => default; } // 0x0000000184C90E20-0x0000000184C90ED0 
		public UnityEngine.UI.Text txtCond3Fail { /* [XID] */ /* 0x0000000189A9EF50-0x0000000189A9EF70 */ get => default; } // 0x0000000184C90D70-0x0000000184C90E20 
		public List<UnityEngine.UI.Text> txtCondSuccList { /* [XID] */ /* 0x0000000189AA68B0-0x0000000189AA68D0 */ get => default; } // 0x0000000184C91020-0x0000000184C91170 
		public List<UnityEngine.UI.Text> txtCondFailList { /* [XID] */ /* 0x0000000189AADF00-0x0000000189AADF20 */ get => default; } // 0x0000000184C90ED0-0x0000000184C91020 
		public UnityEngine.UI.Text txtTipsSucc { /* [XID] */ /* 0x0000000189AB5890-0x0000000189AB58B0 */ get => default; } // 0x0000000184C91350-0x0000000184C91400 
		public Animator animCond1Succ { /* [XID] */ /* 0x0000000189ABD230-0x0000000189ABD250 */ get => default; } // 0x0000000184C903A0-0x0000000184C90450 
		public Animator animCond1Fail { /* [XID] */ /* 0x0000000189AC4CA0-0x0000000189AC4CC0 */ get => default; } // 0x0000000184C902F0-0x0000000184C903A0 
		public Animator animCond2Succ { /* [XID] */ /* 0x0000000189ACC320-0x0000000189ACC340 */ get => default; } // 0x0000000184C90500-0x0000000184C905B0 
		public Animator animCond2Fail { /* [XID] */ /* 0x0000000189AD3E00-0x0000000189AD3E20 */ get => default; } // 0x0000000184C90450-0x0000000184C90500 
		public Animator animCond3Succ { /* [XID] */ /* 0x0000000189ADB900-0x0000000189ADB920 */ get => default; } // 0x0000000184C90660-0x0000000184C90710 
		public Animator animCond3Fail { /* [XID] */ /* 0x0000000189AE31E0-0x0000000189AE3200 */ get => default; } // 0x0000000184C905B0-0x0000000184C90660 
		public List<Animator> animCondSuccList { /* [XID] */ /* 0x0000000189AEABD0-0x0000000189AEABF0 */ get => default; } // 0x0000000184C90840-0x0000000184C90970 
		public List<Animator> animCondFailList { /* [XID] */ /* 0x0000000189AF24A0-0x0000000189AF24C0 */ get => default; } // 0x0000000184C90710-0x0000000184C90840 
	
		// Constructors
		public MonoArenaChallengeFinishDialog() {} // 0x0000000184C90150-0x0000000184C90250
	
		// Methods
		// [XID] // 0x0000000189AF9E40-0x0000000189AF9E60
		public void SetSucc() {} // 0x0000000184C90090-0x0000000184C90150
		// [XID] // 0x0000000189B013B0-0x0000000189B013D0
		public void SetFail() {} // 0x0000000184C8FFD0-0x0000000184C90090
	}
}
