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

public sealed class ReportDynamicRayDrawRay : ReusedAudioReport // TypeDefIndex: 10957
{
	// Fields
	private RayInfo[] _rayInfos; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportDynamicRayDrawRay, RayInfo[]> // TypeDefIndex: 10958
	{
		// Constructors
		public Spawner() {} // 0x0000000183208C10-0x0000000183208C70

		// Methods
		// [XID] // 0x00000001898F87C0-0x00000001898F87E0
		public ReportDynamicRayDrawRay Spawn(RayInfo[] rayInfos) => default; // 0x0000000183208B40-0x0000000183208C10
	}

	public class Polisher : IPolisher<ReportDynamicRayDrawRay, RayInfo[]> // TypeDefIndex: 10959
	{
		// Constructors
		public Polisher() {} // 0x00000001831E7160-0x00000001831E71C0

		// Methods
		// [XID] // 0x00000001899000F0-0x0000000189900110
		public void Polish(ReportDynamicRayDrawRay reused, RayInfo[] rayInfos) {} // 0x00000001831E7070-0x00000001831E7160
	}

	// Constructors
	public ReportDynamicRayDrawRay() {} // Dummy constructor
	private ReportDynamicRayDrawRay(RayInfo[] rayInfo) {} // 0x00000001831F8BE0-0x00000001831F8CA0

	// Methods
	// [XID] // 0x00000001898E1C40-0x00000001898E1C60
	public override void BeforeRecycle() {} // 0x00000001831F8A90-0x00000001831F8B30
	// [XID] // 0x00000001898E99D0-0x00000001898E99F0
	public override void Digest(CommandThreadContext context) {} // 0x00000001831F89B0-0x00000001831F8A90
	// [XID] // 0x00000001898F0E00-0x00000001898F0E20
	public override void Recycle() {} // 0x00000001831F8B30-0x00000001831F8BE0
}

