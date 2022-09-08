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

public sealed class ReportUpdateDynamicAmbientSpawn : ReusedAudioReport // TypeDefIndex: 10966
{
	// Fields
	private AudioDynamicAmbientObject _dynamicObject; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportUpdateDynamicAmbientSpawn, AudioDynamicAmbientObject> // TypeDefIndex: 10967
	{
		// Constructors
		public Spawner() {} // 0x0000000183FE26D0-0x0000000183FE2730

		// Methods
		// [XID] // 0x00000001896EA920-0x00000001896EA940
		public ReportUpdateDynamicAmbientSpawn Spawn(AudioDynamicAmbientObject param1) => default; // 0x0000000183FE2530-0x0000000183FE26D0
	}

	public class Polisher : IPolisher<ReportUpdateDynamicAmbientSpawn, AudioDynamicAmbientObject> // TypeDefIndex: 10968
	{
		// Constructors
		public Polisher() {} // 0x0000000183FE23F0-0x0000000183FE2450

		// Methods
		// [XID] // 0x000000018970E580-0x000000018970E5A0
		public void Polish(ReportUpdateDynamicAmbientSpawn reused, AudioDynamicAmbientObject param1) {} // 0x0000000183FE22D0-0x0000000183FE23F0
	}

	// Constructors
	public ReportUpdateDynamicAmbientSpawn() {} // Dummy constructor
	private ReportUpdateDynamicAmbientSpawn(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000183FF1D80-0x0000000183FF1E10

	// Methods
	// [XID] // 0x000000018991E0F0-0x000000018991E110
	public override void Digest(CommandThreadContext context) {} // 0x0000000183FF1AD0-0x0000000183FF1BE0
	// [XID] // 0x0000000189925A00-0x0000000189925A20
	public override void BeforeRecycle() {} // 0x0000000183FF1BE0-0x0000000183FF1CD0
	// [XID] // 0x000000018992CE90-0x000000018992CEB0
	public override void Recycle() {} // 0x0000000183FF1CD0-0x0000000183FF1D80
}

