/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public class ActorEvent : ISimplePoolObject // TypeDefIndex: 21105
	{
		// Fields
		private static SimpleObjectPool<ActorEvent> _pool; // 0x00
		protected EventType _actorEvtType; // 0x10
		protected ActorEvtTargetType _target; // 0x14
		protected string _alias; // 0x18
		public int evtType; // 0x20
		public object[] evtParams; // 0x28
		public bool canRecover; // 0x30
		public bool isLight; // 0x31
		public int sourceType; // 0x34
		public uint sourceId; // 0x38
	
		// Properties
		public EventType actorEvtType { /* [XID] */ /* 0x0000000189A254F0-0x0000000189A25510 */ get => default; } // 0x0000000181A40A80-0x0000000181A40B20 
		public ActorEvtTargetType target { /* [XID] */ /* 0x0000000189642C80-0x0000000189642CA0 */ get => default; } // 0x0000000181A40BC0-0x0000000181A40C60 
		public string alias { /* [XID] */ /* 0x000000018964A2B0-0x000000018964A2D0 */ get => default; } // 0x0000000181A40B20-0x0000000181A40BC0 
	
		// Nested types
		public enum EventType // TypeDefIndex: 21106
		{
			INVALID = -1,
			NORMAL = 0,
			PAUSE = 1,
			RESUME = 2
		}
	
		// Constructors
		public ActorEvent() {} // 0x0000000181A40A00-0x0000000181A40A80
		static ActorEvent() {} // 0x0000000181A40990-0x0000000181A40A00
	
		// Methods
		[BlackList] // 0x0000000189611680-0x00000001896116C0
		// [XID] // 0x0000000189611680-0x00000001896116C0
		public static ActorEvent Get(EventType actorEvtType, ActorEvtTargetType t, string ali) => default; // 0x0000000181A40590-0x0000000181A406D0
		[BlackList] // 0x000000018961BCB0-0x000000018961BCF0
		// [XID] // 0x000000018961BCB0-0x000000018961BCF0
		public static void Release(ActorEvent evt) {} // 0x0000000181A407B0-0x0000000181A408A0
		[BlackList] // 0x0000000189626240-0x0000000189626280
		// [XID] // 0x0000000189626240-0x0000000189626280
		public void ResetObject() {} // 0x0000000181A408A0-0x0000000181A40990
		[BlackList] // 0x0000000189630CC0-0x0000000189630D00
		// [XID] // 0x0000000189630CC0-0x0000000189630D00
		public void Init(EventType actorEvtType, ActorEvtTargetType t, string ali) {} // 0x0000000181A406D0-0x0000000181A407B0
	}
}
