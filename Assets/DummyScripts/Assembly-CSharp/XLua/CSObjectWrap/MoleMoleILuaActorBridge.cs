/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua.CSObjectWrap
{
	public sealed class MoleMoleILuaActorBridge : LuaBase, ILuaActor // TypeDefIndex: 32287
	{
		// Properties
		string ILuaActor.alias { get => default; } // 0x000000018864BDF0-0x000000018864BFA0 
		bool ILuaActor.isAutoStart { get => default; } // 0x000000018864BFA0-0x000000018864C150 
		BaseActor ILuaActor.uActor { get => default; } // 0x000000018864C150-0x000000018864C3C0 
	
		// Constructors
		public MoleMoleILuaActorBridge() {} // Dummy constructor
		public MoleMoleILuaActorBridge(int reference, LuaEnv luaenv) {} // 0x000000018864C450-0x000000018864C4D0
	
		// Methods
		public static LuaBase __Create(int reference, LuaEnv luaenv) => default; // 0x000000018864C3C0-0x000000018864C450
		void ILuaActor.InvokeOnInteraction(uint param) {} // 0x000000018864B930-0x000000018864BB90
		void ILuaActor.InvokeOnResetFreeStyle(int freeStyleType) {} // 0x000000018864BB90-0x000000018864BDF0
		void ILuaActor.InvokeOnAbility(LuaAbilityParam param) {} // 0x000000018864AFF0-0x000000018864B270
		void ILuaActor.InvokeOnFinalTalkFinish() {} // 0x000000018864B6F0-0x000000018864B930
		void ILuaActor.InvokeOnAppear() {} // 0x000000018864B270-0x000000018864B4B0
		void ILuaActor.InvokeOnDisappear() {} // 0x000000018864B4B0-0x000000018864B6F0
	}
}
