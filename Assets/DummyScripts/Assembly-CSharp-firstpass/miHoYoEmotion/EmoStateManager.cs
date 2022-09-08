/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public class EmoStateManager // TypeDefIndex: 8494
	{
		// Fields
		private Dictionary<int, EmoTrack.EmoVoidHandler> _stateClearHandlerDic; // 0x10
		private Dictionary<int, bool> _stateDic; // 0x18
	
		// Nested types
		public enum EmoState // TypeDefIndex: 8495
		{
			INVALID = -1,
			BLENDING = 0,
			BLINKING = 1
		}
	
		// Constructors
		public EmoStateManager() {} // 0x000000018732B340-0x000000018732B3F0
	
		// Methods
		// [XID] // 0x000000018963D230-0x000000018963D250
		public void SetState(EmoState state) {} // 0x000000018732B230-0x000000018732B340
		// [XID] // 0x0000000189AA6520-0x0000000189AA6540
		public void ClearState(EmoState state) {} // 0x000000018732AEB0-0x000000018732AFD0
		// [XID] // 0x0000000189663A20-0x0000000189663A40
		public bool InState(EmoState state) => default; // 0x000000018732AFD0-0x000000018732B0C0
		// [XID] // 0x0000000189A09DC0-0x0000000189A09DE0
		public void SetStateClearHandler(EmoState state, EmoTrack.EmoVoidHandler handler) {} // 0x000000018732B0C0-0x000000018732B230
		// [XID] // 0x0000000189AF89D0-0x0000000189AF89F0
		public void ClearStateClearHandler(EmoState state, EmoTrack.EmoVoidHandler handler) {} // 0x000000018732AD40-0x000000018732AEB0
		// [XID] // 0x0000000189AC48E0-0x0000000189AC4900
		private void CallStateClearHandler(EmoState state) {} // 0x000000018732AC40-0x000000018732AD40
	}
}
