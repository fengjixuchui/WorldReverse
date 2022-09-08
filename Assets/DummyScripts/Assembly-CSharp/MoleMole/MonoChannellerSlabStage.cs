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
	public class MonoChannellerSlabStage : MonoBehaviour, IJoypadSelect // TypeDefIndex: 30049
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _stageName; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _select; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UIDButton _button; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _stage; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _dungeon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lock; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _goto; // 0x50
	
		// Properties
		public UnityEngine.UI.Text StageName { /* [XID] */ /* 0x0000000189A082A0-0x0000000189A082C0 */ get => default; } // 0x000000018480E130-0x000000018480E1D0 
		public UnityEngine.UI.Text Desc { /* [XID] */ /* 0x0000000189A0F720-0x0000000189A0F740 */ get => default; } // 0x000000018480E090-0x000000018480E130 
		public UIDButton Button { /* [XID] */ /* 0x0000000189A16D60-0x0000000189A16D80 */ get => default; } // 0x000000018480DFF0-0x000000018480E090 
	
		// Constructors
		public MonoChannellerSlabStage() {} // 0x000000018480DF60-0x000000018480DFF0
	
		// Methods
		// [XID] // 0x0000000189A1E3C0-0x0000000189A1E3E0
		public void SetSelected(bool bSelected) {} // 0x000000018480DE80-0x000000018480DF60
		// [XID] // 0x0000000189A25AC0-0x0000000189A25AE0
		public void SetIsStage(bool isStage) {} // 0x000000018480DD70-0x000000018480DE80
		// [XID] // 0x0000000189A2CF40-0x0000000189A2CF60
		public void SetIsLocked(bool isLocked) {} // 0x000000018480DC70-0x000000018480DD70
	}
}
