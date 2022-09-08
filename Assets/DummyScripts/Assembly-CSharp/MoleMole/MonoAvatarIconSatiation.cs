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
	public class MonoAvatarIconSatiation : MonoBehaviour // TypeDefIndex: 30401
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _imgFill; // 0x20
		private float _ratio; // 0x28
		private int PARAM_HUNGER_STATE_HUNGRY; // 0x2C
		private int PARAM_HUNGER_STATE_ORDINARY; // 0x30
		private int PARAM_HUNGER_STATE_ALMOST; // 0x34
		private int PARAM_HUNGER_STATE_FULL; // 0x38
		private int PARAM_HUNGER; // 0x3C
		private bool _forceRefresh; // 0x40
	
		// Properties
		public bool forceRefresh { /* [XID] */ /* 0x0000000189633730-0x0000000189633750 */ get => default; /* [XID] */ /* 0x000000018963AFF0-0x000000018963B010 */ set {} } // 0x000000018421C680-0x000000018421C720 0x000000018421C7D0-0x000000018421C880
		public float satiationRatio { /* [XID] */ /* 0x00000001896426E0-0x0000000189642700 */ get => default; /* [XID] */ /* 0x0000000189649DF0-0x0000000189649E10 */ set {} } // 0x000000018421C720-0x000000018421C7D0 0x000000018421C880-0x000000018421C9D0
	
		// Constructors
		public MonoAvatarIconSatiation() {} // 0x000000018421C5E0-0x000000018421C680
	
		// Methods
		// [XID] // 0x0000000189651510-0x0000000189651530
		private int GetSatiationRank(float ratio) => default; // 0x000000018421C4E0-0x000000018421C5E0
	}
}
