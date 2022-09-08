/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EffectPool : IWorldShiftAgent // TypeDefIndex: 19773
{
	// Fields
	public int DelayRemoveDuration; // 0x10
	private Dictionary<string, EffectPoolItem> _poolDict; // 0x18
	private Action _checkReleaseForBudgetWithoutOneAvaliableEffectLeft; // 0x20
	private Action _checkReleaseForBudgetForTheLastTime; // 0x28
	private const string POOL_ROOT_NAME = "EffectPool"; // Metadata: 0x00AFCCFE
	public bool needCacheClearParticleEffects; // 0x38
	public List<MonoEffect> _cacheClearParticleEffects; // 0x40
	private TickList<MonoEffect> _tickMonoEffects; // 0x48
	private LateTickList<MonoEffect> _lateTickMonoEffects; // 0x50
	private Dictionary<string, List<MonoEffect>> _toBeDeallocatedEffects; // 0x58
	private Dictionary<ulong, uint> _poolDelayRemoveTimer; // 0x60
	private OrderedForBudgetRemovePool _orderedDic; // 0x68
	private List<string> _budgetRemoveList; // 0x70
	private int _particleSystemBudgetCount; // 0x78
	private HashSet<string> _moreThanOneAvaliableEffectPools; // 0x80
	private HashList<MonoEffect> _avaliableEffectsSortedByLastUsedTime; // 0x88
	private HashSet<string> _moreThanOneAvaliableEffectPoolsForRelease; // 0x90
	private HashSet<string> _lastUsedTimeOverThresholdEffectPoolsForRelease; // 0x98
	private SliceFrameWatch _releaseForBudgetStopwatch; // 0xA0
	private HashSet<string> _releasedEffectPoolThisFrame; // 0xA8

	// Properties
	public Transform poolRoot { /* [XID] */ /* 0x0000000189B2AE80-0x0000000189B2AEC0 */ get; /* [XID] */ /* 0x0000000189B351E0-0x0000000189B35220 */ private set; } // 0x00000001853AE6E0-0x00000001853AE740 0x00000001853B18C0-0x00000001853B1920

	// Nested types
	private class DoDelayRemoveHandle : TimerManager.TimerEventHandler // TypeDefIndex: 19774
	{
		// Fields
		private string _effectName; // 0x20
		private ulong _effectPathHash; // 0x28
		private Func<float, string, ulong, bool> _func; // 0x30

		// Properties
		public override bool autoRecycle { /* [XID] */ /* 0x00000001896D7E70-0x00000001896D7E90 */ get => default; } // 0x00000001853A05D0-0x00000001853A0670 

		// Constructors
		public DoDelayRemoveHandle() {} // 0x00000001853A0570-0x00000001853A05D0

		// Methods
		// [XID] // 0x00000001896D0940-0x00000001896D0960
		public void Refine(string effectName, ulong effectPathHash, Func<float, string, ulong, bool> func) {} // 0x00000001853A02E0-0x00000001853A03D0
		// [XID] // 0x00000001896DF740-0x00000001896DF760
		protected override bool Invoke(float delay) => default; // 0x00000001853A03D0-0x00000001853A04B0
		// [XID] // 0x00000001896E6AE0-0x00000001896E6B00
		public override void Recycle() {} // 0x00000001853A04B0-0x00000001853A0570
	}

	private class OrderedForBudgetRemovePool // TypeDefIndex: 19775
	{
		// Fields
		private Dictionary<ulong, OrderedDicData> _allDatas; // 0x10
		private Dictionary<long, OrderedDicData> _addOrders; // 0x18
		private long _nextAddOrder; // 0x20
		private long _nextRemoveOrder; // 0x28

		// Properties
		public int Count { /* [XID] */ /* 0x00000001897D2E50-0x00000001897D2E70 */ get => default; } // 0x00000001853A1110-0x00000001853A11E0 
		private long nextAddOrder { /* [XID] */ /* 0x0000000189AE00C0-0x0000000189AE00E0 */ get => default; } // 0x00000001853A0C20-0x00000001853A0CD0 
		private long nextRemoveOrder { /* [XID] */ /* 0x0000000189AAA7E0-0x0000000189AAA800 */ get => default; } // 0x00000001853A0E70-0x00000001853A0F20 

		// Nested types
		private struct OrderedDicData // TypeDefIndex: 19776
		{
			// Fields
			public ulong effectPathHash; // 0x00
			public string effectName; // 0x08
			public long addOrder; // 0x10

			// Constructors
			public OrderedDicData(string effectName, ulong effectPathHash, long addOrder) {
				this.effectPathHash = default;
				this.effectName = default;
				this.addOrder = default;
			} // 0x00000001853BFF20-0x00000001853C00B0
		}

		// Constructors
		public OrderedForBudgetRemovePool() {} // 0x00000001853A11E0-0x00000001853A12A0

		// Methods
		// [XID] // 0x00000001896EE070-0x00000001896EE090
		public void Clear() {} // 0x00000001853A0B40-0x00000001853A0C20
		// [XID] // 0x00000001896F5890-0x00000001896F58B0
		public void Add(string effectName, ulong effectPathHash) {} // 0x00000001853A0F20-0x00000001853A1110
		// [XID] // 0x00000001896FD050-0x00000001896FD070
		public void Remove(string effectName, ulong effectPathHash) {} // 0x00000001853A0CD0-0x00000001853A0E70
		// [XID] // 0x0000000189704500-0x0000000189704520
		public bool PopByAddOrder(out string removeEffectName, out ulong removeEffectPathHash) {
			removeEffectName = default;
			removeEffectPathHash = default;
			return default;
		} // 0x00000001853A0850-0x00000001853A0A60
		// [XID] // 0x0000000189713600-0x0000000189713620
		private bool ContainsNullReference() => default; // 0x00000001853A0A60-0x00000001853A0B40
	}

	// Constructors
	public EffectPool() {} // 0x00000001853B24F0-0x00000001853B26D0

	// Methods
	// [XID] // 0x0000000189AE7EF0-0x0000000189AE7F10
	public void Destroy() {} // 0x00000001853AD3F0-0x00000001853AD600
	// [XID] // 0x0000000189AEFCE0-0x0000000189AEFD00
	public void Tick() {} // 0x00000001853AE180-0x00000001853AE230
	// [XID] // 0x0000000189AF7220-0x0000000189AF7240
	public void LateTick() {} // 0x00000001853B12C0-0x00000001853B1380
	// [XID] // 0x0000000189AFE850-0x0000000189AFE870
	public void PreloadEffect(ConfigPreloadType preloadType, BaseEntity entity, string effectName, GlobalVars.EffectPoolRemoveStrategy poolRemoveStrategy) {} // 0x00000001853ADC90-0x00000001853ADE50
	// [XID] // 0x0000000189A2E310-0x0000000189A2E330
	public AsyncJob PreloadEffectAsyncWithJob(ConfigPreloadType preloadType, BaseEntity entity, string effectName, Action<string> preloadedHandler, GlobalVars.EffectPoolRemoveStrategy poolRemoveStrategy) => default; // 0x00000001853AD060-0x00000001853AD290
	// [XID] // 0x0000000189B0D890-0x0000000189B0D8B0
	public void ReleasePreloadedEffect(ConfigPreloadType preloadType, BaseEntity entity, string effectName) {} // 0x00000001853B1380-0x00000001853B14B0
	// [XID] // 0x0000000189B14CD0-0x0000000189B14CF0
	public MonoEffect AllocEffect(bool indexed, BaseEntity owner, string effectName, Vector3 initPos, Quaternion initRot, Vector3 initScale) => default; // 0x00000001853B1BA0-0x00000001853B1DF0
	// [XID] // 0x000000018982B7C0-0x000000018982B7E0
	public void AllocEffectAsync(bool indexed, BaseEntity owner, string effectName, Vector3 initPos, Quaternion initRot, Vector3 initScale, Action<MonoEffect> allocedHandler) {} // 0x00000001853B1060-0x00000001853B12C0
	// [XID] // 0x0000000189B23B60-0x0000000189B23B80
	public bool CanSkipCreation(string effectName, Vector3 initPos) => default; // 0x00000001853B20F0-0x00000001853B22B0
	// [XID] // 0x0000000189B3FD80-0x0000000189B3FDA0
	private void InitRoot() {} // 0x00000001853AF9F0-0x00000001853AFB30
	// [XID] // 0x0000000189B475A0-0x0000000189B475C0
	private void ClearRoot() {} // 0x00000001853ACDB0-0x00000001853ACF60
	// [XID] // 0x0000000189B4EDF0-0x0000000189B4EE10
	private void InitCacheClearParticleEffects() {} // 0x00000001853ACCE0-0x00000001853ACDB0
	// [XID] // 0x0000000189B56790-0x0000000189B567B0
	private void ClearCacheClearParticleEffects() {} // 0x00000001853B1A00-0x00000001853B1AC0
	// [XID] // 0x0000000189B5DF60-0x0000000189B5DF80
	private void LateTickClearParticleEffects() {} // 0x00000001853AE020-0x00000001853AE180
	// [XID] // 0x0000000189A9EA90-0x0000000189A9EAB0
	public void AddCacheClearParticleEffects(MonoEffect effect) {} // 0x00000001853B0A40-0x00000001853B0B60
	// [XID] // 0x0000000189B6CA60-0x0000000189B6CA80
	private void InitTickableEffects() {} // 0x00000001853ACBF0-0x00000001853ACCE0
	// [XID] // 0x0000000189B74270-0x0000000189B74290
	private void ClearTickableEffects() {} // 0x00000001853AD770-0x00000001853AD840
	// [XID] // 0x0000000189B7B870-0x0000000189B7B890
	private void TickTickableEffects() {} // 0x00000001853ACA10-0x00000001853ACAF0
	// [XID] // 0x0000000189B831E0-0x0000000189B83200
	public void AddTickMonoEffects(MonoEffect effect) {} // 0x00000001853AF930-0x00000001853AF9F0
	// [XID] // 0x00000001898B0280-0x00000001898B02A0
	public void RemoveTickMonoEffects(MonoEffect effect) {} // 0x00000001853AD330-0x00000001853AD3F0
	// [XID] // 0x0000000189B91C60-0x0000000189B91C80
	private void LateTickTickableEffects() {} // 0x00000001853AF300-0x00000001853AF3D0
	// [XID] // 0x0000000189B99120-0x0000000189B99140
	public void AddLateTickMonoEffects(MonoEffect effect) {} // 0x00000001853AF6A0-0x00000001853AF760
	// [XID] // 0x00000001898BEE60-0x00000001898BEE80
	public void RemoveLateTickMonoEffects(MonoEffect effect) {} // 0x00000001853AD840-0x00000001853AD900
	// [XID] // 0x0000000189BA7D30-0x0000000189BA7D50
	private void InitToBeDeallocated() {} // 0x00000001853AF760-0x00000001853AF830
	// [XID] // 0x0000000189BAF160-0x0000000189BAF180
	private void ClearToBeDeallocated() {} // 0x00000001853B0760-0x00000001853B0970
	// [XID] // 0x0000000189BB6850-0x0000000189BB6870
	private void TickToBeDeallocated() {} // 0x00000001853AEB90-0x00000001853AEEC0
	// [XID] // 0x000000018993EFE0-0x000000018993F000
	public void AddToBeDeallocatedEffects(MonoEffect effect) {} // 0x00000001853B15C0-0x00000001853B1770
	// [XID] // 0x0000000189BC5B60-0x0000000189BC5B80
	private void InitRemovePool() {} // 0x00000001853ADA20-0x00000001853ADAD0
	// [XID] // 0x0000000189BCD560-0x0000000189BCD580
	private void ClearRemovePool() {} // 0x00000001853AE630-0x00000001853AE6E0
	// [XID] // 0x0000000189BD4B10-0x0000000189BD4B30
	private void LateTickRemovePool() {} // 0x00000001853B06C0-0x00000001853B0760
	// [XID] // 0x0000000189A856E0-0x0000000189A85700
	public void AddRemovePool(string effectName, ulong effectPathHash, GlobalVars.EffectPoolRemoveStrategy effectPoolRemoveStrategy) {} // 0x00000001853ACF60-0x00000001853AD060
	// [XID] // 0x00000001895E8EF0-0x00000001895E8F10
	public void CancelRemovePool(string effectName, ulong effectPathHash, GlobalVars.EffectPoolRemoveStrategy effectPoolRemoveStrategy) {} // 0x00000001853AF830-0x00000001853AF930
	// [XID] // 0x000000018978E7C0-0x000000018978E7E0
	private void DoRemovePool(string effectName) {} // 0x00000001853B1FA0-0x00000001853B20F0
	// [XID] // 0x00000001895F80F0-0x00000001895F8110
	private void InitDelayRemove() {} // 0x00000001853B0970-0x00000001853B0A40
	// [XID] // 0x00000001895FF650-0x00000001895FF670
	private void ClearDelayRemove() {} // 0x00000001853B0B60-0x00000001853B0D70
	// [XID] // 0x0000000189A94390-0x0000000189A943B0
	public void AddDelayRemovePool(string effectName, ulong effectPathHash) {} // 0x00000001853ADE50-0x00000001853AE020
	// [XID] // 0x000000018960E6C0-0x000000018960E6E0
	public void CancelDelayRemovePool(string effectName, ulong effectPathHash) {} // 0x00000001853AD600-0x00000001853AD770
	// [XID] // 0x0000000189787170-0x0000000189787190
	private bool DoDelayRemove(float delay, string effectName, ulong effectPathHash) => default; // 0x00000001853ACAF0-0x00000001853ACBF0
	// [XID] // 0x000000018961D610-0x000000018961D630
	private void InitBudgetRemove() {} // 0x00000001853B1DF0-0x00000001853B1ED0
	// [XID] // 0x0000000189624AD0-0x0000000189624AF0
	private void ClearBudgetRemove() {} // 0x00000001853B1ED0-0x00000001853B1FA0
	// [XID] // 0x000000018962C270-0x000000018962C290
	private void LateTickBudgetRemovePool() {} // 0x00000001853AD290-0x00000001853AD330
	// [XID] // 0x0000000189633DB0-0x0000000189633DD0
	private void AddBudgetRemovePool(string effectName, ulong effectPathHash) {} // 0x00000001853B1AC0-0x00000001853B1BA0
	// [XID] // 0x0000000189AFDD70-0x0000000189AFDD90
	private void CheckAndDoBudgetRemove() {} // 0x00000001853B1770-0x00000001853B18C0
	// [XID] // 0x0000000189B05570-0x0000000189B05590
	private void AddToRemoveList(string removeEffectName) {} // 0x00000001853B0D70-0x00000001853B0E30
	// [XID] // 0x000000018964A4B0-0x000000018964A4D0
	private void DoRemoveFromRemoveList() {} // 0x00000001853AE390-0x00000001853AE4E0
	// [XID] // 0x0000000189AE76D0-0x0000000189AE76F0
	private void CancelBudgetRemovePool(string effectName, ulong effectPathHash) {} // 0x00000001853B1920-0x00000001853B1A00
	// [XID] // 0x0000000189659430-0x0000000189659450
	public void AddBudgetCount(MonoEffect effect) {} // 0x00000001853AD900-0x00000001853ADA20
	// [XID] // 0x0000000189660AD0-0x0000000189660AF0
	public void RemoveBudgetCount(MonoEffect effect) {} // 0x00000001853B14B0-0x00000001853B15C0
	// [XID] // 0x0000000189668500-0x0000000189668520
	public void TryAddMoreThanOneAvaliableEffectPool(string effectName) {} // 0x00000001853AE8F0-0x00000001853AEA50
	// [XID] // 0x000000018966FFB0-0x000000018966FFD0
	public void TryRemoveMoreThanOneAvaliableEffectPool(string effectName) {} // 0x00000001853AE230-0x00000001853AE390
	// [XID] // 0x00000001896778C0-0x00000001896778E0
	public void AddAvaliableEffect(MonoEffect effect) {} // 0x00000001853AE4E0-0x00000001853AE630
	// [XID] // 0x0000000189807940-0x0000000189807960
	public void RemoveAvaliableEffect(MonoEffect effect) {} // 0x00000001853B0120-0x00000001853B0220
	// [XID] // 0x00000001896866F0-0x0000000189686710
	private bool ShouldReleaseForBudget() => default; // 0x00000001853AEA50-0x00000001853AEB90
	// [XID] // 0x000000018968E4D0-0x000000018968E4F0
	private void CheckReleaseForBudgetWithOneAvaliableEffectLeft() {} // 0x00000001853AFDF0-0x00000001853B0120
	// [XID] // 0x0000000189695DD0-0x0000000189695DF0
	private void CheckReleaseForBudgetWithoutOneAvaliableEffectLeft() {} // 0x00000001853AEEC0-0x00000001853AF300
	// [XID] // 0x000000018969D540-0x000000018969D560
	private void CheckReleaseForBudgetForTheLastTime() {} // 0x00000001853B0E30-0x00000001853B1060
	// [XID] // 0x00000001896A4580-0x00000001896A45A0
	private void LateTickReleaseForBudget() {} // 0x00000001853AE740-0x00000001853AE8F0
	// [XID] // 0x00000001896ABD90-0x00000001896ABDB0
	private void DoReleaseForBudget(HashSet<string> effectPools, bool ignoreOneAvaliable, Action onReleasedBudget) {} // 0x00000001853B0220-0x00000001853B06C0
	// [XID] // 0x00000001896B2F50-0x00000001896B2F70
	public void VisitAllAlivedEffects(Action<MonoEffect> callback) {} // 0x00000001853ADAD0-0x00000001853ADC90
	// [XID] // 0x00000001896BA770-0x00000001896BA790
	public string Dump() => default; // 0x00000001853AFB30-0x00000001853AFDF0
	// [XID] // 0x00000001896C1840-0x00000001896C1860
	public string DumpCSV() => default; // 0x00000001853AF3D0-0x00000001853AF6A0
	// [XID] // 0x00000001896C8F60-0x00000001896C8F80
	public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x00000001853B22B0-0x00000001853B24F0
}

