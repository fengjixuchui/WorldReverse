/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReportCreateDynamicAmbientSpawns : ReportManageDynamicAmbientSpawns // TypeDefIndex: 10947
{
	// Nested types
	public class SingleItemSpawner : ReportManageDynamicAmbientSpawns.SingleItemSpawner<ReportCreateDynamicAmbientSpawns> // TypeDefIndex: 10948
	{
		// Constructors
		public SingleItemSpawner() {} // 0x00000001835E1D00-0x00000001835E1D70

		// Methods
		// [XID] // 0x00000001898B4450-0x00000001898B4470
		protected override ReportCreateDynamicAmbientSpawns Spawn() => default; // 0x00000001835E1C00-0x00000001835E1D00
	}

	public class MultiItemSpawner : ReportManageDynamicAmbientSpawns.MultiItemSpawner<ReportCreateDynamicAmbientSpawns> // TypeDefIndex: 10949
	{
		// Constructors
		public MultiItemSpawner() {} // 0x00000001835E1EE0-0x00000001835E1F50

		// Methods
		// [XID] // 0x00000001898BC230-0x00000001898BC250
		protected override ReportCreateDynamicAmbientSpawns Spawn() => default; // 0x00000001835E1DE0-0x00000001835E1EE0
	}

	public class SingleItemPolisher : ReportManageDynamicAmbientSpawns.SingleItemPolisher<ReportCreateDynamicAmbientSpawns> // TypeDefIndex: 10950
	{
		// Constructors
		public SingleItemPolisher() {} // 0x0000000183602E20-0x0000000183602F60
	}

	public class MultiItemPolisher : ReportManageDynamicAmbientSpawns.MultiItemPolisher<ReportCreateDynamicAmbientSpawns> // TypeDefIndex: 10951
	{
		// Constructors
		public MultiItemPolisher() {} // 0x00000001835E1D70-0x00000001835E1DE0
	}

	// Constructors
	private ReportCreateDynamicAmbientSpawns() {} // 0x00000001835F7270-0x00000001835F72D0

	// Methods
	// [XID] // 0x00000001898A5A50-0x00000001898A5A70
	public override void Recycle() {} // 0x00000001835F7070-0x00000001835F7120
	// [XID] // 0x00000001898ACF00-0x00000001898ACF20
	protected override void ManageSpawn(CommandThreadContext context, AudioDynamicAmbientObject dynamicObject) {} // 0x00000001835F7120-0x00000001835F7270
}

