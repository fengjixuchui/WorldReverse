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

namespace MoleMole
{
	public sealed class TimerManager : GlobalManager // TypeDefIndex: 10601
	{
		// Fields
		public static readonly int DAY_HOUR; // 0x00
		private const uint kWheelCount = 5; // Metadata: 0x00AE7BAB
		private static int[] kWheelBits; // 0x08
		private static int[] kWheelBitsSum; // 0x10
		private static int[] kWheelSize; // 0x18
		private MTimeWheel[] wheels; // 0x10
		private float _timeScale; // 0x18
		public HashList<Action<float>> onTimeScaleChangeList; // 0x20
		private int _watch; // 0x28
		private uint _token; // 0x2C
		private long _elapsedTime; // 0x30
		private long _lastWheelTime; // 0x38
		private static long _curTime; // 0x20
		private Dictionary<uint, DoublyList<MTimer>> _timerDict; // 0x40
		public int toElapseCreationWatch; // 0x48
	
		// Properties
		public float timeScale { /* [XID] */ /* 0x0000000189B87A40-0x0000000189B87A60 */ get => default; /* [XID] */ /* 0x0000000189B8EBD0-0x0000000189B8EBF0 */ set {} } // 0x0000000186088E70-0x0000000186088F20 0x0000000186089410-0x0000000186089570
		public int timerCount { /* [XID] */ /* 0x0000000189687380-0x00000001896873A0 */ get => default; } // 0x0000000186088F20-0x0000000186088FE0 
		public long ElapsedTime { /* [XID] */ /* 0x000000018968F240-0x000000018968F260 */ get => default; } // 0x0000000186088DD0-0x0000000186088E70 
	
		// Nested types
		public abstract class TimerEventHandler // TypeDefIndex: 10602
		{
			// Fields
			protected string statName; // 0x18
	
			// Properties
			public virtual bool autoRecycle { /* [XID] */ /* 0x000000018973AC50-0x000000018973AC90 */ get; /* [XID] */ /* 0x0000000189745630-0x0000000189745670 */ protected set; } // 0x0000000186086740-0x00000001860867A0 0x00000001860867A0-0x0000000186086800
	
			// Constructors
			protected TimerEventHandler() {} // 0x00000001860866E0-0x0000000186086740
	
			// Methods
			protected abstract bool Invoke(float delay);
			public abstract void Recycle();
			// [XID] // 0x00000001899C20B0-0x00000001899C20D0
			protected void UpdateStatName(Delegate indel) {} // 0x0000000186086600-0x00000001860866E0
			// [XID] // 0x0000000189916EB0-0x0000000189916ED0
			protected void ClearStatName() {} // 0x00000001860863E0-0x00000001860864B0
			// [XID] // 0x000000018975ED30-0x000000018975ED50
			public bool InvokeHandler(float delay) => default; // 0x00000001860864B0-0x0000000186086600
		}
	
		public class SimpleTimerEventHandler : TimerEventHandler // TypeDefIndex: 10603
		{
			// Fields
			private Func<float, bool> _func; // 0x20
	
			// Constructors
			public SimpleTimerEventHandler() {} // 0x0000000186086220-0x00000001860862C0
	
			// Methods
			// [XID] // 0x00000001897661F0-0x0000000189766210
			public TimerEventHandler Refine(Func<float, bool> func, bool autoRecycle = true /* Metadata: 0x00AE7BAF */) => default; // 0x0000000186086130-0x0000000186086220
			// [XID] // 0x0000000189952870-0x0000000189952890
			protected override bool Invoke(float delay) => default; // 0x0000000186085FA0-0x0000000186086070
			// [XID] // 0x0000000189774EA0-0x0000000189774EC0
			public override void Recycle() {} // 0x0000000186086070-0x0000000186086130
		}
	
		public class NoArgTimerEventHandler : TimerEventHandler // TypeDefIndex: 10604
		{
			// Fields
			private Func<bool> _func; // 0x20
	
			// Constructors
			public NoArgTimerEventHandler() {} // 0x0000000186085F00-0x0000000186085FA0
	
			// Methods
			// [XID] // 0x000000018977C780-0x000000018977C7A0
			public void Refine(Func<bool> func, bool autoRecycle = true /* Metadata: 0x00AE7BB0 */) {} // 0x0000000186085E10-0x0000000186085F00
			// [XID] // 0x0000000189959E50-0x0000000189959E70
			protected override bool Invoke(float delay) => default; // 0x0000000186085C80-0x0000000186085D50
			// [XID] // 0x000000018978B930-0x000000018978B950
			public override void Recycle() {} // 0x0000000186085D50-0x0000000186085E10
		}
	
		public class ArgTimerEventHandler : TimerEventHandler // TypeDefIndex: 10605
		{
			// Fields
			private Func<float, object, bool> _func; // 0x20
			private object _arg; // 0x28
	
			// Constructors
			public ArgTimerEventHandler() {} // 0x000000018607C120-0x000000018607C1C0
	
