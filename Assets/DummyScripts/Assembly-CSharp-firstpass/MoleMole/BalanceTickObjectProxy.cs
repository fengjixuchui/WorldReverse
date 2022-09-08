/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullInspector;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class BalanceTickObjectProxy : IReusable // TypeDefIndex: 10470
	{
		// Fields
		private double lastTickGlobalTime; // 0x18
		protected int _lastTickLOD; // 0x28
		protected int _currentTickLOD; // 0x2C
		public static Action<BalanceTickObjectProxy, int, int> _onTickLODChangedFirstPass; // 0x00
	
		// Properties
		protected int _interval { /* [XID] */ /* 0x0000000189AAF2B0-0x0000000189AAF2F0 */ get; /* [XID] */ /* 0x0000000189AB9940-0x0000000189AB9980 */ set; } // 0x00000001868F0DE0-0x00000001868F0E40 0x00000001868F14E0-0x00000001868F1540
		public int intervalJobThreadOnly { /* [XID] */ /* 0x0000000189BB5BF0-0x0000000189BB5C10 */ get; } // 0x00000001868F1120-0x00000001868F1200 
		public int remainder { /* [XID] */ /* 0x0000000189AD8290-0x0000000189AD82D0 */ get; /* [XID] */ /* 0x0000000189AE29E0-0x0000000189AE2A20 */ private set; } // 0x00000001868F1410-0x00000001868F1470 0x00000001868F18B0-0x00000001868F1910
		public bool bShouldTick { /* [XID] */ /* 0x0000000189AED490-0x0000000189AED4B0 */ get; } // 0x00000001868F0E40-0x00000001868F0F30 
		public float deltaTime { /* [XID] */ /* 0x0000000189AF4EC0-0x0000000189AF4F00 */ get; /* [XID] */ /* 0x0000000189AFF510-0x0000000189AFF550 */ private set; } // 0x00000001868F10B0-0x00000001868F1120 0x00000001868F16D0-0x00000001868F1740
		public bool isSelfManagedDeltaTime { /* [XID] */ /* 0x0000000189B09CE0-0x0000000189B09D20 */ get; /* [XID] */ /* 0x0000000189B14100-0x0000000189B14140 */ set; } // 0x00000001868F1260-0x00000001868F12C0 0x00000001868F17A0-0x00000001868F1800
		public bool isRegisteredToTickGroup { /* [XID] */ /* 0x0000000189B1E5C0-0x0000000189B1E600 */ get; /* [XID] */ /* 0x0000000189B28C60-0x0000000189B28CA0 */ set; } // 0x00000001868F1200-0x00000001868F1260 0x00000001868F1740-0x00000001868F17A0
		protected bool isValidInTickGroupJobThread { /* [XID] */ /* 0x0000000189B32FF0-0x0000000189B33010 */ get; } // 0x00000001868F12C0-0x00000001868F1370 
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		public int lastTickLOD { /* [XID] */ /* 0x0000000189B89BB0-0x0000000189B89BD0 */ get; /* [XID] */ /* 0x0000000189B422D0-0x0000000189B422F0 */ protected set; } // 0x00000001868F1370-0x00000001868F1410 0x00000001868F1800-0x00000001868F18B0
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		public int currentTickLOD { /* [XID] */ /* 0x0000000189B49CF0-0x0000000189B49D10 */ get; /* [XID] */ /* 0x0000000189B51450-0x0000000189B51470 */ protected set; } // 0x00000001868F0F30-0x00000001868F0FD0 0x00000001868F1540-0x00000001868F15F0
		public float currentTokenPriority { get; /* [XID] */ /* 0x0000000189BA2E10-0x0000000189BA2E50 */ protected set; } // 0x00000001868F1040-0x00000001868F10B0 0x00000001868F1660-0x00000001868F16D0
		public float currentTokenBudget { get; /* [XID] */ /* 0x0000000189BB4810-0x0000000189BB4850 */ protected set; } // 0x00000001868F0FD0-0x00000001868F1040 0x00000001868F15F0-0x00000001868F1660
		public float tickBudgetWithoutTokenBudget { /* [XID] */ /* 0x0000000189BBEA50-0x0000000189BBEA90 */ get; /* [XID] */ /* 0x0000000189BC99B0-0x0000000189BC99F0 */ protected set; } // 0x00000001868F1470-0x00000001868F14E0 0x00000001868F1910-0x00000001868F1980
	
		// Constructors
		protected BalanceTickObjectProxy() {} // 0x00000001868F0D80-0x00000001868F0DE0
	
		// Methods
		public abstract int GetLastInterval();
		public abstract int GetCurrentInterval();
		// [Conditional] // 0x0000000189ACBD70-0x0000000189ACBDC0
		// [XID] // 0x0000000189ACBD70-0x0000000189ACBDC0
		public virtual void CheckIntervalSanity() {} // 0x00000001868EFFB0-0x00000001868F0050
		public abstract void OnRegisteredUnityThread();
		public abstract void OnRegisteredJobThread();
		public abstract bool ShouldForceTickNextFrame();
		// [XID] // 0x0000000189B58E60-0x0000000189B58E80
		private void Unmanaged() {} // 0x00000001868F08F0-0x00000001868F0A50
		// [XID] // 0x0000000189B604B0-0x0000000189B604D0
		public virtual void UpdateDeltaTime(float inDeltaTime) {} // 0x00000001868F0C10-0x00000001868F0D80
		// [XID] // 0x0000000189B67CB0-0x0000000189B67CD0
		protected virtual void Init() {} // 0x00000001868F00F0-0x00000001868F03B0
		// [XID] // 0x0000000189B6EF10-0x0000000189B6EF30
		public void BeforeRecycle() {} // 0x00000001868EFF00-0x00000001868EFFB0
		// [XID] // 0x0000000189B640D0-0x0000000189B640F0
		public void OnRemovedFromBalanceBucket() {} // 0x00000001868F0460-0x00000001868F0500
		// [XID] // 0x0000000189B7DC60-0x0000000189B7DC80
		public void OnAddedToBalanceBucket(double inGlobalTime) {} // 0x00000001868F03B0-0x00000001868F0460
		// [XID] // 0x0000000189B6BEA0-0x0000000189B6BEC0
		public virtual void UpdateBalanceTickInterval(int inValue) {} // 0x00000001868F0A50-0x00000001868F0B30
		// [XID] // 0x0000000189B8C750-0x0000000189B8C770
		public void UpdateBalanceTickRemainder(int inValue) {} // 0x00000001868F0B30-0x00000001868F0C10
		// [XID] // 0x0000000189B940C0-0x0000000189B940E0
		public virtual void SetShouldTick(bool bInShouldTick, double inGlobalTime) {} // 0x00000001868F0780-0x00000001868F08F0
		public abstract float CollectTokenPriority();
		public abstract float CalcTokenBudgetByTotalToken(float inTotalToken, float deltaTime);
		public abstract float CalcTokenBudgetWithOutBudgetLimit(float deltaTime);
		public abstract int SyncTickLODInfo();
		// [XID] // 0x0000000189AE88B0-0x0000000189AE88D0
		public void OnTickLODChange() {} // 0x00000001868F0600-0x00000001868F0780
		public abstract void ProcessOnTickLODChange(int fromLOD, int toLOD);
		// [XID] // 0x0000000189A47780-0x0000000189A477A0
		public virtual void OnRemovedFromTickGroup() {} // 0x00000001868F0500-0x00000001868F0600
		// [XID] // 0x00000001895E8410-0x00000001895E8430
		public virtual void DeallocateToObjectPool() {} // 0x00000001868F0050-0x00000001868F00F0
		public abstract void SyncTickStateToUnityThread();
		public abstract string GetEntityTypeString();
	}
}
