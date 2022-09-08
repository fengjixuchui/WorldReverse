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
	public class AnimatorEventEntry : ISerializationCallbackReceiver // TypeDefIndex: 19268
	{
		// Fields
		public AnimatorEventType type; // 0x10
		public float normalizedTime; // 0x14
		public float expiredTime; // 0x18
		public bool forceTriggerOnEnter; // 0x1C
		public AnimatorTriggerType forceTriggerOnExit; // 0x20
		public string[] stringArgs; // 0x28
		public float[] floatArgs; // 0x30
		public bool boolArg; // 0x38
	
		// Constructors
		public AnimatorEventEntry() {} // 0x0000000184E79390-0x0000000184E79400
	
		// Methods
		// [XID] // 0x000000018991A6D0-0x000000018991A6F0
		public AnimatorEventEntry Clone() => default; // 0x0000000184E79130-0x0000000184E79220
		// [XID] // 0x0000000189921E20-0x0000000189921E40
		public void OnBeforeSerialize() {} // 0x0000000184E792F0-0x0000000184E79390
		// [XID] // 0x0000000189929600-0x0000000189929620
		public void OnAfterDeserialize() {} // 0x0000000184E79220-0x0000000184E792F0
	}
}