			// Methods
			// [XID] // 0x000000018980C030-0x000000018980C050
			public void Refine(Func<float, object, bool> func, object arg, bool autoRecycle = true /* Metadata: 0x00AE7BB1 */) {} // 0x000000018607C020-0x000000018607C120
			// [XID] // 0x000000018979A430-0x000000018979A450
			protected override bool Invoke(float delay) => default; // 0x000000018607BE80-0x000000018607BF60
			// [XID] // 0x0000000189813700-0x0000000189813720
			public override void Recycle() {} // 0x000000018607BF60-0x000000018607C020
		}
	
		public sealed class MTimer : IComparable<MTimer> // TypeDefIndex: 10606
		{
			// Fields
			private uint _token; // 0x10
			private bool _isGlobal; // 0x14
			private long _triggerTime; // 0x18
			private long _registerTime; // 0x20
			private int _loopCount; // 0x28
			private float _interval; // 0x2C
			private TimerEventHandler _handler; // 0x30
			private bool _isFixedUpdate; // 0x38
	
			// Properties
			public uint Token { /* [XID] */ /* 0x00000001897D6020-0x00000001897D6040 */ get => default; } // 0x00000001860832D0-0x0000000186083370 
			public bool IsGlobal { /* [XID] */ /* 0x00000001897BC870-0x00000001897BC890 */ get => default; } // 0x0000000186083090-0x0000000186083130 
			public long TriggerTime { /* [XID] */ /* 0x00000001897C3CD0-0x00000001897C3CF0 */ get => default; } // 0x0000000186083370-0x0000000186083410 
			public long RegisterTime { /* [XID] */ /* 0x00000001897DD900-0x00000001897DD920 */ get => default; } // 0x0000000186083230-0x00000001860832D0 
			public bool IsInPool { /* [XID] */ /* 0x00000001897D2D60-0x00000001897D2DA0 */ get; /* [XID] */ /* 0x00000001897DD510-0x00000001897DD550 */ set; } // 0x0000000186083130-0x0000000186083190 0x0000000186083410-0x0000000186083470
			public int LoopCount { /* [XID] */ /* 0x00000001897E7D10-0x00000001897E7D30 */ get => default; } // 0x0000000186083190-0x0000000186083230 
			public bool IsFixedUpdate { /* [XID] */ /* 0x00000001897262A0-0x00000001897262C0 */ get => default; } // 0x0000000186082FF0-0x0000000186083090 
	
			// Constructors
			public MTimer() {} // 0x0000000186082F80-0x0000000186082FF0
	
			// Methods
			// [XID] // 0x00000001897F7000-0x00000001897F7020
			public void Refine(uint token, bool isGlobal, float interval, TimerEventHandler handler, int loopCount, bool isFixedUpdate) {} // 0x00000001860829E0-0x0000000186082B50
			// [XID] // 0x00000001898120B0-0x00000001898120D0
			public void RefreshTriggerTime() {} // 0x0000000186082B50-0x0000000186082C60
			// [XID] // 0x0000000189805D30-0x0000000189805D50
			public void Reset() {} // 0x0000000186082C60-0x0000000186082DA0
			// [XID] // 0x000000018980D540-0x000000018980D560
			public bool Fire(float delay) => default; // 0x0000000186082870-0x0000000186082940
			// [XID] // 0x000000018961E740-0x000000018961E760
			public int CompareTo(MTimer other) => default; // 0x0000000186082790-0x0000000186082870
			// [XID] // 0x000000018981C700-0x000000018981C720
			public long TimeLeft() => default; // 0x0000000186082E90-0x0000000186082F80
			// [XID] // 0x00000001896B43E0-0x00000001896B4400
			public long TimeDuration() => default; // 0x0000000186082DA0-0x0000000186082E90
			// [XID] // 0x000000018982B630-0x000000018982B650
			public void MarkDelete() {} // 0x0000000186082940-0x00000001860829E0
		}
	
		private sealed class MTimeWheel // TypeDefIndex: 10607
		{
			// Fields
			public DoublyList<MTimer>[] _list_head; // 0x10
			private uint _wheel_id; // 0x18
	
			// Constructors
			public MTimeWheel() {} // 0x0000000186082730-0x0000000186082790
	
			// Methods
			// [XID] // 0x0000000189832A00-0x0000000189832A20
			public void Init(uint wheel_id) {} // 0x0000000186082150-0x0000000186082370
			// [IDTag] // 0x000000018983A070-0x000000018983A0B0
			// [XID] // 0x000000018983A070-0x000000018983A0B0
			public void InsertTimerCell(int insert_pos, DoublyList<MTimer> node) {} // 0x0000000186082370-0x0000000186082480
			// [IDTag] // 0x0000000189844950-0x0000000189844990
			// [XID] // 0x0000000189844950-0x0000000189844990
			public void InsertTimerCell(int insert_pos, MTimer timer) {} // 0x0000000186082480-0x0000000186082620
			// [XID] // 0x000000018984ED40-0x000000018984ED60
			public void LogOut() {} // 0x0000000186082620-0x0000000186082730
		}
	
