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

public sealed class ListAmortizedEntityTickHelper : ListAmortizedUpdateHelper<IAmortizedTickEntity> // TypeDefIndex: 20811
{
	// Fields
	private int _commonInitWatch; // 0x40
	private List<BaseEntity> _onSafeReadyEntitiesList; // 0x48
	private int _thisFrameInitWatch; // 0x50

	// Nested types
	public class Spawner : ISpawner<ListAmortizedEntityTickHelper, int, List<BaseEntity>> // TypeDefIndex: 20812
	{
		// Constructors
		public Spawner() {} // 0x00000001819382E0-0x0000000181938340

		// Methods
		// [XID] // 0x00000001896C8E60-0x00000001896C8E80
		public ListAmortizedEntityTickHelper Spawn(int inWatch, List<BaseEntity> inOnSafeReadyEntitiesList) => default; // 0x00000001819381D0-0x00000001819382E0
	}

	public class Polisher : IPolisher<ListAmortizedEntityTickHelper, int, List<BaseEntity>> // TypeDefIndex: 20813
	{
		// Constructors
		public Polisher() {} // 0x0000000181914A50-0x0000000181914AB0

		// Methods
		// [XID] // 0x00000001896D07E0-0x00000001896D0800
		public void Polish(ListAmortizedEntityTickHelper instance, int inWatch, List<BaseEntity> inOnSafeReadyEntitiesList) {} // 0x0000000181914950-0x0000000181914A50
	}

	// Constructors
	public ListAmortizedEntityTickHelper() {} // 0x0000000181915320-0x00000001819153B0

	// Methods
	// [XID] // 0x000000018969D3C0-0x000000018969D3E0
	protected override void DoFirstUpdate(IAmortizedTickEntity inElement, float globalTime, float deltaTime) {} // 0x0000000181915000-0x00000001819150D0
	// [XID] // 0x00000001896A4460-0x00000001896A4480
	protected override void DoUpdate(IAmortizedTickEntity inElement, float globalTime) {} // 0x00000001819150D0-0x00000001819151F0
	// [XID] // 0x00000001896ABC50-0x00000001896ABC70
	protected override void DoDestroy(IAmortizedTickEntity inElement) {} // 0x0000000181914F30-0x0000000181915000
	// [XID] // 0x00000001896B2DF0-0x00000001896B2E10
	public void AmortizedTick(float globalTime, float deltaTime, bool infinityMode) {} // 0x0000000181914CD0-0x0000000181914E70
	// [XID] // 0x00000001896BA530-0x00000001896BA550
	private void InitParams(int inWatch, List<BaseEntity> inOnSafeReadyEntitiesList) {} // 0x0000000181915250-0x0000000181915320
	// [XID] // 0x00000001896C1700-0x00000001896C1720
	public override void BeforeRecycle() {} // 0x0000000181914E70-0x0000000181914F30
}

