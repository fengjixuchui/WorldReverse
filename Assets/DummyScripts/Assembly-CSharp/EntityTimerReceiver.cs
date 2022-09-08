/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityTimerReceiver : TimerReceiver // TypeDefIndex: 21308
{
	// Fields
	private BaseEntity _owner; // 0x40
	private LevelEntity _level; // 0x48
	public bool ignoreEntityActive; // 0x50

	// Properties
	public float LevelTimeScale { /* [XID] */ /* 0x0000000189B7FE10-0x0000000189B7FE30 */ get => default; } // 0x00000001845A8240-0x00000001845A8330 
	public float TimeScale { /* [XID] */ /* 0x0000000189B878E0-0x0000000189B87900 */ get => default; } // 0x00000001845A7E50-0x00000001845A7F10 

	// Nested types
	public class Spawner : ISpawner<EntityTimerReceiver, BaseEntity> // TypeDefIndex: 21309
	{
		// Constructors
		public Spawner() {} // 0x00000001845C6730-0x00000001845C6790

		// Methods
		// [XID] // 0x0000000189BCA550-0x0000000189BCA570
		public EntityTimerReceiver Spawn(BaseEntity entity) => default; // 0x00000001845C6660-0x00000001845C6730
	}

	public class Polisher : IPolisher<EntityTimerReceiver, BaseEntity> // TypeDefIndex: 21310
	{
		// Constructors
		public Polisher() {} // 0x00000001845C6600-0x00000001845C6660

		// Methods
		// [XID] // 0x0000000189BD1BC0-0x0000000189BD1BE0
		public void Polish(EntityTimerReceiver reused, BaseEntity param1) {} // 0x00000001845C6520-0x00000001845C6600
	}

	// Constructors
	public EntityTimerReceiver() {} // Dummy constructor
	private EntityTimerReceiver(BaseEntity entity) {} // 0x00000001845A8500-0x00000001845A8580

	// Methods
	// [XID] // 0x0000000189B8EA20-0x0000000189B8EA40
	public override void BeforeRecycle() {} // 0x00000001845A79A0-0x00000001845A7A60
	// [XID] // 0x0000000189B95EC0-0x0000000189B95EE0
	private void Init() {} // 0x00000001845A7C30-0x00000001845A7E50
	// [XID] // 0x0000000189B9D480-0x0000000189B9D4A0
	private void OnOwnerTimeScaleChange(EvtEntityTimeScaleChange evt) {} // 0x00000001845A7B70-0x00000001845A7C30
	// [XID] // 0x0000000189BA4E90-0x0000000189BA4EB0
	private void OnOwnerDestroy(EvtEntityDestroy evt) {} // 0x00000001845A8110-0x00000001845A8240
	// [XID] // 0x0000000189BAC070-0x0000000189BAC090
	private void OnOwnerActiveChange(EvtEntityActiveChange evt) {} // 0x00000001845A8330-0x00000001845A8400
	// [XID] // 0x0000000189BB3870-0x0000000189BB3890
	public void ClearOwner() {} // 0x00000001845A7F10-0x00000001845A80B0
	// [XID] // 0x0000000189BBAE00-0x0000000189BBAE20
	public void ClearLevel() {} // 0x00000001845A8400-0x00000001845A8500
	// [XID] // 0x0000000189B941D0-0x0000000189B941F0
	public void SetTimer(float delay, int loopCount = 1 /* Metadata: 0x00AFF43E */, Func<bool> callBack = null, bool isFixedUpdate = false /* Metadata: 0x00AFF442 */) {} // 0x00000001845A7A60-0x00000001845A7B70
}