		// Constructors
		public TimerManager() {} // 0x00000001860883E0-0x00000001860884B0
		static TimerManager() {} // 0x0000000186088310-0x00000001860883E0
	
		// Methods
		// [XID] // 0x0000000189B69F50-0x0000000189B69F70
		public override void ReloadRes() {} // 0x0000000186087580-0x0000000186087620
		// [XID] // 0x000000018986ADF0-0x000000018986AE10
		public override void Init() {} // 0x0000000186086C70-0x00000001860870A0
		// [XID] // 0x0000000189678450-0x0000000189678470
		public long GetTriggerTime(float interval, bool isFixedUpdate) => default; // 0x0000000186086B30-0x0000000186086C70
		// [XID] // 0x000000018967FD30-0x000000018967FD50
		public long GetRegisterTime(bool isFixedUpdate) => default; // 0x0000000186086A40-0x0000000186086B30
		// [XID] // 0x000000018982FEE0-0x000000018982FF00
		public static long GetCurTime() => default; // 0x0000000186086970-0x0000000186086A40
		// [XID] // 0x000000018969E180-0x000000018969E1A0
		private uint createToken() => default; // 0x0000000186088BB0-0x0000000186088C70
		// [XID] // 0x00000001896A52B0-0x00000001896A52D0
		public static void RefreshTime() {} // 0x0000000186087450-0x0000000186087580
		// [XID] // 0x0000000189880FA0-0x0000000189880FC0
		public override void Tick() {} // 0x0000000186087950-0x0000000186087E00
		// [XID] // 0x00000001896B3E30-0x00000001896B3E50
		public uint SetGlobalTimer(float interval, TimerEventHandler handler, int loopCount = 1 /* Metadata: 0x00AE7BA0 */, bool isFixedUpdate = false /* Metadata: 0x00AE7BA4 */) => default; // 0x0000000186087730-0x0000000186087840
		// [XID] // 0x00000001896BB460-0x00000001896BB480
		public uint SetTimer(float interval, TimerEventHandler handler, int loopCount = 1 /* Metadata: 0x00AE7BA5 */, bool isFixedUpdate = false /* Metadata: 0x00AE7BA9 */) => default; // 0x0000000186087840-0x0000000186087950
		// [XID] // 0x0000000189B17A00-0x0000000189B17A20
		public float TimeLeft(uint token) => default; // 0x0000000186087F20-0x0000000186088040
		// [XID] // 0x0000000189835ED0-0x0000000189835EF0
		public int ResidualTimes(uint token) => default; // 0x0000000186087620-0x0000000186087730
		// [XID] // 0x00000001896D1400-0x00000001896D1420
		public float TimeDuration(uint token) => default; // 0x0000000186087E00-0x0000000186087F20
		// [XID] // 0x00000001897A5A90-0x00000001897A5AB0
		public void KillTimer(uint token) {} // 0x0000000186087360-0x0000000186087450
		// [XID] // 0x0000000189705500-0x0000000189705520
		public void KillTimerAll(bool includeGlobal = false /* Metadata: 0x00AE7BAA */) {} // 0x00000001860870A0-0x0000000186087360
		// [XID] // 0x00000001896E7660-0x00000001896E7680
		private uint setTimer(bool isGlobal, float interval, TimerEventHandler handler, int loopCount, bool isFixedUpdate) => default; // 0x00000001860892A0-0x0000000186089410
		// [IDTag] // 0x00000001896EED40-0x00000001896EED80
		// [XID] // 0x00000001896EED40-0x00000001896EED80
		private void addTimer(DoublyList<MTimer> node) {} // 0x00000001860884B0-0x0000000186088840
		// [IDTag] // 0x00000001896F91D0-0x00000001896F9210
		// [XID] // 0x00000001896F91D0-0x00000001896F9210
		private void addTimer(MTimer timer) {} // 0x0000000186088840-0x0000000186088BB0
		// [XID] // 0x0000000189888580-0x00000001898885A0
		private void UpdateWheel(uint id) {} // 0x00000001860880A0-0x0000000186088310
		// [XID] // 0x0000000189B535C0-0x0000000189B535E0
		private MTimer getTimer(uint token, bool global, float interval, TimerEventHandler handler, int loopCount, bool isFixedUpdate) => default; // 0x0000000186088C70-0x0000000186088DD0
		// [XID] // 0x0000000189BA5090-0x0000000189BA50B0
		private void killTimer(DoublyList<MTimer> node) {} // 0x0000000186088FE0-0x00000001860890E0
		// [XID] // 0x0000000189B46A40-0x0000000189B46A60
		private void returnBackToPool(MTimer timer) {} // 0x00000001860890E0-0x00000001860892A0
		// [XID] // 0x00000001897577D0-0x00000001897577F0
		public override void ClearOnLevelDestroy() {} // 0x0000000186086800-0x00000001860868A0
		// [XID] // 0x0000000189728CC0-0x0000000189728CE0
		public override void Destroy() {} // 0x00000001860868A0-0x0000000186086970
	}
}
