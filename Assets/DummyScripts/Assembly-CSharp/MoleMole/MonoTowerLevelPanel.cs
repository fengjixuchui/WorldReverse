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
	public class MonoTowerLevelPanel : MonoBehaviour // TypeDefIndex: 30957
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _floorItem; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _factorItemList; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _levelScroller; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _startFloorText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _doubleTeamText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _upOffset; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _downOffset; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x50
	
		// Properties
		public MonoSimpleReusableList floorItem { /* [XID] */ /* 0x0000000189BDEE90-0x0000000189BDEEB0 */ get => default; } // 0x0000000184885070-0x0000000184885110 
		public MonoSimpleReusableList factorItemList { /* [XID] */ /* 0x00000001895EBB20-0x00000001895EBB40 */ get => default; } // 0x0000000184884FD0-0x0000000184885070 
		public MonoGridScroller levelScroller { /* [XID] */ /* 0x00000001895F2EA0-0x00000001895F2EC0 */ get => default; } // 0x0000000184885110-0x00000001848851B0 
		public UnityEngine.UI.Text startFloorText { /* [XID] */ /* 0x00000001895FA700-0x00000001895FA720 */ get => default; } // 0x00000001848851B0-0x0000000184885250 
		public UnityEngine.UI.Text doubleTeamText { /* [XID] */ /* 0x00000001896020C0-0x00000001896020E0 */ get => default; } // 0x0000000184884E80-0x0000000184884F20 
		public UnityEngine.UI.Text unlockText { /* [XID] */ /* 0x00000001896098A0-0x00000001896098C0 */ get => default; } // 0x00000001848852F0-0x0000000184885390 
		public float upOffset { /* [XID] */ /* 0x00000001896110C0-0x00000001896110E0 */ get => default; } // 0x0000000184885390-0x0000000184885440 
		public float downOffset { /* [XID] */ /* 0x0000000189618A90-0x0000000189618AB0 */ get => default; } // 0x0000000184884F20-0x0000000184884FD0 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189620020-0x0000000189620040 */ get => default; } // 0x0000000184885250-0x00000001848852F0 
	
		// Constructors
		public MonoTowerLevelPanel() {} // 0x0000000184884DF0-0x0000000184884E80
	}
}
