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
	public class MonoReputationQuestListRow : MonoBehaviour // TypeDefIndex: 31027
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _questIcon; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _questTitle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reputationValue; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _reputationIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpUnable; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpCompleted; // 0x48
	
		// Properties
		public Image questIcon { /* [XID] */ /* 0x000000018989FA30-0x000000018989FA50 */ get => default; } // 0x000000018443C8F0-0x000000018443C990 
		public string questTitle { /* [XID] */ /* 0x00000001898A7460-0x00000001898A7480 */ set {} } // 0x000000018443CA30-0x000000018443CB00
		public string reputationValue { /* [XID] */ /* 0x00000001898AEE20-0x00000001898AEE40 */ set {} } // 0x000000018443CB00-0x000000018443CBD0
		public Image reputationIcon { /* [XID] */ /* 0x00000001898B6230-0x00000001898B6250 */ get => default; } // 0x000000018443C990-0x000000018443CA30 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x00000001898BDAC0-0x00000001898BDAE0 */ get => default; } // 0x000000018443C850-0x000000018443C8F0 
		public RewardState rewardState { /* [XID] */ /* 0x00000001898C53A0-0x00000001898C53C0 */ set {} } // 0x000000018443CBD0-0x000000018443CDF0
	
		// Constructors
		public MonoReputationQuestListRow() {} // 0x000000018443C7D0-0x000000018443C850
	}
}
