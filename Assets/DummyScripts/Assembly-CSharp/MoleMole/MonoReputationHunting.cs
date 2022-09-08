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
	public class MonoReputationHunting : MonoUIProxy // TypeDefIndex: 31022
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> _huntingStars; // 0x40
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _iconMonster; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconBg; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _objUnknown; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _objTracking; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _iconMonsterShadowColor; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _iconBgShadowColor; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _iconMonsterNormalColor; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _iconBgNormalColor; // 0x98
	
		// Properties
		public Image iconMonster { /* [XID] */ /* 0x00000001896BCED0-0x00000001896BCEF0 */ get => default; } // 0x0000000184439410-0x00000001844394B0 
		public int huntingLevel { /* [XID] */ /* 0x00000001896C43B0-0x00000001896C43D0 */ set {} } // 0x00000001844394B0-0x0000000184439610
		public virtual RewardState rewardState { /* [XID] */ /* 0x00000001896CB9F0-0x00000001896CBA10 */ set {} } // 0x0000000184439610-0x00000001844398E0
	
		// Constructors
		public MonoReputationHunting() {} // 0x0000000184439390-0x0000000184439410
	}
}
