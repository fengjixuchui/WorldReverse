/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class CrowdAnimClip // TypeDefIndex: 20373
	{
		// Fields
		public int loopIndex; // 0x10
		public float minLoopLength; // 0x14
		public float maxLoopLength; // 0x18
		public int bsIndex; // 0x1C
		public int asIndex; // 0x20
	
		// Constructors
		public CrowdAnimClip() {} // 0x0000000184D77550-0x0000000184D775C0
	
		// Methods
		// [XID] // 0x0000000189684DE0-0x0000000189684E00
		public int GetAnimIndex(CrowdAnimClipState animState) => default; // 0x0000000184D773A0-0x0000000184D77470
		// [XID] // 0x000000018968C940-0x000000018968C960
		public CrowdAnimClipState GetNextState(CrowdAnimClipState currentState) => default; // 0x0000000184D77470-0x0000000184D77550
		// [XID] // 0x0000000189694470-0x0000000189694490
		public float GetPlayLength(CrowdAnimClipState animState, float clipLength) => default; // 0x0000000184D77270-0x0000000184D773A0
	}
}
