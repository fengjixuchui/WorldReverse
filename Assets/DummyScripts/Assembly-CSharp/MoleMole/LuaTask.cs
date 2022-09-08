/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class LuaTask : ISimplePoolObject // TypeDefIndex: 21165
	{
		// Fields
		protected LuaTaskType _taskType; // 0x50
		protected bool _isStarted; // 0x54
		protected bool _isFinished; // 0x55
		protected bool _isPaused; // 0x56
		protected bool _isDestroyed; // 0x57
		protected int _taskQueueID; // 0x58
		protected BaseActor _actor; // 0x60
		protected string _tag; // 0x68
		protected Dictionary<int, bool> _syncCoDic; // 0x70
	
		// Properties
		public LuaTaskType taskType { /* [XID] */ /* 0x0000000189999E30-0x0000000189999E50 */ get => default; } // 0x0000000184F18090-0x0000000184F18130 
		public bool isStarted { /* [XID] */ /* 0x00000001896A8330-0x00000001896A8350 */ get => default; } // 0x0000000184F17EB0-0x0000000184F17F50 
		public bool isFinished { /* [XID] */ /* 0x0000000189958680-0x00000001899586A0 */ get => default; } // 0x0000000184F17D70-0x0000000184F17E10 
		public bool isPaused { /* [XID] */ /* 0x00000001899B08F0-0x00000001899B0910 */ get => default; } // 0x0000000184F17E10-0x0000000184F17EB0 
		public bool isDestroyed { /* [XID] */ /* 0x00000001899B7CD0-0x00000001899B7CF0 */ get => default; } // 0x0000000184F17CD0-0x0000000184F17D70 
		public int taskQueueID { /* [XID] */ /* 0x0000000189A0C430-0x0000000189A0C450 */ get => default; } // 0x0000000184F17FF0-0x0000000184F18090 
		public virtual bool isBackGround { /* [XID] */ /* 0x00000001899C7050-0x00000001899C7070 */ get => default; } // 0x0000000184F17C30-0x0000000184F17CD0 
		public BaseActor actor { /* [XID] */ /* 0x00000001899CE530-0x00000001899CE550 */ get => default; } // 0x0000000184F17B90-0x0000000184F17C30 
		public string tag { /* [XID] */ /* 0x00000001899D5C90-0x00000001899D5CB0 */ get => default; } // 0x0000000184F17F50-0x0000000184F17FF0 
	
		// Events
		public event Action<ILuaActor, LuaTask> StartEvent;
		public event Action<ILuaActor, LuaTask> FinishEvent;
		public event Action<ILuaActor, LuaTask> PauseEvent;
		public event Action<ILuaActor, LuaTask> ResumeEvent;
		public event Action<ILuaActor, LuaTask, float> TickEvent;
		public event Action<ILuaActor, LuaTask> DisappearEvent;
		public event Action<ILuaActor, LuaTask> AppearEvent;
		public event Action<ILuaActor, LuaTask> DestroyEvent;
	
		// Constructors
		public LuaTask() {} // 0x0000000184F171D0-0x0000000184F17290
	
		// Methods
		// [XID] // 0x00000001898F4700-0x00000001898F4720
		public void CallStartEvent() {} // 0x0000000184F161E0-0x0000000184F162C0
		// [XID] // 0x0000000189967620-0x0000000189967640
		public void CallFinishEvent() {} // 0x0000000184F15F10-0x0000000184F15FF0
		// [XID] // 0x0000000189A95C50-0x0000000189A95C70
		public void CallPauseEvent() {} // 0x0000000184F15FF0-0x0000000184F160D0
		// [XID] // 0x0000000189937E70-0x0000000189937E90
		public void CallResumeEvent() {} // 0x0000000184F160D0-0x0000000184F161E0
		// [XID] // 0x000000018994E620-0x000000018994E640
		public void CallTickEvent() {} // 0x0000000184F162C0-0x0000000184F163C0
		// [XID] // 0x0000000189964DD0-0x0000000189964DF0
		public virtual void CallDisappearEvent() {} // 0x0000000184F15E30-0x0000000184F15F10
		// [XID] // 0x000000018997B610-0x000000018997B630
		public virtual void CallAppearEvent() {} // 0x0000000184F15C70-0x0000000184F15D50
		// [XID] // 0x0000000189A70330-0x0000000189A70350
		public void CallDestroyEvent() {} // 0x0000000184F15D50-0x0000000184F15E30
		// [XID] // 0x00000001899DD060-0x00000001899DD080
		public void SyncCo(int cId) {} // 0x0000000184F16F70-0x0000000184F17060
		[BlackList] // 0x00000001899E4C20-0x00000001899E4C60
		// [XID] // 0x00000001899E4C20-0x00000001899E4C60
		public virtual void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184F16840-0x0000000184F16950
		// [XID] // 0x00000001899EF040-0x00000001899EF060
		public virtual void StartTask() {} // 0x0000000184F16EC0-0x0000000184F16F70
		// [XID] // 0x00000001899F6A10-0x00000001899F6A30
		public virtual void Tick() {} // 0x0000000184F17100-0x0000000184F171D0
		// [XID] // 0x00000001899FDFF0-0x00000001899FE010
		protected virtual void TickInternal() {} // 0x0000000184F17060-0x0000000184F17100
		// [XID] // 0x0000000189A05910-0x0000000189A05930
		public virtual void OnEvent(BaseEvent evt) {} // 0x0000000184F169F0-0x0000000184F16AA0
		// [XID] // 0x0000000189A0CBE0-0x0000000189A0CC00
		public virtual void OnPause() {} // 0x0000000184F16AA0-0x0000000184F16B50
		// [XID] // 0x0000000189AAC290-0x0000000189AAC2B0
		public virtual void OnResume() {} // 0x0000000184F16B50-0x0000000184F16C00
		// [XID] // 0x0000000189A1B7D0-0x0000000189A1B7F0
		public virtual void OnSelfNightTime() {} // 0x0000000184F16CA0-0x0000000184F16D40
		// [XID] // 0x0000000189A231C0-0x0000000189A231E0
		public virtual void OnSelfDayTime() {} // 0x0000000184F16C00-0x0000000184F16CA0
		// [XID] // 0x0000000189A2A3A0-0x0000000189A2A3C0
		public virtual void FinishTask() {} // 0x0000000184F16770-0x0000000184F16840
		// [XID] // 0x0000000189A31810-0x0000000189A31830
		public virtual void OnClear() {} // 0x0000000184F16950-0x0000000184F169F0
		// [XID] // 0x0000000189A39350-0x0000000189A39370
		protected void ClearSyncCo() {} // 0x0000000184F163C0-0x0000000184F165A0
		// [XID] // 0x000000018972D690-0x000000018972D6B0
		public void Destroy() {} // 0x0000000184F166A0-0x0000000184F16770
		// [XID] // 0x00000001898A9F80-0x00000001898A9FA0
		protected virtual void ReleaseTask() {} // 0x0000000184F16D40-0x0000000184F16E10
		// [XID] // 0x0000000189A4FA80-0x0000000189A4FAA0
		protected virtual void DestroyInternal() {} // 0x0000000184F165A0-0x0000000184F166A0
		// [XID] // 0x0000000189A57010-0x0000000189A57030
		public void ResetObject() {} // 0x0000000184F16E10-0x0000000184F16EC0
	}
}
