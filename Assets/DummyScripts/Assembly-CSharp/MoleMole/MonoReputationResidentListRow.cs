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
	public class MonoReputationResidentListRow : MonoBehaviour // TypeDefIndex: 30883
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _npcIcon; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _npcName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _descBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpUnable; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpInprogress; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpCompleted; // 0x40
	
		// Properties
		public Image npcIcon { /* [XID] */ /* 0x0000000189BD1710-0x0000000189BD1730 */ get => default; } // 0x000000018443DD10-0x000000018443DDB0 
		public string npcName { /* [XID] */ /* 0x0000000189BD8D00-0x0000000189BD8D20 */ set {} } // 0x000000018443DDB0-0x000000018443DE80
		public Button descBtn { /* [XID] */ /* 0x00000001895E58E0-0x00000001895E5900 */ get => default; } // 0x000000018443DC70-0x000000018443DD10 
		public RewardState rewardState { /* [XID] */ /* 0x00000001895ED230-0x00000001895ED250 */ set {} } // 0x000000018443DE80-0x000000018443E0B0
	
		// Constructors
		public MonoReputationResidentListRow() {} // 0x000000018443DBF0-0x000000018443DC70
	}
}
