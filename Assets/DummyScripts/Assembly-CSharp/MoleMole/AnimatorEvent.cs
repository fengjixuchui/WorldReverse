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
	[Serializable]
	public abstract class AnimatorEvent // TypeDefIndex: 19272
	{
		// Fields
		public float normalizedTime; // 0x10
		public float expiredTime; // 0x14
		public bool forceTriggerOnEnter; // 0x18
		public AnimatorTriggerType forceTriggerOnExit; // 0x1C
	
		// Constructors
		protected AnimatorEvent() {} // 0x0000000184E7BC80-0x0000000184E7BCF0
	
		// Methods
		// [XID] // 0x000000018993FAA0-0x000000018993FAC0
		public override string ToString() => default; // 0x0000000184E7B550-0x0000000184E7B7B0
		// [XID] // 0x0000000189947160-0x0000000189947180
		public virtual void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x0000000184E79730-0x0000000184E79810
		public abstract AnimatorEventEntry ConvertToEntry();
		public abstract void ParseFromEntry(AnimatorEventEntry entry);
		// [XID] // 0x000000018994E780-0x000000018994E7A0
		public AnimatorEvent Clone() => default; // 0x0000000184E798F0-0x0000000184E799E0
		// [XID] // 0x0000000189955DE0-0x0000000189955E00
		public void ConvertBasicArgsToEntry(AnimatorEventEntry opEntity) {} // 0x0000000184E79650-0x0000000184E79730
		// [XID] // 0x000000018995D950-0x000000018995D970
		public void ParseBasicArgsFromEntry(AnimatorEventEntry opEntity) {} // 0x0000000184E79810-0x0000000184E798F0
		// [XID] // 0x0000000189965030-0x0000000189965050
		public static AnimatorEvent ParseFromAnimatorEventEntry(AnimatorEventEntry entry) => default; // 0x0000000184E799E0-0x0000000184E7A1F0
	}
}
