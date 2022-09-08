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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ReportManageDynamicAmbientSpawns : ReusedAudioReport // TypeDefIndex: 10960
{
	// Fields
	private readonly List<AudioDynamicAmbientObject> _spawns; // 0x10

	// Nested types
	public abstract class Spawner<T> // TypeDefIndex: 10961
		where T : ReportManageDynamicAmbientSpawns
	{
		// Constructors
		protected Spawner() {}

		// Methods
		protected abstract T Spawn();
	}

	public abstract class SingleItemSpawner<T> : Spawner<T>, ISpawner<T, AudioDynamicAmbientObject> // TypeDefIndex: 10962
		where T : ReportManageDynamicAmbientSpawns
	{
		// Constructors
		protected SingleItemSpawner() {}

		// Methods
		public T Spawn(AudioDynamicAmbientObject param1) => default;
	}

	public abstract class MultiItemSpawner<T> : Spawner<T>, ISpawner<T, HashSet<AudioDynamicAmbientObject>> // TypeDefIndex: 10963
		where T : ReportManageDynamicAmbientSpawns
	{
		// Constructors
		protected MultiItemSpawner() {}

		// Methods
		public T Spawn(HashSet<AudioDynamicAmbientObject> param1) => default;
	}

	public abstract class SingleItemPolisher<T> : IPolisher<T, AudioDynamicAmbientObject> // TypeDefIndex: 10964
		where T : ReportManageDynamicAmbientSpawns
	{
		// Constructors
		protected SingleItemPolisher() {}

		// Methods
		public void Polish(T reused, AudioDynamicAmbientObject param1) {}
	}

	public abstract class MultiItemPolisher<T> : IPolisher<T, HashSet<AudioDynamicAmbientObject>> // TypeDefIndex: 10965
		where T : ReportManageDynamicAmbientSpawns
	{
		// Constructors
		protected MultiItemPolisher() {}

		// Methods
		public void Polish(T reused, HashSet<AudioDynamicAmbientObject> param1) {}
	}

	// Constructors
	protected ReportManageDynamicAmbientSpawns() {} // 0x000000018255B9A0-0x000000018255BA30

	// Methods
	// [XID] // 0x0000000189625A40-0x0000000189625A60
	public override void Digest(CommandThreadContext context) {} // 0x000000018255B570-0x000000018255B6D0
	// [XID] // 0x000000018990F050-0x000000018990F070
	public override void BeforeRecycle() {} // 0x000000018255B6D0-0x000000018255B780
	protected abstract void ManageSpawn(CommandThreadContext context, AudioDynamicAmbientObject dynamicObject);
	// [XID] // 0x0000000189916960-0x0000000189916980
	protected void AddDynamicObjects(HashSet<AudioDynamicAmbientObject> spawns) {} // 0x000000018255B780-0x000000018255B9A0
}

