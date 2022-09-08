/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReportDestroyDynamicAmbientSpawns : ReportManageDynamicAmbientSpawns // TypeDefIndex: 10952
{
	// Nested types
	public class SingleItemSpawner : ReportManageDynamicAmbientSpawns.SingleItemSpawner<ReportDestroyDynamicAmbientSpawns> // TypeDefIndex: 10953
	{
		// Constructors
		public SingleItemSpawner() {} // 0x0000000181D4FC00-0x0000000181D4FC70

		// Methods
		// [XID] // 0x00000001898D26D0-0x00000001898D26F0
		protected override ReportDestroyDynamicAmbientSpawns Spawn() => default; // 0x0000000181D4FB00-0x0000000181D4FC00
	}

	public class MultiItemSpawner : ReportManageDynamicAmbientSpawns.MultiItemSpawner<ReportDestroyDynamicAmbientSpawns> // TypeDefIndex: 10954
	{
		// Constructors
		public MultiItemSpawner() {} // 0x0000000181D4FA20-0x0000000181D4FA90

		// Methods
		// [XID] // 0x00000001898D9F70-0x00000001898D9F90
		protected override ReportDestroyDynamicAmbientSpawns Spawn() => default; // 0x0000000181D4F920-0x0000000181D4FA20
	}

	public class SingleItemPolisher : ReportManageDynamicAmbientSpawns.SingleItemPolisher<ReportDestroyDynamicAmbientSpawns> // TypeDefIndex: 10955
	{
		// Constructors
		public SingleItemPolisher() {} // 0x0000000181D4F8B0-0x0000000181D4F920
	}

	public class MultiItemPolisher : ReportManageDynamicAmbientSpawns.MultiItemPolisher<ReportDestroyDynamicAmbientSpawns> // TypeDefIndex: 10956
	{
		// Constructors
		public MultiItemPolisher() {} // 0x0000000181D4FA90-0x0000000181D4FB00
	}

	// Constructors
	private ReportDestroyDynamicAmbientSpawns() {} // 0x0000000181D5E790-0x0000000181D5E7F0

	// Methods
	// [XID] // 0x0000000189B46DA0-0x0000000189B46DC0
	public override void Recycle() {} // 0x0000000181D5E590-0x0000000181D5E640
	// [XID] // 0x00000001898CAFB0-0x00000001898CAFD0
	protected override void ManageSpawn(CommandThreadContext context, AudioDynamicAmbientObject dynamicObject) {} // 0x0000000181D5E640-0x0000000181D5E790
}

