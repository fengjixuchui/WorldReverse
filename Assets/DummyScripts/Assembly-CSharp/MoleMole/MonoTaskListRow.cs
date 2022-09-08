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
	public class MonoTaskListRow : MonoBehaviour // TypeDefIndex: 30947
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _areaText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _positionBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _completeImg; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvas; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockGrp; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadSimpleResuableListHandler _joypadListhandler; // 0x60
		private bool _hightlighted; // 0x68
	
		// Properties
		public MonoJoypadSimpleResuableListHandler joypadListhandler { /* [XID] */ /* 0x00000001898AD550-0x00000001898AD570 */ get => default; } // 0x0000000183B589F0-0x0000000183B58A90 
		public UnityEngine.UI.Text nameText { /* [XID] */ /* 0x00000001898B4AB0-0x00000001898B4AD0 */ get => default; } // 0x0000000183B58B30-0x0000000183B58BD0 
		public UnityEngine.UI.Text areaText { /* [XID] */ /* 0x00000001898BC640-0x00000001898BC660 */ get => default; } // 0x0000000183B58770-0x0000000183B58810 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x00000001898C3C00-0x00000001898C3C20 */ get => default; } // 0x0000000183B58C70-0x0000000183B58D10 
		public Button positionBtn { /* [XID] */ /* 0x00000001898CB460-0x00000001898CB480 */ get => default; } // 0x0000000183B58BD0-0x0000000183B58C70 
		public Image completeImg { /* [XID] */ /* 0x00000001898D2BB0-0x00000001898D2BD0 */ get => default; } // 0x0000000183B588B0-0x0000000183B58950 
		public CanvasGroup canvas { /* [XID] */ /* 0x00000001898DA4C0-0x00000001898DA4E0 */ get => default; } // 0x0000000183B58810-0x0000000183B588B0 
		public Button actionBtn { /* [XID] */ /* 0x00000001898E2190-0x00000001898E21B0 */ get => default; } // 0x0000000183B586D0-0x0000000183B58770 
		public GameObject lockGrp { /* [XID] */ /* 0x00000001898E9D70-0x00000001898E9D90 */ get => default; } // 0x0000000183B58A90-0x0000000183B58B30 
		public bool highlight { /* [XID] */ /* 0x00000001898F14A0-0x00000001898F14C0 */ get => default; /* [XID] */ /* 0x00000001898F8C40-0x00000001898F8C60 */ set {} } // 0x0000000183B58950-0x0000000183B589F0 0x0000000183B58D10-0x0000000183B58EF0
	
		// Constructors
		public MonoTaskListRow() {} // 0x0000000183B58640-0x0000000183B586D0
	}
}
