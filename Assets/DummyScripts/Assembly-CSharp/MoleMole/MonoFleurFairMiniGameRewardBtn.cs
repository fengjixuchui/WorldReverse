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
	public class MonoFleurFairMiniGameRewardBtn : MonoBehaviour // TypeDefIndex: 30381
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btn; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _receive; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _complete; // 0x28
	
		// Properties
		public Button button { /* [XID] */ /* 0x00000001897FC190-0x00000001897FC1B0 */ get => default; } // 0x0000000184ADC180-0x0000000184ADC220 
		public EState state { /* [XID] */ /* 0x0000000189803650-0x0000000189803690 */ get; /* [XID] */ /* 0x000000018980DAD0-0x000000018980DB10 */ private set; } // 0x0000000184ADC220-0x0000000184ADC280 0x0000000184ADBF00-0x0000000184ADBF60
	
		// Nested types
		public enum EState // TypeDefIndex: 30382
		{
			Normal = 0,
			CanReceive = 1,
			Complete = 2
		}
	
		// Constructors
		public MonoFleurFairMiniGameRewardBtn() {} // 0x0000000184ADC110-0x0000000184ADC180
	
		// Methods
		// [XID] // 0x0000000189818610-0x0000000189818630
		public void SetState(EState eState) {} // 0x0000000184ADBF60-0x0000000184ADC110
	}
}
