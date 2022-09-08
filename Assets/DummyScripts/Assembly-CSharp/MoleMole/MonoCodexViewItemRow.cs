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
	public class MonoCodexViewItemRow : MonoBehaviour // TypeDefIndex: 30512
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _areaText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectMark; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockMark; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _image; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redpointMark; // 0x48
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189BAD4E0-0x0000000189BAD500 */ get => default; } // 0x0000000184BAB470-0x0000000184BAB510 
		public UnityEngine.UI.Text areaText { /* [XID] */ /* 0x0000000189BB4C70-0x0000000189BB4C90 */ get => default; } // 0x0000000184BAB290-0x0000000184BAB330 
		public Button button { /* [XID] */ /* 0x0000000189BBC240-0x0000000189BBC260 */ get => default; } // 0x0000000184BAB330-0x0000000184BAB3D0 
		public Image image { /* [XID] */ /* 0x0000000189BC3F80-0x0000000189BC3FA0 */ get => default; } // 0x0000000184BAB3D0-0x0000000184BAB470 
		public bool isNavSelected { /* [XID] */ /* 0x0000000189BCB8E0-0x0000000189BCB900 */ set {} } // 0x0000000184BAB510-0x0000000184BAB600
		public bool isUnlocked { /* [XID] */ /* 0x0000000189BD2E80-0x0000000189BD2EA0 */ set {} } // 0x0000000184BAB600-0x0000000184BAB6F0
	
		// Constructors
		public MonoCodexViewItemRow() {} // 0x0000000184BAB210-0x0000000184BAB290
	
		// Methods
		// [XID] // 0x0000000189BDA600-0x0000000189BDA620
		public void SetRedPoint(bool show) {} // 0x0000000184BAB120-0x0000000184BAB210
	}
}
