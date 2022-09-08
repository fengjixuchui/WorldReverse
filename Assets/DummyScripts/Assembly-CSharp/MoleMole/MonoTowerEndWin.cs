/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTowerEndWin : MonoBehaviour // TypeDefIndex: 31312
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		public Text timeInfo; // 0x20
		public GameObject[] starOn; // 0x28
		public GameObject[] starOff; // 0x30
		public Text[] starConditionTxt; // 0x38
		public GameObject rewardPanel; // 0x40
		public MonoGridScroller firstPassRewardScroller; // 0x48
		public Text nextLevelTip; // 0x50
	
		// Properties
		public MonoUIContainer exitContainer { /* [XID] */ /* 0x0000000189AE2FD0-0x0000000189AE2FF0 */ get => default; } // 0x0000000184883C00-0x0000000184883D10 
		public MonoUIContainer continueContainer { /* [XID] */ /* 0x0000000189AEA9D0-0x0000000189AEA9F0 */ get => default; } // 0x0000000184883A30-0x0000000184883B40 
		public MonoUIContainer detailContainer { /* [XID] */ /* 0x0000000189AF22C0-0x0000000189AF22E0 */ get => default; } // 0x0000000184883B40-0x0000000184883C00 
	
		// Constructors
		public MonoTowerEndWin() {} // 0x00000001848839C0-0x0000000184883A30
	}
}
