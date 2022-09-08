/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAttackModeBtn : MonoActionBtn // TypeDefIndex: 31099
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected AttackMode _attackMode; // 0x58
		private int _triggerSkillID; // 0x5C
		private CanvasGroup _cdGroup; // 0x60
	
		// Nested types
		public enum AttackMode // TypeDefIndex: 31100
		{
			Normal = 0,
			Focus = 1,
			NormalOnly = 2
		}
	
		// Constructors
		public MonoAttackModeBtn() {} // 0x0000000184C9A950-0x0000000184C9A9E0
	
		// Methods
		// [XID] // 0x000000018963DE40-0x000000018963DE60
		public void Start() {} // 0x0000000184C9A620-0x0000000184C9A7A0
		// [XID] // 0x00000001896457F0-0x0000000189645810
		protected override void Update() {} // 0x0000000184C9A7A0-0x0000000184C9A950
		// [XID] // 0x000000018964CF70-0x000000018964CF90
		public override bool OnRealPointerDown(PointerEventData eventData) => default; // 0x0000000184C9A230-0x0000000184C9A3D0
		// [XID] // 0x0000000189654700-0x0000000189654720
		protected override void HandlePointDown() {} // 0x0000000184C9A170-0x0000000184C9A230
		// [XID] // 0x000000018965BE10-0x000000018965BE30
		public override void ResetButton() {} // 0x0000000184C9A430-0x0000000184C9A570
		// [XID] // 0x0000000189663400-0x0000000189663420
		private void OnAttackMode(bool focusAttackMode) {} // 0x0000000184C99F30-0x0000000184C9A170
		// [XID] // 0x000000018966AE10-0x000000018966AE30
		public void SetupSkillView(int triggerSkillID) {} // 0x0000000184C9A570-0x0000000184C9A620
		// [XID] // 0x0000000189672A10-0x0000000189672A30
		public bool CheckActive(ActionPanelState state, bool isNormal) => default; // 0x0000000184C99C60-0x0000000184C99E70
	}
}
