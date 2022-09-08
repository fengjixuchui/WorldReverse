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
	public class MonoWeeklyBossResinDiscountInfo : MonoBehaviour // TypeDefIndex: 31019
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpHalfNum; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _resinCostNumTxt; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _originalResinCostNumTxt; // 0x28
	
		// Constructors
		public MonoWeeklyBossResinDiscountInfo() {} // 0x00000001824A7DB0-0x00000001824A7E20
	
		// Methods
		// [XID] // 0x0000000189B40EB0-0x0000000189B40ED0
		public void CheckShowResinDiscount(uint discountNum, uint discountNumLimit, uint resinCost, uint originalResinCost) {} // 0x00000001824A7860-0x00000001824A7980
		// [XID] // 0x0000000189B48800-0x0000000189B48820
		public void ShowResinDiscountInfo(uint originalResinCost, uint resinCost) {} // 0x00000001824A7BE0-0x00000001824A7DB0
		// [XID] // 0x0000000189B4FF90-0x0000000189B4FFB0
		public void ShowNormalResinInfo(uint originalResinCost) {} // 0x00000001824A7A50-0x00000001824A7BE0
		// [XID] // 0x0000000189B57760-0x0000000189B57780
		public void CloseResinDiscountInfo() {} // 0x00000001824A7980-0x00000001824A7A50
	}
}
