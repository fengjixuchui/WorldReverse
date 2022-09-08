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
	public class MonoLevelChallengeSubRow : MonoReusableListItem // TypeDefIndex: 31244
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitle; // 0x28
		private SubChallengeStatus _subChallengeStatus; // 0x30
	
		// Properties
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x0000000189B79AF0-0x0000000189B79B10 */ get => default; } // 0x0000000183F997A0-0x0000000183F99840 
		public SubChallengeStatus subChallengeStatus { /* [XID] */ /* 0x0000000189B81260-0x0000000189B81280 */ get => default; /* [XID] */ /* 0x0000000189B889F0-0x0000000189B88A10 */ set {} } // 0x0000000183F99700-0x0000000183F997A0 0x0000000183F99840-0x0000000183F99950
	
		// Constructors
		public MonoLevelChallengeSubRow() {} // 0x0000000183F99690-0x0000000183F99700
	
		// Methods
		// [XID] // 0x0000000189B8FEA0-0x0000000189B8FEC0
		public void TriggerAnimatorComplete() {} // 0x0000000183F99290-0x0000000183F99390
		// [XID] // 0x0000000189B972E0-0x0000000189B97300
		public void TriggerAnimatorFail() {} // 0x0000000183F99390-0x0000000183F99490
		// [XID] // 0x0000000189B9E760-0x0000000189B9E780
		public void TriggerAnimatorNew() {} // 0x0000000183F99490-0x0000000183F99590
		// [XID] // 0x0000000189BA6110-0x0000000189BA6130
		public void TriggerProgressUpdate() {} // 0x0000000183F99590-0x0000000183F99690
		// [XID] // 0x0000000189BAD3A0-0x0000000189BAD3C0
		public override void FadeOut() {} // 0x0000000183F991A0-0x0000000183F99290
	}
}
