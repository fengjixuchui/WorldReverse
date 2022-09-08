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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTeamButtonContainer : MonoBehaviour // TypeDefIndex: 29778
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _content; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _teamButtonPrefab; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _multiplayerPanel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _mpItemList; // 0x30
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.Material _deadMaterial; // 0x38
		private Queue<MonoTeamBtn> _buttonPool; // 0x40
	
		// Properties
		public bool showMultiplayerPanel { /* [XID] */ /* 0x0000000189B1A630-0x0000000189B1A650 */ set {} } // 0x0000000183B5F170-0x0000000183B5F250
		public MonoReusableList mpItemList { /* [XID] */ /* 0x0000000189B21BC0-0x0000000189B21BE0 */ get => default; } // 0x0000000183B5F0D0-0x0000000183B5F170 
		public UnityEngine.Material deadMaterial { /* [XID] */ /* 0x0000000189B292C0-0x0000000189B292E0 */ get => default; } // 0x0000000183B5F030-0x0000000183B5F0D0 
	
		// Constructors
		public MonoTeamButtonContainer() {} // 0x0000000183B5EF80-0x0000000183B5F030
	
		// Methods
		// [XID] // 0x0000000189B0BA50-0x0000000189B0BA70
		public MonoTeamBtn GetUnusedButton() => default; // 0x0000000183B5EB20-0x0000000183B5EC90
		// [XID] // 0x0000000189B12F20-0x0000000189B12F40
		public void Reuse(MonoTeamBtn button) {} // 0x0000000183B5EE60-0x0000000183B5EF80
		// [XID] // 0x0000000189B306D0-0x0000000189B306F0
		public void ResetButtonTransform() {} // 0x0000000183B5EC90-0x0000000183B5EE60
	}
}
