/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class BenchmarkEntity // TypeDefIndex: 27647
{
	// Fields
	private static StatEffectContext _currentStatEffContext; // 0x00
	private static StatEntityContext _currentStatEntityContext; // 0x08

	// Properties
	public static IEnumerable<GameObject> currentStatEntityGameObjects { /* [XID] */ /* 0x0000000189636C50-0x0000000189636C70 */ get; } // 0x00000001847DFAD0-0x00000001847DFBB0 

	// Nested types
	private class KeyExtractor : ZOrderCollection<ZOrder96, Vector3, BaseEntity> // TypeDefIndex: 27648
	{
		// Constructors
		public KeyExtractor() {} // 0x00000001847F7060-0x00000001847F70C0

		// Methods
		// [XID] // 0x0000000189684BA0-0x0000000189684BC0
		public Vector3 ExtractKey(BaseEntity data) => default; // 0x00000001847F6F50-0x00000001847F7060
	}

	public abstract class StatObjectContext<T> // TypeDefIndex: 27649
		where T : class
	{
		// Fields
		protected List<T> __instantiateContextObjects;
		protected IEnumerable<T> _currentObjects;
		private IEnumerator _currentIter;
		protected IStatInstantiationContext _currentInstantiationContext;

		// Properties
		protected virtual List<T> _instantiateContextObjects { get; }
		public IEnumerable<T> objects { get; }
		private bool isStating { get; }

		// Constructors
		protected StatObjectContext() {}

		// Methods
		public void InjectStatObjects(IEnumerable<T> inObjects) {}
		public void ReleaseStatObjects() {}
		public bool OnBeginNewContext(IStatInstantiationContext ic) => default;
		public void StartCoroutine(IEnumerator inEnumrator) {}
		protected abstract T InternalInstantiate(IStatInstantiationContext ic);
		public T Instantiate() => default;
		public abstract IEnumerable<GameObject> InternalGetGameObjects();
		public IEnumerable<GameObject> GetGameObjects() => default;
		protected abstract void DisposeObject(T obj);
		protected virtual void OnDisposedAllObjects() {}
		public void DisposeAllObjects() {}
	}

	private class StatEffectContext : StatObjectContext<MonoEffect> // TypeDefIndex: 27650
	{
		// Fields
		private MonoEffect _tempMonoEffect; // 0x30

		// Constructors
		public StatEffectContext() {} // 0x00000001847F8D10-0x00000001847F8D80

		// Methods
		// [XID] // 0x000000018968C750-0x000000018968C770
		protected override MonoEffect InternalInstantiate(IStatInstantiationContext ic) => default; // 0x00000001847F87E0-0x00000001847F8B70
		// [XID] // 0x00000001896941A0-0x00000001896941C0
		protected override void DisposeObject(MonoEffect eff) {} // 0x00000001847F8550-0x00000001847F8610
		// [XID] // 0x000000018969B790-0x000000018969B7B0
		public override IEnumerable<GameObject> InternalGetGameObjects() => default; // 0x00000001847F8B70-0x00000001847F8D10
	}

	public class StatEntityContext : StatObjectContext<BaseEntity> // TypeDefIndex: 27651
	{
		// Fields
		private uint _lastTemplateID; // 0x30

		// Properties
		protected override List<BaseEntity> _instantiateContextObjects { /* [XID] */ /* 0x00000001896BBB70-0x00000001896BBB90 */ get => default; } // 0x00000001847F5A40-0x00000001847F5C80 

		// Constructors
		public StatEntityContext() {} // 0x00000001847F6500-0x00000001847F6570

		// Methods
		// [XID] // 0x00000001896AD250-0x00000001896AD270
		public static void ClearAllEntityByConfigID(uint configID) {} // 0x00000001847F5C80-0x00000001847F5EF0
		// [XID] // 0x00000001896B4900-0x00000001896B4920
		public static void SetAllEntityLightActiveByConfigID(uint configID, bool isActive) {} // 0x00000001847F5820-0x00000001847F5A40
		// [XID] // 0x00000001896C2FF0-0x00000001896C3010
		protected override BaseEntity InternalInstantiate(IStatInstantiationContext ic) => default; // 0x00000001847F5EF0-0x00000001847F6280
		// [XID] // 0x00000001896CA4A0-0x00000001896CA4C0
		protected override void DisposeObject(BaseEntity ent) {} // 0x00000001847F56F0-0x00000001847F5820
		// [XID] // 0x00000001896D1B10-0x00000001896D1B30
		public override IEnumerable<GameObject> InternalGetGameObjects() => default; // 0x00000001847F6280-0x00000001847F6500
	}

	private enum TestEnum // TypeDefIndex: 27652
	{
		TE_0 = 0,
		TE_1 = 1
	}

	private struct TestStruct // TypeDefIndex: 27653
	{
		// Fields
		public int k; // 0x00

		// Methods
		// [XID] // 0x00000001896D9340-0x00000001896D9360
		public bool Equals(TestStruct other) => default; // 0x00000001847F8530-0x00000001847F8550
	}

	// Constructors
	static BenchmarkEntity() {} // 0x00000001847E4B40-0x00000001847E4C80

	// Methods
	// [XID] // 0x0000000189BC5860-0x0000000189BC5880
	public static bool IsEntity(BaseEntity inEntity) => default; // 0x00000001847E43D0-0x00000001847E4470
	// [XID] // 0x0000000189BCD300-0x0000000189BCD320
	public static bool IsAvatarEntity(BaseEntity inEntity) => default; // 0x00000001847E2D30-0x00000001847E2DF0
	// [XID] // 0x0000000189BD47C0-0x0000000189BD47E0
	public static bool IsMonsterEntity(BaseEntity inEntity) => default; // 0x00000001847E3190-0x00000001847E3250
	// [XID] // 0x0000000189BDC330-0x0000000189BDC350
	public static bool IsNPCEntity(BaseEntity inEntity) => default; // 0x00000001847E4A80-0x00000001847E4B40
	// [XID] // 0x00000001895E8B70-0x00000001895E8B90
	public static bool IsScenePropEntity(BaseEntity inEntity) => default; // 0x00000001847E3970-0x00000001847E3A60
	// [XID] // 0x00000001895F0400-0x00000001895F0420
	public static bool IsGadgetEntity(BaseEntity inEntity) => default; // 0x00000001847E3250-0x00000001847E3350
	// [XID] // 0x0000000189602410-0x0000000189602430
	public static void StatFunction(Action func, string funcName) {} // 0x00000001847E02F0-0x00000001847E0480
	// [XID] // 0x0000000189609C70-0x0000000189609C90
	public static void StatGetQueryEntity(Func<Vector3, int, int> onQueryEntity, Vector3 center, int size, string funcName) {} // 0x00000001847E2940-0x00000001847E2D30
	// [XID] // 0x0000000189611460-0x0000000189611480
	public static void StatQueryEntityByZOrder(BaseEntity targetEntity, List<BaseEntity> entities, int querySize) {} // 0x00000001847DF230-0x00000001847DF950
	// [XID] // 0x0000000189618E70-0x0000000189618E90
	public static void StatQueryEntityByDist(BaseEntity targetEntity, List<BaseEntity> entities, int querySize) {} // 0x00000001847E0050-0x00000001847E02F0
	// [XID] // 0x0000000189620350-0x0000000189620370
	public static void StatQueryEntityByShape(BaseEntity targetEntity, List<BaseEntity> entities, int querySize) {} // 0x00000001847E4470-0x00000001847E4A80
	// [XID] // 0x0000000189627790-0x00000001896277B0
	public static void BenchmarkResolveTarget(int size, int testCount) {} // 0x00000001847DFE30-0x00000001847E0050
	// [XID] // 0x000000018962F250-0x000000018962F270
	public static void StatScenePropRange(int queryRangeSize) {} // 0x00000001847E36C0-0x00000001847E3970
	// [XID] // 0x000000018963E180-0x000000018963E1A0
	public static void InjectStatEntity(string entityCategory) {} // 0x00000001847E3A60-0x00000001847E43D0
	// [XID] // 0x0000000189645B10-0x0000000189645B30
	public static void ClearAllTargetEffects(string inName) {} // 0x00000001847DF950-0x00000001847DFAD0
	// [XID] // 0x000000018964D320-0x000000018964D340
	public static void ClearStatEffectContext() {} // 0x00000001847DF150-0x00000001847DF230
	// [XID] // 0x0000000189654BC0-0x0000000189654BE0
	public static void ClearStatEntityContext() {} // 0x00000001847E2730-0x00000001847E2810
	[DebuggerHidden] // 0x000000018965C190-0x000000018965C1D0
	// [XID] // 0x000000018965C190-0x000000018965C1D0
	public static IEnumerator TestEffect(string effectName, int count, float seconds, float scale = 1f /* Metadata: 0x00B0CAA2 */) => default; // 0x00000001847E3050-0x00000001847E3190
	public static void TestWithoutGC<T>(ref T t1, T t2)
		where T : IConvertible {}
	public static void TestWithDefaultComparer<T>(ref T t1, T t2) {}
	public static void TestWithGenericEqual<T>(ref T t1, T t2) {}
	// [XID] // 0x0000000189666700-0x0000000189666720
	public static void RegisterConsoleCommand() {} // 0x00000001847DFBB0-0x00000001847DFE30
	// [XID] // 0x000000018966DE40-0x000000018966DE60
	public static bool OnConsoleCommandLevel(string[] strs) => default; // 0x00000001847E3350-0x00000001847E36C0
	// [XID] // 0x0000000189675CA0-0x0000000189675CC0
	private static void StatSelectTarget() {} // 0x00000001847E2DF0-0x00000001847E3050
	// [XID] // 0x000000018967D510-0x000000018967D530
	public static bool OnConsoleCommand(string[] strs) => default; // 0x00000001847E0480-0x00000001847E2730

	// Extension methods
	// [XID] // 0x00000001895F7E50-0x00000001895F7E90
	public static string ToGotoString(this Vector3 vector) => default; // 0x00000001847E2810-0x00000001847E2940
}

