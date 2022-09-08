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
	public abstract class TickObjectProxyLODManager // TypeDefIndex: 10478
	{
		// Fields
		protected HashList<BalanceTickObjectProxy> _allObjectProxies; // 0x10
		protected EventDispatcherWithEventQueue _eventDispatcherUnityThread; // 0x18
		protected EventDispatcherWithEventQueue _eventDispatcherJobThread; // 0x20
		private List<BalanceTickObjectProxy> _collectedTokenProxies; // 0x28
		protected List<LODEventBase> _toDisposeEvents; // 0x30
		private Comparison<BalanceTickObjectProxy> descendingPriorityComparision; // 0x38
		protected Queue<BalanceTickObjectProxy> newlyRegisteredProxies; // 0x40
		protected HashSet<BalanceTickObjectProxy> newlyRegisteredProxiesSet; // 0x48
		protected List<BalanceTickObjectProxy> toForceTickNextFrameProxies; // 0x50
		public static ObjectPoolNonGenericCluster tickProxyObjectPoolCluster; // 0x00
		private float _currentTotalToken; // 0x58
		private int _continousExceedBudgetFrameCount; // 0x5C
		private const int targetContinousExceedBudgetFrameCount = 10; // Metadata: 0x00AE764B
	
		// Properties
		public float currentTickToken { /* [XID] */ /* 0x000000018979C650-0x000000018979C670 */ get; } // 0x00000001868C12C0-0x00000001868C13B0 
	
		// Nested types
		public abstract class LODEventBase : IDispatchableEvent, IReusable, IDisposable // TypeDefIndex: 10479
		{
			// Properties
			public BalanceTickObjectProxy _proxy { /* [XID] */ /* 0x00000001897E36D0-0x00000001897E3710 */ get; /* [XID] */ /* 0x00000001897EE140-0x00000001897EE180 */ private set; } // 0x0000000186080400-0x0000000186080460 0x0000000186080460-0x00000001860804C0
	
			// Constructors
			protected LODEventBase() {} // 0x00000001860803A0-0x0000000186080400
	
			// Methods
			public static T CreateLODEvent<T>(BalanceTickObjectProxy inProxy)
				where T : LODEventBase, new() => default;
			// [XID] // 0x0000000189684200-0x0000000189684220
			private void Init(BalanceTickObjectProxy inProxy) {} // 0x0000000186080230-0x00000001860803A0
			// [XID] // 0x0000000189693A50-0x0000000189693A70
			public virtual void BeforeRecycle() {} // 0x0000000186080150-0x0000000186080230
			public abstract void Dispose();
		}
	
		public class LODEventAllocate : LODEventBase // TypeDefIndex: 10480
		{
			// Constructors
			public LODEventAllocate() {} // 0x00000001860800B0-0x0000000186080150
	
			// Methods
			// [XID] // 0x00000001898078A0-0x00000001898078C0
			public override void Dispose() {} // 0x000000018607FFC0-0x00000001860800B0
		}
	
		public class LODEventRegister : LODEventBase // TypeDefIndex: 10481
		{
			// Constructors
			public LODEventRegister() {} // 0x0000000186081000-0x00000001860810A0
	
			// Methods
			// [XID] // 0x000000018980EF40-0x000000018980EF60
			public override void Dispose() {} // 0x0000000186080F10-0x0000000186081000
		}
	
		public class LODEventUnregister : LODEventBase // TypeDefIndex: 10482
		{
			// Constructors
			public LODEventUnregister() {} // 0x0000000186081190-0x0000000186081230
	
			// Methods
			// [XID] // 0x00000001898165E0-0x0000000189816600
			public override void Dispose() {} // 0x00000001860810A0-0x0000000186081190
		}
	
		public class LODEventDeallocate : LODEventBase // TypeDefIndex: 10483
		{
			// Properties
			public bool isForceDeallocate { get; /* [XID] */ /* 0x000000018982FAF0-0x000000018982FB30 */ private set; } // 0x0000000186080E50-0x0000000186080EB0 0x0000000186080EB0-0x0000000186080F10
	
			// Constructors
			public LODEventDeallocate() {} // 0x0000000186080DB0-0x0000000186080E50
	
			// Methods
			// [XID] // 0x000000018983A0B0-0x000000018983A0D0
			public LODEventDeallocate Polish(bool inForceDeallocate) => default; // 0x0000000186080C60-0x0000000186080D50
			// [XID] // 0x0000000189841560-0x0000000189841580
			public override void BeforeRecycle() {} // 0x0000000186080A90-0x0000000186080B70
			// [XID] // 0x0000000189848A40-0x0000000189848A60
			public override void Dispose() {} // 0x0000000186080B70-0x0000000186080C60
		}
	
		public class LODEventChange : LODEventBase // TypeDefIndex: 10484
		{
			// Properties
			public int fromLOD { get; /* [XID] */ /* 0x000000018986C110-0x000000018986C150 */ private set; } // 0x0000000186080910-0x0000000186080970 0x00000001860809D0-0x0000000186080A30
			public int toLOD { get; /* [XID] */ /* 0x000000018987E290-0x000000018987E2D0 */ private set; } // 0x0000000186080970-0x00000001860809D0 0x0000000186080A30-0x0000000186080A90
	
			// Constructors
			public LODEventChange() {} // 0x0000000186080870-0x0000000186080910
	
			// Methods
			// [XID] // 0x000000018964F750-0x000000018964F770
			public LODEventChange Polish(int inFromLOD, int inToLOD) => default; // 0x00000001860806D0-0x0000000186080810
			// [XID] // 0x000000018988F680-0x000000018988F6A0
			public override void BeforeRecycle() {} // 0x00000001860804C0-0x00000001860805E0
			// [XID] // 0x0000000189896BE0-0x0000000189896C00
			public override void Dispose() {} // 0x00000001860805E0-0x00000001860806D0
		}
	
		// Constructors
		public TickObjectProxyLODManager() {} // 0x00000001868C0F10-0x00000001868C12C0
		static TickObjectProxyLODManager() {} // 0x00000001868C0EB0-0x00000001868C0F10
	
		// Methods
		// [XID] // 0x0000000189BCCA60-0x0000000189BCCA80
		protected List<BalanceTickObjectProxy> GenerateToForceTickNextFrameProxies() => default; // 0x00000001868BF2D0-0x00000001868BF430
		// [XID] // 0x0000000189BD4110-0x0000000189BD4130
		protected void OnFinishGenerateToForceTickNextFrameProxies() {} // 0x00000001868BFA50-0x00000001868BFB40
		// [XID] // 0x00000001897587F0-0x0000000189758810
		private void InitObjectPoolCluster() {} // 0x00000001868BF430-0x00000001868BF710
		// [XID] // 0x00000001897604F0-0x0000000189760510
		public virtual void Flush() {} // 0x00000001868BF230-0x00000001868BF2D0
		// [XID] // 0x0000000189767860-0x0000000189767880
		protected void SafePurgeAllEvents() {} // 0x00000001868C02A0-0x00000001868C03E0
		// [XID] // 0x00000001895F5C50-0x00000001895F5C70
		protected void InternalFlush() {} // 0x00000001868BF710-0x00000001868BF910
		public virtual T AllocateTickBalanceProxy<T, TSpawner>()
			where T : BalanceTickObjectProxy
			where TSpawner : class, ISpawner<T>, new() => default;
		// [XID] // 0x0000000189776AE0-0x0000000189776B00
		public void RegisterTickBalanceProxy(BalanceTickObjectProxy proxy) {} // 0x00000001868C0150-0x00000001868C02A0
		// [XID] // 0x000000018977DEF0-0x000000018977DF10
		public void UnregisterTickBalanceProxy(BalanceTickObjectProxy proxy) {} // 0x00000001868C0D70-0x00000001868C0EB0
		public void DeallocateTickBalanceProxy<T>(ref T proxy, bool bForceDeallocate)
			where T : BalanceTickObjectProxy {}
		// [XID] // 0x00000001897858E0-0x0000000189785900
		protected void PostProxyCalcTickLOD(BalanceTickObjectProxy inProxy) {} // 0x00000001868BFB40-0x00000001868BFCA0
		// [XID] // 0x000000018978CE10-0x000000018978CE30
		protected void SyncProxyTickStateToUnityThread() {} // 0x00000001868C03E0-0x00000001868C0530
		// [XID] // 0x00000001897942E0-0x0000000189794300
		protected bool RefreshObjectProxiesWithoutBudgetLimit(float deltaTime) => default; // 0x00000001868BFFD0-0x00000001868C0150
		// [XID] // 0x00000001898AC100-0x00000001898AC120
		protected bool RefreshObjectProxiesWithTokenBudget(float deltaTime) => default; // 0x00000001868BFCA0-0x00000001868BFFD0
		// [XID] // 0x000000018968BEB0-0x000000018968BED0
		protected void InternalUpdateObjectProxies(double inGlobalTime, float deltaTime) {} // 0x00000001868BF910-0x00000001868BFA50
		public abstract void UpdateComputeThread(float inGlobalTime, float deltaTime);
	}
}
