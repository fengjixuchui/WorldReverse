/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoypadInputHandlerBase : MonoJoypadUIModule // TypeDefIndex: 30641
	{
		// Fields
		// [Header] // 0x00000001898CC910-0x00000001898CC960
		[SerializeField] // 0x00000001898CC910-0x00000001898CC960
		protected MonoJoypadNavRegionBase _region; // 0x68
		[SerializeField] // 0x00000001898D8B90-0x00000001898D8BE0
		// [Tooltip] // 0x00000001898D8B90-0x00000001898D8BE0
		protected bool _selectItemOnFocus; // 0x70
		[SerializeField] // 0x00000001898E5010-0x00000001898E5050
		// [Tooltip] // 0x00000001898E5010-0x00000001898E5050
		protected bool _cancelItemOnLostFocus; // 0x71
		protected bool _delaySelectItemOnFocus; // 0x72
		[SerializeField] // 0x00000001898EFB40-0x00000001898EFB90
		// [Tooltip] // 0x00000001898EFB40-0x00000001898EFB90
		protected int _resetIndexOnFocus; // 0x74
		protected MonoAudioSelectChangeEvent2D _selectChangeEvent; // 0x78
	
		// Constructors
		public MonoJoypadInputHandlerBase() {} // 0x0000000183F838D0-0x0000000183F83950
	
		// Methods
		// [XID] // 0x00000001898FBA80-0x00000001898FBAA0
		public void SetNavRegion(MonoJoypadNavRegionBase region) {} // 0x0000000183F83820-0x0000000183F838D0
		// [XID] // 0x0000000189903450-0x0000000189903470
		protected override void Init() {} // 0x0000000183F82CF0-0x0000000183F82DB0
		// [XID] // 0x000000018990A9A0-0x000000018990A9C0
		protected override JoypadCrossNavDir ContextToNavDir(ContextEventType context) => default; // 0x0000000183F83670-0x0000000183F837A0
		// [XID] // 0x0000000189912630-0x0000000189912650
		protected void TryPlaySelectChangeSound() {} // 0x0000000183F833F0-0x0000000183F834E0
		// [XID] // 0x0000000189919F00-0x0000000189919F20
		public override void HandleNavigateToTarget(MonoJoypadUIModule navTarget) {} // 0x0000000183F834E0-0x0000000183F83670
		// [XID] // 0x0000000189921720-0x0000000189921740
		protected void SetHighlight(ItemHighlightType itemHighlightType, Transform trans, bool select) {} // 0x0000000183F82DB0-0x0000000183F833F0
	}
}
