/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
	public interface ILuaActor // TypeDefIndex: 21068
	{
		// Properties
		string alias { get; }
		bool isAutoStart { get; }
		BaseActor uActor { get; }
	
		// Methods
		void InvokeOnInteraction(uint param);
		void InvokeOnResetFreeStyle(int freeStyleType);
		void InvokeOnAbility(LuaAbilityParam param);
		void InvokeOnFinalTalkFinish();
		void InvokeOnAppear();
		void InvokeOnDisappear();
	}
}
